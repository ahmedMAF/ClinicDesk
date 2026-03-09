using ClinicDesk.Controls;
using ClinicDesk.Database;
using ClinicDesk.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace ClinicDesk;

public class AppContext : ApplicationContext
{
    private static readonly Dictionary<Type, Form> _openForms = [];

    private static Form _lastForm = null!;
    private static Form _formOverlay = null!;
    private static Form _connectionLostForm = null!;

    public static Form CurrentForm { get; private set; } = null!;

    public AppContext()
    {
        Application.ApplicationExit += ApplicationExit;

        Settings.Initialize();

        Settings settings = Settings.Instance;
        MaterialSkinManager skin = MaterialSkinManager.Instance;

        skin.Theme = settings.IsDarkTheme ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

        skin.ColorScheme = new MaterialColorScheme(
            ColorTranslator.FromHtml("#4CAF50"),
            ColorTranslator.FromHtml("#2E7D32"),
            ColorTranslator.FromHtml("#81C784"),
            ColorTranslator.FromHtml("#03A9F4"),
            MaterialTextShade.WHITE
        );

        if (settings.AccountType == AccountType.NotDefined)
        {
            ShowForm<InstallForm>();
            return;
        }

        if (settings.IsServer && AppLicense.ExpiresInWeek)
            MessageBox.Show("Your license is expiring soon! Please contact support to renew it.", "License Expiration", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        ShowForm<SplashForm>();
    }

    public static T ShowForm<T>(Action<T>? actionBeforeShow = null, Action<T>? actionAfterShow = null) where T : Form, new()
    {
        Type formType = typeof(T);
        T formT = null!;

        if (_openForms.TryGetValue(formType, out Form? form) && !form.IsDisposed)
        {
            formT = (T)form;
            formT.BringToFront();
            formT.Focus();
        }
        else
        {
            formT = new();
            _openForms[formType] = formT;

            if (formT is MaterialForm mat)
                MaterialSkinManager.Instance.AddFormToManage(mat);

            formT.FormClosed += (s, e) => _openForms.Remove(formType);
            
            actionBeforeShow?.Invoke(formT);
            formT.Show();
            actionAfterShow?.Invoke(formT);
        }

        _lastForm = CurrentForm;
        CurrentForm = formT;

        return formT;
    }
    
    public static DialogResult ShowDialog<T>(Action<T>? actionBeforeShow = null, Action<T, DialogResult>? actionAfterShow = null) where T : Form, new()
    {
        Type formType = typeof(T);

        T form = new();
        _openForms[formType] = form;

        if (form is MaterialForm mat)
            MaterialSkinManager.Instance.AddFormToManage(mat);

        form.FormClosed += (s, e) => _openForms.Remove(formType);

        actionBeforeShow?.Invoke(form);
        _lastForm = CurrentForm;
        CurrentForm = form;

        Form overlay = new()
        {
            BackColor = Color.Black,
            Opacity = 0.5,
            MinimizeBox = false,
            MaximizeBox = false,
            Text = "",
            ShowIcon = false,
            ControlBox = false,
            FormBorderStyle = FormBorderStyle.None,
            Size = _lastForm.Size,
            ShowInTaskbar = false,
            Owner = _lastForm,
            Visible = true,
            Location = _lastForm.Location,
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
        };

        // close overlay when dialog closes
        form.FormClosed += (_, _) =>
        {
            Form owner = overlay.Owner;
            overlay.Close();
            owner.BringToFront();
            owner.Activate();
        };

        overlay.Show();

        DialogResult result = form.ShowDialog();

        CurrentForm = _lastForm;
        actionAfterShow?.Invoke(form, result);

        return result;
    }

    internal static void ShowConnectionLostDialog()
    {
        if (CurrentForm == null || CurrentForm.IsDisposed || _connectionLostForm != null)
            return;

        if (CurrentForm.InvokeRequired)
        {
            CurrentForm.Invoke(ShowConnectionLostDialog);
            return;
        }

        _formOverlay = new Form()
        {
            BackColor = Color.Black,
            Opacity = 0.5,
            MinimizeBox = false,
            MaximizeBox = false,
            Text = "",
            ShowIcon = false,
            ControlBox = false,
            FormBorderStyle = FormBorderStyle.None,
            Size = CurrentForm.Size,
            ShowInTaskbar = false,
            Owner = CurrentForm,
            Visible = true,
            Location = CurrentForm.Location,
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
        };

        _formOverlay.Show();

        _connectionLostForm = new ConnectionLostForm()
        {
            StartPosition = FormStartPosition.CenterParent,
            Owner = CurrentForm
        };

        _connectionLostForm.ShowDialog();
        _formOverlay.Close();
    }

    internal static void HideConnectionLostDialog()
    {
        if (CurrentForm.InvokeRequired)
        {
            CurrentForm.Invoke(HideConnectionLostDialog);
            return;
        }

        _connectionLostForm?.Close();
        _formOverlay?.Close();
    }

    private void ApplicationExit(object? sender, EventArgs e)
    {
        if (AppointmentApi.Requests.Count > 0)
        {
            if (MaterialMessageBox.Show(
                "There are appointment requests that need your attention! Do you want to see them?",
                "Notification",
                MessageBoxButtons.YesNo, false) == DialogResult.Yes)
                ShowDialog<AppointmentRequestsForm>();
        }

        AppointmentApi.Shutdown();
        ClinicDb.Shutdown();
    }
}
