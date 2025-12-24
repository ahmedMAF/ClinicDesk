using ReaLTaiizor.Controls;
using Svg;
using System.Drawing.Drawing2D;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private readonly ToothStatus[] _toothStatuses = Enum.GetValues<ToothStatus>();

    private readonly List<Tooth> _teeth = [];
    private Tooth? _selectedTooth;

    public ToothChart()
    {
        DoubleBuffered = true;
        Size = new Size(600, 200);
        CreateTeeth();
    }

    private void CreateTeeth()
    {
        int startX = 20;
        int toothWidth = 30;
        int toothHeight = 60;
        int gap = 5;

        for (int i = 1; i <= 32; i++)
        {
            GraphicsPath path = new();
            int x = startX + ((i - 1) % 16) * (toothWidth + gap);
            int y = i <= 16 ? 20 : 120;

            path.AddRoundedRectangle(new Rectangle(x, y, toothWidth, toothHeight), new Size(6, 6));

            _teeth.Add(new Tooth
            {
                Number = i,
                Path = path,
                Status = ToothStatus.Normal
            });
        }
    }

    protected override void OnMouseDown(MouseEventArgs e)
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
                Cursor = Cursors.Hand
                return;
            }
        }
        
        Cursor = Cursors.Default;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        foreach (Tooth tooth in _teeth)
        {
            using SolidBrush brush = new(GetStatusColor(tooth.Status));
            using Pen pen = new(Color.Gray, 1);

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

    public static GraphicsPath LoadSvgPath(string file)
    {
        SvgDocument doc = SvgDocument.Open(file);
        GraphicsPath path = new();

        foreach (var element in doc.Children)
        {
            if (element is SvgPath svgPath)
            {
                //path.AddPath(svgPath.PathData, false);
            }
        }

        return path;
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
