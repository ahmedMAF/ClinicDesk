using ClinicDesk.Database.Models;
using ReaLTaiizor.Controls;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicDesk;

public static class TeethHelper
{
    private static readonly PointF[][][] _upperAdultTeethCurvesLeftHalf =
    [
        [
            [ new PointF(1.888793f, 25.888147f), new PointF(1.250676f, 24.298525f), new PointF(2.532429f, 24.082109f), new PointF(3.877608f, 24.088744f) ],
            [ new PointF(3.877608f, 24.088744f), new PointF(5.094246f, 24.161804f), new PointF(6.515953f, 23.988132f), new PointF(5.980068f, 25.812383f) ],
            [ new PointF(5.980068f, 25.812383f), new PointF(6.168126f, 26.272456f), new PointF(6.453246f, 27.152705f), new PointF(6.093715f, 27.744374f) ],
            [ new PointF(6.093715f, 27.744374f), new PointF(5.74792f, 28.314272f), new PointF(2.97104f, 28.241303f), new PointF(2.267615f, 28.02849f) ],
            [ new PointF(2.267615f, 28.02849f), new PointF(1.674159f, 27.682807f), new PointF(1.747934f, 26.45241f), new PointF(1.888793f, 25.888147f) ]
        ],
        [
            [ new PointF(2.825748f, 19.360387f), new PointF(3.452218f, 19.102386f), new PointF(5.280657f, 19.194252f), new PointF(5.789605f, 19.453187f) ],
            [ new PointF(5.789605f, 19.453187f), new PointF(6.553027f, 19.779092f), new PointF(6.691426f, 20.408579f), new PointF(6.2048f, 21.34165f) ],
            [ new PointF(6.2048f, 21.34165f), new PointF(6.499454f, 22.591698f), new PointF(6.19141f, 23.172078f), new PointF(5.963719f, 23.32387f) ],
            [ new PointF(5.963719f, 23.32387f), new PointF(4.526164f, 23.681027f), new PointF(3.32076f, 23.645311f), new PointF(2.347508f, 23.216723f) ],
            [ new PointF(2.347508f, 23.216723f), new PointF(1.543978f, 22.213923f), new PointF(2.351008f, 19.551527f), new PointF(2.825748f, 19.360384f) ]
        ],
        [
            [ new PointF(5.829785f, 18.997813f), new PointF(4.832962f, 18.821661f), new PointF(3.910438f, 18.610545f), new PointF(3.338618f, 18.234392f) ],
            [ new PointF(3.338618f, 18.234392f), new PointF(3.173939f, 18.102147f), new PointF(3.035991f, 17.261727f), new PointF(3.325228f, 16.359319f) ],
            [ new PointF(3.325228f, 16.359319f), new PointF(3.547154f, 15.61532f), new PointF(4.06929f, 15.284111f), new PointF(4.718139f, 15.127131f) ],
            [ new PointF(4.718139f, 15.127131f), new PointF(5.92062f, 15.042191f), new PointF(7.051159f, 15.227071f), new PointF(7.128945f, 15.48875f) ],
            [ new PointF(7.128945f, 15.48875f), new PointF(7.269598f, 15.803702f), new PointF(7.077495f, 16.859068f), new PointF(6.753931f, 17.337036f) ],
            [ new PointF(6.753931f, 17.337036f), new PointF(6.626964f, 18.74171f), new PointF(6.109877f, 18.978606f), new PointF(5.829785f, 18.997813f) ]
        ],
        [
            [ new PointF(4.477055f, 12.327916f), new PointF(4.725941f, 11.643694f), new PointF(5.221467f, 11.146578f), new PointF(6.499454f, 11.243053f) ],
            [ new PointF(6.499454f, 11.243053f), new PointF(7.776283f, 11.281753f), new PointF(8.680667f, 11.610124f), new PointF(8.361132f, 12.890436f) ],
            [ new PointF(8.361132f, 12.890436f), new PointF(7.941958f, 14.52481f), new PointF(7.404815f, 14.979488f), new PointF(6.807502f, 14.832475f) ],
            [ new PointF(6.807502f, 14.832475f), new PointF(6.093593f, 14.667276f), new PointF(5.39307f, 14.649317f), new PointF(4.610988f, 13.734218f) ],
            [ new PointF(4.610988f, 13.734218f), new PointF(4.411847f, 13.287522f), new PointF(4.382284f, 12.568336f), new PointF(4.477055f, 12.327916f) ]
        ],
        [
            [ new PointF(6.218193f, 9.756388f), new PointF(6.117638f, 8.844369f), new PointF(6.268203f, 8.081663f), new PointF(7.47717f, 7.948281f) ],
            [ new PointF(7.47717f, 7.948281f), new PointF(9.361783f, 7.810431f), new PointF(9.665778f, 8.292432f), new PointF(9.754043f, 8.859032f) ],
            [ new PointF(9.754043f, 8.859032f), new PointF(9.566347f, 10.853989f), new PointF(9.118837f, 10.940503f), new PointF(8.642393f, 11.082331f) ],
            [ new PointF(8.642393f, 11.082331f), new PointF(7.504332f, 11.261516f), new PointF(6.257623f, 10.216278f), new PointF(6.218193f, 9.756388f) ]
        ],
        [
            [ new PointF(8.215117f, 5.649594f), new PointF(8.426087f, 5.420998f), new PointF(9.967502f, 4.98381f), new PointF(11.340396f, 5.933709f) ],
            [ new PointF(11.340396f, 5.933709f), new PointF(11.893131f, 6.831757f), new PointF(11.370386f, 8.157479f), new PointF(10.630105f, 8.339229f) ],
            [ new PointF(10.630105f, 8.339229f), new PointF(9.488943f, 8.262409f), new PointF(7.962569f, 6.509193f), new PointF(8.215117f, 5.649594f) ]
        ],
        [
            [ new PointF(10.203931f, 4.323717f), new PointF(10.357485f, 3.540855f), new PointF(11.910113f, 3.080284f), new PointF(12.874624f, 2.959959f) ],
            [ new PointF(12.874624f, 2.959959f), new PointF(13.508858f, 3.268799f), new PointF(13.561178f, 5.186405f), new PointF(13.206094f, 5.678005f) ],
            [ new PointF(13.206094f, 5.678005f), new PointF(11.753373f, 6.083817f), new PointF(10.304732f, 4.77239f), new PointF(10.203931f, 4.323717f) ]
        ],
        [
            [ new PointF(13.370255f, 2.631114f), new PointF(13.753551f, 1.866373f), new PointF(16.649095f, 1.393731f), new PointF(17.25433f, 1.988232f) ],
            [ new PointF(17.25433f, 1.988232f), new PointF(17.521922f, 3.14672f), new PointF(16.774499f, 4.545952f), new PointF(16.182863f, 4.733871f) ],
            [ new PointF(16.182863f, 4.733871f), new PointF(15.066458f, 4.740671f), new PointF(13.767208f, 3.85839f), new PointF(13.370255f, 2.631114f) ]
        ]
    ];
    
