Public Class CustomerBooking
    Friend truckHire As Integer
    Friend truckPerhour As Integer
    Friend CarHire As Integer
    Friend CarPerhour As Integer
    Private Sub CustomerBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ManagerTableAdapter1.Fill(Ist3bbDataSet.Manager)
            truckHire = Ist3bbDataSet.Manager.Rows(0).Item(10)
            truckPerhour = Ist3bbDataSet.Manager.Rows(0).Item(9)
            CarHire = Ist3bbDataSet.Manager.Rows(0).Item(8)
            CarPerhour = Ist3bbDataSet.Manager.Rows(0).Item(7)
            tbCustomerID1.Text = CustomerTableAdapter.ScalarQuery() + 1
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label16.Visible = True
            Label11.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Try
            If tbCustomerID1.Text <> "" And tbPrice.Text <> "" And cbGender.Text <> "" Then
                Payment.ShowDialog()
                ' Save Customer
                CustomerTableAdapter.InsertCustomer(tbCustomerID1.Text, tbFirstName.Text, tbLastName.Text, dtpDateOfBirth.Text, cbGender.Text, tbCellNumber.Text,
                                                tbHouseNumber.Text, tbStreetName.Text, tbCity.Text, tbZipCode.Text, tbEmail.Text, dtpTestDate.Text, " ", " ", " ")
                Dim PayId As Integer = PaymentTableAdapter1.MaxPayment() + 1
                Dim date1 As Date = Date.Now
                Dim Lessons As Integer = Integer.Parse(tbPrice.Text) / Integer.Parse(CbLessons.SelectedItem)
                Try
                    ' Save Booking
                    PaymentTableAdapter1.InsertPayment(PayId, tbCustomerID1.Text, date1, tbPrice.Text, 0)
                    For j As Integer = 1 To Integer.Parse(CbLessons.SelectedItem)
                        Try
                            BookingTableAdapter.InsertLessonBook(Integer.Parse(tbCustomerID1.Text), 1, PayId, date1,
                                                                 cbLessonCode.Text, cbBookingStatus.Text, tbVenue.Text, Integer.Parse(CbLessons.SelectedItem), j, Decimal.Parse(Lessons))
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                MessageBox.Show("Saved Successfully")
                ReceiptBooking.ShowDialog()
                Try
                    Dim MyChoice As DialogResult
                    MyChoice = MessageBox.Show("Create Timetable?", "Confirmation", MessageBoxButtons.YesNo)
                    If MyChoice = DialogResult.Yes Then
                        CreateTimetable2.ShowDialog()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                tbCustomerID1.Clear()
                tbCustomerID1.Text = CustomerTableAdapter.ScalarQuery() + 1
                tbFirstName.Clear()
                tbFirstName.Focus()
                tbLastName.Clear()
                dtpDateOfBirth.ResetText()
                cbGender.ResetText()
                tbCellNumber.Clear()
                tbEmail.Clear()
                tbHouseNumber.Clear()
                tbStreetName.Clear()
                tbCity.Clear()
                tbZipCode.Clear()
                cbLessonCode.ResetText()
                rbFullCourse.Checked = False
                rbPerLesson.Checked = False
                CbLessons.ResetText()
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label16.Visible = True
                Label11.Visible = True
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
            Else
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label16.Visible = True
                Label11.Visible = True
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
            End If
        Catch ex As Exception
            'Duplicate exception was captured which indicates that data is already saved.
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub rbYes_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        If rbYes.Checked Then
            tbVenue.Enabled = True
            tbVenue.Clear()
        End If
    End Sub

    Private Sub rbNo_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        If rbNo.Checked Then
            tbVenue.Enabled = False
            tbVenue.Text = "None"
        End If
    End Sub

    Private Sub rbPerLesson_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerLesson.CheckedChanged
        CbLessons.Enabled = True
        CbLessons.Text = ""
    End Sub

    Private Sub rbFullCourse_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullCourse.CheckedChanged, cbLessonCode.SelectedIndexChanged
        Try
            If rbFullCourse.Checked Then
                CbLessons.Text = 20
                CbLessons.Enabled = False
                If cbLessonCode.SelectedItem = 8 Then
                    tbPrice.Text = Ist3bbDataSet.Manager.Rows(0).Item(12)
                Else
                    tbPrice.Text = Ist3bbDataSet.Manager.Rows(0).Item(11)
                End If
            Else
                tbPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CbLessons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbLessons.SelectedIndexChanged, cbLessonCode.SelectedIndexChanged
        Try
            If rbPerLesson.Checked And CbLessons.SelectedItem <> "" And CbLessons.Text <> "" Then
                CbLessons.Enabled = True
                tbPrice.Clear()
                If cbLessonCode.SelectedItem = 8 Then
                    tbPrice.Text = (CarHire + (Integer.Parse(CbLessons.SelectedItem) * CarPerhour))

                ElseIf cbLessonCode.SelectedItem = 10 And CbLessons.SelectedItem <> "" Then
                    tbPrice.Text = (truckHire + (Integer.Parse(CbLessons.SelectedItem) * truckPerhour))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditCustomers_Click(sender As Object, e As EventArgs)
        MainMenu.FormSetUp(Customer)
    End Sub

    Private Sub tbZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbZipCode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub


End Class