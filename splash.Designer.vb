<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Me.progressview = New System.Windows.Forms.Timer(Me.components)
        Me.steploading = New System.Windows.Forms.Timer(Me.components)
        Me.nieuw = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Sloadinfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nieuw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'progressview
        '
        Me.progressview.Enabled = True
        Me.progressview.Interval = 4000
        '
        'steploading
        '
        Me.steploading.Enabled = True
        Me.steploading.Interval = 10000
        '
        'nieuw
        '
        Me.nieuw.Image = CType(resources.GetObject("nieuw.Image"), System.Drawing.Image)
        Me.nieuw.Location = New System.Drawing.Point(249, 171)
        Me.nieuw.Name = "nieuw"
        Me.nieuw.Size = New System.Drawing.Size(157, 72)
        Me.nieuw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.nieuw.TabIndex = 14
        Me.nieuw.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Sloadinfo)
        Me.Panel1.Controls.Add(Me.nieuw)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(624, 414)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(88, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 31
        '
        'Sloadinfo
        '
        Me.Sloadinfo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sloadinfo.ForeColor = System.Drawing.Color.White
        Me.Sloadinfo.Location = New System.Drawing.Point(-1, 362)
        Me.Sloadinfo.Name = "Sloadinfo"
        Me.Sloadinfo.Size = New System.Drawing.Size(624, 23)
        Me.Sloadinfo.TabIndex = 30
        Me.Sloadinfo.Text = "[loadinfo]"
        Me.Sloadinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(624, 414)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        Me.TopMost = True
        CType(Me.nieuw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents progressview As Timer
    Friend WithEvents steploading As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nieuw As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Sloadinfo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
End Class
