using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private readonly ToothStatus[] _toothStatuses = Enum.GetValues<ToothStatus>();

    private readonly List<Tooth> _teeth = [];
    private Tooth? _selectedTooth;
    private Tooth? _hoveredTooth;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public Color HoverColor { get; set; } = Color.LightBlue;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public Color OutlineColor { get; set; } = Color.Gray;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public int OutlineThickness { get; set; } = 5;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public int Spacing { get; set; } = 10;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public Size ToothSize { get; set; } = new Size(30, 60);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Category("Appearance")]
    public Size CornerRounding { get; set; } = new Size(6, 6);

    public ToothChart()
    {
        DoubleBuffered = true;
        Size = new Size(600, 200);
        CreateTeeth();
    }

    private void CreateTeeth()
    {
        int startX = 20;
        
        for (int i = 1; i <= 32; i++)
        {
            GraphicsPath path = new();
            int x = startX + (i - 1) % 16 * (ToothSize.Width + Spacing);
            int y = i <= 16 ? 20 : 120;

            path.AddRoundedRectangle(new Rectangle(x, y, ToothSize.Width, ToothSize.Height), CornerRounding);

            _teeth.Add(new Tooth
            {
                Number = i,
                Path = path,
                Status = ToothStatus.Normal
            });
        }
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
                Cursor = Cursors.Hand;

                if (tooth != _hoveredTooth)
                {
                    _hoveredTooth = tooth;
                    Invalidate();
                }

                return;
            }
        }

        _hoveredTooth = null;
        Cursor = Cursors.Default;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        foreach (Tooth tooth in _teeth)
        {
            Color outlineColor = OutlineColor;

            if (tooth == _hoveredTooth)
                outlineColor = HoverColor;

            using SolidBrush brush = new(GetStatusColor(tooth.Status));
            using Pen pen = new(outlineColor, 5);

            e.Graphics.FillPath(brush, tooth.Path);
            e.Graphics.DrawPath(pen, tooth.Path);
        }
    }

    private void ShowToothMenu(Point location)
    {
        MaterialContextMenuStrip menu = new();

        foreach (ToothStatus status in _toothStatuses)
        {
            ToolStripMenuItem item = new(GetStatusString(status));

            item.Click += (_, _) =>
            {
                _selectedTooth!.Status = status;
                Invalidate();
            };

            menu.Items.Add(item);
        }

        menu.Show(this, location);
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

public enum ToothStatus
{
    Normal,
    Missing,
    Filled,
    Crown,
    Implant,
    RootCanal
}

public class Tooth
{
    public int Number { get; set; }
    public GraphicsPath Path { get; set; } = null!;
    public ToothStatus Status { get; set; }
    public PointF Position { get; set; }
    public float Rotation { get; set; }
    public bool IsUpper { get; set; }
}
