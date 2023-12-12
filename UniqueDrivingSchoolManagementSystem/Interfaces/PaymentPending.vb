Public Class PaymentPending
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            BookingTableAdapter1.FillBy4(Ist3bbDataSet1.Booking, Integer.Parse(TextBox4.Text))
            TextBox3.Text = Integer.Parse(TextBox1.Text) - Integer.Parse(TextBox2.Text)
            If TextBox3.Text <> 0 Then
                MessageBox.Show("Payment must be the same as amount due!!!, please try again")
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox2.Focus()
            Else

                If Ist3bbDataSet1.Payment.Rows.Count > 0 Then


                    PaymentTableAdapter1.UpdateQuery(Date.Now.ToShortDateString(), Decimal.Parse(TextBox2.Text), 0, Integer.Parse(TextBox4.Text))
                    If (Ist3bbDataSet1.Booking.Rows.Count > 0) Then
                        BookingTableAdapter1.UpdateQuery1(Date.Now.ToShortDateString(), Ist3bbDataSet1.Booking.Rows(0).Item("LicenseCode").ToString(), "Complete", 1, 90, Integer.Parse(TextBox4.Text), Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("BookingID")))
                        For j As Integer = 1 To Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("NumOfLessons")) - 1
                            BookingTableAdapter1.InsertQuery(Integer.Parse(TextBox4.Text), 1, j + 1)
                        Next
                        For i As Integer = 0 To Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("NumOfLessons")) - 1
                            If (Ist3bbDataSet1.Booking.Rows(0).Item("NumOfLessons") = 20) Then
                                If i < 11 Then
                                    BookingTableAdapter1.UpdateQuery1(Date.Now.ToShortDateString(), "08", "Complete", i + 1, 90, Integer.Parse(TextBox4.Text), Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("BookingID")) + i)
                                Else
                                    BookingTableAdapter1.UpdateQuery1(Date.Now.ToShortDateString(), "10", "Complete", i + 1, 90, Integer.Parse(TextBox4.Text), Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("BookingID")) + i)
                                End If
                            Else
                                BookingTableAdapter1.UpdateQuery1(Date.Now.ToShortDateString(), Ist3bbDataSet1.Booking.Rows(0).Item("LicenseCode").ToString(), "Complete", i + 1, 90, Integer.Parse(TextBox4.Text), Integer.Parse(Ist3bbDataSet1.Booking.Rows(0).Item("BookingID")) + i)
                            End If
                        Next
                    End If
                End If
                    MessageBox.Show("Payment made!!!")

                    Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = PendingBookings.TextBox2.Text
        TextBox4.Text = PendingBookings.TextBox1.Text
        PaymentTableAdapter1.FillByCustP(Ist3bbDataSet1.Payment, Integer.Parse(TextBox4.Text))
        BookingTableAdapter1.FillBy4(Ist3bbDataSet1.Booking, Integer.Parse(TextBox4.Text))
        '  Dim s As Date = Ist3bbDataSet1.Payment.Rows(0).Item("Date")
        ' Dim s1 As Date = s.AddDays(31)
        ' If s > s1 Then
        '
        '        End If
    End Sub

End Class