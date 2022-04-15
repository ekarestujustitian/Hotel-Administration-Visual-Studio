<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FeedbackRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckOutTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(842, 86)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "b-cheese hotel"
        '
        'RoomNumberComboBox
        '
        Me.RoomNumberComboBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RoomNumberComboBox.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumberComboBox.FormattingEnabled = True
        Me.RoomNumberComboBox.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "106", "107", "108"})
        Me.RoomNumberComboBox.Location = New System.Drawing.Point(486, 184)
        Me.RoomNumberComboBox.Name = "RoomNumberComboBox"
        Me.RoomNumberComboBox.Size = New System.Drawing.Size(408, 51)
        Me.RoomNumberComboBox.Sorted = True
        Me.RoomNumberComboBox.TabIndex = 29
        Me.RoomNumberComboBox.Text = "  Choose Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 43)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Room Number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(960, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 56)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "check out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 43)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Feedback"
        '
        'FeedbackRichTextBox
        '
        Me.FeedbackRichTextBox.Location = New System.Drawing.Point(486, 402)
        Me.FeedbackRichTextBox.Name = "FeedbackRichTextBox"
        Me.FeedbackRichTextBox.Size = New System.Drawing.Size(1343, 322)
        Me.FeedbackRichTextBox.TabIndex = 32
        Me.FeedbackRichTextBox.Text = ""
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1600, 760)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(229, 56)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1535, 908)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(294, 56)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Main Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(411, 43)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Customer name"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(488, 289)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(1341, 48)
        Me.CustomerNameTextBox.TabIndex = 36
        '
        'CheckOutTimePicker
        '
        Me.CheckOutTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.CheckOutTimePicker.Font = New System.Drawing.Font("Wide Latin", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CheckOutTimePicker.Location = New System.Drawing.Point(1535, 53)
        Me.CheckOutTimePicker.Name = "CheckOutTimePicker"
        Me.CheckOutTimePicker.Size = New System.Drawing.Size(285, 30)
        Me.CheckOutTimePicker.TabIndex = 37
        '
        'checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PKL_B_Cheese.My.Resources.Resources._5e32eb9bab49fd706c6ef33b
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.CheckOutTimePicker)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FeedbackRichTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RoomNumberComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Out"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RoomNumberComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents FeedbackRichTextBox As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CheckOutTimePicker As DateTimePicker
End Class
