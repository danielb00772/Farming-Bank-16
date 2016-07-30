<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appsettings))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.settingTabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Smvalue = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Smax = New System.Windows.Forms.CheckBox()
        Me.Sintf = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sactsave = New System.Windows.Forms.CheckBox()
        Me.Slanguage = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Sautologin = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Spath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ssync2 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ssync3 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ssync1 = New System.Windows.Forms.RadioButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Ssaveall = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.settingTabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change name:"
        '
        'Sname
        '
        Me.Sname.Location = New System.Drawing.Point(100, 96)
        Me.Sname.Name = "Sname"
        Me.Sname.Size = New System.Drawing.Size(156, 22)
        Me.Sname.TabIndex = 9
        '
        'settingTabs
        '
        Me.settingTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.settingTabs.Controls.Add(Me.TabPage1)
        Me.settingTabs.Controls.Add(Me.TabPage2)
        Me.settingTabs.Controls.Add(Me.TabPage3)
        Me.settingTabs.Controls.Add(Me.TabPage4)
        Me.settingTabs.Controls.Add(Me.TabPage5)
        Me.settingTabs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.settingTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.settingTabs.ItemSize = New System.Drawing.Size(64, 5)
        Me.settingTabs.Location = New System.Drawing.Point(0, 51)
        Me.settingTabs.Margin = New System.Windows.Forms.Padding(0)
        Me.settingTabs.Name = "settingTabs"
        Me.settingTabs.Padding = New System.Drawing.Point(0, 0)
        Me.settingTabs.SelectedIndex = 0
        Me.settingTabs.Size = New System.Drawing.Size(554, 463)
        Me.settingTabs.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Smvalue)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Sintf)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Sactsave)
        Me.TabPage1.Controls.Add(Me.Slanguage)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Sname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 9)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(546, 450)
        Me.TabPage1.TabIndex = 0
        '
        'Smvalue
        '
        Me.Smvalue.FormattingEnabled = True
        Me.Smvalue.Location = New System.Drawing.Point(363, 28)
        Me.Smvalue.Name = "Smvalue"
        Me.Smvalue.Size = New System.Drawing.Size(64, 21)
        Me.Smvalue.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "money value:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Smax)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 85)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View"
        '
        'Smax
        '
        Me.Smax.AutoSize = True
        Me.Smax.Location = New System.Drawing.Point(6, 39)
        Me.Smax.Name = "Smax"
        Me.Smax.Size = New System.Drawing.Size(246, 17)
        Me.Smax.TabIndex = 23
        Me.Smax.Text = "Run Farming Bank always in maximized mode"
        Me.Smax.UseVisualStyleBackColor = True
        '
        'Sintf
        '
        Me.Sintf.FormattingEnabled = True
        Me.Sintf.Location = New System.Drawing.Point(100, 61)
        Me.Sintf.Name = "Sintf"
        Me.Sintf.Size = New System.Drawing.Size(156, 21)
        Me.Sintf.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Interface:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "This will reset the application to its default settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(all user settings are l" &
    "ost)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Reset me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sactsave
        '
        Me.Sactsave.AutoSize = True
        Me.Sactsave.Location = New System.Drawing.Point(100, 136)
        Me.Sactsave.Name = "Sactsave"
        Me.Sactsave.Size = New System.Drawing.Size(173, 30)
        Me.Sactsave.TabIndex = 16
        Me.Sactsave.Text = "Save current active savegame." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(for next restart)"
        Me.Sactsave.UseVisualStyleBackColor = True
        '
        'Slanguage
        '
        Me.Slanguage.FormattingEnabled = True
        Me.Slanguage.Location = New System.Drawing.Point(100, 28)
        Me.Slanguage.Name = "Slanguage"
        Me.Slanguage.Size = New System.Drawing.Size(156, 21)
        Me.Slanguage.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Language:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 9)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 450)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(395, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "To manage your Account on Farming Bank go to your name in the main program."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Sautologin)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 102)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(76, 30)
        Me.MaskedTextBox1.Mask = "0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(53, 22)
        Me.MaskedTextBox1.TabIndex = 19
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Change PIN:"
        '
        'Sautologin
        '
        Me.Sautologin.AutoSize = True
        Me.Sautologin.Location = New System.Drawing.Point(76, 72)
        Me.Sautologin.Name = "Sautologin"
        Me.Sautologin.Size = New System.Drawing.Size(138, 17)
        Me.Sautologin.TabIndex = 17
        Me.Sautologin.Text = "Enable automatic login"
        Me.Sautologin.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 9)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(546, 450)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Spath)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(313, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 185)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Game Location"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 68)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Be carefull ! This can cause problems or even a crash when changing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tip: Test" &
    " your path of the game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restart is required!"
        '
        'Spath
        '
        Me.Spath.Location = New System.Drawing.Point(9, 42)
        Me.Spath.Name = "Spath"
        Me.Spath.ReadOnly = True
        Me.Spath.Size = New System.Drawing.Size(210, 22)
        Me.Spath.TabIndex = 2
        Me.Spath.Tag = ""
        Me.Spath.Text = "[current path]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Current path"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(119, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 23)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Path properties"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Ssync2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Ssync3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Ssync1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(299, 185)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Syncronisation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "As long as Farming Bank 16 is running"
        '
        'Ssync2
        '
        Me.Ssync2.AutoSize = True
        Me.Ssync2.Location = New System.Drawing.Point(6, 82)
        Me.Ssync2.Name = "Ssync2"
        Me.Ssync2.Size = New System.Drawing.Size(59, 17)
        Me.Ssync2.TabIndex = 2
        Me.Ssync2.TabStop = True
        Me.Ssync2.Text = "Always"
        Me.Ssync2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "User need to Sync. itself"
        '
        'Ssync3
        '
        Me.Ssync3.AutoSize = True
        Me.Ssync3.Location = New System.Drawing.Point(6, 129)
        Me.Ssync3.Name = "Ssync3"
        Me.Ssync3.Size = New System.Drawing.Size(62, 17)
        Me.Ssync3.TabIndex = 1
        Me.Ssync3.TabStop = True
        Me.Ssync3.Text = "Manual"
        Me.Ssync3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Only sync. data when Farming Bank 16 is activated"
        '
        'Ssync1
        '
        Me.Ssync1.AutoSize = True
        Me.Ssync1.Location = New System.Drawing.Point(6, 35)
        Me.Ssync1.Name = "Ssync1"
        Me.Ssync1.Size = New System.Drawing.Size(75, 17)
        Me.Ssync1.TabIndex = 0
        Me.Ssync1.TabStop = True
        Me.Ssync1.Text = "Intelligent"
        Me.Ssync1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CheckBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 9)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(546, 450)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "add new specialisation"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PictureBox2)
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Controls.Add(Me.RichTextBox1)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Location = New System.Drawing.Point(4, 9)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(546, 450)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(404, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 60)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(366, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 184)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(540, 263)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(373, 48)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Made by Daniel Berends" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Farming Bank 16 is Licensed under the GNU General Publi" &
    "c License v3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 32)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Farming Bank 16" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BETA 0.1 Release"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 60)
        Me.Panel1.TabIndex = 17
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(479, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 60)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "About"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.Gainsboro
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(245, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 60)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Advanced"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(160, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 60)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Session"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(75, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 60)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Bank Account"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 60)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "General"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Ssaveall)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 514)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 54)
        Me.Panel2.TabIndex = 18
        '
        'Ssaveall
        '
        Me.Ssaveall.Location = New System.Drawing.Point(386, 19)
        Me.Ssaveall.Name = "Ssaveall"
        Me.Ssaveall.Size = New System.Drawing.Size(75, 23)
        Me.Ssaveall.TabIndex = 1
        Me.Ssaveall.Text = "Save"
        Me.Ssaveall.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(467, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'appsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.settingTabs)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "appsettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.settingTabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Sname As TextBox
    Friend WithEvents settingTabs As TabControl
    Private WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Sactsave As CheckBox
    Friend WithEvents Slanguage As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Sintf As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Smax As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sautologin As CheckBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Smvalue As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Ssync2 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Ssync3 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Ssync1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Ssaveall As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Spath As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
