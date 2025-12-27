using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private static readonly ToothStatus[] _toothStatuses = Enum.GetValues<ToothStatus>();

    private List<Tooth> _teeth = null!;
    private readonly List<ToothGraphic> _teethGp;
    
    private Tooth? _selectedTooth;
    private Tooth? _hoveredTooth;
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [SRCategory("Appearance")]
    public Font NumbersFont
    {
        get;
        set
        {
            field = value;
            Invalidate();
        }
    }
    
    public ToothChart()
    {
        DoubleBuffered = true;
        Size = new Size(600, 200);
        NumbersFont = new Font("Roboto", 12);
        
        _teethGp = TeethHelper.Teeth;
        
        for (int i = 0; i < 52; i++)
            _teeth.Add(new Tooth());
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        foreach (Tooth tooth in _teeth)
        {
            if (tooth.Path.IsVisible(e.Location))
            {
                _selectedTooth = tooth;
                ShowToothMenu(e.Location);
                Invalidate();
                return;
            }
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        foreach (Tooth tooth in _teeth)
        {
            if (tooth.Path.IsVisible(e.Location))
            {
                if (_hoveredTooth != tooth)
                {
                    _hoveredTooth = tooth;
                    Cursor = Cursors.Hand;
                    Invalidate();
                }

                return;
            }
        }

        if (_hoveredTooth != null)
        {
            _hoveredTooth = null;
            Cursor = Cursors.Default;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        foreach (Tooth tooth in _teeth)
        {
            Color color = GetStatusColor(tooth.Status);
            int outlineTickness = 1;

            if (tooth == _hoveredTooth)
                color = Utils.DarkenColor(color, 0.2f);
                
            if (tooth == _hoveredTooth || tooth == _selectedTooth)
                outlineTickness = 3;
                
            RectangleF pathBounds = path.GetBounds();
            string text = tooth.Number.ToString();
            SizeF textSize = g.MeasureString(text, NumbersFont);
        
            float x = pathBounds.X + (pathBounds.Width - textSize.Width) / 2;
            float y = pathBounds.Y + (pathBounds.Height - textSize.Height) / 2;
        
            using SolidBrush brush = new(color);
            using Pen pen = new(Color.Black, outlineTickness);

            e.Graphics.FillPath(brush, tooth.Path);
            e.Graphics.DrawPath(pen, tooth.Path);
            g.DrawString(text, NumbersFont, Brushes.Black, x, y);
        }
    }

    private void ShowToothMenu(Point location)
    {
        /**
         * We need:
         * TxetBox for notes
         * Button for save 
         * ComboBox for status
         * 
         */
        ToothDropDoown popupContent = new();
        popupContent.SetData(_selectedTooth!);
        
        ToolStripControlHost host = new(popupContent)
        {
            Margin = Padding.Empty,
            Padding = Padding.Empty,
            AutoSize = false
        };
    
        ToolStripDropDown dropdown = new()
        {
            Padding = Padding.Empty
        };
        
        dropdown.Items.Add(host);
        popupContent.Leave += (_, _) => dropdown.Close();
        popupContent.OnClosed += DropDown_OnClosed;
    
        dropdown.Show(this, location);
    }
    
    private void DropDown_OnClosed()
    {
        _selectedTooth = null;
        Invalidate();
    }

    private Color GetStatusColor(ToothStatus status) => status switch
    {
        ToothStatus.Normal => Color.White,
        ToothStatus.Missing => Color.FromArgb(230, 230, 230),
        ToothStatus.Filled => Color.FromArgb(33, 150, 243),
        ToothStatus.Crown => Color.FromArgb(255, 193, 7),
        ToothStatus.Implant => Color.FromArgb(76, 175, 80),
        ToothStatus.RootCanal => Color.FromArgb(244, 67, 54),
        _ => throw new NotImplementedException(status.ToString())
    };

    private string GetStatusString(ToothStatus status) => status switch
    {
        ToothStatus.Normal => "Normal",
        ToothStatus.Missing => "Missing",
        ToothStatus.Filled => "Filled",
        ToothStatus.Crown => "Crown",
        ToothStatus.Implant => "Implant",
        ToothStatus.RootCanal => "Root Canal",
        _ => throw new NotImplementedException(status.ToString())
    };
}

public class ToothGraphic
{
    public int Number { get; set; }
    public string Name { get; set; } = null!;
    public GraphicsPath Path { get; set; } = null!;
}
