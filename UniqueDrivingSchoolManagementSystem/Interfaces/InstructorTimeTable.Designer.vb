<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorTimeTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorTimeTable))
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.DataTableInstructorTimeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableInstructorTimeTableTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.DataTableInstructorTimeTableTableAdapter()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.DataTableInstructorTimeTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchInstructorTimeTame = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.InstructorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtInstructorSearcher = New System.Windows.Forms.ComboBox()
        Me.btnPrintInstructorTimeTable = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InstructorTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableInstructorTimeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableInstructorTimeTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableInstructorTimeTableBindingSource
        '
        Me.DataTableInstructorTimeTableBindingSource.DataMember = "DataTableInstructorTimeTable"
        Me.DataTableInstructorTimeTableBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'DataTableInstructorTimeTableTableAdapter
        '
        Me.DataTableInstructorTimeTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Instructor_CarTableAdapter = Nothing
        Me.TableAdapterManager.InstructorTableAdapter = Nothing
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataTableInstructorTimeTableDataGridView
        '
        Me.DataTableInstructorTimeTableDataGridView.AllowUserToAddRows = False
        Me.DataTableInstructorTimeTableDataGridView.AllowUserToDeleteRows = False
        Me.DataTableInstructorTimeTableDataGridView.AutoGenerateColumns = False
        Me.DataTableInstructorTimeTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataTableInstructorTimeTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataTableInstructorTimeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTableInstructorTimeTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataTableInstructorTimeTableDataGridView.DataSource = Me.DataTableInstructorTimeTableBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataTableInstructorTimeTableDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataTableInstructorTimeTableDataGridView.Location = New System.Drawing.Point(14, 28)
        Me.DataTableInstructorTimeTableDataGridView.Name = "DataTableInstructorTimeTableDataGridView"
        Me.DataTableInstructorTimeTableDataGridView.ReadOnly = True
        Me.DataTableInstructorTimeTableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataTableInstructorTimeTableDataGridView.Size = New System.Drawing.Size(792, 602)
        Me.DataTableInstructorTimeTableDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Customer FirstName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Customer LastName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PickupVenue"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pickup Venue"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LessonDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LessonTime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'fromDate
        '
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fromDate.Location = New System.Drawing.Point(14, 23)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(234, 29)
        Me.fromDate.TabIndex = 3
        '
        'toDate
        '
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.toDate.Location = New System.Drawing.Point(6, 23)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(228, 29)
        Me.toDate.TabIndex = 4
        '
        'btnSearchInstructorTimeTame
        '
        Me.btnSearchInstructorTimeTame.Location = New System.Drawing.Point(239, 20)
        Me.btnSearchInstructorTimeTame.Name = "btnSearchInstructorTimeTame"
        Me.btnSearchInstructorTimeTame.Size = New System.Drawing.Size(89, 32)
        Me.btnSearchInstructorTimeTame.TabIndex = 6
        Me.btnSearchInstructorTimeTame.Text = "Search"
        Me.btnSearchInstructorTimeTame.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.fromDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(77, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 61)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.toDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(369, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 61)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.txtInstructorSearcher)
        Me.GroupBox3.Controls.Add(Me.btnSearchInstructorTimeTame)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(633, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 61)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Instructor ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox1.DataSource = Me.InstructorBindingSource
        Me.ComboBox1.DisplayMember = "FirstName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 32)
        Me.ComboBox1.TabIndex = 83
        Me.ComboBox1.TabStop = False
        Me.ComboBox1.ValueMember = "InstructorID"
        '
        'InstructorBindingSource
        '
        Me.InstructorBindingSource.DataMember = "Instructor"
        Me.InstructorBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'txtInstructorSearcher
        '
        Me.txtInstructorSearcher.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.txtInstructorSearcher.DataSource = Me.InstructorBindingSource
        Me.txtInstructorSearcher.DisplayMember = "InstructorID"
        Me.txtInstructorSearcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtInstructorSearcher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructorSearcher.FormattingEnabled = True
        Me.txtInstructorSearcher.Location = New System.Drawing.Point(27, 22)
        Me.txtInstructorSearcher.Name = "txtInstructorSearcher"
        Me.txtInstructorSearcher.Size = New System.Drawing.Size(100, 32)
        Me.txtInstructorSearcher.TabIndex = 82
        Me.txtInstructorSearcher.TabStop = False
        Me.txtInstructorSearcher.ValueMember = "InstructorID"
        '
        'btnPrintInstructorTimeTable
        '
        Me.btnPrintInstructorTimeTable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintInstructorTimeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintInstructorTimeTable.Location = New System.Drawing.Point(831, 828)
        Me.btnPrintInstructorTimeTable.Name = "btnPrintInstructorTimeTable"
        Me.btnPrintInstructorTimeTable.Size = New System.Drawing.Size(75, 49)
        Me.btnPrintInstructorTimeTable.TabIndex = 10
        Me.btnPrintInstructorTimeTable.Text = "Print"
        Me.btnPrintInstructorTimeTable.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.DataTableInstructorTimeTableDataGridView)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(77, 175)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(829, 647)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Instructor Time-Table"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 100)
        Me.Panel1.TabIndex = 13
        '
        'InstructorTableAdapter
        '
        Me.InstructorTableAdapter.ClearBeforeFill = True
        '
        'InstructorTimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(987, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnPrintInstructorTimeTable)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InstructorTimeTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstructorTimeTable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableInstructorTimeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableInstructorTimeTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents DataTableInstructorTimeTableBindingSource As BindingSource
    Friend WithEvents DataTableInstructorTimeTableTableAdapter As ist3bbDataSetTableAdapters.DataTableInstructorTimeTableTableAdapter
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataTableInstructorTimeTableDataGridView As DataGridView
    Friend WithEvents fromDate As DateTimePicker
    Friend WithEvents toDate As DateTimePicker
    Friend WithEvents btnSearchInstructorTimeTame As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPrintInstructorTimeTable As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents txtInstructorSearcher As ComboBox
    Friend WithEvents InstructorBindingSource As BindingSource
    Friend WithEvents InstructorTableAdapter As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
End Class
