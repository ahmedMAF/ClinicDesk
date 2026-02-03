using static ReaLTaiizor.Manager.MaterialSkinManager;

namespace ClinicDesk;

public class Theme
{
    public static Color BackgroundColor => Instance.BackgroundColor;

    public static Color DataGridHeaderColor => BackgroundColor;
    public static Color DataGridLinesColor => Instance.Theme == Themes.LIGHT ? Color.Black : Color.White;

    public static Color DataGridRowBackColor => BackgroundColor;
    public static Color DataGridAttendedRowBackColor => Instance.Theme == Themes.LIGHT ? Color.LightGreen : Color.DarkGreen;
    public static Color DataGridCancelledRowBackColor => Instance.Theme == Themes.LIGHT ? Color.LightPink : Color.DarkRed;
    public static Color DataGridMissedRowBackColor => Instance.Theme == Themes.LIGHT ? Color.LightGray : Color.DarkGray;
    public static Color DataGridRescheduledRowBackColor => Instance.Theme == Themes.LIGHT ? Color.LightYellow : Color.FromArgb(250, 160, 0);
}
