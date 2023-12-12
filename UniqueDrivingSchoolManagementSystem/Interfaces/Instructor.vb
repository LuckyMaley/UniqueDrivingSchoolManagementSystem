Public Class Instructor
    Private Sub InstructorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InstructorDataGridView.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            InstructorDataGridView.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            InstructorDataGridView.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            InstructorDataGridView.EnableHeadersVisualStyles = False
            Me.BookingTableAdapter1.Fill(Ist3bbDataSet1.Booking)
            'TODO: This line of code loads data into the 'Ist3bbDataSet1.Instructor_Car' table. You can move, or remove it, as needed.
            Me.Instructor_CarTableAdapter1.Fill(Me.Ist3bbDataSet1.Instructor_Car)
            'TODO: This line of code loads data into the 'Ist3bbDataSet.Instructor' table. You can move, or remove it, as needed.
            Me.InstructorTableAdapter.Fill(Me.Ist3bbDataSet.Instructor)
            Instructor_CarTableAdapter1.FillByInstrc(Ist3bbDataSet.Instructor_Car, tbInstructorID.Text)
            If Ist3bbDataSet.Instructor_Car.Rows(0).Item(1) <> Nothing Then
                TextBox1.Text = Ist3bbDataSet.Instructor_Car.Rows(0).Item(1)
            End If
            If Ist3bbDataSet.Instructor_Car.Rows(1).Item(1) <> Nothing Then
                TextBox2.Text = Ist3bbDataSet.Instructor_Car.Rows(1).Item(1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            InstructorBindingSource.EndEdit()
            InstructorTableAdapter.Update(Ist3bbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        Try
            btnAddInstructor.Enabled = False
            InstructorBindingSource.MoveLast()
            InstructorBindingSource.AddNew()
            tbInstructorID.Text = InstructorTableAdapter.MaxInstrID() + 1
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button5.Enabled = False
            Button2.Enabled = False
            btnSaveInstructor.Enabled = True
            Label1.Visible = True
            Label5.Visible = True
            Label10.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnSaveInstructor_Click(sender As Object, e As EventArgs) Handles btnSaveInstructor.Click
        Try
            If tbFirstName.Text <> "" And tbLastName.Text <> "" And tbZipCode.Text <> "" Then
                TextBox1.Visible = True
                TextBox2.Visible = True
                InstructorTableAdapter.InsertInstructor(Integer.Parse(tbInstructorID.Text), tbFirstName.Text, tbLastName.Text, tbHouseNumber.Text, tbStreetName.Text, tbCity.Text, tbZipCode.Text, " ", " ")
                InstructorTableAdapter.Fill(Ist3bbDataSet.Instructor)
                Button5.Enabled = True
                Button2.Enabled = True
                btnAddInstructor.Enabled = True
                btnSaveInstructor.Enabled = False
                Label1.Visible = False
                Label5.Visible = False
                Label10.Visible = False
            Else
                MessageBox.Show("Please fill in the required fields that are highlighted")
                Label1.Visible = True
                Label5.Visible = True
                Label10.Visible = True
            End If
        Catch ex As Exception
            'Duplicate exception was captured which indicates that data is already saved.
            MessageBox.Show("Saved Successfully.", "Save")
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            InstructorBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            InstructorBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            InstructorBindingSource.MoveFirst()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            InstructorBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbSearchInstr_TextChanged(sender As Object, e As EventArgs) Handles tbSearchInstr.TextChanged
        Try
            If tbSearchInstr.Text = "" Then
                InstructorTableAdapter.Fill(Ist3bbDataSet.Instructor)
            Else
                InstructorTableAdapter.FillSearchInstructor(Ist3bbDataSet.Instructor, tbSearchInstr.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbInstructorID_TextChanged(sender As Object, e As EventArgs) Handles tbInstructorID.TextChanged
        Try
            If tbInstructorID.Text <> "" Then
                Instructor_CarTableAdapter1.FillByInstrc(Ist3bbDataSet.Instructor_Car, tbInstructorID.Text)
                If Ist3bbDataSet.Instructor_Car.Rows.Count > 0 Then
                    TextBox1.Text = Ist3bbDataSet.Instructor_Car.Rows(0).Item(1)
                    If Ist3bbDataSet.Instructor_Car.Rows.Count > 1 Then
                        TextBox2.Text = Ist3bbDataSet.Instructor_Car.Rows(1).Item(1)
                    Else
                        TextBox2.Text = ""
                    End If
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                End If
            Else
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnInstructorTimeTable_Click(sender As Object, e As EventArgs) Handles btnInstructorTimeTable.Click
        InstructorTimeTable.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BookingTableAdapter1.FillByInstrClear(Ist3bbDataSet1.Booking, Integer.Parse(tbInstructorID.Text))
        Dim MyChoice As DialogResult
        MyChoice = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If MyChoice = DialogResult.Yes Then
                For i As Integer = 0 To Ist3bbDataSet1.Booking.Rows.Count - 1
                    If Ist3bbDataSet1.Booking.Rows(i).Item(6) > Now Then
                        Ist3bbDataSet1.Booking.Rows(i).Item(3) = DBNull.Value
                        Ist3bbDataSet1.Booking.Rows(i).Item(4) = DBNull.Value
                        Ist3bbDataSet1.Booking.Rows(i).Item(13) = DBNull.Value
                        Ist3bbDataSet1.Booking.Rows(i).Item(14) = DBNull.Value
                    End If
                Next
                BookingTableAdapter1.Update(Ist3bbDataSet1.Booking)
                InstructorTableAdapter.FillByInstruct(Ist3bbDataSet.Instructor, Integer.Parse(tbInstructorID.Text))
                If Ist3bbDataSet.Instructor.Rows.Count > 0 Then
                    Ist3bbDataSet.Instructor.Rows(0).Item(4) = "fired"
                    InstructorTableAdapter.Update(Ist3bbDataSet.Instructor)
                End If
                Me.InstructorTableAdapter.Fill(Me.Ist3bbDataSet.Instructor)
                Me.Instructor_CarTableAdapter1.Fill(Me.Ist3bbDataSet1.Instructor_Car)
                    MessageBox.Show("Instructor Deleted")
                Else
                    MessageBox.Show("Deletion Cancelled")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub tbZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbZipCode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class