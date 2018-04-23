using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraPrinting;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Printing;
#endregion #usings

namespace ExportScheduler2PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

#region #export
private void btnExport_Click(object sender, EventArgs e)
{
    SetPrintStyle();
    string filePath = "Test.pdf";
    PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
    pcl.Component = this.schedulerControl1;
    pcl.CreateDocument();
    pcl.ExportToPdf(filePath);
    // Use the code below to open the file in an associated application.
    if (File.Exists(filePath)) {
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        process.StartInfo.FileName = filePath;
        process.Start();
    }
}

private void SetPrintStyle()
{
    DailyPrintStyle pStyle = this.schedulerControl1.ActivePrintStyle as DailyPrintStyle;

    // Set fonts for appointments and column headings.
    pStyle.AppointmentFont = new Font("Arial", 8, FontStyle.Regular);
    pStyle.HeadingsFont = new Font("Arial", 10, FontStyle.Regular);

    // Specify whether the Calendar header should be printed.
    pStyle.CalendarHeaderVisible = false;

    // Specify the intervals to print.
    DateTime dt = DateTime.Now;
    pStyle.PrintTime = new TimeOfDayInterval(dt.TimeOfDay, dt.AddHours(4).TimeOfDay);
    pStyle.StartRangeDate = dt.Date;
    pStyle.EndRangeDate = dt.AddDays(3).Date;

    // Specify resources to print.
    //pStyle.ResourceOptions.CustomResourcesCollection.Add(schedulerStorage1.Resources[0]);
    //pStyle.ResourceOptions.PrintCustomCollection = true;
    pStyle.PrintAllAppointments = false;
}
#endregion #export
    }
}
