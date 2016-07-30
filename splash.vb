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
Imports System.IO
Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressview.Start()                                                 ' progressview acts as a timer to view that the program is loading
        Sloadinfo.Text = "Get information.."
        '| Get's the settings and path validation

    End Sub

    Private Sub Loadprogress_Tick(sender As Object, e As EventArgs) Handles progressview.Tick
        Panel2.Width = 20


    End Sub

    Private Sub progressSteps_Tick(sender As Object, e As EventArgs) Handles steploading.Tick
        progressview.Enabled = False
        progressview.Stop()
        Sloadinfo.Text = "Prepare data.."

        ''Dim G_exist As New usrsetload()
        ''G_exist.ValidatePath_game()
        Panel2.Width = 70


        Dim WS As New usrsetload()
        WS.WizardStep_check()

        Dim BA As New usrsetload()
        BA.BankAlias_login()
        Panel2.Width = 120


        '| END

        Me.Hide()
        Dim AU As New usrsetload()
        AU.AppUpdate()
        steploading.Enabled = False
        steploading.Stop()
    End Sub

    Private Sub splash_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.FromArgb(1, 105, 201), ButtonBorderStyle.Solid)
    End Sub
End Class