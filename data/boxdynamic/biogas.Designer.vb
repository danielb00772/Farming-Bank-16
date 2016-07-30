<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class biogas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(biogas))
        Me.Boxtitle = New System.Windows.Forms.Panel()
        Me.Boxcaption = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TTchart = New System.Windows.Forms.ToolTip(Me.components)
        Me.BioSilo1 = New System.Windows.Forms.ProgressBar()
        Me.BioSilo2 = New System.Windows.Forms.ProgressBar()
        Me.BioSilo3 = New System.Windows.Forms.ProgressBar()
        Me.BioSilo4 = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Boxtitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boxtitle
        '
        Me.Boxtitle.BackColor = System.Drawing.Color.Transparent
        Me.Boxtitle.Controls.Add(Me.Button10)
        Me.Boxtitle.Controls.Add(Me.Boxcaption)
        Me.Boxtitle.Controls.Add(Me.PictureBox1)
        Me.Boxtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boxtitle.Location = New System.Drawing.Point(0, 2)
        Me.Boxtitle.Name = "Boxtitle"
        Me.Boxtitle.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Boxtitle.Size = New System.Drawing.Size(297, 34)
        Me.Boxtitle.TabIndex = 2
        '
        'Boxcaption
        '
        Me.Boxcaption.Dock = System.Windows.Forms.DockStyle.Left
        Me.Boxcaption.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boxcaption.ForeColor = System.Drawing.Color.White
        Me.Boxcaption.Location = New System.Drawing.Point(43, 3)
        Me.Boxcaption.Name = "Boxcaption"
        Me.Boxcaption.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Boxcaption.Size = New System.Drawing.Size(199, 28)
        Me.Boxcaption.TabIndex = 0
        Me.Boxcaption.Text = "[Box name 1] -Biogas | icome "
        Me.Boxcaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TTchart
        '
        Me.TTchart.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTchart.ToolTipTitle = "3D/normal view"
        Me.TTchart.UseFading = False
        '
        'BioSilo1
        '
        Me.BioSilo1.Location = New System.Drawing.Point(10, 50)
        Me.BioSilo1.Name = "BioSilo1"
        Me.BioSilo1.Size = New System.Drawing.Size(212, 23)
        Me.BioSilo1.TabIndex = 3
        '
        'BioSilo2
        '
        Me.BioSilo2.Location = New System.Drawing.Point(10, 113)
        Me.BioSilo2.Name = "BioSilo2"
        Me.BioSilo2.Size = New System.Drawing.Size(212, 23)
        Me.BioSilo2.TabIndex = 4
        '
        'BioSilo3
        '
        Me.BioSilo3.Location = New System.Drawing.Point(10, 184)
        Me.BioSilo3.Name = "BioSilo3"
        Me.BioSilo3.Size = New System.Drawing.Size(212, 23)
        Me.BioSilo3.TabIndex = 5
        '
        'BioSilo4
        '
        Me.BioSilo4.Location = New System.Drawing.Point(10, 256)
        Me.BioSilo4.Name = "BioSilo4"
        Me.BioSilo4.Size = New System.Drawing.Size(212, 23)
        Me.BioSilo4.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 2)
        Me.Panel2.TabIndex = 7
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(256, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(31, 28)
        Me.Button10.TabIndex = 6
        Me.Button10.UseVisualStyleBackColor = True
        '
        'biogas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Boxtitle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BioSilo4)
        Me.Controls.Add(Me.BioSilo3)
        Me.Controls.Add(Me.BioSilo2)
        Me.Controls.Add(Me.BioSilo1)
        Me.Name = "biogas"
        Me.Size = New System.Drawing.Size(297, 375)
        Me.Boxtitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Boxtitle As Panel
    Friend WithEvents Boxcaption As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TTchart As ToolTip
    Friend WithEvents BioSilo1 As ProgressBar
    Friend WithEvents BioSilo2 As ProgressBar
    Friend WithEvents BioSilo3 As ProgressBar
    Friend WithEvents BioSilo4 As ProgressBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button10 As Button
End Class
