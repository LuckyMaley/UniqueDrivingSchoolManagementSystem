<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DailySchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CarIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailySchedule))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.DataTable1TableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.DataTable1TableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lessons = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstructorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cellphone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrivingTestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickupVenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LessonNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LessonTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        CarIDLabel = New System.Windows.Forms.Label()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.Location = New System.Drawing.Point(298, -9)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(658, 109)
        CarIDLabel.TabIndex = 87
        CarIDLabel.Text = "Daily Schedule"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Ist3bbDataSet
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Today's Lesson(s):"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by Lesson Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(565, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(310, 29)
        Me.DateTimePicker1.TabIndex = 5
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(CarIDLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 100)
        Me.Panel1.TabIndex = 92
        '
        'lessons
        '
        Me.lessons.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lessons.AutoSize = True
        Me.lessons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lessons.Location = New System.Drawing.Point(194, 112)
        Me.lessons.Name = "lessons"
        Me.lessons.Size = New System.Drawing.Size(19, 20)
        Me.lessons.TabIndex = 89
        Me.lessons.Text = "#"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerID, Me.InstructorID, Me.FirstName, Me.LastName, Me.Gender, Me.Cellphone, Me.DrivingTestDate, Me.BookingDateDataGridViewTextBoxColumn, Me.LicenseCodeDataGridViewTextBoxColumn, Me.PickupVenueDataGridViewTextBoxColumn, Me.LessonNumberDataGridViewTextBoxColumn, Me.LessonTimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1153, 437)
        Me.DataGridView1.TabIndex = 88
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "CustomerID"
        Me.CustomerID.HeaderText = "Customer"
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        '
        'InstructorID
        '
        Me.InstructorID.DataPropertyName = "InstructorID"
        Me.InstructorID.HeaderText = "Instructor"
        Me.InstructorID.Name = "InstructorID"
        Me.InstructorID.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Cellphone
        '
        Me.Cellphone.DataPropertyName = "Cellphone"
        Me.Cellphone.HeaderText = "Cellphone"
        Me.Cellphone.Name = "Cellphone"
        Me.Cellphone.ReadOnly = True
        '
        'DrivingTestDate
        '
        Me.DrivingTestDate.DataPropertyName = "DrivingTestDate"
        Me.DrivingTestDate.HeaderText = "Test Date"
        Me.DrivingTestDate.Name = "DrivingTestDate"
        Me.DrivingTestDate.ReadOnly = True
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        Me.BookingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LicenseCodeDataGridViewTextBoxColumn
        '
        Me.LicenseCodeDataGridViewTextBoxColumn.DataPropertyName = "LicenseCode"
        Me.LicenseCodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.LicenseCodeDataGridViewTextBoxColumn.Name = "LicenseCodeDataGridViewTextBoxColumn"
        Me.LicenseCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PickupVenueDataGridViewTextBoxColumn
        '
        Me.PickupVenueDataGridViewTextBoxColumn.DataPropertyName = "PickupVenue"
        Me.PickupVenueDataGridViewTextBoxColumn.HeaderText = "Pickup Venue"
        Me.PickupVenueDataGridViewTextBoxColumn.Name = "PickupVenueDataGridViewTextBoxColumn"
        Me.PickupVenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LessonNumberDataGridViewTextBoxColumn
        '
        Me.LessonNumberDataGridViewTextBoxColumn.DataPropertyName = "LessonNumber"
        Me.LessonNumberDataGridViewTextBoxColumn.HeaderText = "LessonNo."
        Me.LessonNumberDataGridViewTextBoxColumn.Name = "LessonNumberDataGridViewTextBoxColumn"
        Me.LessonNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LessonTimeDataGridViewTextBoxColumn
        '
        Me.LessonTimeDataGridViewTextBoxColumn.DataPropertyName = "LessonTime"
        Me.LessonTimeDataGridViewTextBoxColumn.HeaderText = "Lesson Time"
        Me.LessonTimeDataGridViewTextBoxColumn.Name = "LessonTimeDataGridViewTextBoxColumn"
        Me.LessonTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1472, 621)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 44)
        Me.btnPrint.TabIndex = 91
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1165, 475)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
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
        'DailySchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1231, 655)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lessons)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DailySchedule"
        Me.Text = "Daily Schedule"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As ist3bbDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lessons As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents InstructorID As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Cellphone As DataGridViewTextBoxColumn
    Friend WithEvents DrivingTestDate As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicenseCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PickupVenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LessonNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LessonTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
End Class
