using System.Drawing.Drawing2D;
using ClinicDesk.Controls;

namespace ClinicDesk.Utilities;

public static class TeethHelper
{
    public static List<ToothGraphic> Teeth
    {
        get
        {
            if (field == null)
                Initialize();

            return field!;
        }

        private set;
    }
    
    public static void Initialize()
    {
        List<GraphicsPath> teeth = SvgPathParser.ParseMultiplePaths(Properties.Resources.TeethSvg.AsSpan(), new PointF(8f, 8f));
        
        Teeth =
        [
            // Permanent Teeth (Upper Right to Lower Right, FDI 18–48)
            new ToothGraphic { Name = "Upper Right Third Molar", Number = 18, Path = teeth[0] },
            new ToothGraphic { Name = "Upper Right Second Molar", Number = 17, Path = teeth[1] },
            new ToothGraphic { Name = "Upper Right First Molar", Number = 16, Path = teeth[2] },
            new ToothGraphic { Name = "Upper Right Second Premolar", Number = 15, Path = teeth[3] },
            new ToothGraphic { Name = "Upper Right First Premolar", Number = 14, Path = teeth[4] },
            new ToothGraphic { Name = "Upper Right Canine", Number = 13, Path = teeth[5] },
            new ToothGraphic { Name = "Upper Right Lateral Incisor", Number = 12, Path = teeth[6] },
            new ToothGraphic { Name = "Upper Right Central Incisor", Number = 11, Path = teeth[7] },
            new ToothGraphic { Name = "Upper Left Central Incisor", Number = 21, Path = teeth[8] },
            new ToothGraphic { Name = "Upper Left Lateral Incisor", Number = 22, Path = teeth[9] },
            new ToothGraphic { Name = "Upper Left Canine", Number = 23, Path = teeth[10] },
            new ToothGraphic { Name = "Upper Left First Premolar", Number = 24, Path = teeth[11] },
            new ToothGraphic { Name = "Upper Left Second Premolar", Number = 25, Path = teeth[12] },
            new ToothGraphic { Name = "Upper Left First Molar", Number = 26, Path = teeth[13] },
            new ToothGraphic { Name = "Upper Left Second Molar", Number = 27, Path = teeth[14] },
            new ToothGraphic { Name = "Upper Left Third Molar", Number = 28, Path = teeth[15] },
            
            new ToothGraphic { Name = "Lower Left Third Molar", Number = 38, Path = teeth[16] },
            new ToothGraphic { Name = "Lower Left Second Molar", Number = 37, Path = teeth[17] },
            new ToothGraphic { Name = "Lower Left First Molar", Number = 36, Path = teeth[18] },
            new ToothGraphic { Name = "Lower Left Second Premolar", Number = 35, Path = teeth[19] },
            new ToothGraphic { Name = "Lower Left First Premolar", Number = 34, Path = teeth[20] },
            new ToothGraphic { Name = "Lower Left Canine", Number = 33, Path = teeth[21] },
            new ToothGraphic { Name = "Lower Left Lateral Incisor", Number = 32, Path = teeth[22] },
            new ToothGraphic { Name = "Lower Left Central Incisor", Number = 31, Path = teeth[23] },
            new ToothGraphic { Name = "Lower Right Central Incisor", Number = 41, Path = teeth[24] },
            new ToothGraphic { Name = "Lower Right Lateral Incisor", Number = 42, Path = teeth[25] },
            new ToothGraphic { Name = "Lower Right Canine", Number = 43, Path = teeth[26] },
            new ToothGraphic { Name = "Lower Right First Premolar", Number = 44, Path = teeth[27] },
            new ToothGraphic { Name = "Lower Right Second Premolar", Number = 45, Path = teeth[28] },
            new ToothGraphic { Name = "Lower Right First Molar", Number = 46, Path = teeth[29] },
            new ToothGraphic { Name = "Lower Right Second Molar", Number = 47, Path = teeth[30] },
            new ToothGraphic { Name = "Lower Right Third Molar", Number = 48, Path = teeth[31] },
        
            // Primary Teeth (Upper Right to Lower Right, FDI 55–85)
            new ToothGraphic { Name = "Upper Right Second Molar", Number = 55, Path = teeth[32] },
            new ToothGraphic { Name = "Upper Right First Molar", Number = 54, Path = teeth[33] },
            new ToothGraphic { Name = "Upper Right Canine", Number = 53, Path = teeth[34] },
            new ToothGraphic { Name = "Upper Right Lateral Incisor", Number = 52, Path = teeth[35] },
            new ToothGraphic { Name = "Upper Right Central Incisor", Number = 51, Path = teeth[36] },
            new ToothGraphic { Name = "Upper Left Central Incisor", Number = 61, Path = teeth[37] },
            new ToothGraphic { Name = "Upper Left Lateral Incisor", Number = 62, Path = teeth[38] },
            new ToothGraphic { Name = "Upper Left Canine", Number = 63, Path = teeth[39] },
            new ToothGraphic { Name = "Upper Left First Molar", Number = 64, Path = teeth[40] },
            new ToothGraphic { Name = "Upper Left Second Molar", Number = 65, Path = teeth[41] },
            
            new ToothGraphic { Name = "Lower Left Second Molar", Number = 75, Path = teeth[42] },
            new ToothGraphic { Name = "Lower Left First Molar", Number = 74, Path = teeth[43] },
            new ToothGraphic { Name = "Lower Left Canine", Number = 73, Path = teeth[44] },
            new ToothGraphic { Name = "Lower Left Lateral Incisor", Number = 72, Path = teeth[45] },
            new ToothGraphic { Name = "Lower Left Central Incisor", Number = 71, Path = teeth[46] },
            new ToothGraphic { Name = "Lower Right Central Incisor", Number = 81, Path = teeth[47] },
            new ToothGraphic { Name = "Lower Right Lateral Incisor", Number = 82, Path = teeth[48] },
            new ToothGraphic { Name = "Lower Right Canine", Number = 83, Path = teeth[49] },
            new ToothGraphic { Name = "Lower Right First Molar", Number = 84, Path = teeth[50] },
            new ToothGraphic { Name = "Lower Right Second Molar", Number = 85, Path = teeth[51] },
        ];
    }
}
