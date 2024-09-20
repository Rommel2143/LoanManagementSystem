<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan_release_set
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loan_release_set))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btn_see = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lbl_reference = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_transfer = New System.Windows.Forms.Label()
        Me.lbl_disbursement = New System.Windows.Forms.Label()
        Me.lbl_processfee = New System.Windows.Forms.Label()
        Me.lbl_loanamount = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_purpose = New System.Windows.Forms.Label()
        Me.lbl_insurance = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btn_see
        '
        Me.btn_see.BackColor = System.Drawing.Color.Transparent
        Me.btn_see.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btn_see.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btn_see.Image = CType(resources.GetObject("btn_see.Image"), System.Drawing.Image)
        Me.btn_see.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btn_see.ImageRotate = 0!
        Me.btn_see.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_see.Location = New System.Drawing.Point(253, 326)
        Me.btn_see.Name = "btn_see"
        Me.btn_see.PressedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btn_see.Size = New System.Drawing.Size(22, 18)
        Me.btn_see.TabIndex = 64
        Me.btn_see.UseTransparentBackground = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(499, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 62
        '
        'lbl_reference
        '
        Me.lbl_reference.AutoSize = True
        Me.lbl_reference.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reference.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reference.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_reference.Location = New System.Drawing.Point(151, 46)
        Me.lbl_reference.Name = "lbl_reference"
        Me.lbl_reference.Size = New System.Drawing.Size(27, 20)
        Me.lbl_reference.TabIndex = 61
        Me.lbl_reference.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(45, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Reference No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(43, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Borrower :"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_fullname.Location = New System.Drawing.Point(121, 66)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(28, 21)
        Me.lbl_fullname.TabIndex = 56
        Me.lbl_fullname.Text = "---"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(312, 315)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(82, 40)
        Me.Guna2Button1.TabIndex = 53
        Me.Guna2Button1.Text = "Release"
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
        Me.txt_password.IconLeft = CType(resources.GetObject("txt_password.IconLeft"), System.Drawing.Image)
        Me.txt_password.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_password.Location = New System.Drawing.Point(88, 315)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "Password..."
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(217, 40)
        Me.txt_password.TabIndex = 52
        '
        'lbl_transfer
        '
        Me.lbl_transfer.AutoSize = True
        Me.lbl_transfer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_transfer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transfer.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_transfer.Location = New System.Drawing.Point(328, 243)
        Me.lbl_transfer.Name = "lbl_transfer"
        Me.lbl_transfer.Size = New System.Drawing.Size(28, 21)
        Me.lbl_transfer.TabIndex = 77
        Me.lbl_transfer.Text = "---"
        '
        'lbl_disbursement
        '
        Me.lbl_disbursement.AutoSize = True
        Me.lbl_disbursement.BackColor = System.Drawing.Color.Transparent
        Me.lbl_disbursement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disbursement.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_disbursement.Location = New System.Drawing.Point(328, 213)
        Me.lbl_disbursement.Name = "lbl_disbursement"
        Me.lbl_disbursement.Size = New System.Drawing.Size(28, 21)
        Me.lbl_disbursement.TabIndex = 76
        Me.lbl_disbursement.Text = "---"
        '
        'lbl_processfee
        '
        Me.lbl_processfee.AutoSize = True
        Me.lbl_processfee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_processfee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_processfee.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_processfee.Location = New System.Drawing.Point(328, 157)
        Me.lbl_processfee.Name = "lbl_processfee"
        Me.lbl_processfee.Size = New System.Drawing.Size(28, 21)
        Me.lbl_processfee.TabIndex = 75
        Me.lbl_processfee.Text = "---"
        '
        'lbl_loanamount
        '
        Me.lbl_loanamount.AutoSize = True
        Me.lbl_loanamount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_loanamount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loanamount.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_loanamount.Location = New System.Drawing.Point(328, 129)
        Me.lbl_loanamount.Name = "lbl_loanamount"
        Me.lbl_loanamount.Size = New System.Drawing.Size(28, 21)
        Me.lbl_loanamount.TabIndex = 74
        Me.lbl_loanamount.Text = "---"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(45, 244)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 20)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "Transfer thru"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(49, 201)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(344, 10)
        Me.Guna2Separator1.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(45, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 20)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Amount to be disbursed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(45, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Processing fee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(45, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Loan amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(45, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Loan purpose"
        '
        'lbl_purpose
        '
        Me.lbl_purpose.AutoSize = True
        Me.lbl_purpose.BackColor = System.Drawing.Color.Transparent
        Me.lbl_purpose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_purpose.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_purpose.Location = New System.Drawing.Point(328, 104)
        Me.lbl_purpose.Name = "lbl_purpose"
        Me.lbl_purpose.Size = New System.Drawing.Size(28, 21)
        Me.lbl_purpose.TabIndex = 68
        Me.lbl_purpose.Text = "---"
        '
        'lbl_insurance
        '
        Me.lbl_insurance.AutoSize = True
        Me.lbl_insurance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_insurance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_insurance.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_insurance.Location = New System.Drawing.Point(328, 180)
        Me.lbl_insurance.Name = "lbl_insurance"
        Me.lbl_insurance.Size = New System.Drawing.Size(28, 21)
        Me.lbl_insurance.TabIndex = 79
        Me.lbl_insurance.Text = "---"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(45, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Insurance fee"
        '
        'loan_release_set
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 387)
        Me.Controls.Add(Me.lbl_insurance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_transfer)
        Me.Controls.Add(Me.lbl_disbursement)
        Me.Controls.Add(Me.lbl_processfee)
        Me.Controls.Add(Me.lbl_loanamount)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_purpose)
        Me.Controls.Add(Me.btn_see)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.lbl_reference)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_fullname)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txt_password)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loan_release_set"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loan_release_set"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btn_see As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lbl_reference As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_transfer As Label
    Friend WithEvents lbl_disbursement As Label
    Friend WithEvents lbl_processfee As Label
    Friend WithEvents lbl_loanamount As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_purpose As Label
    Friend WithEvents lbl_insurance As Label
    Friend WithEvents Label3 As Label
End Class
