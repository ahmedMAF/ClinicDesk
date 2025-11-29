using QliniqRec.Forms;

namespace QliniqRec;

public class AppContext : ApplicationContext
{
    private static Dictionary<Type, Form> _openForms = [];
    
    public AppContext()
    {
        ShowForm<WelcomeForm>();
    }
    
    public static T ShowForm<T>() where T : Form, new()
    {
        Type formType = typeof(T);

        if (_openForms.TryGetValue(formType, out Form form) && !form.IsDisposed)
        {
            form.BringToFront();
            form.Focus();
        }
        else
        {
            form = new T();
            _openForms[formType] = form;

            form.FormClosed += (s, e) => _openForms.Remove(formType);
            form.Show();
        }
        
        return (T)form;
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
    
    public static void CloseForm<T>() where T : Form, new()
    {
        Type formType = typeof(T);

        if (_openForms.TryGetValue(formType, out Form? form) && !form.IsDisposed)
            form.Close();
    }
}
