Imports MySql.Data.MySqlClient

Public Class checkout
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "UPDATE datakamar SET roomstatus='available' WHERE roomnumber='" & RoomNumberComboBox.SelectedItem & "';
                    UPDATE datakustomer SET checkoutdate='" & CheckOutTimePicker.Text & "' WHERE roomnumber='" & RoomNumberComboBox.SelectedItem & "'"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Check out berhasil!")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim Query As String
            Query = "INSERT INTO catatankustomer (customername, feedback) VALUES ('" & CustomerNameTextBox.Text & "','" & FeedbackRichTextBox.Text & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Feedback tersimpan!")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True
    End Sub
End Class