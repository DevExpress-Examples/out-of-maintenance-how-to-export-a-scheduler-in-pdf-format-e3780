Imports Microsoft.VisualBasic
Imports System
Namespace ExportScheduler2PDF
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnExport)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(784, 48)
			Me.panelControl1.TabIndex = 0
			' 
			' btnExport
			' 
			Me.btnExport.Location = New System.Drawing.Point(12, 12)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New System.Drawing.Size(75, 23)
			Me.btnExport.TabIndex = 0
			Me.btnExport.Text = "Export to PDF"
'			Me.btnExport.Click += New System.EventHandler(Me.btnExport_Click);
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 48)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(784, 414)
			Me.schedulerControl1.Start = New System.DateTime(2012, 1, 27, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 1
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(784, 462)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

	End Class
End Namespace

