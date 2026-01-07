using ClinicDesk.Database.Models;
using ClinicDesk.Utilities;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private readonly List<ToothGraphic> _teethGp;
    
    private int? _selectedTooth;
    private int? _hoveredTooth;
    
    public event EventHandler<ToothEventArgs>? SelectedToothChanged;
    public event EventHandler<ToothEventArgs>? HoveredToothChanged;
    
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public bool IsReadonly { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<Tooth> Teeth
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
        Size = new Size(500, 500);
        NumbersFont = new Font("Segoe UI", 8);

        Teeth = new(52);
        _teethGp = TeethHelper.Teeth;
        
        for (int i = 0; i < 52; i++)
            Teeth.Add(new Tooth());
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        if (IsReadonly)
            return;

        for (int i = 0; i < _teethGp.Count; i++)
        {
            if (_teethGp[i].Path.IsVisible(e.Location))
            {
                _selectedTooth = i;
                SelectedToothChanged?.Invoke(this, new ToothEventArgs(Teeth[i], _teethGp[i]));
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
                    HoveredToothChanged?.Invoke(this, new ToothEventArgs(Teeth[i], _teethGp[i]));
                    Cursor = Cursors.Hand;
                    Invalidate();
                }

                return;
            }
        }

        if (_hoveredTooth != null)
        {
            _hoveredTooth = null;
            HoveredToothChanged?.Invoke(this, new ToothEventArgs());
            Cursor = Cursors.Default;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        for (int i = 0; i < _teethGp.Count; i++)
        {
            Tooth tooth = Teeth[i];
            ToothGraphic toothGp = _teethGp[i];

            Color color = GetStatusColor(tooth.Status);
            int outlineTickness = 1;

            if (i == _hoveredTooth)
                color = Utils.DarkenColor(color, 0.2f);
                
            if (i == _hoveredTooth || i == _selectedTooth)
                outlineTickness = 2;
                
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
        ToothDropDown popupContent = new();
        
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
    
        popupContent.SetData(Teeth[_selectedTooth!.Value]!, dropdown);
        dropdown.Show(this, location);
    }

    private void DropDown_Closed(object? sender, ToolStripDropDownClosedEventArgs e)
    {
        _selectedTooth = null;
        SelectedToothChanged?.Invoke(this, new ToothEventArgs());
        Invalidate();
    }

    private Color GetStatusColor(ToothStatus status) => status switch
    {
        ToothStatus.Normal => Color.White,
        ToothStatus.Missing => Color.Gray,
        ToothStatus.Implant => Color.FromArgb(76, 175, 80),
        ToothStatus.RootCanal => Color.FromArgb(244, 67, 54),
        _ => throw new NotImplementedException(status.ToString())
    };
}

public class ToothGraphic
{
    public int Number { get; set; }
    public string Name { get; set; } = null!;
    public GraphicsPath Path { get; set; } = null!;
}

public class ToothEventArgs : EventArgs
{
    public Tooth? Tooth { get; set; }
    public ToothGraphic? ToothGraphic { get; set; }

    public ToothEventArgs() { }

    public ToothEventArgs(Tooth tooth, ToothGraphic toothGraphic)
    {
        Tooth = tooth;
        ToothGraphic = toothGraphic;
    }
}
