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
Public Class appsettings

    Private Sub appsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'User & application settings
        Dim su As New usrsetload()
        su.app_set()
        'license load
        Me.RichTextBox1.LoadFile("COPYING.rtf", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.settingTabs.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.settingTabs.SelectedIndex = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.settingTabs.SelectedIndex = 2
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Slanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Slanguage.SelectedIndexChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Ssaveall.Click
        Dim su As New usrsetload()
        su.app_set_save()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        netdiv.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.settingTabs.SelectedIndex = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ft_command As New RichTextBox
        Dim factory As New Form
        factory.Text = "wait.."
        factory.TopMost = True
        factory.AutoSize = True

        factory.Controls.Add(ft_command)
        ft_command.Dock = DockStyle.Fill
        ft_command.AppendText("Back to factory ..")
        ft_command.ForeColor = Color.White
        ft_command.BackColor = Color.Black


        Dim w As New liveSync
        w.stop_session()

        fb16.Close()
        login_form.Show()

        ' settings on default
        My.Settings.Reset()
        MsgBox("Click 'OK' to restart application", MsgBoxStyle.Information)
        Application.Restart()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class