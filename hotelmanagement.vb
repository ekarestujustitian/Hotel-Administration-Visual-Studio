Imports MySql.Data.MySqlClient

Public Class hotelmanagement
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim SDA As New MySqlDataAdapter
    Dim SDA2 As New MySqlDataAdapter
    Dim dbDataSet As New DataTable
    Dim dbDataSet2 As New DataTable
    Dim bsource As New BindingSource
    Dim bsource2 As New BindingSource

    Private Sub CheckIncomesButton_Click(sender As Object, e As EventArgs) Handles CheckIncomesButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT COUNT(customername) AS TotalCustomer,SUM(totalprice) AS TotalIncomes FROM datakustomer;"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            DataGridView2.DataSource = bsource
            SDA.Update(dbDataSet)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM dataadmin"
            command = New MySqlCommand(Query, connection)
            SDA2.SelectCommand = command
            SDA2.Fill(dbDataSet2)
            bsource2.DataSource = dbDataSet2
            DataGridView1.DataSource = bsource2
            SDA2.Update(dbDataSet2)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM dataadmin WHERE username LIKE '%" & SearchTextBox.Text & "%' OR name LIKE '%" & SearchTextBox.Text & "%'"
            command = New MySqlCommand(Query, connection)
            SDA2.SelectCommand = command
            SDA2.Fill(dbDataSet2)
            bsource2.DataSource = dbDataSet2
            DataGridView1.DataSource = bsource2
            SDA2.Update(dbDataSet2)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Visible = False

        Dim addemployee As New addemployee
        addemployee.Visible = True

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        Visible = False

        Dim editemployee As New editemployee
        editemployee.Visible = True

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Visible = False

        Dim deleteemployee As New deleteemployee
        deleteemployee.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "INSERT INTO catatankustomer (note) VALUES ('" & RichTextBox1.Text & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data telah tersimpan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub
End Class