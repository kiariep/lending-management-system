﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCollectable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.infiniter8_dbDataSet = New INFINITER8_LMS.infiniter8_dbDataSet()
        Me.CollectableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollectableTableAdapter = New INFINITER8_LMS.infiniter8_dbDataSetTableAdapters.CollectableTableAdapter()
        CType(Me.infiniter8_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsCollectable"
        ReportDataSource1.Value = Me.CollectableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "INFINITER8_LMS.rptCollectable.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(691, 415)
        Me.ReportViewer1.TabIndex = 0
        '
        'infiniter8_dbDataSet
        '
        Me.infiniter8_dbDataSet.DataSetName = "infiniter8_dbDataSet"
        Me.infiniter8_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollectableBindingSource
        '
        Me.CollectableBindingSource.DataMember = "Collectable"
        Me.CollectableBindingSource.DataSource = Me.infiniter8_dbDataSet
        '
        'CollectableTableAdapter
        '
        Me.CollectableTableAdapter.ClearBeforeFill = True
        '
        'frmReportCollectable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 416)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportCollectable"
        Me.Text = "Collectables Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.infiniter8_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CollectableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents infiniter8_dbDataSet As INFINITER8_LMS.infiniter8_dbDataSet
    Friend WithEvents CollectableTableAdapter As INFINITER8_LMS.infiniter8_dbDataSetTableAdapters.CollectableTableAdapter
End Class
