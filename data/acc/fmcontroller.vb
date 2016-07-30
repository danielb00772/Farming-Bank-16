Imports FarmingBank.liveSync
Public Class fmcontroller
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


    'fmcontroller is an notification-system
    'fmcontroller(farming money controlling) 2016 v1.0
    'fmcontroller.vb is connected with : @fb16 and @addvehicle
    '---------------------------------------------------

    '==================
    'BEGIN FMCONTROLLER
    '==================


    '|      STRING COLLECTION
    '|      -----------------

    '| Form creation & multi line text for messages
    Dim FM_form As New Form
    Dim a As New RichTextBox

    '| String collection for Inbox Messages
    Dim FM_Isubj() As String =
    {
     "Welcome customer",
     "Loan information",
     "High Ammount detected . time to sell Crops",
     "Too much Investments token",
     "Time for a bigger trailer ?",
     "Low income detected"
    }
    Dim FM_Icont As String = "Farming Bank Support"
    Dim FM_Imessage() As String = {
    "Thank you for choosing Farming Bank! We are proud to have you here. Our Bank provides you with the best features for a happy experience.",
    "You can't borrow money. Make sure to pay it back soon."
    }
    Dim FM_opening As String = "Dear Mr/Mrs " + My.Settings.name + " ,"
    Dim FM_greets As String = "Sincely,  Farming Bank "

    '| Opens the 'mail -window' > Inbox 
    Public Sub MeClick()
        ' Set form property's of > FM_form
        FM_form.TopMost = True
        FM_form.ShowIcon = False
        FM_form.Controls.Add(a)
        FM_form.Padding = New Padding(10, 10, 10, 10)
        FM_form.Show()
        FM_form.AutoSize = True
        'Textbox property's of > a
        a.ReadOnly = True
        a.Dock = DockStyle.Fill
        a.BorderStyle = BorderStyle.FixedSingle

        If fb16.accIbox.CurrentRow().Cells(1).Value = FM_Isubj(0) Then
            FM_form.Text = FM_Isubj(0)
            a.AppendText(FM_opening + vbNewLine)
            a.AppendText("" + vbNewLine) 'Free space 
            a.AppendText(FM_Imessage(0) + vbNewLine)
            a.AppendText("" + vbNewLine) 'Free space 
            a.AppendText(FM_greets + vbNewLine)
        End If
        If fb16.accIbox.CurrentRow().Cells(1).Value = FM_Isubj(1) Then
            FM_form.Text = FM_Isubj(1)
            a.AppendText(FM_opening + vbNewLine)
            a.AppendText("" + vbNewLine) 'Free space 
            a.AppendText(FM_Imessage(1) + vbNewLine)
            a.AppendText("" + vbNewLine) 'Free space 
            a.AppendText(FM_greets + vbNewLine)
        End If
    End Sub
    '|The messages for the Inbox > activate
    Public Sub inbox()
        fb16.accIbox.Rows().Clear()
        'message > Welcome

        fb16.accIbox.Rows.Add(FM_Icont, FM_Isubj(0))

        'message > The loan
        If fb16.UIselector1.debtMess.Text = My.Settings.moneychar + "200000" + "  You can't borrow money. Make sure to pay it back soon ;)" Then
            fb16.accIbox.Rows.Add(FM_Icont, FM_Isubj(1))
        End If



    End Sub

    Public Sub f_detail()
        Dim e As String = fb16.Vehicle1.DataGridView1.Rows(0).ToString
        Dim dt As String = System.DateTime.Now.ToString

        fb16.Fdetails.ForeColor = Color.IndianRed
        fb16.Fdetails.AppendText("__________________________________________________" + vbNewLine)
        fb16.Fdetails.AppendText(dt + vbNewLine)
        fb16.Fdetails.AppendText("Your transaction at the Farmer Shop on: " + fb16.Minfo.Text + vbNewLine)
        fb16.Fdetails.AppendText(e + vbNewLine)
        fb16.Fdetails.AppendText(My.Settings.Asave + My.Settings.name + vbNewLine)
        fb16.Fdetails.AppendText("__________________________________________________" + vbNewLine)
    End Sub
End Class
