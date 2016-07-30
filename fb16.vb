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
Option Explicit On
Option Strict On
Imports System.Drawing
Imports System.IO
Imports System.Data
Public Class fb16
    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer

    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point

    Private Sub farmingbank_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadindicator.Show()
        Dim j As New usrsetload
        j.oth()
        Me.MinimumSize = New Size(800, 600)
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub money_Tick(sender As Object, e As EventArgs) Handles bigSync.Tick
        Status_i.Text = "Try to Sync .."

        ' load the modules of LiveSync
        Dim gi_trigger As New liveSync()
        gi_trigger.g_information()

        Dim m_trigger As New liveSync()
        m_trigger.money_module()

        Dim chart_trigger As New liveSync()
        chart_trigger.uiselector_module()

        Dim animals_trigger As New liveSync()
        animals_trigger.animals_module()

        Dim vehicle_trigger As New liveSync()
        vehicle_trigger.vehicle_module()

        Dim bale_trigger As New liveSync()
        bale_trigger.bale_module()

        Dim moneyV As New liveSync()
        moneyV.moneyVal()
        'END
        Dim ts As New liveSync
        ts.totalsum()
        If My.Settings.sync_a = True Then
            Status_i.Text = "Session created succesfully " + " |Sync.Setting: Always" + My.Settings.ipadr + My.Settings.unet
        End If
        If My.Settings.sync_m = True Then
            Status_i.Text = "Session created succesfully " + " |Sync.Setting: Manually" + My.Settings.ipadr + My.Settings.unet
        End If
        If My.Settings.sync_i = True Then
            Status_i.Text = "Session created succesfully " + " |Sync.Setting: Intelligent" + My.Settings.ipadr + My.Settings.unet
        End If

        Status_i.ForeColor = Color.FromArgb(64, 64, 64)
        fbStatus.BackColor = Color.YellowGreen
        Button10.Enabled = True
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles borderR.Paint
        ' ControlPaint.DrawBorder(e.Graphics, borderR.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Panel3_Resize(sender As Object, e As EventArgs) Handles borderR.Resize
        Invalidate()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles fbTitlebar.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grip_MouseDown(sender As Object, e As MouseEventArgs) Handles grip.MouseDown
        If e.Button = MouseButtons.Left Then    'If the control is being left-clicked
            GripDrag = True                     'Confirms the grip is ready to be dragged
            Me.SuspendLayout()
            Me.Opacity = 0.7
            InitialSizeX = Me.Width             'Sets the initial width
            InitialSizeY = Me.Height            'Sets the initial height
        End If
    End Sub
    Private Sub grip_MouseMove(sender As Object, e As MouseEventArgs) Handles grip.MouseMove
        If GripDrag = True Then
            Me.Width = InitialSizeX + (Cursor.Position.X - (Me.Width + Me.Location.X)) 'Increases the width of the form by the amount the grip has been dragged towards the right
            Me.Height = InitialSizeY + (Cursor.Position.Y - (Me.Height + Me.Location.Y)) 'Increases the height of the form by the amount the grip has been dragged downward

            InitialSizeX = Me.Width 'Resets the value to the form's current width
            InitialSizeY = Me.Height 'Resets the value to the form's current height


            Me.Refresh()
        End If
    End Sub

    Private Sub grip_MouseUp(sender As Object, e As MouseEventArgs) Handles grip.MouseUp
        GripDrag = False 'Confirms the grip is no longer being dragged
        Me.Opacity = 1
        Me.ResumeLayout()
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles fbTitlebar.Paint

    End Sub

    Private Sub fbTitlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles fbTitlebar.MouseMove
        If allowCoolMove = True Then
            Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub fbTitlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles fbTitlebar.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Wclose_Click(sender As Object, e As EventArgs) Handles Wclose.Click
        splash.Close()
    End Sub

    Private Sub fbTitlebar_DoubleClick(sender As Object, e As EventArgs) Handles fbTitlebar.DoubleClick
        If Me.WindowState = FormWindowState.Maximized = False Then
            Me.WindowState = FormWindowState.Maximized
            borderR.Invalidate()
        Else
            Me.WindowState = FormWindowState.Normal
            borderR.Invalidate()
        End If
    End Sub

    Private Sub Wmin_Click(sender As Object, e As EventArgs) Handles Wmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Wmax_Click(sender As Object, e As EventArgs) Handles Wmax.Click
        If Me.WindowState = FormWindowState.Maximized = False Then
            Me.WindowState = FormWindowState.Maximized
            borderR.Invalidate()
        Else
            Me.WindowState = FormWindowState.Normal
            borderR.Invalidate()
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Stp_trigger As New liveSync
        Stp_trigger.stop_session()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Hm1.Click
        Me.fbTabcontainers.SelectedIndex = 0
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.fbTabcontainers.SelectedIndex = 2
    End Sub

    Private Sub Hm2_Click(sender As Object, e As EventArgs) Handles Hm2.Click
        Me.fbTabcontainers.SelectedIndex = 1
    End Sub

    Private Sub fbNewSession_Click(sender As Object, e As EventArgs) Handles fbNewSession.Click
        Dim str_trigger As New liveSync
        str_trigger.gen_session()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        appsettings.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If FbUser.Visible = False Then
            UIselector1.Hide()
            Mbarspanel.Hide()
            fbTabcontainers.Enabled = False
            FbUser.Show()
            FbUser.Dock = DockStyle.Fill
            bigSync.Enabled = False
            bigSync.Stop()
            Status_i.Text = "Syncronisation | Break mode"
            Lsvisual.Hide()
            Status_i.ForeColor = Color.FromArgb(107, 204, 238)
            fbStatus.BackColor = Color.FromArgb(51, 102, 153)
            My.Settings.Reload()
            Button5.Text = My.Settings.moneychar
        Else
            bigSync.Enabled = True
            bigSync.Start()
            FbUser.Hide()
            UIselector1.Show()
            Mbarspanel.Show()
            Lsvisual.Show()
            fbTabcontainers.Enabled = True
        End If
    End Sub

    Private Sub user_out_Click(sender As Object, e As EventArgs) Handles user_out.Click
        login_form.Show()
        Me.Hide()
        MsgBox("Succesfully Signed Out")
    End Sub

    Private Sub FbUser_Paint(sender As Object, e As PaintEventArgs) Handles FbUser.Paint

    End Sub

    Private Sub fb16_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.FromArgb(1, 105, 201), ButtonBorderStyle.Solid)
    End Sub

    Private Sub fb16_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Invalidate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bigSync.Enabled = True
        bigSync.Start()
        FbUser.Hide()
        UIselector1.Show()
        Mbarspanel.Show()
        fbTabcontainers.Enabled = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim w As New fmcontroller
        w.inbox()
    End Sub

    Private Sub accIbox_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles accIbox.CellContentClick

    End Sub

    Private Sub accIbox_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles accIbox.CellClick
        ' Make row content clickable to open mails
        Dim s As New fmcontroller
        s.MeClick()
    End Sub

    Private Sub mailsync_Tick(sender As Object, e As EventArgs) Handles mailsync.Tick
        mail_ncount.Visible = True
        ' Load fmcontroller for the bank-account
        Dim Ibox As New fmcontroller
        Ibox.inbox()

        Dim i As String = CType(accIbox.Rows().Count(), String)
        mail_ncount.Text = i
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        '| Export Vehicle List
        Ev.ShowDialog()

    End Sub

    Private Sub Ev_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ev.FileOk

        Dim f As String = Ev.FileName
        Dim g As String = Vehicle1.DataGridView1.Rows(0).Cells(0).RowIndex.ToString

        Dim objwriter As New System.IO.StreamWriter(f)
        objwriter.Write(g)
        objwriter.Close()

    End Sub
End Class