Imports MySql.Data.MySqlClient

Public Class checkin
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim roomprice As Integer
    Dim roomxtimeprice As Integer

    Private Sub RoomNumberComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomNumberComboBox.SelectedIndexChanged
        If (RoomNumberComboBox.SelectedItem = 101) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Royal Room".ToString
            roomprice = 2654000
        ElseIf (RoomNumberComboBox.SelectedItem = 102) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Royal Room".ToString
            roomprice = 2654000

        ElseIf (RoomNumberComboBox.SelectedItem = 103) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomprice = 1340000

        ElseIf (RoomNumberComboBox.SelectedItem = 104) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomprice = 1340000

        ElseIf (RoomNumberComboBox.SelectedItem = 105) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomprice = 1340000

        Else
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Premium Room".ToString
            roomprice = 764000
        End If
    End Sub

    Private Sub StayTimeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StayTimeComboBox.SelectedIndexChanged
        roomxtimeprice = StayTimeComboBox.SelectedItem * roomprice
        RoomPriceTextBox.Text = roomxtimeprice.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim Query As String
            Query = "UPDATE datakamar SET status='BOOK' WHERE roomnumber='" & RoomNumberComboBox.SelectedItem & "';
                    INSERT INTO datakustomer(
                    customername, customerid, roomnumber, staytime , address, phonenumber, totalprice,
                    driverservice, rentalservice, tourguideservice
                    ) VALUES (
                    '" & CustomerNameTextbox.Text & "', '" & CustomerIDTextbox.Text & "',
                    '" & RoomNumberComboBox.SelectedItem & "', '" & StayTimeComboBox.SelectedItem & "',
                    '" & AddressTextbox.Text & "', '" & PhoneNumberTextBox.Text & "',
                    '" & RoomPriceTextBox.Text & "','-', '-', '-'
                    )"
            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data telah tersimpan")
            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try

        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True
    End Sub


End Class