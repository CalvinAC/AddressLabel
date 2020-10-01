'Calvin Coxen
'RCET0265
'Fall 2020
'Address Label Form


Option Explicit On
Option Strict On






Public Class AdressLabelForm



    Private Sub Display_Label_Click(sender As Object, e As EventArgs) Handles Display_Label.Click

        Dim addressLabelString As New List(Of String)

        addressLabelString.Add(First_Name.Text & " ")
        addressLabelString.Add(Last_Name.Text & " ")
        addressLabelString.Add(Street_Address.Text & " ")
        addressLabelString.Add(City.Text & ",")
        addressLabelString.Add(State.Text & " ")
        addressLabelString.Add(ZIP_Code.Text)


        Address_Display.Text = (addressLabelString(0) & addressLabelString(1) & vbNewLine & addressLabelString(2) & vbNewLine & addressLabelString(3) & addressLabelString(4) & addressLabelString(5))



    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click

        First_Name.Text = " "
        Last_Name.Text = " "
        Street_Address.Text = " "
        City.Text = " "
        State.Text = " "
        ZIP_Code.Text = " "

        Address_Display.Text = " "
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
