<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdressLabelForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.AddressDisplayLabel = New System.Windows.Forms.Label()
        Me.ZIPCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayLabelButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddressGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(96, 81)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(400, 44)
        Me.FirstNameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNameTextBox, "Type your first name")
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(96, 162)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(400, 44)
        Me.LastNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastNameTextBox, "Type your last name")
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(96, 242)
        Me.StreetAddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StreetAddressTextBox.Multiline = True
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(400, 44)
        Me.StreetAddressTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.StreetAddressTextBox, "Type your street")
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(96, 329)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CityTextBox.Multiline = True
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(400, 44)
        Me.CityTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Type your city")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(96, 421)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StateTextBox.Multiline = True
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(192, 44)
        Me.StateTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Type your state")
        '
        'AddressDisplayLabel
        '
        Me.AddressDisplayLabel.AccessibleDescription = ""
        Me.AddressDisplayLabel.Location = New System.Drawing.Point(684, 69)
        Me.AddressDisplayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressDisplayLabel.Name = "AddressDisplayLabel"
        Me.AddressDisplayLabel.Size = New System.Drawing.Size(606, 440)
        Me.AddressDisplayLabel.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.AddressDisplayLabel, "Addres will be displayed here when ""Dispaly Label"" is clicked")
        '
        'ZIPCodeTextBox
        '
        Me.ZIPCodeTextBox.Location = New System.Drawing.Point(96, 510)
        Me.ZIPCodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ZIPCodeTextBox.Multiline = True
        Me.ZIPCodeTextBox.Name = "ZIPCodeTextBox"
        Me.ZIPCodeTextBox.Size = New System.Drawing.Size(192, 44)
        Me.ZIPCodeTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ZIPCodeTextBox, "Type your zipcode")
        '
        'DisplayLabelButton
        '
        Me.DisplayLabelButton.Location = New System.Drawing.Point(684, 658)
        Me.DisplayLabelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayLabelButton.Name = "DisplayLabelButton"
        Me.DisplayLabelButton.Size = New System.Drawing.Size(168, 144)
        Me.DisplayLabelButton.TabIndex = 7
        Me.DisplayLabelButton.Text = "Display Label"
        Me.ToolTip1.SetToolTip(Me.DisplayLabelButton, "Press to Display  address")
        Me.DisplayLabelButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(896, 658)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(168, 144)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Press to erase")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(1122, 658)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(168, 144)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click to exit or hit escape")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Street Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 394)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "State" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 483)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ZIP Code"
        '
        'AddressGroupBox
        '
        Me.AddressGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label7)
        Me.AddressGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label6)
        Me.AddressGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label5)
        Me.AddressGroupBox.Controls.Add(Me.CityTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label4)
        Me.AddressGroupBox.Controls.Add(Me.StateTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label3)
        Me.AddressGroupBox.Controls.Add(Me.ZIPCodeTextBox)
        Me.AddressGroupBox.Controls.Add(Me.Label2)
        Me.AddressGroupBox.Location = New System.Drawing.Point(28, 69)
        Me.AddressGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressGroupBox.Name = "AddressGroupBox"
        Me.AddressGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.AddressGroupBox.Size = New System.Drawing.Size(614, 577)
        Me.AddressGroupBox.TabIndex = 16
        Me.AddressGroupBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.AddressGroupBox, "Enter your Information in the boxed below")
        '
        'AdressLabelForm
        '
        Me.AcceptButton = Me.DisplayLabelButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1440, 894)
        Me.Controls.Add(Me.AddressGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayLabelButton)
        Me.Controls.Add(Me.AddressDisplayLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdressLabelForm"
        Me.Text = "Address Label Viewer"
        Me.AddressGroupBox.ResumeLayout(False)
        Me.AddressGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents AddressDisplayLabel As Label
    Friend WithEvents ZIPCodeTextBox As TextBox
    Friend WithEvents DisplayLabelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
