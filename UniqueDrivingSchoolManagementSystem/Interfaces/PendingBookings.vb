Public Class PendingBookings
    Private Sub PendingBookings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.PendingBookingsToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PendingBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
            TextBox3.Text = ""
            PaymentTableAdapter1.FillBy1(Ist3bbDataSet1.Payment)
            BookingTableAdapter1.Fill(Ist3bbDataSet1.Booking)
            CustomerTableAdapter1.Fill(Ist3bbDataSet1.Customer)

            Dim s As Date
            If Ist3bbDataSet1.Payment.Rows.Count > 0 Then
                For i As Integer = 0 To Ist3bbDataSet1.Payment.Rows.Count - 1
                    CustomerTableAdapter1.FillByCustomerID(Ist3bbDataSet1.Customer, Integer.Parse(Ist3bbDataSet1.Payment.Rows(i).Item("CustomerID")))
                    s = Ist3bbDataSet1.Payment.Rows(i).Item("Date")
                    If (s.Date - Date.Now.Date).TotalDays > 30 Then
                        BookingTableAdapter1.DeleteQuery1(Integer.Parse(Ist3bbDataSet1.Payment.Rows(i).Item("PaymentID")))
                        PaymentTableAdapter1.DeleteQuery1(Integer.Parse(Ist3bbDataSet1.Payment.Rows(i).Item("CustomerID")))
                        CustomerTableAdapter1.DeleteQuery(Integer.Parse(Ist3bbDataSet1.Payment.Rows(i).Item("CustomerID")))
                    End If
                    Try
                        Me.CustomerTableAdapter1.FillByfi(Me.Ist3bbDataSet1.Customer, Integer.Parse(TextBox1.Text))
                        TextBox3.Text = Ist3bbDataSet1.Customer.Rows(0).Item("FirstName") + " " + Ist3bbDataSet1.Customer.Rows(0).Item("LastName")
                    Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try
                Next
            Else
                TextBox1.Clear()
            End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PaymentPending.ShowDialog()
        TextBox1.Text = "1"
        Me.PendingBookings_Load(sender, e)

    End Sub

    Private Sub PaymentDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles PaymentDataGridView.SelectionChanged
        Try
            If TextBox1.Text <> "" Then
                Me.CustomerTableAdapter1.FillByfi(Me.Ist3bbDataSet1.Customer, Integer.Parse(TextBox1.Text))
                TextBox3.Text = Ist3bbDataSet1.Customer.Rows(0).Item("FirstName") + " " + Ist3bbDataSet1.Customer.Rows(0).Item("LastName")
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class