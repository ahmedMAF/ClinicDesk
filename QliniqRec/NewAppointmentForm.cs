using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QliniqRec;

public partial class NewAppointmentForm : Form
{
    public static NewAppointmentForm? Instance { get; private set; }

    public NewAppointmentForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new NewAppointmentForm();

        Instance.ShowDialog();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        CloseInstance();
    }
    private void saveBtn_Click(object sender, EventArgs e)
    {
        CloseInstance();
    }

    private void searchNameBtn_Click(object sender, EventArgs e)
    {
        if (false)
        {

            return;
        }

        if (MessageBox.Show("Patient was not found, do you want to add a new patient?", "Search Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            NewPatient.ShowInstance();
        }
    }

    private void searchPhoneBtn_Click(object sender, EventArgs e)
    {

    }

}
