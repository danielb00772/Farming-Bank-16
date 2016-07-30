<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addvehicle
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
        Me.StandardgvehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vehicles = New FarmingBank.vehicles()
        Me.StandardgvehiclesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Standard_g_vehiclesTableAdapter = New FarmingBank.vehiclesTableAdapters.standard_g_vehiclesTableAdapter()
        Me.ModsuservehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.costs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Mods_user_vehiclesTableAdapter = New FarmingBank.vehiclesTableAdapters.mods_user_vehiclesTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.StandardgvehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandardgvehiclesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModsuservehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StandardgvehiclesBindingSource
        '
        Me.StandardgvehiclesBindingSource.DataMember = "standard_g_vehicles"
        Me.StandardgvehiclesBindingSource.DataSource = Me.Vehicles
        '
        'Vehicles
        '
        Me.Vehicles.DataSetName = "vehicles"
        Me.Vehicles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StandardgvehiclesBindingSource1
        '
        Me.StandardgvehiclesBindingSource1.DataMember = "standard_g_vehicles"
        Me.StandardgvehiclesBindingSource1.DataSource = Me.VehiclesBindingSource
        '
        'VehiclesBindingSource
        '
        Me.VehiclesBindingSource.DataSource = Me.Vehicles
        Me.VehiclesBindingSource.Position = 0
        '
        'Standard_g_vehiclesTableAdapter
        '
        Me.Standard_g_vehiclesTableAdapter.ClearBeforeFill = True
        '
        'ModsuservehiclesBindingSource
        '
        Me.ModsuservehiclesBindingSource.DataMember = "mods_user_vehicles"
        Me.ModsuservehiclesBindingSource.DataSource = Me.VehiclesBindingSource
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(126, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 37)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Edit mod list"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "How many:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(280, 209)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 22)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StandardgvehiclesBindingSource1, "Cost p/d", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(123, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 1)
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "price"
        '
        'costs
        '
        Me.costs.Location = New System.Drawing.Point(378, 209)
        Me.costs.Name = "costs"
        Me.costs.ReadOnly = True
        Me.costs.Size = New System.Drawing.Size(17, 22)
        Me.costs.TabIndex = 16
        Me.costs.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(16, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(4)
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Costs per Day:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(227, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 37)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Add vehicle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.StandardgvehiclesBindingSource, "model", True))
        Me.ComboBox1.DataSource = Me.StandardgvehiclesBindingSource1
        Me.ComboBox1.DisplayMember = "model"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(101, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(4, 4, 4, 1)
        Me.Label9.Size = New System.Drawing.Size(22, 21)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "€"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Manually (Mods for Example)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 21)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Standard Giants Vehicles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.StandardgvehiclesBindingSource, "Brand", True))
        Me.ComboBox3.DataSource = Me.StandardgvehiclesBindingSource1
        Me.ComboBox3.DisplayMember = "Brand"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(378, 209)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(17, 21)
        Me.ComboBox3.TabIndex = 34
        Me.ComboBox3.Visible = False
        '
        'Mods_user_vehiclesTableAdapter
        '
        Me.Mods_user_vehiclesTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.StandardgvehiclesBindingSource, "model", True))
        Me.ComboBox2.DataSource = Me.ModsuservehiclesBindingSource
        Me.ComboBox2.DisplayMember = "model"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 65)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox2.TabIndex = 37
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(227, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 37)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Add Mod"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(280, 64)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(49, 22)
        Me.NumericUpDown2.TabIndex = 41
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "How many:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModsuservehiclesBindingSource, "Cost p/d", True))
        Me.Label5.Location = New System.Drawing.Point(123, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModsuservehiclesBindingSource, "Brand", True))
        Me.Label7.Location = New System.Drawing.Point(16, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModsuservehiclesBindingSource, "Cost p/d", True))
        Me.Label10.Location = New System.Drawing.Point(13, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "--"
        Me.Label10.Visible = False
        '
        'addvehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 369)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.costs)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addvehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Module - Add new"
        Me.TopMost = True
        CType(Me.StandardgvehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandardgvehiclesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModsuservehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vehicles As vehicles
    Friend WithEvents StandardgvehiclesBindingSource As BindingSource
    Friend WithEvents Standard_g_vehiclesTableAdapter As vehiclesTableAdapters.standard_g_vehiclesTableAdapter
    Friend WithEvents VehiclesBindingSource As BindingSource
    Friend WithEvents StandardgvehiclesBindingSource1 As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents costs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ModsuservehiclesBindingSource As BindingSource
    Friend WithEvents Mods_user_vehiclesTableAdapter As vehiclesTableAdapters.mods_user_vehiclesTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
End Class
