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

Public Class usrsetload
    'Loads the program settings & checks the existing Paths
    'usersetload 2016 v1.0
    'usersetload() is connected with: splash.vb ,appsettings.vb and fb16.vb
    '------------------------------------------------------------------


    '======================================
    'Check and prepare the following steps:
    '======================================
    '1 || Check if a monitor session is saved
    Public Sub SlotSession()            ' ! : Slot session is offline ,omdat hier problemen opduiken. Als het geen Giants Map is dan Crasht het programma
        'Mform.Show()
        'Mform.MpData.Show()
        'fb16.Show()
        'Mform.Hide()

        ' Voor nood actief:
        Mform.Show()
        Mform.MpData.Show()
    End Sub
    '2 || Check for Updates (Hotfix,Fix,version(like 1.1), new version(like 2.0))
    Public Sub AppUpdate()
        Dim updatenotify As New Updatemodule()
        updatenotify.Main()
    End Sub
    '3 || Check if the wizard is completed. Even save, to reload a step if the user closes or abort.
    Public Sub WizardStep_check()
        If My.Settings.wizardsteps = True Then
            wfb_fuse.Show()

            splash.steploading.Enabled = False
            splash.steploading.Stop()
            splash.Hide()
        Else
            login_form.Show()
        End If
    End Sub

    '4 || Validating paths(game path, savegame path,auto-save mod)
    ' Public Sub ValidatePath_game()
    'If File.Exists("C:\Program Files (x86)\Farming Simulator 2015\x64\FarmingSimulator2015Game.exe") Or File.Exists("C:\Program Files (x86)\Steam\SteamApps\common\Farming Simulator 15\FarmingSimulator2015.exe") Then   'dvd version or Steam

    'Else
    ''    MsgBox("Farming Simulator 15 is not installed on this pc. Please install the game first. If the game is installed on a different pc in your LAN area then you can use this program externally", 16)
    ''  Application.Exit()
    ''End If
    ''End Sub
    '5 || Enable login , if checked in the app settings
    Public Sub BankAlias_login()
        If My.Settings.autologin = True Then
            Mform.Show()
            Mform.MpData.Show()
            login_form.Hide()
        End If
    End Sub
    '6 || other
    Public Sub oth()
        If My.Settings.maxset = True Then
            fb16.WindowState = FormWindowState.Maximized                                                    'Set's Farming Bank to maximized
            fb16.MaximumSize = Screen.FromRectangle(fb16.Bounds).WorkingArea.Size
        End If
        fb16.Button13.Text = My.Settings.name
        fb16.Pname.Text = My.Settings.name + " | Agriculture(Private Farmer)"
    End Sub
    '================================================================================================================
    'Load the settings of the application   -> appsettings.vb
    Public Sub app_set()
        '|| Loading values into the controls
        appsettings.Slanguage.Items.Add("English")
        appsettings.Slanguage.Items.Add("Deutsch")
        appsettings.Slanguage.Items.Add("Nederlands")
        appsettings.Smvalue.Items.Add("Euro")
        appsettings.Smvalue.Items.Add("Dollar")
        appsettings.Smvalue.Items.Add("Pound")
        appsettings.Sintf.Items.Add("Dark |Not available")
        appsettings.Sintf.Items.Add("Beauty Metallic")

        'General
        My.Settings.Reload()
        If My.Settings.languagesetEN = True Then
            appsettings.Slanguage.SelectedItem = "English"
        End If
        If My.Settings.languagesetDE = True Then
            appsettings.Slanguage.SelectedItem = "Deutsch"
        End If
        If My.Settings.languagesetNL = True Then
            appsettings.Slanguage.SelectedItem = "Nederlands"
        End If

        appsettings.Sintf.Text = "Beauty Metallic"
        'name
        appsettings.Sname.Text = My.Settings.name

        If My.Settings.eu = True Then
            appsettings.Smvalue.SelectedItem = "Euro"
        End If
        If My.Settings.pd = True Then
            appsettings.Smvalue.SelectedItem = "Pound"
        End If
        If My.Settings.dol = True Then
            appsettings.Smvalue.SelectedItem = "Dollar"
        End If
        ' savegame save
        If My.Settings.sessionsave = "0" Then
            appsettings.Sactsave.CheckState = CheckState.Unchecked
        Else
            appsettings.Sactsave.CheckState = CheckState.Checked
        End If
        ' Maximize property
        If My.Settings.maxset = True Then
            appsettings.Smax.CheckState = CheckState.Checked
        Else
            appsettings.Smax.CheckState = CheckState.Unchecked
        End If
        'Bank account
        appsettings.MaskedTextBox1.Text = My.Settings.Psave
        If My.Settings.autologin = True Then
            appsettings.Sautologin.CheckState = CheckState.Checked
        Else
            appsettings.Sautologin.CheckState = CheckState.Unchecked
        End If
        'Session sync intelligence
        If My.Settings.sync_i = True Then
            appsettings.Ssync1.Checked = True
        Else
            appsettings.Ssync1.Checked = False
        End If
        If My.Settings.sync_a = True Then
            appsettings.Ssync2.Checked = True
        Else
            appsettings.Ssync2.Checked = False
        End If
        If My.Settings.sync_m = True Then
            appsettings.Ssync3.Checked = True
        Else
            appsettings.Ssync3.Checked = False
        End If
        If My.Settings.ipadr = Nothing Then
            appsettings.Spath.Text = "Local path"
        Else
            appsettings.Spath.Text = My.Settings.ipadr + My.Settings.unet + "[Network location]"
        End If
    End Sub
    ' | Save/change Settings values of the application
    Public Sub app_set_save()
        'General
        If appsettings.Slanguage.Text = "Deutsch" Then
            My.Settings.languagesetDE = True
            My.Settings.Save()
        End If

        If appsettings.Smvalue.Text = "Euro" Then
            My.Settings.eu = True
            My.Settings.dol = False
            My.Settings.pd = False
            My.Settings.Save()
        End If
        If appsettings.Smvalue.Text = "Dollar" Then
            My.Settings.dol = True
            My.Settings.eu = False
            My.Settings.pd = False
            My.Settings.Save()
        End If
        If appsettings.Smvalue.Text = "Pound" Then
            My.Settings.pd = True
            My.Settings.dol = False
            My.Settings.eu = False
            My.Settings.Save()
        End If
        'name
        My.Settings.name = appsettings.Sname.Text

        If appsettings.Sactsave.CheckState = CheckState.Checked Then
            Dim m As String = Mform.MpData.CurrentRow.Cells(0).Value
            My.Settings.sessionsave = m
        Else
            My.Settings.sessionsave = "0"
        End If
        If appsettings.Smax.CheckState = CheckState.Checked Then
            My.Settings.maxset = True
        Else
            My.Settings.maxset = False
        End If

        'Bank account
        My.Settings.Psave = appsettings.MaskedTextBox1.Text
        If appsettings.Sautologin.CheckState = CheckState.Checked Then
            My.Settings.autologin = True
        Else
            My.Settings.autologin = False
        End If

        My.Settings.Save()
        My.Settings.Reload()

        'load some settings to get a live result
        Dim a As New usrsetload
        a.oth()
    End Sub


End Class
