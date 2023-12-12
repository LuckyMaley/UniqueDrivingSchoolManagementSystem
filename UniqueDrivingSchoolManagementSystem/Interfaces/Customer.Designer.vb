<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.CustomerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CustomerTableAdapter()
        Me.BookingTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpTestDate = New System.Windows.Forms.DateTimePicker()
        Me.cbTestResults = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbCellNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.butto1 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbCustomerID = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbHouseNumber = New System.Windows.Forms.TextBox()
        Me.tbZipCode = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbStreetName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.FKBookingCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.tbVenue = New System.Windows.Forms.TextBox()
        Me.ManagerTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.ManagerTableAdapter()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.PaymentTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.PaymentTableAdapter()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbBookingStatus = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CarIDLabel = New System.Windows.Forms.Label()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FKBookingCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.Location = New System.Drawing.Point(178, -6)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(688, 109)
        CarIDLabel.TabIndex = 13
        CarIDLabel.Text = "Edit Customers"
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(203, 24)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Search by Customer ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 698)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Customer"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataSource = Me.CustomerBindingSource
        Me.ComboBox3.DisplayMember = "CustomerID"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(218, 31)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(241, 32)
        Me.ComboBox3.TabIndex = 30
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtpTestDate)
        Me.GroupBox5.Controls.Add(Me.cbTestResults)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 576)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 116)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Driving Test Details"
        '
        'dtpTestDate
        '
        Me.dtpTestDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DrivingTestDate", True))
        Me.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTestDate.Location = New System.Drawing.Point(213, 23)
        Me.dtpTestDate.Name = "dtpTestDate"
        Me.dtpTestDate.Size = New System.Drawing.Size(241, 29)
        Me.dtpTestDate.TabIndex = 16
        '
        'cbTestResults
        '
        Me.cbTestResults.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbTestResults.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DrivingTestResult", True))
        Me.cbTestResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTestResults.FormattingEnabled = True
        Me.cbTestResults.Items.AddRange(New Object() {"Pass", "Failed"})
        Me.cbTestResults.Location = New System.Drawing.Point(213, 64)
        Me.cbTestResults.Name = "cbTestResults"
        Me.cbTestResults.Size = New System.Drawing.Size(241, 32)
        Me.cbTestResults.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Driving Test Results"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Driving Test Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbCellNumber)
        Me.GroupBox3.Controls.Add(Me.cbGender)
        Me.GroupBox3.Controls.Add(Me.dtpDateOfBirth)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbEmail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.butto1)
        Me.GroupBox3.Controls.Add(Me.tbLastName)
        Me.GroupBox3.Controls.Add(Me.tbFirstName)
        Me.GroupBox3.Controls.Add(Me.tbCustomerID)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 301)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Details"
        '
        'tbCellNumber
        '
        Me.tbCellNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cellphone", True))
        Me.tbCellNumber.Location = New System.Drawing.Point(212, 225)
        Me.tbCellNumber.Mask = "000-000-0000"
        Me.tbCellNumber.Name = "tbCellNumber"
        Me.tbCellNumber.Size = New System.Drawing.Size(241, 29)
        Me.tbCellNumber.TabIndex = 59
        Me.tbCellNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cbGender
        '
        Me.cbGender.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Gender", True))
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"M", "F"})
        Me.cbGender.Location = New System.Drawing.Point(212, 182)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(241, 32)
        Me.cbGender.TabIndex = 58
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "DateOfBirth", True))
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(212, 142)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(241, 29)
        Me.dtpDateOfBirth.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 24)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "EmailAddress", True))
        Me.tbEmail.Location = New System.Drawing.Point(212, 265)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(241, 29)
        Me.tbEmail.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Date Of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "First Name"
        '
        'butto1
        '
        Me.butto1.AutoSize = True
        Me.butto1.Location = New System.Drawing.Point(38, 27)
        Me.butto1.Name = "butto1"
        Me.butto1.Size = New System.Drawing.Size(113, 24)
        Me.butto1.TabIndex = 3
        Me.butto1.Text = "Customer ID"
        '
        'tbLastName
        '
        Me.tbLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.tbLastName.Location = New System.Drawing.Point(212, 104)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(241, 29)
        Me.tbLastName.TabIndex = 2
        '
        'tbFirstName
        '
        Me.tbFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.tbFirstName.Location = New System.Drawing.Point(212, 63)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(241, 29)
        Me.tbFirstName.TabIndex = 1
        '
        'tbCustomerID
        '
        Me.tbCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.tbCustomerID.Enabled = False
        Me.tbCustomerID.Location = New System.Drawing.Point(212, 24)
        Me.tbCustomerID.Name = "tbCustomerID"
        Me.tbCustomerID.Size = New System.Drawing.Size(241, 29)
        Me.tbCustomerID.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbHouseNumber)
        Me.GroupBox4.Controls.Add(Me.tbZipCode)
        Me.GroupBox4.Controls.Add(Me.tbCity)
        Me.GroupBox4.Controls.Add(Me.tbStreetName)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 381)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(555, 193)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Address"
        '
        'tbHouseNumber
        '
        Me.tbHouseNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "HouseNumber", True))
        Me.tbHouseNumber.Location = New System.Drawing.Point(212, 25)
        Me.tbHouseNumber.Name = "tbHouseNumber"
        Me.tbHouseNumber.Size = New System.Drawing.Size(242, 29)
        Me.tbHouseNumber.TabIndex = 11
        '
        'tbZipCode
        '
        Me.tbZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ZipCode", True))
        Me.tbZipCode.Location = New System.Drawing.Point(212, 142)
        Me.tbZipCode.Name = "tbZipCode"
        Me.tbZipCode.Size = New System.Drawing.Size(242, 29)
        Me.tbZipCode.TabIndex = 10
        '
        'tbCity
        '
        Me.tbCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CityOrTown", True))
        Me.tbCity.Location = New System.Drawing.Point(212, 102)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(242, 29)
        Me.tbCity.TabIndex = 9
        '
        'tbStreetName
        '
        Me.tbStreetName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "StreetName", True))
        Me.tbStreetName.Location = New System.Drawing.Point(212, 62)
        Me.tbStreetName.Name = "tbStreetName"
        Me.tbStreetName.Size = New System.Drawing.Size(242, 29)
        Me.tbStreetName.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(39, 102)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 24)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "City or Town"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(39, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 24)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Street Name"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(39, 142)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 24)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Zip Code"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(39, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(140, 24)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "House Number"
        '
        'BookingBindingSource1
        '
        Me.BookingBindingSource1.DataMember = "FK_Booking_Customer"
        Me.BookingBindingSource1.DataSource = Me.CustomerBindingSource
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.btnLast)
        Me.GroupBox2.Controls.Add(Me.btnFirst)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 810)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 87)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Navigate"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 26)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(98, 55)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 26)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(98, 55)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(110, 26)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(98, 55)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(352, 26)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(98, 55)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'FKBookingCustomerBindingSource
        '
        Me.FKBookingCustomerBindingSource.DataMember = "FK_Booking_Customer"
        Me.FKBookingCustomerBindingSource.DataSource = Me.CustomerBindingSource
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCustomer.Location = New System.Drawing.Point(843, 338)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(107, 64)
        Me.btnSaveCustomer.TabIndex = 20
        Me.btnSaveCustomer.TabStop = False
        Me.btnSaveCustomer.Text = "Save"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(622, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(305, 161)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Edit Pickup"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 24)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Pick Up"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(154, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 24)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Venue"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbNo)
        Me.Panel1.Controls.Add(Me.rbYes)
        Me.Panel1.Controls.Add(Me.tbVenue)
        Me.Panel1.Location = New System.Drawing.Point(10, 71)
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
        Me.tbVenue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource1, "PickupVenue", True))
        Me.tbVenue.Enabled = False
        Me.tbVenue.Location = New System.Drawing.Point(148, 3)
        Me.tbVenue.Name = "tbVenue"
        Me.tbVenue.Size = New System.Drawing.Size(128, 29)
        Me.tbVenue.TabIndex = 12
        Me.tbVenue.TabStop = False
        Me.tbVenue.Text = "None"
        '
        'ManagerTableAdapter1
        '
        Me.ManagerTableAdapter1.ClearBeforeFill = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(730, 338)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 64)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'PaymentTableAdapter1
        '
        Me.PaymentTableAdapter1.ClearBeforeFill = True
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(629, 282)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 24)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Booking Status"
        '
        'cbBookingStatus
        '
        Me.cbBookingStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbBookingStatus.AutoCompleteCustomSource.AddRange(New String() {"Code 8", "Code 10"})
        Me.cbBookingStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource1, "BookingStatus", True))
        Me.cbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBookingStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBookingStatus.FormattingEnabled = True
        Me.cbBookingStatus.Items.AddRange(New Object() {"In Progress", "Complete", "Cancelled"})
        Me.cbBookingStatus.Location = New System.Drawing.Point(769, 282)
        Me.cbBookingStatus.Name = "cbBookingStatus"
        Me.cbBookingStatus.Size = New System.Drawing.Size(148, 32)
        Me.cbBookingStatus.TabIndex = 40
        Me.cbBookingStatus.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(CarIDLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 100)
        Me.Panel2.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(617, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 64)
        Me.Button1.TabIndex = 42
        Me.Button1.TabStop = False
        Me.Button1.Text = "Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbBookingStatus)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSaveCustomer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Customer"
        Me.Text = "Customer "
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FKBookingCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ist3bbDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents BookingTableAdapter As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BookingBindingSource1 As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtpTestDate As DateTimePicker
    Friend WithEvents cbTestResults As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents butto1 As Label
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbCustomerID As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbHouseNumber As TextBox
    Friend WithEvents tbZipCode As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbStreetName As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents FKBookingCustomerBindingSource As BindingSource
    Friend WithEvents btnSaveCustomer As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents tbVenue As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbCellNumber As MaskedTextBox
    Friend WithEvents ManagerTableAdapter1 As ist3bbDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents btnDelete As Button
    Friend WithEvents PaymentTableAdapter1 As ist3bbDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents Label20 As Label
    Friend WithEvents cbBookingStatus As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
