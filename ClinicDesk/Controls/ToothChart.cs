using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using ClinicDesk.Utilities;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private static readonly ToothStatus[] _toothStatuses = Enum.GetValues<ToothStatus>();

    private List<Tooth> _teeth = null!;
    private readonly List<ToothGraphic> _teethGp;
    
    private int? _selectedTooth;
    private int? _hoveredTooth;
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
        for (int i = 0; i < _teethGp.Count; i++)
        {
            if (_teethGp[i].Path.IsVisible(e.Location))
            {
                _selectedTooth = i;
                ShowToothMenu(e.Location);
                Invalidate();
                return;
            }
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        for (int i = 0; i < _teethGp.Count; i++)
        {
            if (_teethGp[i].Path.IsVisible(e.Location))
            {
                if (_hoveredTooth != i)
                {
                    _hoveredTooth = i;
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

        for (int i = 0; i < _teethGp.Count; i++)
        {
            Tooth tooth = _teeth[i];
            ToothGraphic toothGp = _teethGp[i];

            Color color = GetStatusColor(tooth.Status);
            int outlineTickness = 1;

            if (i == _hoveredTooth)
                color = Utils.DarkenColor(color, 0.2f);
                
            if (i == _hoveredTooth || i == _selectedTooth)
                outlineTickness = 3;
                
            RectangleF pathBounds = toothGp.Path.GetBounds();
            string text = toothGp.Number.ToString();
            SizeF textSize = e.Graphics.MeasureString(text, NumbersFont);
        
            float x = pathBounds.X + (pathBounds.Width - textSize.Width) / 2;
            float y = pathBounds.Y + (pathBounds.Height - textSize.Height) / 2;
        
            using SolidBrush brush = new(color);
            using Pen pen = new(Color.Black, outlineTickness);

            e.Graphics.FillPath(brush, toothGp.Path);
            e.Graphics.DrawPath(pen, toothGp.Path);
            e.Graphics.DrawString(text, NumbersFont, Brushes.Black, x, y);
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
        ToothDropDown popupContent = new();
        popupContent.SetData(_teeth[_selectedTooth!.Value]!);
        
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
        dropdown.Closed += DropDown_Closed;
        popupContent.Leave += (_, _) => dropdown.Close();
    
        dropdown.Show(this, location);
    }

    private void DropDown_Closed(object? sender, ToolStripDropDownClosedEventArgs e)
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
