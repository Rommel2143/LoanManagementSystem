<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registeraccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registeraccount))
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.placeofbirth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.group_personal = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.id_done = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.birth_done = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gender_done = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.fullname_done = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbgender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbcivil = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtidno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbidtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dateofbirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtxtmiddleinitial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.group_financial = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.done_financial = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbmonthlyincome = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbincomesource = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.group_address = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.done_email = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.done_phone = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.done_current_address = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtphoneno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcurrentadd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.checkaddress = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.group_emergency = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.done_emergency_credential = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.done_emergency_name = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnregister = New Guna.UI2.WinForms.Guna2Button()
        Me.txtemergencynumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbrelationship = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtemergencycontact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.progress_registration = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.fname_display = New System.Windows.Forms.Label()
        Me.idno_display = New System.Windows.Forms.Label()
        Me.group_personal.SuspendLayout()
        CType(Me.id_done, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.birth_done, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gender_done, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fullname_done, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_financial.SuspendLayout()
        CType(Me.done_financial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_address.SuspendLayout()
        CType(Me.done_email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.done_phone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.done_current_address, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_emergency.SuspendLayout()
        CType(Me.done_emergency_credential, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.done_emergency_name, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtfirstname
        '
        Me.txtfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.Location = New System.Drawing.Point(71, 75)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderText = "Firstname..."
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.Size = New System.Drawing.Size(200, 36)
        Me.txtfirstname.TabIndex = 0
        '
        'placeofbirth
        '
        Me.placeofbirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.placeofbirth.DefaultText = ""
        Me.placeofbirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.placeofbirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.placeofbirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.placeofbirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.placeofbirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.placeofbirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.placeofbirth.ForeColor = System.Drawing.Color.Black
        Me.placeofbirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.placeofbirth.Location = New System.Drawing.Point(255, 176)
        Me.placeofbirth.Name = "placeofbirth"
        Me.placeofbirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.placeofbirth.PlaceholderText = "Enter place of birth.."
        Me.placeofbirth.SelectedText = ""
        Me.placeofbirth.Size = New System.Drawing.Size(312, 36)
        Me.placeofbirth.TabIndex = 4
        '
        'group_personal
        '
        Me.group_personal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.group_personal.BackColor = System.Drawing.Color.Transparent
        Me.group_personal.BorderRadius = 7
        Me.group_personal.Controls.Add(Me.id_done)
        Me.group_personal.Controls.Add(Me.birth_done)
        Me.group_personal.Controls.Add(Me.gender_done)
        Me.group_personal.Controls.Add(Me.fullname_done)
        Me.group_personal.Controls.Add(Me.Label19)
        Me.group_personal.Controls.Add(Me.Guna2Separator1)
        Me.group_personal.Controls.Add(Me.Label6)
        Me.group_personal.Controls.Add(Me.placeofbirth)
        Me.group_personal.Controls.Add(Me.Label10)
        Me.group_personal.Controls.Add(Me.Label9)
        Me.group_personal.Controls.Add(Me.Label8)
        Me.group_personal.Controls.Add(Me.Label7)
        Me.group_personal.Controls.Add(Me.Label4)
        Me.group_personal.Controls.Add(Me.Label3)
        Me.group_personal.Controls.Add(Me.Label2)
        Me.group_personal.Controls.Add(Me.Label1)
        Me.group_personal.Controls.Add(Me.cmbgender)
        Me.group_personal.Controls.Add(Me.cmbcivil)
        Me.group_personal.Controls.Add(Me.txtidno)
        Me.group_personal.Controls.Add(Me.cmbidtype)
        Me.group_personal.Controls.Add(Me.dateofbirth)
        Me.group_personal.Controls.Add(Me.txtxtmiddleinitial)
        Me.group_personal.Controls.Add(Me.txtlastname)
        Me.group_personal.Controls.Add(Me.txtfirstname)
        Me.group_personal.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.group_personal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.group_personal.ForeColor = System.Drawing.Color.White
        Me.group_personal.Location = New System.Drawing.Point(84, 34)
        Me.group_personal.Name = "group_personal"
        Me.group_personal.ShadowDecoration.BorderRadius = 8
        Me.group_personal.ShadowDecoration.Depth = 10
        Me.group_personal.ShadowDecoration.Enabled = True
        Me.group_personal.Size = New System.Drawing.Size(650, 427)
        Me.group_personal.TabIndex = 4
        Me.group_personal.Text = "1. Personal Details"
        '
        'id_done
        '
        Me.id_done.Image = CType(resources.GetObject("id_done.Image"), System.Drawing.Image)
        Me.id_done.ImageRotate = 0!
        Me.id_done.Location = New System.Drawing.Point(488, 351)
        Me.id_done.Name = "id_done"
        Me.id_done.Size = New System.Drawing.Size(20, 20)
        Me.id_done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.id_done.TabIndex = 26
        Me.id_done.TabStop = False
        Me.id_done.UseTransparentBackground = True
        Me.id_done.Visible = False
        '
        'birth_done
        '
        Me.birth_done.Image = CType(resources.GetObject("birth_done.Image"), System.Drawing.Image)
        Me.birth_done.ImageRotate = 0!
        Me.birth_done.Location = New System.Drawing.Point(573, 185)
        Me.birth_done.Name = "birth_done"
        Me.birth_done.Size = New System.Drawing.Size(20, 20)
        Me.birth_done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.birth_done.TabIndex = 25
        Me.birth_done.TabStop = False
        Me.birth_done.UseTransparentBackground = True
        Me.birth_done.Visible = False
        '
        'gender_done
        '
        Me.gender_done.Image = CType(resources.GetObject("gender_done.Image"), System.Drawing.Image)
        Me.gender_done.ImageRotate = 0!
        Me.gender_done.Location = New System.Drawing.Point(383, 266)
        Me.gender_done.Name = "gender_done"
        Me.gender_done.Size = New System.Drawing.Size(20, 20)
        Me.gender_done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gender_done.TabIndex = 24
        Me.gender_done.TabStop = False
        Me.gender_done.UseTransparentBackground = True
        Me.gender_done.Visible = False
        '
        'fullname_done
        '
        Me.fullname_done.Image = CType(resources.GetObject("fullname_done.Image"), System.Drawing.Image)
        Me.fullname_done.ImageRotate = 0!
        Me.fullname_done.Location = New System.Drawing.Point(589, 82)
        Me.fullname_done.Name = "fullname_done"
        Me.fullname_done.Size = New System.Drawing.Size(20, 20)
        Me.fullname_done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fullname_done.TabIndex = 23
        Me.fullname_done.TabStop = False
        Me.fullname_done.UseTransparentBackground = True
        Me.fullname_done.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(264, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 15)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "__"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.White
        Me.Guna2Separator1.Location = New System.Drawing.Point(35, 121)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(574, 8)
        Me.Guna2Separator1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(255, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Place of Birth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(274, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Middle Initial"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(380, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Last name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(68, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "First name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(35, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(283, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ID No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(35, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Valid ID Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(214, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(35, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Civil Status"
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.Color.Transparent
        Me.cmbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbgender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbgender.ItemHeight = 30
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cmbgender.Location = New System.Drawing.Point(217, 259)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(160, 36)
        Me.cmbgender.TabIndex = 6
        '
        'cmbcivil
        '
        Me.cmbcivil.BackColor = System.Drawing.Color.Transparent
        Me.cmbcivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcivil.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcivil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcivil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbcivil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcivil.ItemHeight = 30
        Me.cmbcivil.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widow/Widower", "Other"})
        Me.cmbcivil.Location = New System.Drawing.Point(35, 259)
        Me.cmbcivil.Name = "cmbcivil"
        Me.cmbcivil.Size = New System.Drawing.Size(160, 36)
        Me.cmbcivil.TabIndex = 5
        '
        'txtidno
        '
        Me.txtidno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidno.DefaultText = ""
        Me.txtidno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtidno.ForeColor = System.Drawing.Color.Black
        Me.txtidno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidno.Location = New System.Drawing.Point(283, 344)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidno.PlaceholderText = "Enter ID Number..."
        Me.txtidno.SelectedText = ""
        Me.txtidno.Size = New System.Drawing.Size(199, 36)
        Me.txtidno.TabIndex = 8
        '
        'cmbidtype
        '
        Me.cmbidtype.BackColor = System.Drawing.Color.Transparent
        Me.cmbidtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbidtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbidtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbidtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbidtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbidtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbidtype.ItemHeight = 30
        Me.cmbidtype.Items.AddRange(New Object() {"UMID", "Driver's License", "SSS", "Phil Health", "TIN ID", "Other"})
        Me.cmbidtype.Location = New System.Drawing.Point(35, 344)
        Me.cmbidtype.Name = "cmbidtype"
        Me.cmbidtype.Size = New System.Drawing.Size(226, 36)
        Me.cmbidtype.TabIndex = 7
        '
        'dateofbirth
        '
        Me.dateofbirth.Checked = True
        Me.dateofbirth.CustomFormat = "MMMM dd yyyy"
        Me.dateofbirth.FillColor = System.Drawing.SystemColors.Highlight
        Me.dateofbirth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateofbirth.ForeColor = System.Drawing.Color.White
        Me.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateofbirth.Location = New System.Drawing.Point(35, 176)
        Me.dateofbirth.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateofbirth.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.Size = New System.Drawing.Size(200, 36)
        Me.dateofbirth.TabIndex = 3
        Me.dateofbirth.Value = New Date(2024, 2, 28, 14, 10, 37, 601)
        '
        'txtxtmiddleinitial
        '
        Me.txtxtmiddleinitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtxtmiddleinitial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtxtmiddleinitial.DefaultText = ""
        Me.txtxtmiddleinitial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtxtmiddleinitial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtxtmiddleinitial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxtmiddleinitial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxtmiddleinitial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtxtmiddleinitial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtxtmiddleinitial.ForeColor = System.Drawing.Color.Black
        Me.txtxtmiddleinitial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtxtmiddleinitial.Location = New System.Drawing.Point(277, 75)
        Me.txtxtmiddleinitial.MaxLength = 1
        Me.txtxtmiddleinitial.Name = "txtxtmiddleinitial"
        Me.txtxtmiddleinitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtxtmiddleinitial.PlaceholderText = "Middle Initial..."
        Me.txtxtmiddleinitial.SelectedText = ""
        Me.txtxtmiddleinitial.Size = New System.Drawing.Size(100, 36)
        Me.txtxtmiddleinitial.TabIndex = 1
        '
        'txtlastname
        '
        Me.txtlastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.DefaultText = ""
        Me.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.Location = New System.Drawing.Point(383, 75)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderText = "Lastname..."
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.Size = New System.Drawing.Size(200, 36)
        Me.txtlastname.TabIndex = 2
        '
        'group_financial
        '
        Me.group_financial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.group_financial.BackColor = System.Drawing.Color.Transparent
        Me.group_financial.BorderRadius = 7
        Me.group_financial.Controls.Add(Me.done_financial)
        Me.group_financial.Controls.Add(Me.Label20)
        Me.group_financial.Controls.Add(Me.Label11)
        Me.group_financial.Controls.Add(Me.cmbmonthlyincome)
        Me.group_financial.Controls.Add(Me.Label5)
        Me.group_financial.Controls.Add(Me.cmbincomesource)
        Me.group_financial.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.group_financial.Enabled = False
        Me.group_financial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.group_financial.ForeColor = System.Drawing.Color.White
        Me.group_financial.Location = New System.Drawing.Point(84, 869)
        Me.group_financial.Name = "group_financial"
        Me.group_financial.ShadowDecoration.BorderRadius = 9
        Me.group_financial.ShadowDecoration.Depth = 10
        Me.group_financial.ShadowDecoration.Enabled = True
        Me.group_financial.Size = New System.Drawing.Size(650, 151)
        Me.group_financial.TabIndex = 5
        Me.group_financial.Text = "3. Financial Information"
        '
        'done_financial
        '
        Me.done_financial.Image = CType(resources.GetObject("done_financial.Image"), System.Drawing.Image)
        Me.done_financial.ImageRotate = 0!
        Me.done_financial.Location = New System.Drawing.Point(515, 91)
        Me.done_financial.Name = "done_financial"
        Me.done_financial.Size = New System.Drawing.Size(20, 20)
        Me.done_financial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_financial.TabIndex = 29
        Me.done_financial.TabStop = False
        Me.done_financial.UseTransparentBackground = True
        Me.done_financial.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(259, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 15)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "__"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(279, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Monthly Income"
        '
        'cmbmonthlyincome
        '
        Me.cmbmonthlyincome.BackColor = System.Drawing.Color.Transparent
        Me.cmbmonthlyincome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbmonthlyincome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmonthlyincome.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmonthlyincome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbmonthlyincome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbmonthlyincome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbmonthlyincome.ItemHeight = 30
        Me.cmbmonthlyincome.Items.AddRange(New Object() {"Below ₱10,000", "₱10,000 - ₱25,000", "₱25,000 - ₱50,000", "₱50,000 - ₱100,000", "₱100,000 above"})
        Me.cmbmonthlyincome.Location = New System.Drawing.Point(282, 83)
        Me.cmbmonthlyincome.Name = "cmbmonthlyincome"
        Me.cmbmonthlyincome.Size = New System.Drawing.Size(227, 36)
        Me.cmbmonthlyincome.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(29, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Source of Income"
        '
        'cmbincomesource
        '
        Me.cmbincomesource.BackColor = System.Drawing.Color.Transparent
        Me.cmbincomesource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbincomesource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbincomesource.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbincomesource.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbincomesource.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbincomesource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbincomesource.ItemHeight = 30
        Me.cmbincomesource.Items.AddRange(New Object() {"Employment", "Self-Employment", "Investment", "Retirement", "Rental Income", "Others"})
        Me.cmbincomesource.Location = New System.Drawing.Point(32, 83)
        Me.cmbincomesource.Name = "cmbincomesource"
        Me.cmbincomesource.Size = New System.Drawing.Size(221, 36)
        Me.cmbincomesource.TabIndex = 0
        '
        'group_address
        '
        Me.group_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.group_address.BackColor = System.Drawing.Color.Transparent
        Me.group_address.BorderRadius = 7
        Me.group_address.Controls.Add(Me.done_email)
        Me.group_address.Controls.Add(Me.done_phone)
        Me.group_address.Controls.Add(Me.done_current_address)
        Me.group_address.Controls.Add(Me.txtemail)
        Me.group_address.Controls.Add(Me.Label14)
        Me.group_address.Controls.Add(Me.txtphoneno)
        Me.group_address.Controls.Add(Me.Label12)
        Me.group_address.Controls.Add(Me.txtcurrentadd)
        Me.group_address.Controls.Add(Me.checkaddress)
        Me.group_address.Controls.Add(Me.Label13)
        Me.group_address.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.group_address.Enabled = False
        Me.group_address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.group_address.ForeColor = System.Drawing.Color.White
        Me.group_address.Location = New System.Drawing.Point(84, 489)
        Me.group_address.Name = "group_address"
        Me.group_address.ShadowDecoration.BorderRadius = 8
        Me.group_address.ShadowDecoration.Depth = 10
        Me.group_address.ShadowDecoration.Enabled = True
        Me.group_address.Size = New System.Drawing.Size(650, 352)
        Me.group_address.TabIndex = 6
        Me.group_address.Text = "2. Address and Contact Details"
        '
        'done_email
        '
        Me.done_email.Image = CType(resources.GetObject("done_email.Image"), System.Drawing.Image)
        Me.done_email.ImageRotate = 0!
        Me.done_email.Location = New System.Drawing.Point(354, 280)
        Me.done_email.Name = "done_email"
        Me.done_email.Size = New System.Drawing.Size(20, 20)
        Me.done_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_email.TabIndex = 29
        Me.done_email.TabStop = False
        Me.done_email.UseTransparentBackground = True
        Me.done_email.Visible = False
        '
        'done_phone
        '
        Me.done_phone.Image = CType(resources.GetObject("done_phone.Image"), System.Drawing.Image)
        Me.done_phone.ImageRotate = 0!
        Me.done_phone.Location = New System.Drawing.Point(264, 206)
        Me.done_phone.Name = "done_phone"
        Me.done_phone.Size = New System.Drawing.Size(20, 20)
        Me.done_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_phone.TabIndex = 28
        Me.done_phone.TabStop = False
        Me.done_phone.UseTransparentBackground = True
        Me.done_phone.Visible = False
        '
        'done_current_address
        '
        Me.done_current_address.Image = CType(resources.GetObject("done_current_address.Image"), System.Drawing.Image)
        Me.done_current_address.ImageRotate = 0!
        Me.done_current_address.Location = New System.Drawing.Point(431, 105)
        Me.done_current_address.Name = "done_current_address"
        Me.done_current_address.Size = New System.Drawing.Size(20, 20)
        Me.done_current_address.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_current_address.TabIndex = 27
        Me.done_current_address.TabStop = False
        Me.done_current_address.UseTransparentBackground = True
        Me.done_current_address.Visible = False
        '
        'txtemail
        '
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(35, 270)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = "Enter email address (Optional)..."
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(314, 36)
        Me.txtemail.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(35, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Email"
        '
        'txtphoneno
        '
        Me.txtphoneno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtphoneno.DefaultText = ""
        Me.txtphoneno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtphoneno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtphoneno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphoneno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphoneno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphoneno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtphoneno.ForeColor = System.Drawing.Color.Black
        Me.txtphoneno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphoneno.Location = New System.Drawing.Point(35, 197)
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphoneno.PlaceholderText = "Enter Phone Number..."
        Me.txtphoneno.SelectedText = ""
        Me.txtphoneno.Size = New System.Drawing.Size(223, 36)
        Me.txtphoneno.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(35, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Phone No."
        '
        'txtcurrentadd
        '
        Me.txtcurrentadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrentadd.DefaultText = ""
        Me.txtcurrentadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcurrentadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcurrentadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrentadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrentadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcurrentadd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcurrentadd.ForeColor = System.Drawing.Color.Black
        Me.txtcurrentadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcurrentadd.Location = New System.Drawing.Point(35, 95)
        Me.txtcurrentadd.Name = "txtcurrentadd"
        Me.txtcurrentadd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcurrentadd.PlaceholderText = "Enter current address.."
        Me.txtcurrentadd.SelectedText = ""
        Me.txtcurrentadd.Size = New System.Drawing.Size(390, 36)
        Me.txtcurrentadd.TabIndex = 0
        '
        'checkaddress
        '
        Me.checkaddress.AutoSize = True
        Me.checkaddress.BackColor = System.Drawing.Color.White
        Me.checkaddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkaddress.CheckedState.BorderRadius = 2
        Me.checkaddress.CheckedState.BorderThickness = 0
        Me.checkaddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.checkaddress.Location = New System.Drawing.Point(41, 131)
        Me.checkaddress.Name = "checkaddress"
        Me.checkaddress.Size = New System.Drawing.Size(142, 19)
        Me.checkaddress.TabIndex = 1
        Me.checkaddress.Text = "Same as Place of Birth"
        Me.checkaddress.UncheckedState.BorderColor = System.Drawing.Color.DarkGray
        Me.checkaddress.UncheckedState.BorderRadius = 2
        Me.checkaddress.UncheckedState.BorderThickness = 3
        Me.checkaddress.UncheckedState.FillColor = System.Drawing.Color.White
        Me.checkaddress.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(35, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Current Address"
        '
        'group_emergency
        '
        Me.group_emergency.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.group_emergency.BackColor = System.Drawing.Color.Transparent
        Me.group_emergency.BorderRadius = 7
        Me.group_emergency.Controls.Add(Me.done_emergency_credential)
        Me.group_emergency.Controls.Add(Me.done_emergency_name)
        Me.group_emergency.Controls.Add(Me.txtemergencynumber)
        Me.group_emergency.Controls.Add(Me.Label16)
        Me.group_emergency.Controls.Add(Me.Label15)
        Me.group_emergency.Controls.Add(Me.cmbrelationship)
        Me.group_emergency.Controls.Add(Me.txtemergencycontact)
        Me.group_emergency.Controls.Add(Me.Label17)
        Me.group_emergency.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.group_emergency.Enabled = False
        Me.group_emergency.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.group_emergency.ForeColor = System.Drawing.Color.White
        Me.group_emergency.Location = New System.Drawing.Point(84, 1048)
        Me.group_emergency.Name = "group_emergency"
        Me.group_emergency.ShadowDecoration.BorderRadius = 9
        Me.group_emergency.ShadowDecoration.Depth = 10
        Me.group_emergency.ShadowDecoration.Enabled = True
        Me.group_emergency.Size = New System.Drawing.Size(650, 260)
        Me.group_emergency.TabIndex = 7
        Me.group_emergency.Text = "5. Emergency Contact Information"
        '
        'done_emergency_credential
        '
        Me.done_emergency_credential.Image = CType(resources.GetObject("done_emergency_credential.Image"), System.Drawing.Image)
        Me.done_emergency_credential.ImageRotate = 0!
        Me.done_emergency_credential.Location = New System.Drawing.Point(553, 171)
        Me.done_emergency_credential.Name = "done_emergency_credential"
        Me.done_emergency_credential.Size = New System.Drawing.Size(20, 20)
        Me.done_emergency_credential.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_emergency_credential.TabIndex = 30
        Me.done_emergency_credential.TabStop = False
        Me.done_emergency_credential.UseTransparentBackground = True
        Me.done_emergency_credential.Visible = False
        '
        'done_emergency_name
        '
        Me.done_emergency_name.Image = CType(resources.GetObject("done_emergency_name.Image"), System.Drawing.Image)
        Me.done_emergency_name.ImageRotate = 0!
        Me.done_emergency_name.Location = New System.Drawing.Point(514, 93)
        Me.done_emergency_name.Name = "done_emergency_name"
        Me.done_emergency_name.Size = New System.Drawing.Size(20, 20)
        Me.done_emergency_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.done_emergency_name.TabIndex = 29
        Me.done_emergency_name.TabStop = False
        Me.done_emergency_name.UseTransparentBackground = True
        Me.done_emergency_name.Visible = False
        '
        'btnregister
        '
        Me.btnregister.Animated = True
        Me.btnregister.AutoRoundedCorners = True
        Me.btnregister.BorderRadius = 25
        Me.btnregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnregister.Enabled = False
        Me.btnregister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnregister.ForeColor = System.Drawing.Color.White
        Me.btnregister.Location = New System.Drawing.Point(235, 182)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(180, 52)
        Me.btnregister.TabIndex = 3
        Me.btnregister.Text = "Register Account"
        '
        'txtemergencynumber
        '
        Me.txtemergencynumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemergencynumber.DefaultText = ""
        Me.txtemergencynumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemergencynumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemergencynumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemergencynumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemergencynumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemergencynumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemergencynumber.ForeColor = System.Drawing.Color.Black
        Me.txtemergencynumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemergencynumber.Location = New System.Drawing.Point(342, 163)
        Me.txtemergencynumber.Name = "txtemergencynumber"
        Me.txtemergencynumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemergencynumber.PlaceholderText = "Enter Contact No..."
        Me.txtemergencynumber.SelectedText = ""
        Me.txtemergencynumber.Size = New System.Drawing.Size(207, 36)
        Me.txtemergencynumber.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(339, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 15)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Phone Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(78, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 15)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Relationship"
        '
        'cmbrelationship
        '
        Me.cmbrelationship.BackColor = System.Drawing.Color.Transparent
        Me.cmbrelationship.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbrelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrelationship.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbrelationship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbrelationship.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbrelationship.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbrelationship.ItemHeight = 30
        Me.cmbrelationship.Items.AddRange(New Object() {"Parent", "Sibling", "Relative", "Friend", "Other"})
        Me.cmbrelationship.Location = New System.Drawing.Point(81, 163)
        Me.cmbrelationship.Name = "cmbrelationship"
        Me.cmbrelationship.Size = New System.Drawing.Size(197, 36)
        Me.cmbrelationship.TabIndex = 1
        '
        'txtemergencycontact
        '
        Me.txtemergencycontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemergencycontact.DefaultText = ""
        Me.txtemergencycontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemergencycontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemergencycontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemergencycontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemergencycontact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemergencycontact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemergencycontact.ForeColor = System.Drawing.Color.Black
        Me.txtemergencycontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemergencycontact.Location = New System.Drawing.Point(119, 86)
        Me.txtemergencycontact.Name = "txtemergencycontact"
        Me.txtemergencycontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemergencycontact.PlaceholderText = "Enter Name..."
        Me.txtemergencycontact.SelectedText = ""
        Me.txtemergencycontact.Size = New System.Drawing.Size(390, 36)
        Me.txtemergencycontact.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(116, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(179, 15)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "In case of Emergency Please call:"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 100
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoScroll = True
        Me.Guna2Panel2.AutoScrollMargin = New System.Drawing.Size(0, 110)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel2.Controls.Add(Me.group_personal)
        Me.Guna2Panel2.Controls.Add(Me.group_address)
        Me.Guna2Panel2.Controls.Add(Me.group_financial)
        Me.Guna2Panel2.Controls.Add(Me.group_emergency)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Depth = 10
        Me.Guna2Panel2.Size = New System.Drawing.Size(835, 670)
        Me.Guna2Panel2.TabIndex = 10
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.Controls.Add(Me.Label18)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel3.Controls.Add(Me.progress_registration)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(835, 71)
        Me.Guna2Panel3.TabIndex = 11
        '
        'progress_registration
        '
        Me.progress_registration.AutoRoundedCorners = True
        Me.progress_registration.BackColor = System.Drawing.Color.White
        Me.progress_registration.BorderRadius = 4
        Me.progress_registration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progress_registration.FillColor = System.Drawing.Color.White
        Me.progress_registration.Location = New System.Drawing.Point(0, 61)
        Me.progress_registration.Maximum = 10
        Me.progress_registration.Name = "progress_registration"
        Me.progress_registration.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition
        Me.progress_registration.ProgressColor = System.Drawing.Color.White
        Me.progress_registration.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.progress_registration.Size = New System.Drawing.Size(835, 10)
        Me.progress_registration.TabIndex = 27
        Me.progress_registration.Text = "Guna2ProgressBar1"
        Me.progress_registration.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(12, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(196, 45)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Registration"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator2.Location = New System.Drawing.Point(0, 51)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(835, 10)
        Me.Guna2Separator2.TabIndex = 30
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.Controls.Add(Me.idno_display)
        Me.Guna2GroupBox1.Controls.Add(Me.fname_display)
        Me.Guna2GroupBox1.Controls.Add(Me.btnregister)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(84, 1342)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 9
        Me.Guna2GroupBox1.ShadowDecoration.Depth = 10
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(650, 295)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "6. Register"
        '
        'fname_display
        '
        Me.fname_display.AutoSize = True
        Me.fname_display.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname_display.ForeColor = System.Drawing.Color.DimGray
        Me.fname_display.Location = New System.Drawing.Point(225, 62)
        Me.fname_display.Name = "fname_display"
        Me.fname_display.Size = New System.Drawing.Size(201, 32)
        Me.fname_display.TabIndex = 33
        Me.fname_display.Text = "Sample Fullname"
        '
        'idno_display
        '
        Me.idno_display.AutoSize = True
        Me.idno_display.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idno_display.ForeColor = System.Drawing.Color.DimGray
        Me.idno_display.Location = New System.Drawing.Point(272, 103)
        Me.idno_display.Name = "idno_display"
        Me.idno_display.Size = New System.Drawing.Size(107, 21)
        Me.idno_display.TabIndex = 34
        Me.idno_display.Text = "Sample ID no"
        '
        'registeraccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 741)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registeraccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registeraccount"
        Me.group_personal.ResumeLayout(False)
        Me.group_personal.PerformLayout()
        CType(Me.id_done, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.birth_done, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gender_done, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fullname_done, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_financial.ResumeLayout(False)
        Me.group_financial.PerformLayout()
        CType(Me.done_financial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_address.ResumeLayout(False)
        Me.group_address.PerformLayout()
        CType(Me.done_email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.done_phone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.done_current_address, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_emergency.ResumeLayout(False)
        Me.group_emergency.PerformLayout()
        CType(Me.done_emergency_credential, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.done_emergency_name, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents placeofbirth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents group_personal As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dateofbirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtidno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbidtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbgender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbcivil As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents group_financial As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtxtmiddleinitial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbmonthlyincome As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbincomesource As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents group_address As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtphoneno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcurrentadd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents checkaddress As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents group_emergency As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtemergencynumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbrelationship As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtemergencycontact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label20 As Label
    Friend WithEvents id_done As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents birth_done As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gender_done As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents fullname_done As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents progress_registration As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents done_financial As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents done_email As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents done_phone As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents done_current_address As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents done_emergency_credential As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents done_emergency_name As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents fname_display As Label
    Friend WithEvents idno_display As Label
End Class
