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

        if (AppLicense.ExpiresInWeek)
            MessageBox.Show($"Your license expires in {AppLicense.ExpiresIn} days! Please contact support to renew it.", "License Expiration", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            formT.Activate();
        }
        else
        {
            formT = new()
            {
                ShowInTaskbar = true,
                MinimizeBox = true,
                StartPosition = FormStartPosition.CenterScreen
            };

            _openForms[formType] = formT;

            if (formT is MaterialForm mat)
                MaterialSkinManager.Instance.AddFormToManage(mat);

            formT.FormClosing += (s, e) => _openForms.Remove(formType);

            actionBeforeShow?.Invoke(formT);
            formT.Show();
            actionAfterShow?.Invoke(formT);
        }

        CurrentForm = formT;

        return formT;
    }

    public static DialogResult ShowDialog<T>(Action<T>? actionBeforeShow = null, Action<T, DialogResult>? actionAfterShow = null) where T : Form, new()
    {
        Type formType = typeof(T);

        T form = new()
        {
            ShowInTaskbar = false,
            MinimizeBox = false,
            StartPosition = FormStartPosition.CenterParent
        };

        if (form is MaterialForm mat)
            MaterialSkinManager.Instance.AddFormToManage(mat);

        using Form overlay = new()
        {
            BackColor = Color.Black,
            Opacity = 0.5,
            FormBorderStyle = FormBorderStyle.None,
            ShowInTaskbar = false,
            StartPosition = FormStartPosition.Manual,
            Enabled = false,
            Size = CurrentForm.Size,
            Location = CurrentForm.Location,
            Owner = CurrentForm
        };

        form.Owner = overlay;
        Form previous = CurrentForm;
        CurrentForm = form;

        actionBeforeShow?.Invoke(form);

        overlay.Show();

        DialogResult result = DialogResult.None;

        try
        {
            result = form.ShowDialog(overlay);
        }
        finally
        {
            Form owner = overlay.Owner;
            overlay.Close();
            owner.BringToFront();
            owner.Activate();

            CurrentForm = previous;
            actionAfterShow?.Invoke(form, result);
        }

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

        using Form overlay = new()
        {
            BackColor = Color.Black,
            Opacity = 0.5,
            FormBorderStyle = FormBorderStyle.None,
            ShowInTaskbar = false,
            StartPosition = FormStartPosition.Manual,
            Enabled = false,
            Size = CurrentForm.Size,
            Location = CurrentForm.Location,
            Owner = CurrentForm
        };

        overlay.Show();

        _connectionLostForm = new ConnectionLostForm()
        {
            StartPosition = FormStartPosition.CenterParent,
            Owner = overlay
        };

        try
        {
            _connectionLostForm.ShowDialog(overlay);
        }
        finally
        {
            Form owner = overlay.Owner;
            overlay.Close();
            owner.BringToFront();
            owner.Activate();
        }
    }

    internal static void HideConnectionLostDialog()
    {
        if (CurrentForm.InvokeRequired)
        {
            CurrentForm.Invoke(HideConnectionLostDialog);
            return;
        }

        _connectionLostForm?.Close();
        _connectionLostForm = null!;
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
