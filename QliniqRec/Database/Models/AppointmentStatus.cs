namespace QliniqRec.Database.Models;

public enum AppointmentStatus : byte
{
    Pending,
    Attended,
    Cancelled,
    Missed,
    Rescheduled
}
