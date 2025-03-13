<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sharecap_daily
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtpicker_from = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.dtpicker_from)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(912, 81)
        Me.Guna2Panel1.TabIndex = 0
        '
        'dtpicker_from
        '
        Me.dtpicker_from.Checked = True
        Me.dtpicker_from.FillColor = System.Drawing.Color.MidnightBlue
        Me.dtpicker_from.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker_from.ForeColor = System.Drawing.Color.White
        Me.dtpicker_from.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker_from.Location = New System.Drawing.Point(25, 39)
        Me.dtpicker_from.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker_from.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker_from.Name = "dtpicker_from"
        Me.dtpicker_from.Size = New System.Drawing.Size(213, 36)
        Me.dtpicker_from.TabIndex = 89
        Me.dtpicker_from.Value = New Date(2025, 2, 17, 17, 29, 34, 254)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 81)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(912, 518)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'sharecap_daily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 599)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "sharecap_daily"
        Me.Text = "sharecap_daily"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtpicker_from As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
