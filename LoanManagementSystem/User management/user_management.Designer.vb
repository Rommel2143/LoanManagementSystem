<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_management
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
        Me.cmb_fullname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_account = New System.Windows.Forms.Label()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_fullname
        '
        Me.cmb_fullname.BackColor = System.Drawing.Color.Transparent
        Me.cmb_fullname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_fullname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fullname.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_fullname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_fullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_fullname.ItemHeight = 30
        Me.cmb_fullname.Location = New System.Drawing.Point(41, 27)
        Me.cmb_fullname.Name = "cmb_fullname"
        Me.cmb_fullname.Size = New System.Drawing.Size(450, 36)
        Me.cmb_fullname.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 3
        Me.Guna2Panel3.Controls.Add(Me.Label22)
        Me.Guna2Panel3.Controls.Add(Me.lbl_account)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(41, 78)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.BorderRadius = 8
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.Guna2Panel3.ShadowDecoration.Depth = 10
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.Size = New System.Drawing.Size(301, 56)
        Me.Guna2Panel3.TabIndex = 122
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(12, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 17)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Account No. :"
        '
        'lbl_account
        '
        Me.lbl_account.AutoSize = True
        Me.lbl_account.BackColor = System.Drawing.Color.Transparent
        Me.lbl_account.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_account.Location = New System.Drawing.Point(104, 18)
        Me.lbl_account.Name = "lbl_account"
        Me.lbl_account.Size = New System.Drawing.Size(27, 20)
        Me.lbl_account.TabIndex = 80
        Me.lbl_account.Text = "---"
        '
        'user_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 658)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.cmb_fullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_management"
        Me.Text = "user_management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmb_fullname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_account As Label
End Class
