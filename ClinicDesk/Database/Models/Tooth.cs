namespace ClinicDesk.Database.Models;

public class Tooth
{
    public ToothStatus Status { get; set; }
    public ToothCrown Crown { get; set; }
    public ToothFilling Filling { get; set; }
    public List<ToothCavity> Cavities { get; set; } = [];
    public string Notes { get; set; } = "";
}
