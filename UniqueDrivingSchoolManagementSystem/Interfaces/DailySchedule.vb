Public Class DailySchedule
    Private Sub DailySchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(3).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(4).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(5).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(6).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(7).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(8).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(9).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(10).HeaderCell.Style.BackColor = Color.DarkSeaGreen
        DataGridView1.Columns(11).HeaderCell.Style.BackColor = Color.DarkSeaGreen

        DataGridView1.EnableHeadersVisualStyles = False

        'TODO: This line of code loads data into the 'Ist3bbDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.Ist3bbDataSet.DataTable1)
        DateTimePicker1.Text = Today
        GridDate()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            If DateTimePicker1.Text = "" Then
                DataTable1TableAdapter.Fill(Ist3bbDataSet.DataTable1)
                GridDate()
            Else
                DataTable1TableAdapter.FillByDate(Ist3bbDataSet.DataTable1, DateTimePicker1.Text)
                GridDate()
            End If

            lessons.Text = BookingTableAdapter.CountDailyLesson(DateTimePicker1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private bitmap As Bitmap
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Drawing.Font("Sans serif", 10)

        Try
            DataTable1TableAdapter.FillByDate(Ist3bbDataSet.DataTable1, DateTimePicker1.Text)
            GridDate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            e.Graphics.DrawImage(bitmap, 0, 0)
            Dim recPrint As RectangleF = e.PageSettings.PrintableArea

            If Me.DataGridView1.Height - recPrint.Height > 0 Then
                e.HasMorePages = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = DataGridView1.Height
        Try
            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
            bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
            DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()
            DataGridView1.Height = height

            DataTable1TableAdapter.FillByDate(Ist3bbDataSet.DataTable1, DateTimePicker1.Text)
            GridDate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GridDate()
        Dim date1 As Date
        For i As Integer = 0 To Ist3bbDataSet.DataTable1.Rows.Count - 1
            date1 = Ist3bbDataSet.DataTable1.Rows(i).Item(13)
            If date1.DayOfYear < Now.DayOfYear Then
                DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Gray
            End If
        Next
    End Sub
End Class