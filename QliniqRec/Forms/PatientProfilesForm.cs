using QliniqRec.Database.Models;
using System.ComponentModel;

namespace QliniqRec.Forms;

public partial class PatientProfilesForm : Form
{
    private Appointment _appointment = null!;
    private Patient _patient = null!;

    public PatientProfilesForm()
    {
        InitializeComponent();
    }
    
    internal void SetData(Appointment appointment)
    {
        _appointment = appointment;
        _patient = _appointment.Patient;
    }
}
