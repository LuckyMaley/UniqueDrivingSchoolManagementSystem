Public Class CreateTimetable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        Dim date2 As Date = DateTimePicker2.Text


        If tbInstructorID.Text <> "" Then
            Try
                BookingTableAdapter2.FillBy(Ist3bbDataSet2.Booking, Integer.Parse(tbInstructorID.Text), date2, ComboBox2.SelectedItem)
                If (Ist3bbDataSet2.Booking.Rows.Count > 0) Then


                End If
                GridDate()
                InstructorTableAdapter1.CheckInstructor(Ist3bbDataSet1.Instructor, Integer.Parse(tbInstructorID.Text))
                BookingTableAdapter1.FillBy2(Ist3bbDataSet4.Booking, Integer.Parse(TextBox1.Text), Integer.Parse(ComboBox1.Text))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If Ist3bbDataSet4.Booking.Rows(0).Item("LessonDate") IsNot DBNull.Value Then


                If Ist3bbDataSet1.Instructor.Rows.Count > 0 Then

                    If ComboBox2.Text <> "" Then
                        If Ist3bbDataSet2.Booking.Rows.Count > 0 Then
                            MessageBox.Show("Instructor Booked")
                        Else
                            MessageBox.Show("Instructor not Booked ")
                            result = MessageBox.Show(ParentForm, "Do you want to save lesson time (Y/N)?", "Confirmation", MessageBoxButtons.YesNo)
                            If result = DialogResult.Yes Then
                                If Ist3bbDataSet1.Booking.Rows(0).Item(10) = 20 And Ist3bbDataSet1.Booking.Rows(0).Item(7) = "10" Then
                                    Try

                                        For i As Integer = 1 To 10

                                            CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Car")
                                            BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, i)
                                        Next
                                        For k As Integer = 11 To 20
                                            CarTableAdapter2.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Truck")
                                            BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, k)
                                        Next

                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message)
                                    End Try
                                Else
                                    Try

                                        If Ist3bbDataSet1.Booking.Rows(0).Item(7) = "08" Then
                                            For j As Integer = 1 To Ist3bbDataSet1.Booking.Rows.Count
                                                CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Car")
                                                BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, j)
                                            Next
                                        ElseIf Ist3bbDataSet1.Booking.Rows(0).Item(7) = "10" Then
                                            For j As Integer = 1 To Ist3bbDataSet1.Booking.Rows.Count
                                                CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Truck")
                                                BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, j)
                                            Next
                                        End If

                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message)
                                    End Try
                                End If

                                Try
                                    Dim lessonN As Integer = Integer.Parse(ComboBox1.Text)
                                    BookingTableAdapter1.UpdateDateTime(DateTimePicker2.Text, ComboBox2.Text, TextBox1.Text, ComboBox1.Text)
                                    BookingTableAdapter1.FillByCustID(Ist3bbDataSet1.Booking, TextBox1.Text)
                                    GridDate1()
                                    ComboBox1.Text = lessonN + 1
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                End Try
                                MessageBox.Show("Date and Timeslot has been saved!!!")
                            End If
                        End If
                    Else
                        MessageBox.Show("Make sure that a time is chosen!!!")
                        ComboBox2.Focus()
                    End If
                Else
                    MessageBox.Show("There is no instructor with that ID, Please enter a Correct ID!!!")
                    tbInstructorID.ResetText()
                End If

            Else
                If Ist3bbDataSet1.Instructor.Rows.Count > 0 Then

                    If ComboBox2.Text <> "" Then
                        If Ist3bbDataSet2.Booking.Rows.Count > 0 Then
                            MessageBox.Show("Instructor Booked")
                        Else
                            MessageBox.Show("Instructor not Booked ")
                            result = MessageBox.Show(ParentForm, "Do you want to save lesson time (Y/N)?", "Confirmation", MessageBoxButtons.YesNo)
                            If result = DialogResult.Yes Then
                                If Ist3bbDataSet1.Booking.Rows(0).Item(10) = 20 And Ist3bbDataSet1.Booking.Rows(0).Item(7) = "10" Then
                                    Try

                                        For i As Integer = 1 To 10

                                            CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Car")
                                            BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, i)
                                        Next
                                        For k As Integer = 11 To 20
                                            CarTableAdapter2.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Truck")
                                            BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, k)
                                        Next

                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message)
                                    End Try
                                Else
                                    Try

                                        If Ist3bbDataSet1.Booking.Rows(0).Item(7) = "08" Then
                                            For j As Integer = 1 To Ist3bbDataSet1.Booking.Rows.Count
                                                CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Car")
                                                BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, j)
                                            Next
                                        ElseIf Ist3bbDataSet1.Booking.Rows(0).Item(7) = "10" Then
                                            For j As Integer = 1 To Ist3bbDataSet1.Booking.Rows.Count
                                                CarTableAdapter1.FillInstrCar(Ist3bbDataSet1.Car, tbInstructorID.Text, "Truck")
                                                BookingTableAdapter1.UpdateBooking(tbInstructorID.Text, Ist3bbDataSet1.Car.Rows(0).Item(0), "Complete", TextBox1.Text, j)
                                            Next
                                        End If

                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message)
                                    End Try
                                End If

                                Try
                                    Dim lessonN As Integer = Integer.Parse(ComboBox1.Text)
                                    BookingTableAdapter1.UpdateDateTime(DateTimePicker2.Text, ComboBox2.Text, TextBox1.Text, ComboBox1.Text)
                                    BookingTableAdapter1.FillByCustID(Ist3bbDataSet1.Booking, TextBox1.Text)
                                    GridDate1()
                                    ComboBox1.Text = lessonN + 1
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                End Try
                                MessageBox.Show("Date and Timeslot has been saved!!!")
                            End If
                        End If
                    Else
                        MessageBox.Show("Make sure that a time is chosen!!!")
                        ComboBox2.Focus()
                    End If
                Else
                    MessageBox.Show("There is no instructor with that ID, Please enter a Correct ID!!!")
                    tbInstructorID.ResetText()
                End If
            End If
        Else
            MessageBox.Show("Must Not be null")
        End If

        Try
            If tbInstructorID.Text <> "" Then
                BookingTableAdapter2.FillByDate(Ist3bbDataSet2.Booking, DateTimePicker2.Text)
                GridDate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            tbFirstName.Clear()
            tbLastName.Clear()
            ComboBox1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            DateTimePicker2.Enabled = False
            ComboBox2.Enabled = False
            tbInstructorID.Enabled = True
            Button2.Enabled = False
            Button5.Enabled = False
            Ist3bbDataSet1.Booking.Clear()
            ComboBox1.ResetText()
            ComboBox2.ResetText()
            tbInstructorID.ResetText()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            BookingBindingSource.MoveNext()
        Catch ex As Exception
        MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            BookingBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tbInstructorID_TextChanged(sender As Object, e As EventArgs) Handles tbInstructorID.SelectedIndexChanged
        If tbInstructorID.Text = "" Or tbInstructorID.Text = " " Then
            Button2.Enabled = False
            Button5.Enabled = False
            TextBox2.Clear()
        Else
            Button2.Enabled = True
            Button5.Enabled = True
            InstructorTableAdapter1.FillBysd(Ist3bbDataSet1.Instructor, Integer.Parse(tbInstructorID.Text))
            TextBox2.Text = Ist3bbDataSet1.Instructor.Rows(0).Item("FirstName")
        End If
    End Sub


    'THIS IS THE PRINTING CODE
    Private bitmap As Bitmap
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim height As Integer = BookingDataGridView.Height
        Try

            BookingDataGridView.Height = BookingDataGridView.RowCount * BookingDataGridView.RowTemplate.Height + BookingDataGridView.RowTemplate.Height + BookingDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.BookingDataGridView.Width, Me.BookingDataGridView.Height)
            BookingDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.BookingDataGridView.Width, Me.BookingDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.ShowDialog()
            BookingDataGridView.Height = height
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            BookingTableAdapter1.FillByCustID(Ist3bbDataSet1.Booking, TextBox1.Text)
            GridDate1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim f As Font = New Drawing.Font("Sans serif", 10)
        Dim ff As Font = New Drawing.Font("Sans serif", 25)

        Try
            BookingTableAdapter1.FillBy1(Ist3bbDataSet1.Booking, TextBox1.Text, tbInstructorID.Text)
            GridDate1()

        Catch df As Exception
            MsgBox(df.Message)
        End Try
        Try
            e.Graphics.DrawString("Customer Time Table ", ff, Brushes.DarkBlue, 250, 110)
            e.Graphics.DrawString("Customer name  : " & Ist3bbDataSet1.Booking.Rows(0).Item(15) & " " & Ist3bbDataSet1.Booking.Rows(0).Item(16), f, Brushes.Black, 250, 180)
            e.Graphics.DrawString("Customer ID : " & Ist3bbDataSet1.Booking.Rows(0).Item(1), f, Brushes.Black, 250, 150)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        e.Graphics.DrawString("Assigned Instructor : " & Ist3bbDataSet1.Booking.Rows(0).Item(17) & " " & Ist3bbDataSet1.Booking.Rows(0).Item(18), f, Brushes.Black, 250, 210)
        e.Graphics.DrawImage(bitmap, 250, 250)
        Dim recPrint As RectangleF = e.PageSettings.PrintableArea

        If Me.BookingDataGridView.Height - recPrint.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub




    Private Sub CreateTimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BookingDataGridView.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView.EnableHeadersVisualStyles = False
            BookingDataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView1.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView1.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView1.Columns(3).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            BookingDataGridView1.EnableHeadersVisualStyles = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try

            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Payment' table. You can move, or remove it, as needed.
            Me.PaymentTableAdapter.Fill(Ist3bbDataSet1.Payment)
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Customer' table. You can move, or remove it, as needed.
            Me.CustomerTableAdapter.Fill(Ist3bbDataSet1.Customer)
            TextBox1.Text = ""
            tbInstructorID.Enabled = False
            DateTimePicker2.MinDate = Date.Today
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub TextBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox1.SelectedIndexChanged
        Try
            tbInstructorID.Items.Clear()
            If TextBox1.Text <> "" Then
                InstructorTableAdapter1.Fill(Ist3bbDataSet1.Instructor)
                tbInstructorID.Items.Add(" ")
                For i As Integer = 0 To Ist3bbDataSet1.Instructor.Rows.Count - 1
                    tbInstructorID.Items.Add(Ist3bbDataSet1.Instructor.Rows(i).Item(0))
                Next


                BookingTableAdapter1.FillByCustID(Ist3bbDataSet1.Booking, TextBox1.Text)
                GridDate1()
                ' Me.BookingTableAdapter3.FillByCustID(Me.Ist3bbDataSet3.Booking, TextBox1.Text)

                tbInstructorID.ResetText()
                If Ist3bbDataSet1.Booking.Rows.Count > 0 Then
                    ComboBox1.Enabled = True
                    Button3.Enabled = True
                    Button4.Enabled = True
                    DateTimePicker2.Enabled = True
                    ComboBox2.Enabled = True
                    tbInstructorID.Enabled = True
                    If Ist3bbDataSet1.Booking.Rows(0).Item(3) IsNot DBNull.Value Then

                        tbInstructorID.Text = Ist3bbDataSet1.Booking.Rows(0).Item(3)
                        '  tbInstructorID.Enabled = False
                        InstructorTableAdapter1.FillBysd(Ist3bbDataSet1.Instructor, Integer.Parse(tbInstructorID.Text))
                        TextBox2.Text = Ist3bbDataSet1.Instructor.Rows(0).Item("FirstName")
                    End If
                    BookingBindingSource.MoveFirst()

                    CustomerTableAdapter.FillByCustomerID(Ist3bbDataSet1.Customer, TextBox1.Text)
                    If Ist3bbDataSet1.Customer.Rows.Count > 0 Then
                        tbFirstName.Text = Ist3bbDataSet1.Customer.Rows(0).Item(1)
                        tbLastName.Text = Ist3bbDataSet1.Customer.Rows(0).Item(2)
                    End If
                Else


                    MessageBox.Show("Customer ID is invalid which means he or she has not paid, Please Try again later after payment is made!!!")
                End If
                BookingTableAdapter2.FillBy3(Ist3bbDataSet2.Booking, Integer.Parse(TextBox1.Text))
                If (Ist3bbDataSet2.Booking.Rows.Count > 0) Then

                    If Ist3bbDataSet2.Booking.Rows(0).Item("LessonNumber") Is DBNull.Value Then
                        Button2.Enabled = False
                        tbInstructorID.Items.Clear()
                    End If
                End If
            Else

                    tbInstructorID.Items.Clear()
                tbInstructorID.ResetText()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            If tbInstructorID.Text <> "" Then
                BookingTableAdapter2.FillByDate(Ist3bbDataSet2.Booking, DateTimePicker2.Text)
                GridDateinstr()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridDate()
        Dim date1 As Date
        Dim str As String
        If BookingDataGridView.Rows.Count > 0 Then
            For i As Integer = 0 To Ist3bbDataSet2.Booking.Rows.Count - 1
                If Ist3bbDataSet2.Booking.Rows(i).Item(13) IsNot DBNull.Value Then
                    str = Ist3bbDataSet2.Booking.Rows(i).Item(13)
                    If str <> "" Then
                        date1 = str
                        If date1.DayOfYear < Now.DayOfYear Then
                            BookingDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Gray
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub GridDateinstr()
        Dim date1 As Date
        Dim str As String
        If BookingDataGridView1.Rows.Count > 0 Then

            For i As Integer = 0 To BookingDataGridView1.Rows.Count - 1
                If Ist3bbDataSet2.Booking.Rows(i).Item(13) IsNot DBNull.Value Then
                    str = Ist3bbDataSet2.Booking.Rows(i).Item(13)
                    If str <> "" Then
                        date1 = str

                        If Now.DayOfWeek > date1.DayOfWeek Then
                            BookingDataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Gray
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub GridDate1()
        Dim date1 As Date
        Dim str As String

        If BookingDataGridView.Rows.Count > 0 Then

            For i As Integer = 0 To Ist3bbDataSet1.Booking.Rows.Count - 1
                If Ist3bbDataSet1.Booking.Rows(i).Item(13) IsNot DBNull.Value Then
                    str = Ist3bbDataSet1.Booking.Rows(i).Item(13)
                    If str <> "" Then
                        date1 = str
                        If date1.DayOfYear < Now.DayOfYear Then
                            BookingDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Gray
                        End If
                    End If
                End If
            Next
        End If
    End Sub
End Class