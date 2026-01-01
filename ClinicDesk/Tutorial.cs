using ReaLTaiizor.Controls;
using Panel = System.Windows.Forms.Panel;

namespace ClinicDesk;

public partial class Tutorial : UserControl
{
    private static readonly Dictionary<Type, List<TutorialStep>> Tutorials = [];
    
    private Form _form;
    private int _currentStep = -1;
    
    public Color BackColor { get; set; }
    public List<TutorialStep> Steps { get; set; }
    
    private Tutorial(Type type, Form form)
    {
        InitializeComponent();
        
        _form = form;
        Steps = Tutorials[type];
        
        NextStep();
        
        form.Controls.Add(this);
    }
    
    public static Tutorial ForForm<T>(T form) where T : Form
    {
        return new Tutorial(typeof(T), form);
    }
    
    private void NextStep()
    {
        _currentStep++;
        
        if (_currentStep >= Steps.Count)
        {
            Finish();
            return;
        }
        
        if (_currentStep == Steps.Count - 1)
            nextBtn.Text = "Finish";
        
        TutorialStep step = Steps[_currentStep];
        
        titleLbl.Text = step.Title;
        textLbl.Text = step.Text;
        
        layout.Location = step.TextLocation;
    }
    
    private void Finish()
    {
        _form.Controls.Remove(this);
    }
    
    private void nextBtn_Click(object sender, EventArgs e)
    {
        NextStep();
    }
    
    private void skipBtn_Click(object sender, EventArgs e)
    {
        Finish();
    }
}

public class TutorialStep
{
    public Point TextLocation { get; set; }
    public Point Location { get; set; }
    public Size Radius { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}
