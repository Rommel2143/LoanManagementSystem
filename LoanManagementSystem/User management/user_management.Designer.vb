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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_management))
        Me.cmb_fullname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_account = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.chk_reg = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chk_coll = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chk_release = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chk_appr = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chk_app = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmb_level = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_initials = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.cmb_fullname.Location = New System.Drawing.Point(41, 72)
        Me.cmb_fullname.Name = "cmb_fullname"
        Me.cmb_fullname.Size = New System.Drawing.Size(359, 36)
        Me.cmb_fullname.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 3
        Me.Guna2Panel3.Controls.Add(Me.Label22)
        Me.Guna2Panel3.Controls.Add(Me.lbl_account)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(40, 135)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.BorderRadius = 8
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel3.ShadowDecoration.Depth = 10
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.Size = New System.Drawing.Size(422, 56)
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
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.chk_reg)
        Me.Guna2GroupBox1.Controls.Add(Me.chk_coll)
        Me.Guna2GroupBox1.Controls.Add(Me.chk_release)
        Me.Guna2GroupBox1.Controls.Add(Me.chk_appr)
        Me.Guna2GroupBox1.Controls.Add(Me.chk_app)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MidnightBlue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(478, 135)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(334, 239)
        Me.Guna2GroupBox1.TabIndex = 123
        Me.Guna2GroupBox1.Text = "User Access"
        '
        'chk_reg
        '
        Me.chk_reg.AutoSize = True
        Me.chk_reg.BackColor = System.Drawing.Color.Transparent
        Me.chk_reg.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_reg.CheckedState.BorderRadius = 2
        Me.chk_reg.CheckedState.BorderThickness = 0
        Me.chk_reg.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_reg.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.chk_reg.ForeColor = System.Drawing.Color.DimGray
        Me.chk_reg.Location = New System.Drawing.Point(26, 175)
        Me.chk_reg.Name = "chk_reg"
        Me.chk_reg.Size = New System.Drawing.Size(168, 24)
        Me.chk_reg.TabIndex = 4
        Me.chk_reg.Text = "Member Registration"
        Me.chk_reg.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_reg.UncheckedState.BorderRadius = 2
        Me.chk_reg.UncheckedState.BorderThickness = 0
        Me.chk_reg.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_reg.UseVisualStyleBackColor = False
        '
        'chk_coll
        '
        Me.chk_coll.AutoSize = True
        Me.chk_coll.BackColor = System.Drawing.Color.Transparent
        Me.chk_coll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_coll.CheckedState.BorderRadius = 2
        Me.chk_coll.CheckedState.BorderThickness = 0
        Me.chk_coll.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_coll.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.chk_coll.ForeColor = System.Drawing.Color.DimGray
        Me.chk_coll.Location = New System.Drawing.Point(26, 145)
        Me.chk_coll.Name = "chk_coll"
        Me.chk_coll.Size = New System.Drawing.Size(131, 24)
        Me.chk_coll.TabIndex = 3
        Me.chk_coll.Text = "Loan Collection"
        Me.chk_coll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_coll.UncheckedState.BorderRadius = 2
        Me.chk_coll.UncheckedState.BorderThickness = 0
        Me.chk_coll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_coll.UseVisualStyleBackColor = False
        '
        'chk_release
        '
        Me.chk_release.AutoSize = True
        Me.chk_release.BackColor = System.Drawing.Color.Transparent
        Me.chk_release.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_release.CheckedState.BorderRadius = 2
        Me.chk_release.CheckedState.BorderThickness = 0
        Me.chk_release.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_release.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.chk_release.ForeColor = System.Drawing.Color.DimGray
        Me.chk_release.Location = New System.Drawing.Point(26, 115)
        Me.chk_release.Name = "chk_release"
        Me.chk_release.Size = New System.Drawing.Size(115, 24)
        Me.chk_release.TabIndex = 2
        Me.chk_release.Text = "Loan Release"
        Me.chk_release.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_release.UncheckedState.BorderRadius = 2
        Me.chk_release.UncheckedState.BorderThickness = 0
        Me.chk_release.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_release.UseVisualStyleBackColor = False
        '
        'chk_appr
        '
        Me.chk_appr.AutoSize = True
        Me.chk_appr.BackColor = System.Drawing.Color.Transparent
        Me.chk_appr.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_appr.CheckedState.BorderRadius = 2
        Me.chk_appr.CheckedState.BorderThickness = 0
        Me.chk_appr.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_appr.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.chk_appr.ForeColor = System.Drawing.Color.DimGray
        Me.chk_appr.Location = New System.Drawing.Point(26, 85)
        Me.chk_appr.Name = "chk_appr"
        Me.chk_appr.Size = New System.Drawing.Size(125, 24)
        Me.chk_appr.TabIndex = 1
        Me.chk_appr.Text = "Loan Approval"
        Me.chk_appr.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_appr.UncheckedState.BorderRadius = 2
        Me.chk_appr.UncheckedState.BorderThickness = 0
        Me.chk_appr.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_appr.UseVisualStyleBackColor = False
        '
        'chk_app
        '
        Me.chk_app.AutoSize = True
        Me.chk_app.BackColor = System.Drawing.Color.Transparent
        Me.chk_app.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_app.CheckedState.BorderRadius = 2
        Me.chk_app.CheckedState.BorderThickness = 0
        Me.chk_app.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_app.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.chk_app.ForeColor = System.Drawing.Color.DimGray
        Me.chk_app.Location = New System.Drawing.Point(26, 55)
        Me.chk_app.Name = "chk_app"
        Me.chk_app.Size = New System.Drawing.Size(141, 24)
        Me.chk_app.TabIndex = 0
        Me.chk_app.Text = "Loan Application"
        Me.chk_app.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_app.UncheckedState.BorderRadius = 2
        Me.chk_app.UncheckedState.BorderThickness = 0
        Me.chk_app.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chk_app.UseVisualStyleBackColor = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 3
        Me.Guna2Panel1.Controls.Add(Me.cmb_level)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.txt_initials)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.txt_password)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txt_username)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(40, 197)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 8
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel1.ShadowDecoration.Depth = 10
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(422, 236)
        Me.Guna2Panel1.TabIndex = 123
        '
        'cmb_level
        '
        Me.cmb_level.BackColor = System.Drawing.Color.Transparent
        Me.cmb_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_level.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_level.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_level.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_level.ItemHeight = 30
        Me.cmb_level.Items.AddRange(New Object() {"User", "Admin"})
        Me.cmb_level.Location = New System.Drawing.Point(139, 168)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(98, 36)
        Me.cmb_level.StartIndex = 0
        Me.cmb_level.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(84, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Type :"
        '
        'txt_initials
        '
        Me.txt_initials.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_initials.DefaultText = ""
        Me.txt_initials.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_initials.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_initials.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_initials.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_initials.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_initials.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_initials.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_initials.Location = New System.Drawing.Point(139, 124)
        Me.txt_initials.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_initials.MaxLength = 4
        Me.txt_initials.Name = "txt_initials"
        Me.txt_initials.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_initials.PlaceholderText = "..."
        Me.txt_initials.SelectedText = ""
        Me.txt_initials.Size = New System.Drawing.Size(98, 36)
        Me.txt_initials.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(19, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Teller no./Initials :"
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(139, 78)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "..."
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(221, 36)
        Me.txt_password.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(57, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Password :"
        '
        'txt_username
        '
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(139, 32)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = "..."
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(221, 36)
        Me.txt_username.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Username :"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2Button2.Location = New System.Drawing.Point(406, 72)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(56, 36)
        Me.Guna2Button2.TabIndex = 127
        Me.Guna2Button2.Text = "Add"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 3
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(479, 380)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(333, 53)
        Me.Guna2Button1.TabIndex = 126
        Me.Guna2Button1.Text = "Update Details"
        '
        'user_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.ClientSize = New System.Drawing.Size(1078, 658)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.cmb_fullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_management"
        Me.Text = "user_management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmb_fullname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_account As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents chk_reg As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chk_coll As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chk_release As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chk_appr As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chk_app As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_initials As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_level As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
End Class
