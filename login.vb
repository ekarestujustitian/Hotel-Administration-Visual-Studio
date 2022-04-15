Imports MySql.Data.MySqlClient

Public Class login
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
            Query = "SELECT * FROM dataadmin WHERE username='" & TextBox1.Text & "' AND password= '" & TextBox2.Text & "'"
            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username dan password benar. Selamat datang ")
                Dim mainmenu As New mainmenu
                mainmenu.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Tidak dapat login sekarang. Username sedang digunakan")
            Else
                MessageBox.Show("Username atau password salah. Silahkan coba lagi")
                TextBox1.ResetText()
                TextBox2.ResetText()
            End If


            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
