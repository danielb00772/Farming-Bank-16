Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
'<Farming Bank 16 . A mod for the fs15 game>
'Copyright (C) <2016>  <Daniel Berends>

'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with this program.  If Not, see <http://www.gnu.org/licenses/>.
Public Class addvehicle
    Private Sub addvehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = My.Settings.moneychar
        My.Settings.Reload()
        'TODO: This line of code loads data into the 'Vehicles.mods_user_vehicles' table. You can move, or remove it, as needed.
        Me.Mods_user_vehiclesTableAdapter.Fill(Me.Vehicles.mods_user_vehicles)
        loadindicator.Close()
        'TODO: This line of code loads data into the 'Vehicles.standard_g_vehicles' table. You can move, or remove it, as needed.
        Me.Standard_g_vehiclesTableAdapter.Fill(Me.Vehicles.standard_g_vehicles)
        Label2.Text = "0"
        ComboBox1.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '|sum for Numericupdown Costs p/d , example : 3x [vehicle name] New Cost p/d: [NEW TOTAL ]
        Dim a As String = Label2.Text
        Dim h As String = NumericUpDown1.Value
        Dim result As String = a * h
        Dim rtxt As String = "New price: " + My.Settings.moneychar

        '| Shows a message on the vehicle box
        fb16.Vehicle1.totalA.Text = "Vehicle added ! new cost (Per day): " + rtxt + result.ToString



        costs.AppendText(result)                                                                       ' Not visible textbox ,, Gets the selected Costs p/Day of vehicle

        '|sum to get the total ammount for Costs Per Day
        Dim TextBox1Value As Double = CDbl(costs.Text)
        costs.Clear()
        Dim TextBox2Value As Double = CDbl(fb16.Vehicle1.Vdebt.Text)

        TextBox2Value += TextBox1Value
        fb16.Vehicle1.Vdebt.Text = TextBox2Value.ToString

        '| Add Vehicle to list
        Dim VehicleData As String() = New String() {Nothing, ComboBox3.Text, ComboBox1.Text, result}
        fb16.Vehicle1.DataGridView1.Rows.Add(VehicleData)

        '| Add the vehicle to the Bank account details
        Dim t As New fmcontroller
        t.f_detail()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        addmod.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub addvehicle_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub addvehicle_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.2
    End Sub

    Private Sub addvehicle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            If addmod.Visible = True Then
                addmod.Close()
            End If

            Me.Hide()
            End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox2.SelectedItem = Nothing Then
            MsgBox("Please select an Item first", MsgBoxStyle.Exclamation)
        Else
            Dim a As String = Label5.Text
            Dim h As String = NumericUpDown2.Value
            Dim resultM As String = a * h

            Label10.Text = resultM

            '|sum to get the total ammount for Costs Per Day
            Dim TextBox1Value As Double = CDbl(Label10.Text)
            Dim TextBox2Value As Double = CDbl(fb16.Vehicle1.Vdebt.Text)

            TextBox2Value += TextBox1Value
            fb16.Vehicle1.Vdebt.Text = TextBox2Value.ToString


            '| Add own Mods to the List
            Dim VData As String() = New String() {Nothing, Label7.Text, ComboBox2.Text, resultM}
            fb16.Vehicle1.DataGridView1.Rows.Add(VData)

            '| Add the vehicle to the Bank account details
            Dim t As New fmcontroller
            t.f_detail()
        End If


    End Sub
End Class