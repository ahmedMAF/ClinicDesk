using QliniqRec.Forms;

namespace QliniqRec;

public class AppContext : ApplicationContext
{
    private static readonly Dictionary<Type, Form> _openForms = [];
    
    public AppContext()
    {
        ShowForm<WelcomeForm>();
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

        form.FormClosed += (s, e) => _openForms.Remove(formType);
        
        actionBeforeShow?.Invoke(form);
        DialogResult result = form.ShowDialog();
        actionAfterShow?.Invoke(form, result);
        
        return result;
    }
}
