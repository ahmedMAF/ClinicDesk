using QliniqRec.Database;
using QliniqRec.Forms;
using YAXLib;

namespace QliniqRec;

public class AppContext : ApplicationContext
{
    private static Dictionary<Type, Form> _openForms = [];
    
    public MyAppContext()
    {
        ShowForm<WelcomeForm>();
    }
    
    public static T ShowForm<T>() where T : Form, new()
    {
        Type formType = typeof(T);

        if (_openForms.TryGetValue(formType, out T form) && !form.IsDisposed)
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
        
        return form;
    }
    
    public static void CloseForm<T>() where T : Form, new()
    {
        Type formType = typeof(T);

        if (_openForms.TryGetValue(formType, out T form) && !form.IsDisposed)
            form.Close();
    }
}
