'Calvin Coxen
'RCET0265
'Fall 2020
'Address Label Form
'https://github.com/CalvinAC/AddressLabel

Option Explicit On
Option Strict On


Public Class AdressLabelForm

    'Displays text entered by the user into the text box
    Private Sub Display_Label_Click(sender As Object, e As EventArgs) Handles Display_Label.Click

        Dim addressLabelString As New List(Of String)
        addressLabelString.Add(First_Name.Text & " ")
        addressLabelString.Add(Last_Name.Text & " ")
        addressLabelString.Add(Street_Address.Text & " ")
        addressLabelString.Add(City.Text & ",")
        addressLabelString.Add(State.Text & " ")
        addressLabelString.Add(ZIP_Code.Text)

        'Check that all text boxes have a value otherwise do not display and alert user-TJR
        Address_Display.Text = (addressLabelString(0) & addressLabelString(1) & vbNewLine & addressLabelString(2) & vbNewLine & addressLabelString(3) & addressLabelString(4) & addressLabelString(5))

    End Sub

    'Clears the users input for new data
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        'Empty strings do not contain space - TJR
        First_Name.Text = " "
        Last_Name.Text = " "
        Street_Address.Text = " "
        City.Text = " "
        State.Text = " "
        ZIP_Code.Text = " "

        Address_Display.Text = " "
    End Sub

    'Exits the program
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

End Class