    private static readonly PointF[][][] _upperBabyTeethCurvesLeftHalf =
    [
        [
            [ new PointF(34.958802f, 24.988011f), new PointF(35.064216f, 22.237101f), new PointF(36.365835f, 22.702486f), new PointF(37.326439f, 22.904491f) ],
            [ new PointF(37.326439f, 22.904491f), new PointF(38.327805f, 23.107698f), new PointF(39.668078f, 23.179529f), new PointF(38.879606f, 25.404717f) ],
            [ new PointF(38.879606f, 25.404717f), new PointF(39.264067f, 26.612439f), new PointF(39.29154f, 27.579713f), new PointF(38.159847f, 28.151174f) ],
            [ new PointF(38.159847f, 28.151174f), new PointF(37.025291f, 28.268196f), new PointF(36.230762f, 28.073884f), new PointF(35.489154f, 27.829176f) ],
            [ new PointF(35.489154f, 27.829176f), new PointF(34.543294f, 27.358312f), new PointF(34.682665f, 26.213787f), new PointF(34.958802f, 24.988011f) ]
        ],
        [
            [ new PointF(36.290534f, 21.467508f), new PointF(36.743244f, 20.474399f), new PointF(37.410269f, 18.554969f), new PointF(37.884345f, 18.226312f) ],
            [ new PointF(37.884345f, 18.226312f), new PointF(38.812626f, 18.053907f), new PointF(39.790274f, 18.727559f), new PointF(40.268365f, 19.177243f) ],
            [ new PointF(40.268365f, 19.177243f), new PointF(40.984011f, 19.811751f), new PointF(39.878227f, 22.147351f), new PointF(39.545124f, 22.418439f) ],
            [ new PointF(39.545124f, 22.418439f), new PointF(38.684101f, 22.891927f), new PointF(36.467778f, 22.64119f), new PointF(36.290534f, 21.467508f) ]
        ],
        [
            [ new PointF(38.737549f, 16.852814f), new PointF(39.769751f, 16.139379f), new PointF(40.942054f, 16.035183f), new PointF(41.616594f, 16.322465f) ],
            [ new PointF(41.616594f, 16.322465f), new PointF(42.278895f, 17.098249f), new PointF(42.431594f, 17.966409f), new PointF(41.862829f, 18.765863f) ],
            [ new PointF(41.862829f, 18.765863f), new PointF(40.064987f, 18.971568f), new PointF(38.583048f, 17.754461f), new PointF(38.737549f, 16.852814f) ]
        ],
        [
            [ new PointF(41.031788f, 15.15923f), new PointF(41.227656f, 14.395733f), new PointF(42.965638f, 13.801265f), new PointF(43.857789f, 13.779714f) ],
            [ new PointF(43.857789f, 13.779714f), new PointF(44.203909f, 14.407389f), new PointF(44.210582f, 15.848359f), new PointF(44.031231f, 16.564385f) ],
            [ new PointF(44.031231f, 16.564385f), new PointF(43.027271f, 16.957989f), new PointF(41.383944f, 16.057764f), new PointF(41.031788f, 15.15923f) ]
        ],
        [
            [ new PointF(44.125656f, 13.618992f), new PointF(44.43148f, 13.044749f), new PointF(46.887799f, 12.340875f), new PointF(47.755261f, 13.002897f) ],
            [ new PointF(47.755261f, 13.002897f), new PointF(47.906247f, 13.773531f), new PointF(47.390759f, 15.082713f), new PointF(46.817725f, 15.614604f) ],
            [ new PointF(46.817725f, 15.614604f), new PointF(45.839256f, 15.609704f), new PointF(44.46252f, 14.540631f), new PointF(44.125656f, 13.618992f) ]
        ]
    ];
    
