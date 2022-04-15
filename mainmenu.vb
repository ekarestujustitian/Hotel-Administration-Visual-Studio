Public Class mainmenu


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedItem = "Check In" Then
            Dim checkin As New checkin
            checkin.Show()
            Visible = False

        ElseIf ComboBox1.SelectedItem = "Check Room" Then
            Dim checkroom As New checkroom
            checkroom.Show()
            Visible = False

        ElseIf ComboBox1.SelectedItem = "Service" Then
            Dim service As New service
            service.Show()
            Visible = False

        ElseIf ComboBox1.SelectedItem = "Check Out" Then
            Dim checkout As New checkout
            checkout.Show()
            Visible = False

        ElseIf ComboBox1.SelectedItem = "Customer Data" Then
            Dim customerdata As New customerdata
            customerdata.Show()
            Visible = False

        ElseIf ComboBox1.SelectedItem = "Hotel Management" Then
            Dim hotelmanagement As New hotelmanagement
            hotelmanagement.Show()
            Visible = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
        Dim login As New login
        login.Show()
        Me.Hide()

    End Sub

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class