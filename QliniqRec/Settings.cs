namespace QliniqRec;

public class Settings
{
    public string Server { get; internal set; } = null!;
    public ushort Port { get; internal set; }
    public string Database { get; internal set; } = null!;
    public string User { get; internal set; } = null!;
    public string Password { get; internal set; } = null!;
}