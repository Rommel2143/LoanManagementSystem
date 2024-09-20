<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subframe))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_loan_apply = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_loan_approve = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_calendar = New System.Windows.Forms.Label()
        Me.lbl_tittle = New System.Windows.Forms.Label()
        Me.error_panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.btn_close = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuggestImprovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.error_panel.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userstrip, Me.LoanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1346, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_loan_apply, Me.btn_loan_approve, Me.ReleaseToolStripMenuItem, Me.LoanRecordsToolStripMenuItem})
        Me.LoanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'btn_loan_apply
        '
        Me.btn_loan_apply.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_loan_apply.Name = "btn_loan_apply"
        Me.btn_loan_apply.Size = New System.Drawing.Size(191, 24)
        Me.btn_loan_apply.Text = "Loan Application"
        '
        'btn_loan_approve
        '
        Me.btn_loan_approve.Name = "btn_loan_approve"
        Me.btn_loan_approve.Size = New System.Drawing.Size(191, 24)
        Me.btn_loan_approve.Text = "Approval"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1346, 706)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_calendar)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_tittle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1346, 24)
        Me.Panel2.TabIndex = 2
        '
        'lbl_calendar
        '
        Me.lbl_calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_calendar.AutoSize = True
        Me.lbl_calendar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calendar.ForeColor = System.Drawing.Color.White
        Me.lbl_calendar.Location = New System.Drawing.Point(1235, 6)
        Me.lbl_calendar.Name = "lbl_calendar"
        Me.lbl_calendar.Size = New System.Drawing.Size(99, 15)
        Me.lbl_calendar.TabIndex = 3
        Me.lbl_calendar.Text = "MMMM-dd-yyyy"
        '
        'lbl_tittle
        '
        Me.lbl_tittle.AutoSize = True
        Me.lbl_tittle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tittle.ForeColor = System.Drawing.Color.White
        Me.lbl_tittle.Location = New System.Drawing.Point(43, 2)
        Me.lbl_tittle.Name = "lbl_tittle"
        Me.lbl_tittle.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tittle.TabIndex = 0
        '
        'error_panel
        '
        Me.error_panel.Controls.Add(Me.btn_close)
        Me.error_panel.Controls.Add(Me.Guna2PictureBox3)
        Me.error_panel.Controls.Add(Me.lbl_error)
        Me.error_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.error_panel.FillColor = System.Drawing.Color.Red
        Me.error_panel.FillColor2 = System.Drawing.Color.Salmon
        Me.error_panel.Location = New System.Drawing.Point(0, 52)
        Me.error_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.error_panel.Name = "error_panel"
        Me.error_panel.Size = New System.Drawing.Size(1346, 27)
        Me.error_panel.TabIndex = 32
        Me.error_panel.Visible = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.White
        Me.lbl_error.Location = New System.Drawing.Point(41, 6)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(119, 17)
        Me.lbl_error.TabIndex = 0
        Me.lbl_error.Text = "Invalid Credentials"
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageRotate = 0!
        Me.btn_close.Location = New System.Drawing.Point(1322, 5)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(15, 15)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 2
        Me.btn_close.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(12, 2)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(19, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1209, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageMyProfileToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DeviceInfoToolStripMenuItem, Me.SuggestImprovementToolStripMenuItem, Me.logout, Me.ExitToolStripMenuItem, Me.add_user})
        Me.userstrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.userstrip.Size = New System.Drawing.Size(66, 24)
        Me.userstrip.Text = "User"
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ManageMyProfileToolStripMenuItem
        '
        Me.ManageMyProfileToolStripMenuItem.Name = "ManageMyProfileToolStripMenuItem"
        Me.ManageMyProfileToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.ManageMyProfileToolStripMenuItem.Text = "Manage my profile"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'DeviceInfoToolStripMenuItem
        '
        Me.DeviceInfoToolStripMenuItem.Name = "DeviceInfoToolStripMenuItem"
        Me.DeviceInfoToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.DeviceInfoToolStripMenuItem.Text = "Device Info."
        '
        'SuggestImprovementToolStripMenuItem
        '
        Me.SuggestImprovementToolStripMenuItem.Name = "SuggestImprovementToolStripMenuItem"
        Me.SuggestImprovementToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.SuggestImprovementToolStripMenuItem.Text = "Suggest improvement"
        '
        'logout
        '
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(224, 24)
        Me.logout.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'add_user
        '
        Me.add_user.Name = "add_user"
        Me.add_user.Size = New System.Drawing.Size(224, 24)
        Me.add_user.Text = "Add User"
        Me.add_user.Visible = False
        '
        'LoanRecordsToolStripMenuItem
        '
        Me.LoanRecordsToolStripMenuItem.Name = "LoanRecordsToolStripMenuItem"
        Me.LoanRecordsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.LoanRecordsToolStripMenuItem.Text = "Loan Records"
        '
        'subframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 785)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.error_panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "subframe"
        Me.Text = "subframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.error_panel.ResumeLayout(False)
        Me.error_panel.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents logout As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuggestImprovementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_tittle As Label
    Friend WithEvents lbl_calendar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents add_user As ToolStripMenuItem
    Friend WithEvents ManageMyProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_loan_apply As ToolStripMenuItem
    Friend WithEvents error_panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_error As Label
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_loan_approve As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanRecordsToolStripMenuItem As ToolStripMenuItem
End Class
