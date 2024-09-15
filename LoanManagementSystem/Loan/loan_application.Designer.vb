<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan_application
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loan_application))
        Me.lbl_reference = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_account = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_apply = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_ma = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_purpose = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_mode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_year = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btn_month = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.num_plan = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2Panel1.SuspendLayout()
        Me.panel_apply.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.num_plan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_reference
        '
        Me.lbl_reference.AutoSize = True
        Me.lbl_reference.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reference.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reference.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_reference.Location = New System.Drawing.Point(126, 126)
        Me.lbl_reference.Name = "lbl_reference"
        Me.lbl_reference.Size = New System.Drawing.Size(27, 20)
        Me.lbl_reference.TabIndex = 38
        Me.lbl_reference.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(20, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Reference No :"
        '
        'lbl_account
        '
        Me.lbl_account.AutoSize = True
        Me.lbl_account.BackColor = System.Drawing.Color.Transparent
        Me.lbl_account.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_account.Location = New System.Drawing.Point(117, 106)
        Me.lbl_account.Name = "lbl_account"
        Me.lbl_account.Size = New System.Drawing.Size(27, 20)
        Me.lbl_account.TabIndex = 36
        Me.lbl_account.Text = "---"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(494, 481)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(134, 56)
        Me.Guna2Button2.TabIndex = 34
        Me.Guna2Button2.Text = "Apply Loan"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_fullname.Location = New System.Drawing.Point(98, 84)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(28, 21)
        Me.lbl_fullname.TabIndex = 21
        Me.lbl_fullname.Text = "---"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(20, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Borrower :"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(24, 21)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(105, 41)
        Me.Guna2Button1.TabIndex = 17
        Me.Guna2Button1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(20, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Account no :"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lbl_reference)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_account)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_fullname)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1073, 171)
        Me.Guna2Panel1.TabIndex = 39
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1073, 38)
        Me.Guna2Panel2.TabIndex = 40
        '
        'panel_apply
        '
        Me.panel_apply.AutoScroll = True
        Me.panel_apply.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.panel_apply.Controls.Add(Me.txt_ma)
        Me.panel_apply.Controls.Add(Me.Label9)
        Me.panel_apply.Controls.Add(Me.Label8)
        Me.panel_apply.Controls.Add(Me.Guna2ComboBox1)
        Me.panel_apply.Controls.Add(Me.Label7)
        Me.panel_apply.Controls.Add(Me.cmb_purpose)
        Me.panel_apply.Controls.Add(Me.Label6)
        Me.panel_apply.Controls.Add(Me.txt_amount)
        Me.panel_apply.Controls.Add(Me.Label5)
        Me.panel_apply.Controls.Add(Me.cmb_mode)
        Me.panel_apply.Controls.Add(Me.Guna2Panel4)
        Me.panel_apply.Controls.Add(Me.Guna2Button2)
        Me.panel_apply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_apply.Enabled = False
        Me.panel_apply.Location = New System.Drawing.Point(0, 209)
        Me.panel_apply.Name = "panel_apply"
        Me.panel_apply.Size = New System.Drawing.Size(1073, 535)
        Me.panel_apply.TabIndex = 41
        '
        'txt_ma
        '
        Me.txt_ma.AutoSize = True
        Me.txt_ma.BackColor = System.Drawing.Color.Transparent
        Me.txt_ma.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ma.ForeColor = System.Drawing.Color.DimGray
        Me.txt_ma.Location = New System.Drawing.Point(98, 309)
        Me.txt_ma.Name = "txt_ma"
        Me.txt_ma.Size = New System.Drawing.Size(116, 25)
        Me.txt_ma.TabIndex = 48
        Me.txt_ma.Text = "0.00/Month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(99, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Monthly payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(415, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Collateral"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Share Capital", "Savings", "House", "Car", "Others"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(415, 145)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(288, 36)
        Me.Guna2ComboBox1.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(402, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Purpose"
        '
        'cmb_purpose
        '
        Me.cmb_purpose.BackColor = System.Drawing.Color.Transparent
        Me.cmb_purpose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_purpose.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_purpose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_purpose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_purpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_purpose.ItemHeight = 30
        Me.cmb_purpose.Location = New System.Drawing.Point(402, 35)
        Me.cmb_purpose.Name = "cmb_purpose"
        Me.cmb_purpose.Size = New System.Drawing.Size(288, 36)
        Me.cmb_purpose.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(75, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Desired amount (Pesos)"
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.DefaultText = "0"
        Me.txt_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amount.Location = New System.Drawing.Point(79, 35)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount.PlaceholderText = ""
        Me.txt_amount.SelectedText = ""
        Me.txt_amount.Size = New System.Drawing.Size(266, 36)
        Me.txt_amount.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(783, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Transfer Thru"
        '
        'cmb_mode
        '
        Me.cmb_mode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_mode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_mode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_mode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_mode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_mode.ItemHeight = 30
        Me.cmb_mode.Items.AddRange(New Object() {"Cash", "Check", "Bank Transfer"})
        Me.cmb_mode.Location = New System.Drawing.Point(783, 35)
        Me.cmb_mode.Name = "cmb_mode"
        Me.cmb_mode.Size = New System.Drawing.Size(140, 36)
        Me.cmb_mode.TabIndex = 40
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Controls.Add(Me.btn_year)
        Me.Guna2Panel4.Controls.Add(Me.btn_month)
        Me.Guna2Panel4.Controls.Add(Me.num_plan)
        Me.Guna2Panel4.Location = New System.Drawing.Point(78, 127)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(290, 84)
        Me.Guna2Panel4.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Installment Plan"
        '
        'btn_year
        '
        Me.btn_year.AutoSize = True
        Me.btn_year.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_year.CheckedState.BorderThickness = 0
        Me.btn_year.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_year.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_year.CheckedState.InnerOffset = -4
        Me.btn_year.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_year.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_year.Location = New System.Drawing.Point(106, 56)
        Me.btn_year.Name = "btn_year"
        Me.btn_year.Size = New System.Drawing.Size(51, 21)
        Me.btn_year.TabIndex = 38
        Me.btn_year.Text = "Year"
        Me.btn_year.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_year.UncheckedState.BorderThickness = 2
        Me.btn_year.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_year.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btn_month
        '
        Me.btn_month.AutoSize = True
        Me.btn_month.Checked = True
        Me.btn_month.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_month.CheckedState.BorderThickness = 0
        Me.btn_month.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_month.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_month.CheckedState.InnerOffset = -4
        Me.btn_month.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btn_month.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_month.Location = New System.Drawing.Point(106, 33)
        Me.btn_month.Name = "btn_month"
        Me.btn_month.Size = New System.Drawing.Size(70, 21)
        Me.btn_month.TabIndex = 37
        Me.btn_month.TabStop = True
        Me.btn_month.Text = "Months"
        Me.btn_month.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_month.UncheckedState.BorderThickness = 2
        Me.btn_month.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_month.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'num_plan
        '
        Me.num_plan.BackColor = System.Drawing.Color.Transparent
        Me.num_plan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.num_plan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_plan.Location = New System.Drawing.Point(14, 33)
        Me.num_plan.Maximum = New Decimal(New Integer() {480, 0, 0, 0})
        Me.num_plan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_plan.Name = "num_plan"
        Me.num_plan.Size = New System.Drawing.Size(86, 46)
        Me.num_plan.TabIndex = 36
        Me.num_plan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'loan_application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 744)
        Me.Controls.Add(Me.panel_apply)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loan_application"
        Me.Text = "loan_application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.panel_apply.ResumeLayout(False)
        Me.panel_apply.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.num_plan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_account As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_reference As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel_apply As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_purpose As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_mode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_year As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_month As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents num_plan As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_ma As Label
    Friend WithEvents Label9 As Label
End Class
