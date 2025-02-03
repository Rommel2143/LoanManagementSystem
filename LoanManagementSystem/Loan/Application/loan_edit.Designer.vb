<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loan_edit))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_year = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btn_month = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.num_plan = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.txt_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_cm2 = New System.Windows.Forms.Label()
        Me.lbl_cm1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.lbl_percentinterest = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_interest = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_servicefee = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_ma = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblreference = New System.Windows.Forms.Label()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.num_plan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(85, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Loan amount (Pesos)"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Controls.Add(Me.btn_year)
        Me.Guna2Panel4.Controls.Add(Me.btn_month)
        Me.Guna2Panel4.Controls.Add(Me.num_plan)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(89, 154)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(290, 123)
        Me.Guna2Panel4.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Loan Terms"
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
        Me.btn_year.Location = New System.Drawing.Point(134, 67)
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
        Me.btn_month.Location = New System.Drawing.Point(134, 33)
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
        Me.num_plan.Size = New System.Drawing.Size(104, 55)
        Me.num_plan.TabIndex = 36
        Me.num_plan.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.txt_amount.Location = New System.Drawing.Point(89, 85)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount.PlaceholderText = ""
        Me.txt_amount.SelectedText = ""
        Me.txt_amount.Size = New System.Drawing.Size(266, 36)
        Me.txt_amount.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(85, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Co-makers"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
        Me.Guna2Button4.Location = New System.Drawing.Point(89, 425)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(22, 23)
        Me.Guna2Button4.TabIndex = 63
        '
        'lbl_cm2
        '
        Me.lbl_cm2.AutoSize = True
        Me.lbl_cm2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cm2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cm2.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cm2.Location = New System.Drawing.Point(129, 428)
        Me.lbl_cm2.Name = "lbl_cm2"
        Me.lbl_cm2.Size = New System.Drawing.Size(143, 20)
        Me.lbl_cm2.TabIndex = 62
        Me.lbl_cm2.Text = "Please select name..."
        '
        'lbl_cm1
        '
        Me.lbl_cm1.AutoSize = True
        Me.lbl_cm1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cm1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cm1.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cm1.Location = New System.Drawing.Point(129, 362)
        Me.lbl_cm1.Name = "lbl_cm1"
        Me.lbl_cm1.Size = New System.Drawing.Size(143, 20)
        Me.lbl_cm1.TabIndex = 61
        Me.lbl_cm1.Text = "Please select name..."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DimGray
        Me.Label28.Location = New System.Drawing.Point(109, 428)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(20, 20)
        Me.Label28.TabIndex = 60
        Me.Label28.Text = "2."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(109, 362)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(20, 20)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "1."
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.Location = New System.Drawing.Point(89, 362)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(22, 20)
        Me.Guna2Button3.TabIndex = 58
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(434, 37)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(17, 171)
        Me.Guna2VSeparator1.TabIndex = 73
        '
        'lbl_percentinterest
        '
        Me.lbl_percentinterest.AutoSize = True
        Me.lbl_percentinterest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_percentinterest.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_percentinterest.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_percentinterest.Location = New System.Drawing.Point(640, 43)
        Me.lbl_percentinterest.Name = "lbl_percentinterest"
        Me.lbl_percentinterest.Size = New System.Drawing.Size(50, 25)
        Me.lbl_percentinterest.TabIndex = 72
        Me.lbl_percentinterest.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(457, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 20)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Rate"
        '
        'lbl_interest
        '
        Me.lbl_interest.AutoSize = True
        Me.lbl_interest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_interest.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interest.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_interest.Location = New System.Drawing.Point(640, 159)
        Me.lbl_interest.Name = "lbl_interest"
        Me.lbl_interest.Size = New System.Drawing.Size(50, 25)
        Me.lbl_interest.TabIndex = 70
        Me.lbl_interest.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(457, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 20)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Interest"
        '
        'lbl_servicefee
        '
        Me.lbl_servicefee.AutoSize = True
        Me.lbl_servicefee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_servicefee.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_servicefee.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_servicefee.Location = New System.Drawing.Point(640, 78)
        Me.lbl_servicefee.Name = "lbl_servicefee"
        Me.lbl_servicefee.Size = New System.Drawing.Size(50, 25)
        Me.lbl_servicefee.TabIndex = 68
        Me.lbl_servicefee.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(457, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Processing fee"
        '
        'txt_ma
        '
        Me.txt_ma.AutoSize = True
        Me.txt_ma.BackColor = System.Drawing.Color.Transparent
        Me.txt_ma.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ma.ForeColor = System.Drawing.Color.DimGray
        Me.txt_ma.Location = New System.Drawing.Point(639, 118)
        Me.txt_ma.Name = "txt_ma"
        Me.txt_ma.Size = New System.Drawing.Size(120, 25)
        Me.txt_ma.TabIndex = 66
        Me.txt_ma.Text = "0.00/ month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(457, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Monthly payment"
        '
        'lblreference
        '
        Me.lblreference.AutoSize = True
        Me.lblreference.BackColor = System.Drawing.Color.Transparent
        Me.lblreference.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreference.ForeColor = System.Drawing.Color.DimGray
        Me.lblreference.Location = New System.Drawing.Point(47, 20)
        Me.lblreference.Name = "lblreference"
        Me.lblreference.Size = New System.Drawing.Size(50, 25)
        Me.lblreference.TabIndex = 74
        Me.lblreference.Text = "0.00"
        '
        'loan_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 562)
        Me.Controls.Add(Me.lblreference)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.lbl_percentinterest)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lbl_interest)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_servicefee)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_ma)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.lbl_cm2)
        Me.Controls.Add(Me.lbl_cm1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.txt_amount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loan_edit"
        Me.Text = "loan_edit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.num_plan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_year As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_month As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents num_plan As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents txt_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_cm2 As Label
    Friend WithEvents lbl_cm1 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents lbl_percentinterest As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_interest As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_servicefee As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_ma As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblreference As Label
End Class
