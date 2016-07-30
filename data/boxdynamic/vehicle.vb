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
Public Class vehicle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loadindicator.Show()
        addvehicle.Show()
        Button2.Visible = False
    End Sub

    Private Sub Vdebt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.Columns(3).Visible = False Then
            DataGridView1.Columns(3).Visible = True
        Else
            DataGridView1.Columns(3).Visible = False
        End If
    End Sub

    Private Sub vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Box title set
        Boxcaption.Text = "Vehicles"

        Dim s As String = My.Settings.moneychar
        DataGridView1.Columns(3).Visible = False
        Vdebt.Text = "0"
        Button6.Text = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As String = DataGridView1.SelectedRows(0).Cells(3).Value
            Dim b As String = Vdebt.Text - a
            Dim rslt As String = b

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Vdebt.Text = rslt
            DataGridView1.Rows.Remove(row)
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        loadindicator.Show()
        addvehicle.Show()
        Button2.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.Image = My.Resources.box_close_icon_hover
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.Image = My.Resources.box_close_icon
    End Sub

    Private Sub V_add_message_Tick(sender As Object, e As EventArgs) Handles V_add_message.Tick

        totalA.Show()


    End Sub

    Private Sub Vdebt_Click_1(sender As Object, e As EventArgs) Handles Vdebt.Click

    End Sub
End Class