Imports MySql.Data.MySqlClient

Public Class servicepayment
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim SDA As New MySqlDataAdapter
    Dim dbDataSet As New DataTable
    Dim bsource As New BindingSource

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"

        Try
            connection.Open()
            Dim Query As String
            Query = "SELECT SUM(roomserviceprice + extraserviceprice) AS TOTAL FROM dataservis WHERE serviceid='" & TextBox2.Text & "'"
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

            TextBox1.Text = row.Cells("TOTAL").Value.ToString

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "UPDATE datakustomer SET serviceprice='" & TextBox1.Text & "' WHERE roomnumber='" & TextBox3.Text & "';"
            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Service Confirmed")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
        Visible = False
        Dim service As New service
        service.Visible = False

        Dim payment As New payment
        payment.Visible = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "DELETE FROM dataservice WHERE serviceid='" & TextBox2.Text & "'"
            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Service Canceled")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
        Visible = False
        Dim service As New service
        service.Visible = False
        Dim payment As New payment
        payment.Visible = True
    End Sub
End Class