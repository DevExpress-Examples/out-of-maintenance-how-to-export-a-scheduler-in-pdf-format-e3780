Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Printing
#End Region ' #usings

Namespace ExportScheduler2PDF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

#Region "#export"
Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
	SetPrintStyle()
	Dim filePath As String = "Test.pdf"
	Dim pcl As New PrintableComponentLink(New PrintingSystem())
	pcl.Component = Me.schedulerControl1
	pcl.CreateDocument()
	pcl.ExportToPdf(filePath)
	' Use the code below to open the file in an associated application.
	If File.Exists(filePath) Then
		Dim process As New System.Diagnostics.Process()
		process.StartInfo.FileName = filePath
		process.Start()
	End If
End Sub

Private Sub SetPrintStyle()
	Dim pStyle As DailyPrintStyle = TryCast(Me.schedulerControl1.ActivePrintStyle, DailyPrintStyle)

	' Set fonts for appointments and column headings.
	pStyle.AppointmentFont = New Font("Arial", 8, FontStyle.Regular)
	pStyle.HeadingsFont = New Font("Arial", 10, FontStyle.Regular)

	' Specify whether the Calendar header should be printed.
	pStyle.CalendarHeaderVisible = False

	' Specify the intervals to print.
	Dim dt As DateTime = DateTime.Now
	pStyle.PrintTime = New TimeOfDayInterval(dt.TimeOfDay, dt.AddHours(4).TimeOfDay)
	pStyle.StartRangeDate = dt.Date
	pStyle.EndRangeDate = dt.AddDays(3).Date

	' Specify resources to print.
	'pStyle.ResourceOptions.CustomResourcesCollection.Add(schedulerStorage1.Resources[0]);
	'pStyle.ResourceOptions.PrintCustomCollection = true;
	pStyle.PrintAllAppointments = False
End Sub
#End Region ' #export
	End Class
End Namespace
