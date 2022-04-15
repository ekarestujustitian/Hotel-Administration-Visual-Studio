Imports MySql.Data.MySqlClient


Public Class checkin
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Dim roomclassprice As Integer
    Dim roomxtimeprice As Integer

    Private Sub RoomNumberComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomNumberComboBox.SelectedIndexChanged
        If (RoomNumberComboBox.SelectedItem = 101) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Royal Room".ToString
            roomclassprice = 2654000

        ElseIf (RoomNumberComboBox.SelectedItem = 102) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Royal Room".ToString
            roomclassprice = 2654000

        ElseIf (RoomNumberComboBox.SelectedItem = 103) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomclassprice = 1340000

        ElseIf (RoomNumberComboBox.SelectedItem = 104) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomclassprice = 1340000

        ElseIf (RoomNumberComboBox.SelectedItem = 105) Then
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Luxury Room".ToString
            roomclassprice = 1340000

        Else
            StatusTextBox.ResetText()
            RoomClassTextbox.ResetText()

            StatusTextBox.Text = "BOOK".ToString
            RoomClassTextbox.Text = "Premium Room".ToString
            roomclassprice = 764000

        End If
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT roomstatus FROM datakamar WHERE roomnumber='" & RoomNumberComboBox.SelectedItem & "' AND roomstatus='available'"
            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While

            If count = 0 Then
                MessageBox.Show("Kamar yang anda pilih tidak tersedia!")

            Else
                MessageBox.Show("Kamar yang anda pilih tersedia!")
            End If


            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub StayTimeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StayTimeComboBox.SelectedIndexChanged
        roomxtimeprice = StayTimeComboBox.SelectedItem * roomclassprice
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
            Query = "UPDATE datakamar SET roomstatus='BOOK' WHERE roomnumber='" & RoomNumberComboBox.SelectedItem & "';
                        INSERT INTO datakustomer(
                        checkindate, customername, customerid, roomnumber, roomclass, staytime , address, phonenumber, roomprice, serviceprice, totalprice
                        ) VALUES (
                        '" & CheckInTimePicker.Text & "','" & CustomerNameTextbox.Text & "', '" & CustomerIDTextbox.Text & "',
                        '" & RoomNumberComboBox.SelectedItem & "', '" & RoomClassTextbox.Text & "', '" & StayTimeComboBox.SelectedItem & "',
                        '" & AddressTextbox.Text & "', '" & PhoneNumberTextBox.Text & "',
                        '" & RoomPriceTextBox.Text & "', '0', '0'
                        )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data telah tersimpan")
            connection.Close()

            If (ServiceComboBox.SelectedItem = "NO") Then
                Visible = False
                Dim payment As New payment
                payment.Visible = True

            Else
                Visible = False
                Dim service As New service
                service.Visible = True

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True

    End Sub

End Class