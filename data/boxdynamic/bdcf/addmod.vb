Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft
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
Public Class addmod

    Private Sub addmod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vehicles.mods_user_vehicles' table. You can move, or remove it, as needed.
        Me.Mods_user_vehiclesTableAdapter.Fill(Me.Vehicles.mods_user_vehicles)
        My.Settings.Reload()
        Label7.Text = My.Settings.moneychar
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' vehicle data - Creats a new row & Sets it into the database
        Dim i As Integer = NumericUpDown1.Value
        Dim R As DataRow = Vehicles.mods_user_vehicles.NewRow
        R("v_type") = ComboBox2.SelectedItem
        R("Brand") = TextBox1.Text
        R("model") = TextBox2.Text
        R("Cost p/d") = i
        Vehicles.mods_user_vehicles.Rows.Add(R)
        DataGridView1.DataSource = Vehicles.mods_user_vehicles
        Try
            Me.Validate()
            Me.ModsuservehiclesBindingSource.EndEdit()
            Me.Mods_user_vehiclesTableAdapter.Update(Me.Vehicles.mods_user_vehicles)
            addvehicle.ComboBox2.Update()

            Label5.Text = ("Update successful")

        Catch ex As Exception
            Label5.Text = ("Update failed")
        End Try

        'clear the input boxes
        ComboBox2.SelectedItem = Nothing
        TextBox1.Text = ""
        TextBox2.Text = ""
        NumericUpDown1.Value = "0"

        'form refresh
        Me.Refresh()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If ComboBox1.Visible = False Then
            ComboBox1.Visible = True
        Else
            ComboBox1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem
        ComboBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class