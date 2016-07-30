<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIselector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIselector))
        Me.Boxtitle = New System.Windows.Forms.Panel()
        Me.Boxcaption = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TTchart = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.debtMess = New System.Windows.Forms.Button()
        Me.Uinc = New System.Windows.Forms.Button()
        Me.Udebt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Boxtitle.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boxtitle
        '
        Me.Boxtitle.Controls.Add(Me.Boxcaption)
        Me.Boxtitle.Controls.Add(Me.PictureBox1)
        Me.Boxtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boxtitle.Location = New System.Drawing.Point(5, 5)
        Me.Boxtitle.Name = "Boxtitle"
        Me.Boxtitle.Padding = New System.Windows.Forms.Padding(10)
        Me.Boxtitle.Size = New System.Drawing.Size(900, 48)
        Me.Boxtitle.TabIndex = 2
        '
        'Boxcaption
        '
        Me.Boxcaption.Dock = System.Windows.Forms.DockStyle.Left
        Me.Boxcaption.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boxcaption.ForeColor = System.Drawing.Color.White
        Me.Boxcaption.Location = New System.Drawing.Point(42, 10)
        Me.Boxcaption.Name = "Boxcaption"
        Me.Boxcaption.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Boxcaption.Size = New System.Drawing.Size(313, 28)
        Me.Boxcaption.TabIndex = 0
        Me.Boxcaption.Text = "[Box name 1]"
        Me.Boxcaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Debt [Total]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 2)
        Me.Panel2.TabIndex = 5
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.IsMarksNextToAxis = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(89, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.Title = "fruit"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(89, Byte), Integer))
        ChartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(89, Byte), Integer))
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(89, Byte), Integer))
        ChartArea1.AxisX2.TitleFont = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.BlanchedAlmond
        ChartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(89, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None
        ChartArea1.AxisY.Title = "L/ Ton"
        ChartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.TitleFont = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Top
        Legend1.BackColor = System.Drawing.Color.Gainsboro
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(1, 1)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.Lime
        Series1.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.LabelToolTip = "#VAL"
        Series1.Legend = "Legend1"
        Series1.LegendToolTip = "#LABEL  :   #VAL{N}"
        Series1.Name = "storage"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No
        Series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None
        Series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White
        Series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box
        Series1.ToolTip = "Total ammount :  #TOTAL{G}"
        Series1.YValuesPerPoint = 6
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(457, 154)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        Me.TTchart.SetToolTip(Me.Chart1, "Change it's view")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(459, 343)
        Me.Panel3.TabIndex = 7
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(287, 182)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(91, 31)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "View in 3D"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'TTchart
        '
        Me.TTchart.AutomaticDelay = 100
        Me.TTchart.AutoPopDelay = 5000
        Me.TTchart.BackColor = System.Drawing.Color.White
        Me.TTchart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTchart.InitialDelay = 100
        Me.TTchart.ReshowDelay = 600
        Me.TTchart.ToolTipTitle = "3D/normal view"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 53)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel2.Controls.Add(Me.debtMess)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Uinc)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Udebt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 343)
        Me.SplitContainer1.SplitterDistance = 459
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 8
        '
        'debtMess
        '
        Me.debtMess.AutoSize = True
        Me.debtMess.FlatAppearance.BorderSize = 0
        Me.debtMess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.debtMess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.debtMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.debtMess.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debtMess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.debtMess.Location = New System.Drawing.Point(32, 23)
        Me.debtMess.Name = "debtMess"
        Me.debtMess.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.debtMess.Size = New System.Drawing.Size(75, 26)
        Me.debtMess.TabIndex = 11
        Me.debtMess.Text = "message"
        Me.debtMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.debtMess.UseVisualStyleBackColor = False
        Me.debtMess.Visible = False
        '
        'Uinc
        '
        Me.Uinc.AutoSize = True
        Me.Uinc.BackColor = System.Drawing.Color.LightGreen
        Me.Uinc.FlatAppearance.BorderSize = 0
        Me.Uinc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Uinc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Uinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Uinc.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uinc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Uinc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Uinc.Location = New System.Drawing.Point(208, 106)
        Me.Uinc.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Uinc.Name = "Uinc"
        Me.Uinc.Padding = New System.Windows.Forms.Padding(10)
        Me.Uinc.Size = New System.Drawing.Size(132, 88)
        Me.Uinc.TabIndex = 9
        Me.Uinc.Text = "[value]"
        Me.Uinc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Uinc.UseVisualStyleBackColor = False
        '
        'Udebt
        '
        Me.Udebt.AutoSize = True
        Me.Udebt.BackColor = System.Drawing.Color.IndianRed
        Me.Udebt.FlatAppearance.BorderSize = 0
        Me.Udebt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Udebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Udebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Udebt.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Udebt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Udebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Udebt.Location = New System.Drawing.Point(37, 106)
        Me.Udebt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Udebt.Name = "Udebt"
        Me.Udebt.Padding = New System.Windows.Forms.Padding(10)
        Me.Udebt.Size = New System.Drawing.Size(132, 88)
        Me.Udebt.TabIndex = 8
        Me.Udebt.Text = "[value]"
        Me.Udebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Udebt.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(208, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Income [Total]"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'UIselector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Boxtitle)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UIselector"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(910, 403)
        Me.Boxtitle.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Boxtitle As Panel
    Friend WithEvents Boxcaption As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TTchart As ToolTip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Uinc As Button
    Friend WithEvents Udebt As Button
    Friend WithEvents debtMess As Button
End Class
