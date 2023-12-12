Public Class Manager

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Ist3bbDataSet.Manager' table. You can move, or remove it, as needed.
            Me.ManagerTableAdapter.Fill(Me.Ist3bbDataSet.Manager)
            tbPassword.UseSystemPasswordChar = True
            ManagerTableAdapter.Fill(Ist3bbDataSet.Manager)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateManager_Click(sender As Object, e As EventArgs) Handles btnUpdateManager.Click
        Try
            Dim result As DialogResult = MessageBox.Show(Parent, "Do you want to update your details?", "Confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ManagerBindingSource.EndEdit()
                Me.ManagerTableAdapter.Update(Ist3bbDataSet)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim result As DialogResult = MessageBox.Show(Parent, "Do you want to update package prices?", "Confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ManagerBindingSource.EndEdit()
                ManagerTableAdapter.Update(Ist3bbDataSet.Manager)
                MessageBox.Show("Updated Prices Successfully!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbShowPwd_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPwd.CheckedChanged
        'Hides the password if checked
        If cbShowPwd.CheckState = CheckState.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox1.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class