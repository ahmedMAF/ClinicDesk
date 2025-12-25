using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicDesk.Controls;

public partial class ToothChart : Control
{
    private readonly ToothStatus[] _toothStatuses = Enum.GetValues<ToothStatus>();

    private readonly List<Point[][]> _upperAdultTeethCurvesLeftHalf =
    [
        [
            [new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0)],
            [new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0)],
            [new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0)]
        ]
    ];

    private readonly List<Tooth> _teeth = [];
    private readonly List<GraphicsPath> _teethGp = [];
    
    private Tooth? _selectedTooth;
    private Tooth? _hoveredTooth;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [SRCategory("Appearance")]
    public Color HoverColor
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
        HoverColor = Color.LightBlue;
        Size = new Size(600, 200);
        
        CreateTeeth();
    }

    private void CreateTeeth()
    {
        int startX = 20;
        int toothWidth = 30;
        int toothHieght = 60;
        int spacing = 10;
        
        for (int i = 0; i < 8; i++)
        {
            GraphicsPath path = new();
            Point[][] toothCurves = _upperAdultTeethCurvesLeftHalf[i];
            
            // path.StartFigure();
            
            // foreach (Point[] curve in toothCurves)
            //     path.AddBezier(curve[0], curve[1], curve[2], curve[3]);
            
            // path.CloseFigure();
            
            int x = startX + i * (toothWidth + spacing);
            int y = i <= 16 ? 20 : 120;

            path.AddRoundedRectangle(new Rectangle(x, y, toothWidth, toothHeight), new Size(6, 6));

            _teethGp.Add(path);
        }
        
        // Flip at middle.
        for (int i = 7; i >= 0; i--)
        {
            GraphicsPath path = (GraphicsPath)_teethGp[i].Clone();
            
            RectangleF bounds = path.GetBounds();
            Matrix flipX = new Matrix(-1, 0, 0, 1, bounds.Left + bounds.Width, 0);
            path.Transform(flipX);
            
            _teethGp.Add(path);
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
            Color color = GetStatusColor(tooth.Status);

            if (tooth == _hoveredTooth)
                color = Utils.DarkenColor(color, 0.2f);

            using SolidBrush brush = new(color);
            using Pen pen = new(Color.Gray, 5);

            e.Graphics.FillPath(brush, tooth.Path);
            e.Graphics.DrawPath(pen, tooth.Path);
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
        popupContent.OnClosed += (_, _) => Invalidate();
    
        dropdown.Show(this, location);
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
