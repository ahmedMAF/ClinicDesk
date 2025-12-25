using System.Drawing.Drawing2D;

namespace ClinicDesk.Database.Models;

public class Tooth
{
    public int Number { get; set; }
    public ToothStatus Status { get; set; }
    public string Notes { get; set; }
}
