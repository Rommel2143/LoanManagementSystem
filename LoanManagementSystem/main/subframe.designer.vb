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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subframe))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_manageuser = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_loan_apply = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_loan_approve = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnloan_release = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnloan_collection = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_tittle = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_calendar = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userstrip, Me.DashboardToolStripMenuItem, Me.MembersToolStripMenuItem, Me.LoanToolStripMenuItem, Me.LoanRecordsToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(937, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageMyProfileToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DeviceInfoToolStripMenuItem, Me.logout, Me.btn_manageuser})
        Me.userstrip.ForeColor = System.Drawing.Color.Black
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.userstrip.Size = New System.Drawing.Size(66, 24)
        Me.userstrip.Text = "User"
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ManageMyProfileToolStripMenuItem
        '
        Me.ManageMyProfileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageMyProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ManageMyProfileToolStripMenuItem.Image = CType(resources.GetObject("ManageMyProfileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageMyProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ManageMyProfileToolStripMenuItem.Name = "ManageMyProfileToolStripMenuItem"
        Me.ManageMyProfileToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ManageMyProfileToolStripMenuItem.Text = "Manage my profile"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckForUpdatesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'DeviceInfoToolStripMenuItem
        '
        Me.DeviceInfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DeviceInfoToolStripMenuItem.Image = CType(resources.GetObject("DeviceInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeviceInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeviceInfoToolStripMenuItem.Name = "DeviceInfoToolStripMenuItem"
        Me.DeviceInfoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DeviceInfoToolStripMenuItem.Text = "Device Info."
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(188, 22)
        Me.logout.Text = "Logout"
        '
        'btn_manageuser
        '
        Me.btn_manageuser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageuser.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_manageuser.Image = CType(resources.GetObject("btn_manageuser.Image"), System.Drawing.Image)
        Me.btn_manageuser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_manageuser.Name = "btn_manageuser"
        Me.btn_manageuser.Size = New System.Drawing.Size(188, 22)
        Me.btn_manageuser.Text = "User Management"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DashboardToolStripMenuItem.Image = CType(resources.GetObject("DashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MembersToolStripMenuItem.Image = CType(resources.GetObject("MembersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.MembersToolStripMenuItem.Text = "Accounts"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_loan_apply, Me.btn_loan_approve, Me.btnloan_release, Me.btnloan_collection})
        Me.LoanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LoanToolStripMenuItem.Image = CType(resources.GetObject("LoanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.LoanToolStripMenuItem.Text = "Loan Transaction"
        '
        'btn_loan_apply
        '
        Me.btn_loan_apply.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_loan_apply.Image = CType(resources.GetObject("btn_loan_apply.Image"), System.Drawing.Image)
        Me.btn_loan_apply.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_loan_apply.Name = "btn_loan_apply"
        Me.btn_loan_apply.Size = New System.Drawing.Size(199, 30)
        Me.btn_loan_apply.Text = "Loan Application"
        '
        'btn_loan_approve
        '
        Me.btn_loan_approve.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_loan_approve.Image = CType(resources.GetObject("btn_loan_approve.Image"), System.Drawing.Image)
        Me.btn_loan_approve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_loan_approve.Name = "btn_loan_approve"
        Me.btn_loan_approve.Size = New System.Drawing.Size(199, 30)
        Me.btn_loan_approve.Text = "Approval"
        '
        'btnloan_release
        '
        Me.btnloan_release.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnloan_release.Image = CType(resources.GetObject("btnloan_release.Image"), System.Drawing.Image)
        Me.btnloan_release.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnloan_release.Name = "btnloan_release"
        Me.btnloan_release.Size = New System.Drawing.Size(199, 30)
        Me.btnloan_release.Text = "Release"
        '
        'btnloan_collection
        '
        Me.btnloan_collection.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnloan_collection.Image = CType(resources.GetObject("btnloan_collection.Image"), System.Drawing.Image)
        Me.btnloan_collection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnloan_collection.Name = "btnloan_collection"
        Me.btnloan_collection.Size = New System.Drawing.Size(199, 30)
        Me.btnloan_collection.Text = "Collection"
        '
        'LoanRecordsToolStripMenuItem1
        '
        Me.LoanRecordsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LoanRecordsToolStripMenuItem1.Image = CType(resources.GetObject("LoanRecordsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LoanRecordsToolStripMenuItem1.Name = "LoanRecordsToolStripMenuItem1"
        Me.LoanRecordsToolStripMenuItem1.Size = New System.Drawing.Size(126, 24)
        Me.LoanRecordsToolStripMenuItem1.Text = "Loan Records"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 727)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_tittle)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_calendar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 30)
        Me.Panel2.TabIndex = 2
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(822, 0)
        Me.Guna2PictureBox1.MaximumSize = New System.Drawing.Size(16, 16)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_tittle
        '
        Me.lbl_tittle.AutoSize = True
        Me.lbl_tittle.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbl_tittle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tittle.ForeColor = System.Drawing.Color.White
        Me.lbl_tittle.Location = New System.Drawing.Point(26, 4)
        Me.lbl_tittle.Name = "lbl_tittle"
        Me.lbl_tittle.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tittle.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(40, 30)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'lbl_calendar
        '
        Me.lbl_calendar.AutoSize = True
        Me.lbl_calendar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_calendar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calendar.ForeColor = System.Drawing.Color.White
        Me.lbl_calendar.Location = New System.Drawing.Point(838, 0)
        Me.lbl_calendar.Name = "lbl_calendar"
        Me.lbl_calendar.Size = New System.Drawing.Size(99, 15)
        Me.lbl_calendar.TabIndex = 3
        Me.lbl_calendar.Text = "MMMM-dd-yyyy"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'subframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 785)
        Me.Controls.Add(Me.Panel1)
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
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents logout As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_tittle As Label
    Friend WithEvents lbl_calendar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ManageMyProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_loan_apply As ToolStripMenuItem
    Friend WithEvents btn_loan_approve As ToolStripMenuItem
    Friend WithEvents btnloan_release As ToolStripMenuItem
    Friend WithEvents btnloan_collection As ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LoanRecordsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn_manageuser As ToolStripMenuItem
End Class
