<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bales))
        Me.Boxtitle = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Boxcaption = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TTchart = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bcount = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Boxtitle.Size = New System.Drawing.Size(263, 34)
        Me.Boxtitle.TabIndex = 2
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(222, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(31, 28)
        Me.Button10.TabIndex = 6
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Boxcaption
        '
        Me.Boxcaption.Dock = System.Windows.Forms.DockStyle.Left
        Me.Boxcaption.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boxcaption.ForeColor = System.Drawing.Color.White
        Me.Boxcaption.Location = New System.Drawing.Point(43, 3)
        Me.Boxcaption.Name = "Boxcaption"
        Me.Boxcaption.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Boxcaption.Size = New System.Drawing.Size(158, 28)
        Me.Boxcaption.TabIndex = 0
        Me.Boxcaption.Text = "[Box name 1] bales"
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LawnGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 70)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "[price]"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LawnGreen
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "We think that you earn the following:"
        '
        'Bcount
        '
        Me.Bcount.AutoSize = True
        Me.Bcount.BackColor = System.Drawing.Color.White
        Me.Bcount.FlatAppearance.BorderSize = 0
        Me.Bcount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Bcount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Bcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcount.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Bcount.Image = CType(resources.GetObject("Bcount.Image"), System.Drawing.Image)
        Me.Bcount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bcount.Location = New System.Drawing.Point(10, 50)
        Me.Bcount.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Bcount.Name = "Bcount"
        Me.Bcount.Padding = New System.Windows.Forms.Padding(10)
        Me.Bcount.Size = New System.Drawing.Size(238, 76)
        Me.Bcount.TabIndex = 7
        Me.Bcount.Text = "[value]"
        Me.Bcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bcount.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(263, 2)
        Me.Panel2.TabIndex = 8
        '
        'bales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Boxtitle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Bcount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "bales"
        Me.Size = New System.Drawing.Size(263, 230)
        Me.Boxtitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boxtitle As Panel
    Friend WithEvents Boxcaption As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TTchart As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Bcount As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button10 As Button
End Class
