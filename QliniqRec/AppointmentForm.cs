using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QliniqRec;

public partial class AppointmentForm : Form
{
    public static AppointmentForm? Instance { get; private set; }

    public AppointmentForm()
    {
        InitializeComponent();
    }

    public static void ShowInstance()
    {
        if (Instance == null || Instance.IsDisposed)
            Instance = new AppointmentForm();

        Instance.Show();
    }

    public static void CloseInstance()
    {
        Instance?.Close();
        Instance = null;
    }
}
