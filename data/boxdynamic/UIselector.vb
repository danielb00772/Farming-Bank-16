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
Public Class UIselector
    Private Sub UIselector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Box title set
        Boxcaption.Text = "General Information"

        Me.Chart1.Series("storage").Points.AddXY("Weed", 44)
        Me.Chart1.Series("storage").Points.AddXY("Barley", 44)
        Me.Chart1.Series("storage").Points.AddXY("Canola", 250973)
        Me.Chart1.Series("storage").Points.AddXY("Corn", 0)


    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        If Chart1.ChartAreas(0).Area3DStyle.Enable3D = False Then
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
            Chart1.ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Simplistic
        Else
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Chart1.ChartAreas(0).Area3DStyle.Enable3D = False Then
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
            Chart1.ChartAreas(0).Area3DStyle.LightStyle = DataVisualization.Charting.LightStyle.Simplistic
            Button10.FlatAppearance.BorderColor = Color.White
        Else
            Chart1.ChartAreas(0).Area3DStyle.Enable3D = False
            Button10.FlatAppearance.BorderColor = Color.FromArgb(1, 105, 201)
        End If
    End Sub

    Private Sub TTchart_Popup(sender As Object, e As PopupEventArgs) Handles TTchart.Popup
        TTchart.BackColor = Color.Black
        TTchart.ForeColor = Color.White
    End Sub

    Private Sub TTchart_Draw(sender As Object, e As DrawToolTipEventArgs) Handles TTchart.Draw

    End Sub
End Class
