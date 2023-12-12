Public Class InstructorTimeTable

    Private Sub btnSearchInstructorTimeTame_Click(sender As Object, e As EventArgs) Handles btnSearchInstructorTimeTame.Click
        Try
            Me.DataTableInstructorTimeTableTableAdapter.FillInstructorTimeTable(Ist3bbDataSet.DataTableInstructorTimeTable, txtInstructorSearcher.Text, fromDate.Text, toDate.Text)
            GridDate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim bitmap As Bitmap

    Private Sub btnPrintInstructorTimeTable_Click(sender As Object, e As EventArgs) Handles btnPrintInstructorTimeTable.Click

        Dim height As Integer = DataTableInstructorTimeTableDataGridView.Height
        Try

            DataTableInstructorTimeTableDataGridView.Height = DataTableInstructorTimeTableDataGridView.RowCount * DataTableInstructorTimeTableDataGridView.RowTemplate.Height + DataTableInstructorTimeTableDataGridView.RowTemplate.Height + DataTableInstructorTimeTableDataGridView.RowTemplate.Height + DataTableInstructorTimeTableDataGridView.RowTemplate.Height
            bitmap = New Bitmap(Me.DataTableInstructorTimeTableDataGridView.Width, Me.DataTableInstructorTimeTableDataGridView.Height)
            DataTableInstructorTimeTableDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataTableInstructorTimeTableDataGridView.Width, Me.DataTableInstructorTimeTableDataGridView.Height))
            PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.ShowDialog()
            DataTableInstructorTimeTableDataGridView.Height = height
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try

            Me.DataTableInstructorTimeTableTableAdapter.FillInstructorTimeTable(Ist3bbDataSet.DataTableInstructorTimeTable, txtInstructorSearcher.Text, fromDate.Text, toDate.Text)
            GridDate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As Font = New Drawing.Font("Sans serif", 10)
        Dim ff As Font = New Drawing.Font("Sans serif", 25)

        Try
            Me.DataTableInstructorTimeTableTableAdapter.FillInstructorTimeTable(Ist3bbDataSet.DataTableInstructorTimeTable, txtInstructorSearcher.Text, fromDate.Text, toDate.Text)
            GridDate()
        Catch df As Exception
            MsgBox(df.Message)
        End Try
        Try
            e.Graphics.DrawString("Instructor Time Table " & "", ff, Brushes.DarkBlue, 200, 110)
            ' e.Graphics.DrawString("Instructor Name  : " & Ist3bbDataSet.DataTableInstructorTimeTable.Rows(0).Item(15) & " " & Ist3bbDataSet.DataTableInstructorTimeTable.Rows(0).Item(16), f, Brushes.Black, 250, 180)
            e.Graphics.DrawString("Instructor ID : " & Ist3bbDataSet.DataTableInstructorTimeTable.Rows(0).Item(0), f, Brushes.Black, 20, 150)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        e.Graphics.DrawImage(bitmap, 20, 250)
        Dim recPrint As RectangleF = e.PageSettings.PrintableArea

        If Me.DataTableInstructorTimeTableDataGridView.Height - recPrint.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub InstructorTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist3bbDataSet.Instructor' table. You can move, or remove it, as needed.
        Me.InstructorTableAdapter.Fill(Me.Ist3bbDataSet.Instructor)
        Try
            DataTableInstructorTimeTableDataGridView.Columns(0).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            DataTableInstructorTimeTableDataGridView.Columns(1).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            DataTableInstructorTimeTableDataGridView.Columns(2).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            DataTableInstructorTimeTableDataGridView.Columns(3).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            DataTableInstructorTimeTableDataGridView.Columns(4).HeaderCell.Style.BackColor = Color.DarkSeaGreen
            DataTableInstructorTimeTableDataGridView.Columns(5).HeaderCell.Style.BackColor = Color.DarkSeaGreen


            DataTableInstructorTimeTableDataGridView.EnableHeadersVisualStyles = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub GridDate()
        Dim date1 As Date
        For i As Integer = 0 To DataTableInstructorTimeTableDataGridView.Rows.Count - 1
            date1 = Ist3bbDataSet.DataTableInstructorTimeTable.Rows(i).Item(3)
            If date1.DayOfYear < Now.DayOfYear Then
                DataTableInstructorTimeTableDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Gray
            End If
        Next
    End Sub

End Class