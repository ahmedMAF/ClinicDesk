using System.Drawing.Drawing2D;

namespace ClinicDesk.Database.Models;

public enum ToothStatus : byte
{
    Normal,
    Missing,
    Filled,
    Crown,
    Implant,
    RootCanal
}
