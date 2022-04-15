Imports MySql.Data.MySqlClient

Public Class service
    Dim connection As MySqlConnection
    Dim command As MySqlCommand



    Private Sub BreakfastButton_Click(sender As Object, e As EventArgs) Handles BreakfastButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If BreakfastComboBox.SelectedItem = "Premium Breakfast" Then
                price = 75000
                serviceprice = price * BreakfastTextBox.Text
            Else
                price = 170000
                serviceprice = price * BreakfastTextBox.Text
            End If

            serviceprice = price * BreakfastTextBox.Text

            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '" & BreakfastComboBox.SelectedItem & "',
            '" & BreakfastTextBox.Text & "',
            '" & price & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0','" & serviceprice & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','0'

            )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub FoodsButton_Click(sender As Object, e As EventArgs) Handles FoodsButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If FoodComboBox.SelectedItem = "Fried Rice" Then
                price = 27000
                serviceprice = price * FoodsTextBox.Text
            Else
                price = 17000
                serviceprice = price * FoodsTextBox.Text
            End If

            serviceprice = price * FoodsTextBox.Text

            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '" & FoodComboBox.SelectedItem & "',
            '" & FoodsTextBox.Text & "',
            '" & price & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','" & serviceprice & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','0'
            )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub BeveragesButton_Click(sender As Object, e As EventArgs) Handles BeveragesButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If BeveragesComboBox.SelectedItem = "Orange Juice" Then
                price = 9000
                serviceprice = price * BeveragesTextBox.Text
            Else
                price = 7000
                serviceprice = price * BeveragesTextBox.Text
            End If


            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '" & BeveragesComboBox.SelectedItem & "',
            '" & BeveragesTextBox.Text & "',
            '" & price & "',
            '0','0','0',
            '0','0','0','" & serviceprice & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','0'
            
            )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub ExtraBedButton_Click(sender As Object, e As EventArgs) Handles ExtraBedButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If ExtraBedComboBox.SelectedItem = "Single Bed" Then
                price = 120000
                serviceprice = price * ExtraBedTextBox.Text
            Else
                price = 220000
                serviceprice = price * ExtraBedTextBox.Text
            End If



            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '" & ExtraBedComboBox.SelectedItem & "',
            '" & ExtraBedTextBox.Text & "',
            '" & price & "',
            '0','0','0','" & serviceprice & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','0'
            )"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub OthersButton_Click(sender As Object, e As EventArgs) Handles OthersButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If OthersComboBox.SelectedItem = "Pillow" Then
                price = 50000
                serviceprice = price * OthersTextBox.Text
            Else
                price = 60000
                serviceprice = price * OthersTextBox.Text
            End If



            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '" & OthersComboBox.SelectedItem & "',
            '" & OthersTextBox.Text & "',
            '" & price & "',
            '" & serviceprice & "',
            '0','0','0',
            '0','0','0',
            '0','0','0','0')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub DriverServiceButton_Click(sender As Object, e As EventArgs) Handles DriverServiceButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If DriverServiceComboBox.SelectedItem = "I Made Bali" Then
                price = 350000
                serviceprice = price * DriverServiceTextBox.Text
            Else
                price = 350000
                serviceprice = price * DriverServiceTextBox.Text
            End If



            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0','0',
            '" & DriverServiceComboBox.SelectedItem & "',
            '" & DriverServiceTextBox.Text & "',
            '" & price & "',
            '0','0','0',
            '0','0','0',
            '" & serviceprice & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub RentalServiceButton_Click(sender As Object, e As EventArgs) Handles RentalServiceButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If RentalServiceComboBox.SelectedItem = "Car" Then
                price = 770000
                serviceprice = price * RentalServiceTextBox.Text

            ElseIf RentalServiceComboBox.SelectedItem = "Motorcycle" Then
                price = 140000
                serviceprice = price * RentalServiceTextBox.Text

            Else
                price = 35000
                serviceprice = price * RentalServiceTextBox.Text
            End If



            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0','0',
            '0','0','0',
            '" & RentalServiceComboBox.SelectedItem & "',
            '" & RentalServiceTextBox.Text & "', 
            '" & price & "',
            '0','0','0',
            '" & serviceprice & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub TourGuideServiceButton_Click(sender As Object, e As EventArgs) Handles TourGuideServiceButton.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Dim price As Integer
            Dim serviceprice As Integer

            If TourGuideServiceComboBox.SelectedItem = "Armin Arlert" Then
                price = 770000
                serviceprice = price * TourGuideServiceTextBox.Text
            Else
                price = 35000
                serviceprice = price * TourGuideServiceTextBox.Text
            End If



            Query = "INSERT INTO dataservis (
            serviceid, breakfast, totalbreakfast, breakfastprice,
            foods, totalfoods, foodsprice,
            beverages, totalbeverages, beveragesprice,
            extrabed, totalextrabed, extrabedprice,
            others, totalothers, othersprice, roomserviceprice,
            driverservice, driverserviceday, driverprice,
            rentalservice, rentalserviceday, rentalprice,
            tourguideservice, tourguideserviceday, tourguideprice, extraserviceprice
            ) VALUES (
            '" & ServiceNumberTextBox.Text & "',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0',
            '0','0','0','0',
            '0','0','0',
            '0','0','0',
            '" & TourGuideServiceComboBox.SelectedItem & "',
            '" & TourGuideServiceTextBox.Text & "',
            '" & price & "',
            '" & serviceprice & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Item ditambahkan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Visible = False
        Dim mainmenu As New mainmenu
        mainmenu.Visible = True

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connection = New MySqlConnection
        connection.ConnectionString =
        "server=localhost;user id=root;password=;database=pkldb"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim Query As String
            Query = "INSERT INTO catatankustomer (roomnumber, note) VALUES ('" & ServiceNumberTextBox.Text & "', '" & NoteRichTextBox.Text & "')"

            command = New MySqlCommand(Query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data telah tersimpan")
            connection.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try

        Dim servicepayment As New servicepayment
        servicepayment.Visible = True


    End Sub
End Class