<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee_add
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
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_first = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_accountno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pic1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_middle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_last = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_civil = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error.Location = New System.Drawing.Point(463, 563)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(187, 20)
        Me.lbl_error.TabIndex = 39
        Me.lbl_error.Text = "Please Complete the Form!"
        Me.lbl_error.Visible = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(492, 586)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(134, 56)
        Me.Guna2Button2.TabIndex = 38
        Me.Guna2Button2.Text = "Save Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(106, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Fullname :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(91, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Account no :"
        '
        'txt_first
        '
        Me.txt_first.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_first.DefaultText = ""
        Me.txt_first.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_first.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_first.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_first.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_first.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_first.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_first.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_first.Location = New System.Drawing.Point(188, 115)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_first.PlaceholderText = "Firstname..."
        Me.txt_first.SelectedText = ""
        Me.txt_first.Size = New System.Drawing.Size(200, 36)
        Me.txt_first.TabIndex = 40
        '
        'txt_accountno
        '
        Me.txt_accountno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_accountno.DefaultText = ""
        Me.txt_accountno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_accountno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_accountno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_accountno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_accountno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_accountno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_accountno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_accountno.Location = New System.Drawing.Point(188, 49)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_accountno.PlaceholderText = ""
        Me.txt_accountno.SelectedText = ""
        Me.txt_accountno.Size = New System.Drawing.Size(200, 36)
        Me.txt_accountno.TabIndex = 41
        '
        'pic1
        '
        Me.pic1.ImageRotate = 0!
        Me.pic1.Location = New System.Drawing.Point(983, 49)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(170, 170)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 43
        Me.pic1.TabStop = False
        '
        'txt_middle
        '
        Me.txt_middle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_middle.DefaultText = ""
        Me.txt_middle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_middle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_middle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_middle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middle.Location = New System.Drawing.Point(188, 157)
        Me.txt_middle.Name = "txt_middle"
        Me.txt_middle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_middle.PlaceholderText = "Middlename..."
        Me.txt_middle.SelectedText = ""
        Me.txt_middle.Size = New System.Drawing.Size(200, 36)
        Me.txt_middle.TabIndex = 44
        '
        'txt_last
        '
        Me.txt_last.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_last.DefaultText = ""
        Me.txt_last.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_last.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_last.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_last.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_last.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_last.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_last.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_last.Location = New System.Drawing.Point(188, 199)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_last.PlaceholderText = "Lastname..."
        Me.txt_last.SelectedText = ""
        Me.txt_last.Size = New System.Drawing.Size(200, 36)
        Me.txt_last.TabIndex = 45
        '
        'dtpicker1
        '
        Me.dtpicker1.Checked = True
        Me.dtpicker1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker1.ForeColor = System.Drawing.Color.White
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker1.Location = New System.Drawing.Point(188, 300)
        Me.dtpicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(241, 48)
        Me.dtpicker1.TabIndex = 46
        Me.dtpicker1.Value = New Date(2024, 8, 21, 10, 35, 3, 361)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(106, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Birthdate :"
        '
        'cmb_civil
        '
        Me.cmb_civil.BackColor = System.Drawing.Color.Transparent
        Me.cmb_civil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_civil.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_civil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_civil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_civil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_civil.ItemHeight = 30
        Me.cmb_civil.Items.AddRange(New Object() {"Married", "Single", "Divorced", "Widowed", "Others"})
        Me.cmb_civil.Location = New System.Drawing.Point(188, 354)
        Me.cmb_civil.Name = "cmb_civil"
        Me.cmb_civil.Size = New System.Drawing.Size(241, 36)
        Me.cmb_civil.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(94, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Civil Status :"
        '
        'employee_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 700)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_civil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpicker1)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.txt_middle)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.txt_accountno)
        Me.Controls.Add(Me.txt_first)
        Me.Controls.Add(Me.lbl_error)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employee_add"
        Me.Text = "employee_add"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_error As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_first As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_accountno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pic1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_middle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_last As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_civil As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
End Class
