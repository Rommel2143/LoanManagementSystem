<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member_info
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
        Me.pic_user = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.White
        Me.pic_user.ImageRotate = 0!
        Me.pic_user.Location = New System.Drawing.Point(50, 42)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.pic_user.ShadowDecoration.Enabled = True
        Me.pic_user.Size = New System.Drawing.Size(150, 150)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 61
        Me.pic_user.TabStop = False
        '
        'member_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 754)
        Me.Controls.Add(Me.pic_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "member_info"
        Me.Text = "member_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_user As Guna.UI2.WinForms.Guna2PictureBox
End Class
