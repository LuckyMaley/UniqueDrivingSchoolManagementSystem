Public Class Customer
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BookingTableAdapter.Fill(Me.Ist3bbDataSet.Booking)
            'TODO: This line of code loads data into the 'Ist3bbDataSet.Customer' table. You can move, or remove it, as needed.
            Me.CustomerTableAdapter.Fill(Me.Ist3bbDataSet.Customer)
            Me.ManagerTableAdapter1.Fill(Me.Ist3bbDataSet.Manager)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Try
            BookingBindingSource1.EndEdit()
            CustomerBindingSource.EndEdit()
            BookingTableAdapter.Update(Ist3bbDataSet.Booking)
            CustomerTableAdapter.Update(Ist3bbDataSet.Customer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Failed")
        End Try

        MessageBox.Show("Update Successful")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim MyChoice As DialogResult
        MyChoice = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If MyChoice = DialogResult.Yes Then
                BookingTableAdapter.DeleteQuery(tbCustomerID.Text)
                PaymentTableAdapter1.DeleteQuery1(tbCustomerID.Text)
                CustomerBindingSource.RemoveCurrent()
                CustomerTableAdapter.Update(Ist3bbDataSet.Customer)
            Else
                MessageBox.Show("Deletion Cancelled")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CustomerBindingSource.MoveNext()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        CustomerBindingSource.MoveLast()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub

    Private Sub tbZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbZipCode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class