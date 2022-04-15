Imports MySql.Data.MySqlClient

Public Class addemployee
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
            Query = "INSERT INTO dataadmin(
                        username, password, name, noktp, placeofbirth, dateofbirth, position
                        ) VALUES (
                        '" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox3.Text & "',
                        '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & DOBTimePicker.Text & "' ,'" & TextBox6.Text & "'
                        )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Pegawai ditambahkan")
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