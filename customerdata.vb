Imports MySql.Data.MySqlClient

Public Class customerdata
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim SDA As New MySqlDataAdapter
    Dim dbDataSet As New DataTable
    Dim bsource As New BindingSource

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM datakustomer"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataSet)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

        End If
    End Sub

    Private Sub SearchButton_Click_1(sender As Object, e As EventArgs) Handles SearchButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM datakustomer WHERE customername LIKE '%" & SearchTextBox.Text & "%' OR customerid LIKE '%" & SearchTextBox.Text & "%'"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataSet)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT * FROM datakustomer WHERE checkindate = '" & DateTimePicker1.Text & "'"
            command = New MySqlCommand(Query, connection)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataSet)

            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub
End Class