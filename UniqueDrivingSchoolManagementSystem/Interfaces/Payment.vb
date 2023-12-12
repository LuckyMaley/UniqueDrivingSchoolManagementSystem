Public Class Payment
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox3.Text = Integer.Parse(TextBox1.Text) - Integer.Parse(TextBox2.Text)
            If TextBox3.Text <> 0 Then
                MessageBox.Show("Payment must be the same as amount due!!!, please try again")
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox2.Focus()
            Else
                MessageBox.Show("Payment made!!!")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = CustomerBooking.tbPrice.Text
    End Sub
End Class