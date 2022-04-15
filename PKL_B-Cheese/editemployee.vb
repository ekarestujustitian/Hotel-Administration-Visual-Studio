Imports MySql.Data.MySqlClient
Public Class editemployee
    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "UPDATE dataadmin SET 
                        password = '" & TextBox2.Text & "', name = '" & TextBox3.Text & "',
                        noktp = '" & TextBox4.Text & "', placeofbirth = '" & TextBox5.Text & "',
                        dateofbirth = '" & DOBTimePicker.Text & "', position = '" & TextBox6.Text & "'
                        WHERE username='" & TextBox1.Text & "'"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data Pegawai berhasil di edit")
            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
        Visible = False
        Dim hotelmanagement As New hotelmanagement
        hotelmanagement.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Visible = False
        Dim hotelmanagement As New hotelmanagement
        hotelmanagement.Visible = True
    End Sub

End Class