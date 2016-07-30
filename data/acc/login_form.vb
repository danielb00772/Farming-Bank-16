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
Imports System.ComponentModel

Public Class login_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '| Check if login data is valid
        If TextBox1.Text = My.Settings.Asave And TextBox2.Text = My.Settings.Psave Then
            Mform.Show()
            Mform.MpData.Show()


            '| load some settings from usrsetload.vb
            If My.Settings.sessionsave = "0" Then
                Mform.Show()
                Mform.MpData.Show()
                Me.Hide()
            Else
                Dim f As New usrsetload
                f.SlotSession()
                Me.Hide()
            End If

        Else
            MsgBox("Login incorrect. Please try again", 16)
        End If


    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Starting the Back worker > progress
        progress.RunWorkerAsync()
        '| load saved settings

        LgnAlias.Text = My.Settings.Asave
        LgnPIN.Text = My.Settings.Psave


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '====  Account Alias creation

        '| Select an array for the alias . This happends random
        Dim myRnd As New Random
        Dim Aliastemplate() As String = {
            "$fHBB9Iua100",
            "4598G#sJnmmT",
            "TqqAAscxY0ui",
            "U722QhiiQ9!a",
            "SxXla!@sW3hh",
            "A@@1Hbc76017",
            "09D($xXnkLqW",
            "&uYtTtpWNmvx",
            "9001Qad?xcDD",
            "0Pqw@@dsHKnm",
            "56P%5dsQopxC"
        }
        LgnAlias.Text = Aliastemplate(myRnd.Next(7))

        '| rerange the selected array Dynamically & complete Random to get a Unique Alias 
        Dim r As New Random
        LgnAlias.Text = New String(LgnAlias.Text.ToCharArray.OrderBy(Function(c) r.NextDouble).ToArray) ' Alias code rerange dynamically

        '====




        Button3.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        wfb_fuse.Enabled = True


        'save the Alias & PIN
        My.Settings.Asave = LgnAlias.Text
        My.Settings.Psave = LgnPIN.Text
        My.Settings.wizardsteps = False                 ' Disable the wizard
        My.Settings.Save()
        My.Settings.Reload()

        wfb_fuse.W3step4.Image = My.Resources.checked_green_icon
        wfb_fuse.Wcancel.Hide()
        wfb_fuse.Button4.Show()


        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub login_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            splash.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim t1 As String = "ALIAS:" + LgnAlias.Text + "PIN:" + LgnPIN.Text


        Clipboard.Clear()
        Clipboard.SetText(t1)
    End Sub

    Private Sub progress_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles progress.DoWork
        ' time-consuming
        Dim f As New Form
        Dim h As New ProgressBar
        Dim n As New Label


        f.Show()
        f.Controls.Add(n)
        f.Controls.Add(h)

        n.Text = "Bitte warten..."

    End Sub

    Private Sub progress_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles progress.RunWorkerCompleted
        loadindicator.Hide()
    End Sub
End Class