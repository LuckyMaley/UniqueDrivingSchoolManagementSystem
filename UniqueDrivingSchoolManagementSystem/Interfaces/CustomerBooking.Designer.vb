<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerBooking
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
        Dim CarIDLabel As System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dtpTestDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CbLessons = New System.Windows.Forms.ComboBox()
        Me.cbBookingStatus = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.tbVenue = New System.Windows.Forms.TextBox()
        Me.cbLessonCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rbPerLesson = New System.Windows.Forms.RadioButton()
        Me.rbFullCourse = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCellNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.butto1 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbCustomerID1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbHouseNumber = New System.Windows.Forms.TextBox()
        Me.tbZipCode = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbStreetName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BookingTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.CustomerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CustomerTableAdapter()
        Me.PaymentTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.PaymentTableAdapter()
        Me.ManagerTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.ManagerTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CarIDLabel = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.Location = New System.Drawing.Point(211, -9)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(813, 109)
        CarIDLabel.TabIndex = 20
        CarIDLabel.Text = "Customer Booking"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox6.Controls.Add(Me.dtpTestDate)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.CbLessons)
        Me.GroupBox6.Controls.Add(Me.cbBookingStatus)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.cbLessonCode)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.rbPerLesson)
        Me.GroupBox6.Controls.Add(Me.rbFullCourse)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.tbPrice)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(586, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(506, 458)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Booking"
        '
        'dtpTestDate
        '
        Me.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTestDate.Location = New System.Drawing.Point(159, 385)
        Me.dtpTestDate.Name = "dtpTestDate"
        Me.dtpTestDate.Size = New System.Drawing.Size(197, 29)
        Me.dtpTestDate.TabIndex = 17
        Me.dtpTestDate.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 24)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Driving Test Date"
        '
        'CbLessons
        '
        Me.CbLessons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLessons.FormattingEnabled = True
        Me.CbLessons.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CbLessons.Location = New System.Drawing.Point(159, 136)
        Me.CbLessons.Name = "CbLessons"
        Me.CbLessons.Size = New System.Drawing.Size(52, 32)
        Me.CbLessons.TabIndex = 14
        Me.CbLessons.TabStop = False
        '
        'cbBookingStatus
        '
        Me.cbBookingStatus.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBookingStatus.FormattingEnabled = True
        Me.cbBookingStatus.Items.AddRange(New Object() {"In Progress"})
        Me.cbBookingStatus.Location = New System.Drawing.Point(159, 340)
        Me.cbBookingStatus.Name = "cbBookingStatus"
        Me.cbBookingStatus.Size = New System.Drawing.Size(197, 32)
        Me.cbBookingStatus.TabIndex = 16
        Me.cbBookingStatus.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 340)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 24)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Booking Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Lessons"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 24)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Pick Up"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbNo)
        Me.Panel1.Controls.Add(Me.rbYes)
        Me.Panel1.Controls.Add(Me.tbVenue)
        Me.Panel1.Location = New System.Drawing.Point(11, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 77)
        Me.Panel1.TabIndex = 40
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(12, 37)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(53, 28)
        Me.rbNo.TabIndex = 16
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Location = New System.Drawing.Point(12, 3)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(60, 28)
        Me.rbYes.TabIndex = 15
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'tbVenue
        '
        Me.tbVenue.Enabled = False
        Me.tbVenue.Location = New System.Drawing.Point(148, 3)
        Me.tbVenue.Name = "tbVenue"
        Me.tbVenue.Size = New System.Drawing.Size(128, 29)
        Me.tbVenue.TabIndex = 12
        Me.tbVenue.TabStop = False
        Me.tbVenue.Text = "None"
        '
        'cbLessonCode
        '
        Me.cbLessonCode.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbLessonCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLessonCode.FormattingEnabled = True
        Me.cbLessonCode.Items.AddRange(New Object() {"08", "10"})
        Me.cbLessonCode.Location = New System.Drawing.Point(159, 33)
        Me.cbLessonCode.Name = "cbLessonCode"
        Me.cbLessonCode.Size = New System.Drawing.Size(52, 32)
        Me.cbLessonCode.TabIndex = 11
        Me.cbLessonCode.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(155, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 24)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Venue"
        '
        'rbPerLesson
        '
        Me.rbPerLesson.AutoSize = True
        Me.rbPerLesson.Location = New System.Drawing.Point(141, 98)
        Me.rbPerLesson.Name = "rbPerLesson"
        Me.rbPerLesson.Size = New System.Drawing.Size(123, 28)
        Me.rbPerLesson.TabIndex = 13
        Me.rbPerLesson.Text = "Per Lesson"
        Me.rbPerLesson.UseVisualStyleBackColor = True
        '
        'rbFullCourse
        '
        Me.rbFullCourse.AutoSize = True
        Me.rbFullCourse.Location = New System.Drawing.Point(10, 98)
        Me.rbFullCourse.Name = "rbFullCourse"
        Me.rbFullCourse.Size = New System.Drawing.Size(125, 28)
        Me.rbFullCourse.TabIndex = 12
        Me.rbFullCourse.Text = "Full Course"
        Me.rbFullCourse.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 24)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Booking Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 24)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Total Cost"
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(159, 182)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.ReadOnly = True
        Me.tbPrice.Size = New System.Drawing.Size(127, 29)
        Me.tbPrice.TabIndex = 23
        Me.tbPrice.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 24)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "License Code"
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCustomer.Location = New System.Drawing.Point(985, 579)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(107, 64)
        Me.btnSaveCustomer.TabIndex = 0
        Me.btnSaveCustomer.TabStop = False
        Me.btnSaveCustomer.Text = "Save"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbCellNumber)
        Me.GroupBox3.Controls.Add(Me.cbGender)
        Me.GroupBox3.Controls.Add(Me.dtpDateOfBirth)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbEmail)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.butto1)
        Me.GroupBox3.Controls.Add(Me.tbLastName)
        Me.GroupBox3.Controls.Add(Me.tbFirstName)
        Me.GroupBox3.Controls.Add(Me.tbCustomerID1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(77, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 329)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Details"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(443, 286)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 31)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(443, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 31)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(443, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 31)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(444, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(444, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(444, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "*"
        '
        'tbCellNumber
        '
        Me.tbCellNumber.Location = New System.Drawing.Point(171, 243)
        Me.tbCellNumber.Mask = "000-000-0000"
        Me.tbCellNumber.Name = "tbCellNumber"
        Me.tbCellNumber.Size = New System.Drawing.Size(267, 29)
        Me.tbCellNumber.TabIndex = 5
        Me.tbCellNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cbGender
        '
        Me.cbGender.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"M", "F"})
        Me.cbGender.Location = New System.Drawing.Point(170, 196)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(267, 32)
        Me.cbGender.TabIndex = 4
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(171, 154)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(267, 29)
        Me.dtpDateOfBirth.TabIndex = 3
        Me.dtpDateOfBirth.Value = New Date(2000, 2, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 24)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(171, 285)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(267, 29)
        Me.tbEmail.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "First Name"
        '
        'butto1
        '
        Me.butto1.AutoSize = True
        Me.butto1.Location = New System.Drawing.Point(21, 33)
        Me.butto1.Name = "butto1"
        Me.butto1.Size = New System.Drawing.Size(104, 24)
        Me.butto1.TabIndex = 21
        Me.butto1.Text = "CusomerID"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(171, 113)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(267, 29)
        Me.tbLastName.TabIndex = 2
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(171, 73)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(267, 29)
        Me.tbFirstName.TabIndex = 0
        '
        'tbCustomerID1
        '
        Me.tbCustomerID1.Enabled = False
        Me.tbCustomerID1.Location = New System.Drawing.Point(171, 33)
        Me.tbCustomerID1.Name = "tbCustomerID1"
        Me.tbCustomerID1.ReadOnly = True
        Me.tbCustomerID1.Size = New System.Drawing.Size(267, 29)
        Me.tbCustomerID1.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.tbHouseNumber)
        Me.GroupBox2.Controls.Add(Me.tbZipCode)
        Me.GroupBox2.Controls.Add(Me.tbCity)
        Me.GroupBox2.Controls.Add(Me.tbStreetName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(77, 441)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 207)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(443, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 31)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(445, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 31)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "*"
        '
        'tbHouseNumber
        '
        Me.tbHouseNumber.Location = New System.Drawing.Point(172, 34)
        Me.tbHouseNumber.Name = "tbHouseNumber"
        Me.tbHouseNumber.Size = New System.Drawing.Size(267, 29)
        Me.tbHouseNumber.TabIndex = 7
        '
        'tbZipCode
        '
        Me.tbZipCode.Location = New System.Drawing.Point(172, 170)
        Me.tbZipCode.Name = "tbZipCode"
        Me.tbZipCode.Size = New System.Drawing.Size(267, 29)
        Me.tbZipCode.TabIndex = 10
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(171, 125)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(267, 29)
        Me.tbCity.TabIndex = 9
        '
        'tbStreetName
        '
        Me.tbStreetName.Location = New System.Drawing.Point(172, 78)
        Me.tbStreetName.Name = "tbStreetName"
        Me.tbStreetName.Size = New System.Drawing.Size(267, 29)
        Me.tbStreetName.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "City or Town"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(22, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 24)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Street Name"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 170)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 24)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Zip Code"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 34)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(140, 24)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "House Number"
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PaymentTableAdapter1
        '
        Me.PaymentTableAdapter1.ClearBeforeFill = True
        '
        'ManagerTableAdapter1
        '
        Me.ManagerTableAdapter1.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(CarIDLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1218, 100)
        Me.Panel2.TabIndex = 25
        '
        'CustomerBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1218, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSaveCustomer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "CustomerBooking"
        Me.Text = "Booking"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents BookingTableAdapter As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cbBookingStatus As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents tbVenue As TextBox
    Friend WithEvents cbLessonCode As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents rbPerLesson As RadioButton
    Friend WithEvents rbFullCourse As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CustomerTableAdapter As ist3bbDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents btnSaveCustomer As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents butto1 As Label
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbCustomerID1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbHouseNumber As TextBox
    Friend WithEvents tbZipCode As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbStreetName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents CbLessons As ComboBox
    Friend WithEvents PaymentTableAdapter1 As ist3bbDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents ManagerTableAdapter1 As ist3bbDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents dtpTestDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents tbCellNumber As MaskedTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
End Class
