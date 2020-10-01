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
        Me.First_Name = New System.Windows.Forms.TextBox()
        Me.Last_Name = New System.Windows.Forms.TextBox()
        Me.Street_Address = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.State = New System.Windows.Forms.TextBox()
        Me.Address_Display = New System.Windows.Forms.Label()
        Me.ZIP_Code = New System.Windows.Forms.TextBox()
        Me.Display_Label = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_Name
        '
        Me.First_Name.Location = New System.Drawing.Point(48, 42)
        Me.First_Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.First_Name.Multiline = True
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Size = New System.Drawing.Size(202, 25)
        Me.First_Name.TabIndex = 0
        '
        'Last_Name
        '
        Me.Last_Name.Location = New System.Drawing.Point(48, 84)
        Me.Last_Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Last_Name.Multiline = True
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.Size = New System.Drawing.Size(202, 25)
        Me.Last_Name.TabIndex = 1
        '
        'Street_Address
        '
        Me.Street_Address.Location = New System.Drawing.Point(48, 126)
        Me.Street_Address.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Street_Address.Multiline = True
        Me.Street_Address.Name = "Street_Address"
        Me.Street_Address.Size = New System.Drawing.Size(202, 25)
        Me.Street_Address.TabIndex = 2
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(48, 171)
        Me.City.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.City.Multiline = True
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(202, 25)
        Me.City.TabIndex = 3
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(48, 219)
        Me.State.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.State.Multiline = True
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(98, 25)
        Me.State.TabIndex = 4
        '
        'Address_Display
        '
        Me.Address_Display.Location = New System.Drawing.Point(342, 36)
        Me.Address_Display.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Address_Display.Name = "Address_Display"
        Me.Address_Display.Size = New System.Drawing.Size(303, 229)
        Me.Address_Display.TabIndex = 5
        '
        'ZIP_Code
        '
        Me.ZIP_Code.Location = New System.Drawing.Point(48, 265)
        Me.ZIP_Code.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ZIP_Code.Multiline = True
        Me.ZIP_Code.Name = "ZIP_Code"
        Me.ZIP_Code.Size = New System.Drawing.Size(98, 25)
        Me.ZIP_Code.TabIndex = 6
        '
        'Display_Label
        '
        Me.Display_Label.Location = New System.Drawing.Point(342, 342)
        Me.Display_Label.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Display_Label.Name = "Display_Label"
        Me.Display_Label.Size = New System.Drawing.Size(84, 75)
        Me.Display_Label.TabIndex = 7
        Me.Display_Label.Text = "Display Label"
        Me.Display_Label.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(448, 342)
        Me.Clear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(84, 75)
        Me.Clear.TabIndex = 8
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(561, 342)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(84, 75)
        Me.Exit_Button.TabIndex = 9
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Street Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "State" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ZIP Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.First_Name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Last_Name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Street_Address)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.City)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.State)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ZIP_Code)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 300)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AdressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Display_Label)
        Me.Controls.Add(Me.Address_Display)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AdressLabelForm"
        Me.Text = "Address Label Viewer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents First_Name As TextBox
    Friend WithEvents Last_Name As TextBox
    Friend WithEvents Street_Address As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents State As TextBox
    Friend WithEvents Address_Display As Label
    Friend WithEvents ZIP_Code As TextBox
    Friend WithEvents Display_Label As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
