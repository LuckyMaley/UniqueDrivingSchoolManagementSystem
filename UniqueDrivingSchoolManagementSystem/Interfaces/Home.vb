Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Car' table. You can move, or remove it, as needed.
            Me.CarTableAdapter.FillByCond(Me.Ist3bbDataSet1.Car, "Written off")
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Instructor' table. You can move, or remove it, as needed.
            Me.InstructorTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor)
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Booking' table. You can move, or remove it, as needed.
            Me.BookingTableAdapter.Fill(Me.Ist3bbDataSet1.Booking)

            For i As Integer = 0 To Ist3bbDataSet1.Booking.Rows.Count - 1
                If Ist3bbDataSet1.Booking.Rows(i).Item("LessonDate") IsNot DBNull.Value Then
                    MonthCalendar2.AddBoldedDate(Ist3bbDataSet1.Booking.Rows(i).Item(13))
                End If
            Next
            MonthCalendar2.SelectionStart = Today.AddDays(30)
            MonthCalendar2.SelectionEnd = Today.AddDays(30)
            MonthCalendar2.SelectionStart = Date.Now
            MonthCalendar2.SelectionEnd = Date.Now
            MonthCalendar2.Refresh()
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Customer' table. You can move, or remove it, as needed.
            Me.CustomerTableAdapter.Fill(Me.Ist3bbDataSet1.Customer)
            lblBookedCustomers.Text = CustomerTableAdapter.CountCustomers()
            lblFullCourseCust.Text = BookingTableAdapter.CountFullCourse()
            lblPerLessonCust.Text = CustomerTableAdapter.CountCustomers() - (BookingTableAdapter.CountFullCourse())
            lblInstructors.Text = InstructorTableAdapter.CountInstructorID()
            lblCars.Text = CarTableAdapter.CountCars()
            BookingTableAdapter.FillByDate(Ist3bbDataSet1.Booking, Today)
            If Ist3bbDataSet1.Booking.Rows.Count > 0 Then
                If Ist3bbDataSet1.Booking.Rows.Count = 1 Then
                    Label13.Text = "1 lesson is assigned to an instructor today." & Environment.NewLine & "***Check Daily Schedule for more info.***"
                    Label14.Text = ""
                    Label12.Text = ""

                ElseIf Ist3bbDataSet1.Booking.Rows.Count > 1 Then
                    Label13.Text = "There is more than 1 lesson assigned to instructor(s) today." & Environment.NewLine & "***Check Daily Schedule for more info.***"
                    Label14.Text = ""
                    Label12.Text = ""
                End If
            Else
                Label13.Text = "No lesson is assigned to any Instructor today"
                Label14.Text = ""
                Label12.Text = ""
            End If

            Dim vald As Integer = PaymentTableAdapter1.ScalarQueryCountPending()
            If vald = 0 Then
                LblPendingPayments.Text = vald.ToString()

            Else
                LblPendingPayments.Text = vald.ToString() + Environment.NewLine + " ***Check Pending Payments" + Environment.NewLine + " under Access***"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class