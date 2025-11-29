using QliniqRec.Database.Models;
using System.ComponentModel;

namespace QliniqRec.Forms;

public partial class PatientProfilesForm : Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    internal Appointment Appointment { get; set; } = null!;

    public PatientProfilesForm()
    {
        InitializeComponent();
    }
}
