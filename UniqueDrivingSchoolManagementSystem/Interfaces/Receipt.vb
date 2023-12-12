Public Class Form2
    Dim bitmap As Bitmap
    Private Sub PaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ist3bbDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Ist3bbDataSet.Payment' table. You can move, or remove it, as needed.
            Me.PaymentTableAdapter.Fill(Me.Ist3bbDataSet.Payment)
            PaymentTableAdapter.FillByCustP(Me.Ist3bbDataSet.Payment, Integer.Parse(Customer.tbCustomerID.Text))
            BookingTableAdapter1.FillByCustCode(Ist3bbDataSet.Booking, Integer.Parse(Customer.tbCustomerID.Text))
            CustomerTableAdapter1.FillByCustName(Ist3bbDataSet.Customer, Integer.Parse(Customer.tbCustomerID.Text))
            Label4.Text = Ist3bbDataSet.Booking.Rows(0).Item(7)
            Label5.Text = "R" & Ist3bbDataSet.Payment.Rows(0).Item(3)
            Label7.Text = Ist3bbDataSet.Customer.Rows(0).Item(1) & " " & Ist3bbDataSet.Customer.Rows(0).Item(2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Printing Customers Receipt
    Dim bitmap2 As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'fix this not done
        Dim height As Integer = PaymentDataGridView.Height

        Try
            PaymentDataGridView.Height = PaymentDataGridView.RowCount * PaymentDataGridView.RowTemplate.Height + PaymentDataGridView.RowTemplate.Height + PaymentDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.PaymentDataGridView.Width, Me.PaymentDataGridView.Height)
            PaymentDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.PaymentDataGridView.Width, Me.PaymentDataGridView.Height))
            PrintPreviewDialog2.Document = PrintDocument2

            PrintPreviewDialog2.ShowDialog()
            PaymentDataGridView.Height = height

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim f As Font = New Drawing.Font("Sans serif", 10)
        Dim f2 As Font = New Drawing.Font("New Times Roman", 30)

        Try
            e.Graphics.DrawString("UNIQUE DRIVING SCHOOL", f2, Brushes.DarkBlue, 150, 100)
            e.Graphics.DrawString("Customer ID  : " & Ist3bbDataSet.Payment.Rows(0).Item(1), f, Brushes.Black, 250, 150)
            e.Graphics.DrawString("Customer Name : " & Ist3bbDataSet.Customer.Rows(0).Item(1) & " " & Ist3bbDataSet.Customer.Rows(0).Item(2), f, Brushes.Black, 250, 180)
            e.Graphics.DrawString("License Code : " & Ist3bbDataSet.Booking.Rows(0).Item(7), f, Brushes.Black, 250, 210)
            e.Graphics.DrawImage(bitmap, 150, 250)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim recPrint As RectangleF = e.PageSettings.PrintableArea

        If Me.PaymentDataGridView.Height - recPrint.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

End Class