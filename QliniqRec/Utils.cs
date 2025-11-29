namespace QliniqRec;

internal static class Utils
{
    public static void SetupAppointmentsDataGrid(DataGridView appointmentsGrd)
    {
        appointmentsGrd.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        appointmentsGrd.AutoGenerateColumns = false;

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 50,
            DataPropertyName = "Serial",
            HeaderText = "No."
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 300,
            DataPropertyName = "PatientName",
            HeaderText = "Name"
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 90,
            DataPropertyName = "Time",
            HeaderText = "Time"
        });

        appointmentsGrd.Columns.Add(new DataGridViewTextBoxColumn
        {
            Width = 120,
            DataPropertyName = "Phone",
            HeaderText = "Phone"
        });
    }
}
