'Calvin Coxen
'RCET0265
'Fall 2020
'Address Label Form
'https://github.com/CalvinAC/AddressLabel

Option Explicit On
Option Strict On
Option Compare Binary


Public Class AdressLabelForm

    Function Verification() As Boolean
        Dim goodData, data As Boolean
        Dim zip As Integer

        'Verifies text boxes are not left empty by the user
        If FirstNameTextBox.Text = "" Then
            MsgBox("Enter first name")
        ElseIf LastNameTextBox.Text = "" Then
            MsgBox("Enter last name")
        ElseIf StreetAddressTextBox.Text = "" Then
            MsgBox("Enter street adress")
        ElseIf CityTextBox.Text = "" Then
            MsgBox("Enter city")
        ElseIf StateTextBox.Text = "" Then
            MsgBox("Enter state")
        ElseIf ZIPCodeTextBox.Text = "" Then
            MsgBox("Enter zipcode")
        Else
            goodData = True
        End If

        If goodData = False Then
            Exit Function
        End If

        'Verifies user entered an integer value for the zip code
        Try
            zip = CInt(ZIPCodeTextBox.Text)
            data = True
        Catch ex As Exception
            MsgBox("Zipcode should be numeric value")
            ZIPCodeTextBox.Clear()
        End Try

        Return goodData And data
    End Function
    Private Sub Display_Label_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click

        'Displays text entered by the user into the text box
        If Verification() = True Then
            AddressDisplayLabel.Text = (FirstNameTextBox.Text & vbNewLine &
            LastNameTextBox.Text & vbNewLine &
            StreetAddressTextBox.Text & vbNewLine &
            CityTextBox.Text & ", " & StateTextBox.Text & " " & ZIPCodeTextBox.Text)
        Else

        End If

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        'Clears the users input for new data
        FirstNameTextBox.Text = Nothing
        LastNameTextBox.Text = Nothing
        StreetAddressTextBox.Text = Nothing
        CityTextBox.Text = Nothing
        StateTextBox.Text = Nothing
        ZIPCodeTextBox.Text = Nothing

        AddressDisplayLabel.Text = Nothing
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
