using ClinicDesk.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace ClinicDesk;

public class AppContext : ApplicationContext
{
    private static readonly Dictionary<Type, Form> _openForms = [];
    
    public AppContext()
    {
        MaterialSkinManager skin = MaterialSkinManager.Instance;

        skin.Theme = MaterialSkinManager.Themes.LIGHT;
        skin.ColorScheme = new MaterialColorScheme(
            MaterialPrimary.Indigo500,
            MaterialPrimary.Indigo700,
            MaterialPrimary.Indigo100,
            MaterialAccent.Red200,
            MaterialTextShade.WHITE
        );

        switch (Settings.Instance.AccountType)
        {
            case AccountType.Doctor:
                ShowForm<DoctorForm>();
                break;
                
            case AccountType.Secretary:
                ShowForm<SecretaryForm>();
                break;

            case AccountType.AllInOne:
                ShowForm<AllInOneForm>();
                break;

            default:
#if DEBUG
                ShowForm<WelcomeForm>();
#else
                ShowForm<InstallForm>();
#endif
                break;
        }
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
        DialogResult result = form.ShowDialog();
        actionAfterShow?.Invoke(form, result);
        
        return result;
    }
}