    private static readonly string[] _adultTeethNames =
    [
        "Third Molar",
        "Second Molar",
        "First Molar",
        "Second Premolar",
        "First Premolar",
        "Canine",
        "Lateral Incisor",
        "Central Incisor"
    ];
    
    private static readonly string[] _babyTeethNames =
    [
        "Second Molar",
        "First Molar",
        "Canine",
        "Lateral Incisor",
        "Central Incisor"
    ];
    
    public static List<ToothGraphic> Teeth { get; private set; }
    
    private static void Initialize()
    {
        Teeth = new List<ToothGraphic>(52);
        
        for (int i = 0; i < 8; i++)
        {
            GraphicsPath path = new();
            Point[][] toothCurves = _upperAdultTeethCurvesLeftHalf[i];
            
            path.StartFigure();
            
            foreach (Point[] curve in toothCurves)
                path.AddBezier(curve[0], curve[1], curve[2], curve[3]);
            
            path.CloseFigure();
            
            Teeth.Add(new ToothGraphic
            {
                Name = "Upper Right " + _adultTeethNames[i],
                Number = 10 + (8 - i),
                Path = path
            });
        }
        
        // Flip at middle. Upper right half.
        for (int i = 7; i >= 0; i--)
        {
            GraphicsPath path = (GraphicsPath)Teeth[i].Path.Clone();
            
            RectangleF bounds = path.GetBounds();
            Matrix flipX = new Matrix(-1, 0, 0, 1, 00, 0);
            path.Transform(flipX);
            
            Teeth.Add(new ToothGraphic
            {
                Name = "Upper Left " + _adultTeethNames[i],
                Number = 20 + (8 - i),
                Path = path
            });
        }
        
        // Lower half.
        for (int i = 15; i >= 0; i--)
        {
            GraphicsPath path = (GraphicsPath)_teethGp[i].Clone();
            
            RectangleF bounds = path.GetBounds();
            Matrix flipY = new Matrix(1, 0, 0, -1, 0, 00);
            path.Transform(flipY);
            
            Teeth.Add(new ToothGraphic
            {
                Name = "Lower " (i > 7 ? "Left " : "Right ") + _adultTeethNames[i],
                Number = i > 7 ? 30 + (i - 7) : 40 + i + 1,
                Path = path
            });
        }
    }
}
