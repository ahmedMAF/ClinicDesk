using ReaLTaiizor.Controls;
using Panel = System.Windows.Forms.Panel;

namespace ClinicDesk;

public class Tutorial
{
    private Form _form;
    
    private Panel _panel = new();
    private MaterialButton _nextBtn = new();
    private MaterialButton _skipBtn = new();
    private MaterialLabel _titleLbl = new();
    private MaterialLabel _textLbl = new();
    
    private int _currentStep;
    
    public Color BackColor { get; set; }
    public List<TutorialStep> Steps { get; set; }
    
    public Tutorial(Form form)
    {
        _form = form;
        
        
    }
    
    private void NextStep()
    {
        
    }
}

public class TutorialStep
{
    public Point Location { get; set; }
    public Size Radius { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}
