<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_profiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_profiles))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_newpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_confirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.img_notequal = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.img_notequal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(483, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(483, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password"
        '
        'txt_newpass
        '
        Me.txt_newpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_newpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_newpass.DefaultText = ""
        Me.txt_newpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_newpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_newpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_newpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_newpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_newpass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_newpass.Location = New System.Drawing.Point(486, 382)
        Me.txt_newpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_newpass.PlaceholderText = ""
        Me.txt_newpass.SelectedText = ""
        Me.txt_newpass.Size = New System.Drawing.Size(229, 37)
        Me.txt_newpass.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(483, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'txt_confirmpass
        '
        Me.txt_confirmpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_confirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirmpass.DefaultText = ""
        Me.txt_confirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_confirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_confirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmpass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmpass.Location = New System.Drawing.Point(486, 455)
        Me.txt_confirmpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_confirmpass.Name = "txt_confirmpass"
        Me.txt_confirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_confirmpass.PlaceholderText = ""
        Me.txt_confirmpass.SelectedText = ""
        Me.txt_confirmpass.Size = New System.Drawing.Size(229, 37)
        Me.txt_confirmpass.TabIndex = 4
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.White
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(684, 305)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(29, 24)
        Me.Guna2ImageButton1.TabIndex = 30
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.IconLeft = CType(resources.GetObject("txt_password.IconLeft"), System.Drawing.Image)
        Me.txt_password.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_password.Location = New System.Drawing.Point(486, 300)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "Password..."
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(229, 35)
        Me.txt_password.TabIndex = 29
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2ImageButton2.BackColor = System.Drawing.Color.White
        Me.Guna2ImageButton2.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton2.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Image = CType(resources.GetObject("Guna2ImageButton2.Image"), System.Drawing.Image)
        Me.Guna2ImageButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton2.ImageRotate = 0!
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(682, 390)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2ImageButton2.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(29, 24)
        Me.Guna2ImageButton2.TabIndex = 31
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.Enabled = False
        Me.btn_login.FillColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(521, 522)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(156, 46)
        Me.btn_login.TabIndex = 32
        Me.btn_login.Text = "Change my password"
        '
        'img_notequal
        '
        Me.img_notequal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_notequal.BackColor = System.Drawing.Color.White
        Me.img_notequal.Image = CType(resources.GetObject("img_notequal.Image"), System.Drawing.Image)
        Me.img_notequal.ImageRotate = 0!
        Me.img_notequal.Location = New System.Drawing.Point(683, 458)
        Me.img_notequal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.img_notequal.Name = "img_notequal"
        Me.img_notequal.Size = New System.Drawing.Size(27, 29)
        Me.img_notequal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_notequal.TabIndex = 2
        Me.img_notequal.TabStop = False
        Me.img_notequal.Visible = False
        '
        'manage_profiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 771)
        Me.Controls.Add(Me.img_notequal)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Guna2ImageButton2)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_confirmpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_newpass)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manage_profiles"
        Me.Text = "manage_profiles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.img_notequal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_newpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_confirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents img_notequal As Guna.UI2.WinForms.Guna2PictureBox
End Class
