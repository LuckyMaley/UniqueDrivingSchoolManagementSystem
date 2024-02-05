Public Class Cars
    Private Sub CarsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist3bbDataSet1.Instructor' table. You can move, or remove it, as needed.
        Me.InstructorTableAdapter1.Fill(Me.Ist3bbDataSet1.Instructor)
        Try
            CarDataGridView.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            CarDataGridView.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            CarDataGridView.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            CarDataGridView.EnableHeadersVisualStyles = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            BookingTableAdapter1.Fill(Ist3bbDataSet.Booking)
            'TODO: This line of code loads data into the 'Ist3bbDataSet.Car' table. You can move, or remove it, as needed.
            Me.CarTableAdapter.FillByCond(Me.Ist3bbDataSet.Car, "Written off")
            If Ist3bbDataSet.Car.Count > 0 Then
                'TODO: This line of code loads data into the 'Ist3bbDataSet1.Instructor_Car' table. You can move, or remove it, as needed.
                Me.Instructor_CarTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor_Car)
                Me.Instructor_CarTableAdapter.FillBy(Ist3bbDataSet1.Instructor_Car, tbCarID.Text)
                If Ist3bbDataSet1.Instructor_Car.Rows.Count > 0 Then
                    tbText1.Text = Ist3bbDataSet1.Instructor_Car.Rows(0).Item(0)
                Else
                    tbText1.ResetText()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        Try

            btnAddCar.Enabled = False
            CarBindingSource.MoveLast()
            CarBindingSource.AddNew()
            If Ist3bbDataSet.Car.Count = 0 Then
                tbCarID.Text = (0 + 1).ToString
            Else
                tbCarID.Text = CarTableAdapter.MaxID() + 1
            End If

            tbText1.ResetText()
            btnSaveCar.Enabled = True
            Button1.Enabled = False
            Button2.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnSaveCar_Click(sender As Object, e As EventArgs) Handles btnSaveCar.Click
        Try
            If tbText1.Text <> "" Then
                CarTableAdapter.InsertCar(tbCarID.Text, 1, tbModel.Text, tbStatus.Text, tbcarType.Text)
                Instructor_CarTableAdapter.Insert(tbText1.Text, tbCarID.Text)
                CarTableAdapter.FillByCond(Ist3bbDataSet.Car, "Written off")
                Me.Instructor_CarTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor_Car)
                MessageBox.Show("Saved Successfully.", "Save")
                btnAddCar.Enabled = True
                btnSaveCar.Enabled = False
                Button1.Enabled = True
                Button2.Enabled = True
            Else
                MessageBox.Show("Please make sure that an instructor has been assigned to a car")
            End If
        Catch ex As Exception
            'Duplicate exception was captured which indicates that data is already saved.
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            CarBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            CarBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            CarBindingSource.MoveFirst()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            CarBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            If TextBox2.Text = "" Then
                Me.CarTableAdapter.FillByCond(Me.Ist3bbDataSet.Car, "Written off")
                Me.Instructor_CarTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor_Car)
            Else
                CarTableAdapter.FillSearchCar(Ist3bbDataSet.Car, TextBox2.Text)
                Me.Instructor_CarTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor_Car)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub tbCarID_TextChanged(sender As Object, e As EventArgs) Handles tbCarID.TextChanged
        Try
            tbText1.Items.Clear()
            If tbCarID.Text <> "" And tbcarType.Text <> "" Then
                tbText1.Items.Add(" ")
                For i As Integer = 0 To Ist3bbDataSet1.Instructor.Rows.Count - 1
                    tbText1.Items.Add(Ist3bbDataSet1.Instructor.Rows(i).Item(0))
                Next
                If tbcarType.Text = "Car" Or tbcarType.Text = "car" Then
                    PictureBox1.Visible = True
                    GroupBox2.Enabled = True
                    PictureBox1.Refresh()
                    PictureBox1.Image = My.Resources.silvercar
                    Me.Instructor_CarTableAdapter.FillBy(Ist3bbDataSet1.Instructor_Car, tbCarID.Text)
                    If Ist3bbDataSet1.Instructor_Car.Rows.Count > 0 Then
                        tbText1.Text = Ist3bbDataSet1.Instructor_Car.Rows(0).Item(0)
                    End If
                ElseIf tbcarType.Text = "Truck" Or tbcarType.Text = "truck" Then
                    PictureBox1.Visible = True
                    GroupBox2.Enabled = True
                    PictureBox1.Refresh()
                    PictureBox1.Image = My.Resources.truck1
                    Me.Instructor_CarTableAdapter.FillBy(Ist3bbDataSet1.Instructor_Car, tbCarID.Text)
                    If Ist3bbDataSet1.Instructor_Car.Rows.Count > 0 Then
                        tbText1.Text = Ist3bbDataSet1.Instructor_Car.Rows(0).Item(0)
                    End If
                End If
            Else
                PictureBox1.Visible = False
                GroupBox2.Enabled = False
                PictureBox1.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookingTableAdapter1.FillByCar(Ist3bbDataSet.Booking, Integer.Parse(tbCarID.Text))
        Dim MyChoice As DialogResult
        MyChoice = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo)
        Try
            If MyChoice = DialogResult.Yes Then
                For i As Integer = 0 To Ist3bbDataSet.Booking.Rows.Count - 1
                    Ist3bbDataSet.Booking.Rows(i).Item(4) = DBNull.Value
                Next
                tbStatus.Text = "Written off"
                CarBindingSource.EndEdit()
                CarTableAdapter.Update(Ist3bbDataSet.Car)
                Me.CarTableAdapter.FillByCond(Me.Ist3bbDataSet.Car, "Written off")
                Me.Instructor_CarTableAdapter.Fill(Me.Ist3bbDataSet1.Instructor_Car)
                MessageBox.Show("Car Deleted")
            Else
                MessageBox.Show("Deletion Cancelled")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If tbText1.Text = "" Then
                CarBindingSource.EndEdit()
                CarTableAdapter.Update(Ist3bbDataSet.Car)
                Instructor_CarTableAdapter.UpdateInstrCar(Integer.Parse(tbText1.Text), Integer.Parse(tbCarID.Text))
                Me.CarTableAdapter.FillByCond(Me.Ist3bbDataSet.Car, "Written off")
            Else
                MessageBox.Show("Assigned Instructor cannot be left blank!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

End Class