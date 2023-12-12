<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateTimetable
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateTimetable))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookingDataGridView = New System.Windows.Forms.DataGridView()
        Me.LessonNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LessonDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LessonTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.Ist3bbDataSet2 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.BookingTableAdapter2 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CarTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CarTableAdapter()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.CarTableAdapter2 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CarTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbInstructorID = New System.Windows.Forms.ComboBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InstructorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.InstructorTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CustomerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CustomerTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.ComboBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.PaymentTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ist3bbDataSet3 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.BookingTableAdapter3 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.Ist3bbDataSet4 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        CarIDLabel = New System.Windows.Forms.Label()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Ist3bbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.Location = New System.Drawing.Point(469, -6)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(461, 109)
        CarIDLabel.TabIndex = 86
        CarIDLabel.Text = "Timetable"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(661, 649)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 47)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "Print "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 24)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Instructor ID"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(120, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 37)
        Me.Button4.TabIndex = 76
        Me.Button4.TabStop = False
        Me.Button4.Text = "Prev"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(197, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 37)
        Me.Button3.TabIndex = 75
        Me.Button3.TabStop = False
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(242, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 32)
        Me.Button2.TabIndex = 74
        Me.Button2.TabStop = False
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"})
        Me.ComboBox2.Location = New System.Drawing.Point(120, 307)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(116, 32)
        Me.ComboBox2.TabIndex = 72
        Me.ComboBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Time"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(120, 268)
        Me.DateTimePicker2.MinDate = New Date(2019, 8, 30, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(199, 29)
        Me.DateTimePicker2.TabIndex = 70
        Me.DateTimePicker2.TabStop = False
        Me.DateTimePicker2.Value = New Date(2019, 8, 30, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Date"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox1.DataSource = Me.BookingBindingSource
        Me.ComboBox1.DisplayMember = "LessonNumber"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 32)
        Me.ComboBox1.TabIndex = 68
        Me.ComboBox1.TabStop = False
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'Ist3bbDataSet1
        '
        Me.Ist3bbDataSet1.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Lesson"
        '
        'BookingDataGridView
        '
        Me.BookingDataGridView.AllowUserToAddRows = False
        Me.BookingDataGridView.AllowUserToDeleteRows = False
        Me.BookingDataGridView.AllowUserToResizeColumns = False
        Me.BookingDataGridView.AllowUserToResizeRows = False
        Me.BookingDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BookingDataGridView.AutoGenerateColumns = False
        Me.BookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookingDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.BookingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LessonNumberDataGridViewTextBoxColumn, Me.LessonDateDataGridViewTextBoxColumn, Me.LessonTimeDataGridViewTextBoxColumn})
        Me.BookingDataGridView.DataSource = Me.BookingBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookingDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BookingDataGridView.Location = New System.Drawing.Point(9, 17)
        Me.BookingDataGridView.Name = "BookingDataGridView"
        Me.BookingDataGridView.ReadOnly = True
        Me.BookingDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BookingDataGridView.Size = New System.Drawing.Size(342, 471)
        Me.BookingDataGridView.TabIndex = 66
        '
        'LessonNumberDataGridViewTextBoxColumn
        '
        Me.LessonNumberDataGridViewTextBoxColumn.DataPropertyName = "LessonNumber"
        Me.LessonNumberDataGridViewTextBoxColumn.HeaderText = "Lesson"
        Me.LessonNumberDataGridViewTextBoxColumn.Name = "LessonNumberDataGridViewTextBoxColumn"
        Me.LessonNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LessonDateDataGridViewTextBoxColumn
        '
        Me.LessonDateDataGridViewTextBoxColumn.DataPropertyName = "LessonDate"
        Me.LessonDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.LessonDateDataGridViewTextBoxColumn.Name = "LessonDateDataGridViewTextBoxColumn"
        Me.LessonDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LessonTimeDataGridViewTextBoxColumn
        '
        Me.LessonTimeDataGridViewTextBoxColumn.DataPropertyName = "LessonTime"
        Me.LessonTimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.LessonTimeDataGridViewTextBoxColumn.Name = "LessonTimeDataGridViewTextBoxColumn"
        Me.LessonTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'Ist3bbDataSet2
        '
        Me.Ist3bbDataSet2.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter2
        '
        Me.BookingTableAdapter2.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(484, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Search by CustomerID"
        '
        'CarTableAdapter1
        '
        Me.CarTableAdapter1.ClearBeforeFill = True
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "Car"
        Me.CarBindingSource.DataSource = Me.Ist3bbDataSet2
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter1
        Me.TableAdapterManager.CarTableAdapter = Me.CarTableAdapter1
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Instructor_CarTableAdapter = Nothing
        Me.TableAdapterManager.InstructorTableAdapter = Nothing
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarTableAdapter2
        '
        Me.CarTableAdapter2.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.tbInstructorID)
        Me.GroupBox1.Controls.Add(Me.tbLastName)
        Me.GroupBox1.Controls.Add(Me.tbFirstName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(90, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 391)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(150, 29)
        Me.TextBox2.TabIndex = 82
        Me.TextBox2.TabStop = False
        '
        'tbInstructorID
        '
        Me.tbInstructorID.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.tbInstructorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbInstructorID.Enabled = False
        Me.tbInstructorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInstructorID.FormattingEnabled = True
        Me.tbInstructorID.Location = New System.Drawing.Point(120, 110)
        Me.tbInstructorID.Name = "tbInstructorID"
        Me.tbInstructorID.Size = New System.Drawing.Size(150, 32)
        Me.tbInstructorID.TabIndex = 81
        Me.tbInstructorID.TabStop = False
        '
        'tbLastName
        '
        Me.tbLastName.Enabled = False
        Me.tbLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLastName.Location = New System.Drawing.Point(120, 65)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.ReadOnly = True
        Me.tbLastName.Size = New System.Drawing.Size(150, 29)
        Me.tbLastName.TabIndex = 80
        Me.tbLastName.TabStop = False
        '
        'tbFirstName
        '
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstName.Location = New System.Drawing.Point(120, 22)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.ReadOnly = True
        Me.tbFirstName.Size = New System.Drawing.Size(150, 29)
        Me.tbFirstName.TabIndex = 79
        Me.tbFirstName.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 24)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "First Name"
        '
        'InstructorBindingSource
        '
        Me.InstructorBindingSource.DataMember = "Instructor"
        Me.InstructorBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'InstructorTableAdapter1
        '
        Me.InstructorTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.BookingDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(436, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 501)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TextBox1.DataSource = Me.PaymentBindingSource
        Me.TextBox1.DisplayMember = "CustomerID"
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.FormattingEnabled = True
        Me.TextBox1.Location = New System.Drawing.Point(708, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 32)
        Me.TextBox1.TabIndex = 88
        Me.TextBox1.ValueMember = "CustomerID"
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(CarIDLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 100)
        Me.Panel1.TabIndex = 89
        '
        'BookingBindingSource1
        '
        Me.BookingBindingSource1.DataMember = "Booking"
        Me.BookingBindingSource1.DataSource = Me.Ist3bbDataSet2
        '
        'BookingDataGridView1
        '
        Me.BookingDataGridView1.AllowUserToAddRows = False
        Me.BookingDataGridView1.AllowUserToDeleteRows = False
        Me.BookingDataGridView1.AllowUserToResizeColumns = False
        Me.BookingDataGridView1.AllowUserToResizeRows = False
        Me.BookingDataGridView1.AutoGenerateColumns = False
        Me.BookingDataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.BookingDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookingDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookingDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.BookingDataGridView1.DataSource = Me.BookingBindingSource1
        Me.BookingDataGridView1.Location = New System.Drawing.Point(7, 46)
        Me.BookingDataGridView1.Name = "BookingDataGridView1"
        Me.BookingDataGridView1.ReadOnly = True
        Me.BookingDataGridView1.Size = New System.Drawing.Size(501, 442)
        Me.BookingDataGridView1.TabIndex = 89
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "InstructorID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Instructor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LicenseCode"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LessonDate"
        Me.DataGridViewTextBoxColumn14.HeaderText = "LessonDate"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 130
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "LessonTime"
        Me.DataGridViewTextBoxColumn15.HeaderText = "LessonTime"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 130
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.BookingDataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(813, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 501)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 24)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Instructor(s) Booked at:"
        '
        'Ist3bbDataSet3
        '
        Me.Ist3bbDataSet3.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter3
        '
        Me.BookingTableAdapter3.ClearBeforeFill = True
        '
        'Ist3bbDataSet4
        '
        Me.Ist3bbDataSet4.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreateTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1370, 734)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "CreateTimetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timetable"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Ist3bbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BookingDataGridView As DataGridView
    Friend WithEvents BookingTableAdapter1 As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents Ist3bbDataSet1 As ist3bbDataSet
    Friend WithEvents Ist3bbDataSet2 As ist3bbDataSet
    Friend WithEvents BookingTableAdapter2 As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents LessonNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LessonDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LessonTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarTableAdapter1 As ist3bbDataSetTableAdapters.CarTableAdapter
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarTableAdapter2 As ist3bbDataSetTableAdapters.CarTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents InstructorTableAdapter1 As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CustomerTableAdapter As ist3bbDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TextBox1 As ComboBox
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As ist3bbDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookingBindingSource1 As BindingSource
    Friend WithEvents BookingDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Ist3bbDataSet3 As ist3bbDataSet
    Friend WithEvents BookingTableAdapter3 As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents tbInstructorID As ComboBox
    Friend WithEvents InstructorBindingSource As BindingSource
    Friend WithEvents Ist3bbDataSet4 As ist3bbDataSet
    Friend WithEvents TextBox2 As TextBox
End Class
