<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Instructor
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
        Dim Label4 As System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSaveInstructor = New System.Windows.Forms.Button()
        Me.btnAddInstructor = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblInstructorID = New System.Windows.Forms.Label()
        Me.tbInstructorID = New System.Windows.Forms.TextBox()
        Me.InstructorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Label()
        Me.tbSearchInstr = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbHouseNumber = New System.Windows.Forms.TextBox()
        Me.tbZipCode = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbStreetName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.InstructorDataGridView = New System.Windows.Forms.DataGridView()
        Me.InstructorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnInstructorTimeTable = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InstructorTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.InstructorTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        Me.Instructor_CarTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.Instructor_CarTableAdapter()
        Me.Ist3bbDataSet1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.InstructorCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        CarIDLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InstructorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.ForeColor = System.Drawing.SystemColors.ControlText
        CarIDLabel.Location = New System.Drawing.Point(265, -6)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(468, 109)
        CarIDLabel.TabIndex = 13
        CarIDLabel.Text = "Instructor"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(24, 172)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(144, 24)
        Label4.TabIndex = 28
        Label4.Text = "Assigned Car(s)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.btnSaveInstructor)
        Me.GroupBox4.Controls.Add(Me.btnAddInstructor)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(465, 73)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(247, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 39)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSaveInstructor
        '
        Me.btnSaveInstructor.Enabled = False
        Me.btnSaveInstructor.Location = New System.Drawing.Point(352, 28)
        Me.btnSaveInstructor.Name = "btnSaveInstructor"
        Me.btnSaveInstructor.Size = New System.Drawing.Size(99, 39)
        Me.btnSaveInstructor.TabIndex = 13
        Me.btnSaveInstructor.Text = "Save"
        Me.btnSaveInstructor.UseVisualStyleBackColor = True
        '
        'btnAddInstructor
        '
        Me.btnAddInstructor.Location = New System.Drawing.Point(8, 28)
        Me.btnAddInstructor.Name = "btnAddInstructor"
        Me.btnAddInstructor.Size = New System.Drawing.Size(99, 39)
        Me.btnAddInstructor.TabIndex = 4
        Me.btnAddInstructor.Text = "Add"
        Me.btnAddInstructor.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(113, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 39)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.lblInstructorID)
        Me.GroupBox3.Controls.Add(Me.tbInstructorID)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbLastName)
        Me.GroupBox3.Controls.Add(Me.tbFirstName)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 267)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(417, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "*"
        Me.Label5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(417, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "*"
        Me.Label1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 207)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(212, 29)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(201, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 29)
        Me.TextBox1.TabIndex = 29
        '
        'lblInstructorID
        '
        Me.lblInstructorID.AutoSize = True
        Me.lblInstructorID.Location = New System.Drawing.Point(22, 39)
        Me.lblInstructorID.Name = "lblInstructorID"
        Me.lblInstructorID.Size = New System.Drawing.Size(108, 24)
        Me.lblInstructorID.TabIndex = 7
        Me.lblInstructorID.Text = "Instructor ID"
        '
        'tbInstructorID
        '
        Me.tbInstructorID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "InstructorID", True))
        Me.tbInstructorID.Enabled = False
        Me.tbInstructorID.Location = New System.Drawing.Point(198, 34)
        Me.tbInstructorID.Name = "tbInstructorID"
        Me.tbInstructorID.Size = New System.Drawing.Size(214, 29)
        Me.tbInstructorID.TabIndex = 6
        '
        'InstructorBindingSource
        '
        Me.InstructorBindingSource.DataMember = "Instructor"
        Me.InstructorBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'tbLastName
        '
        Me.tbLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "LastName", True))
        Me.tbLastName.Location = New System.Drawing.Point(198, 121)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(213, 29)
        Me.tbLastName.TabIndex = 2
        '
        'tbFirstName
        '
        Me.tbFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "FirstName", True))
        Me.tbFirstName.Location = New System.Drawing.Point(199, 78)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(213, 29)
        Me.tbFirstName.TabIndex = 1
        '
        'button1
        '
        Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button1.AutoSize = True
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(602, 122)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(191, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Search by First Name"
        '
        'tbSearchInstr
        '
        Me.tbSearchInstr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearchInstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchInstr.Location = New System.Drawing.Point(809, 117)
        Me.tbSearchInstr.Name = "tbSearchInstr"
        Me.tbSearchInstr.Size = New System.Drawing.Size(141, 29)
        Me.tbSearchInstr.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbHouseNumber)
        Me.GroupBox2.Controls.Add(Me.tbZipCode)
        Me.GroupBox2.Controls.Add(Me.tbCity)
        Me.GroupBox2.Controls.Add(Me.tbStreetName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 458)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 203)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(417, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 31)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "*"
        Me.Label10.Visible = False
        '
        'tbHouseNumber
        '
        Me.tbHouseNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "HouseNumber", True))
        Me.tbHouseNumber.Location = New System.Drawing.Point(198, 25)
        Me.tbHouseNumber.Name = "tbHouseNumber"
        Me.tbHouseNumber.Size = New System.Drawing.Size(213, 29)
        Me.tbHouseNumber.TabIndex = 11
        '
        'tbZipCode
        '
        Me.tbZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "ZipCode", True))
        Me.tbZipCode.Location = New System.Drawing.Point(197, 157)
        Me.tbZipCode.Name = "tbZipCode"
        Me.tbZipCode.Size = New System.Drawing.Size(214, 29)
        Me.tbZipCode.TabIndex = 10
        '
        'tbCity
        '
        Me.tbCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "CityOrTown", True))
        Me.tbCity.Location = New System.Drawing.Point(199, 113)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(213, 29)
        Me.tbCity.TabIndex = 9
        '
        'tbStreetName
        '
        Me.tbStreetName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstructorBindingSource, "StreetName", True))
        Me.tbStreetName.Location = New System.Drawing.Point(198, 68)
        Me.tbStreetName.Name = "tbStreetName"
        Me.tbStreetName.Size = New System.Drawing.Size(213, 29)
        Me.tbStreetName.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "City or Town"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Street Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "House Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 656)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Navigate"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(87, 28)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(95, 36)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(374, 28)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 36)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(275, 28)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(93, 36)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(6, 28)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 36)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'InstructorDataGridView
        '
        Me.InstructorDataGridView.AllowUserToAddRows = False
        Me.InstructorDataGridView.AllowUserToDeleteRows = False
        Me.InstructorDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InstructorDataGridView.AutoGenerateColumns = False
        Me.InstructorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InstructorDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.InstructorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InstructorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InstructorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstructorID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.InstructorDataGridView.DataSource = Me.InstructorBindingSource
        Me.InstructorDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.InstructorDataGridView.Name = "InstructorDataGridView"
        Me.InstructorDataGridView.ReadOnly = True
        Me.InstructorDataGridView.Size = New System.Drawing.Size(451, 397)
        Me.InstructorDataGridView.TabIndex = 13
        '
        'InstructorID
        '
        Me.InstructorID.DataPropertyName = "InstructorID"
        Me.InstructorID.HeaderText = "Instructor"
        Me.InstructorID.Name = "InstructorID"
        Me.InstructorID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.btnInstructorTimeTable)
        Me.GroupBox5.Controls.Add(Me.InstructorDataGridView)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(512, 150)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(463, 489)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        '
        'btnInstructorTimeTable
        '
        Me.btnInstructorTimeTable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInstructorTimeTable.BackColor = System.Drawing.Color.SeaGreen
        Me.btnInstructorTimeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructorTimeTable.Location = New System.Drawing.Point(6, 438)
        Me.btnInstructorTimeTable.Name = "btnInstructorTimeTable"
        Me.btnInstructorTimeTable.Size = New System.Drawing.Size(451, 45)
        Me.btnInstructorTimeTable.TabIndex = 16
        Me.btnInstructorTimeTable.Text = "View Instructor TimeTable"
        Me.btnInstructorTimeTable.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(CarIDLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 100)
        Me.Panel1.TabIndex = 15
        '
        'InstructorTableAdapter
        '
        Me.InstructorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Instructor_CarTableAdapter = Nothing
        Me.TableAdapterManager.InstructorTableAdapter = Me.InstructorTableAdapter
        Me.TableAdapterManager.ManagerTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InstructorTableAdapter1
        '
        Me.InstructorTableAdapter1.ClearBeforeFill = True
        '
        'Instructor_CarTableAdapter1
        '
        Me.Instructor_CarTableAdapter1.ClearBeforeFill = True
        '
        'Ist3bbDataSet1
        '
        Me.Ist3bbDataSet1.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstructorCarBindingSource
        '
        Me.InstructorCarBindingSource.DataMember = "Instructor_Car"
        Me.InstructorCarBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'Instructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbSearchInstr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "Instructor"
        Me.Text = "Instructor"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.InstructorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents button1 As Label
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbSearchInstr As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbHouseNumber As TextBox
    Friend WithEvents tbZipCode As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbStreetName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents InstructorBindingSource As BindingSource
    Friend WithEvents InstructorTableAdapter As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents btnSaveInstructor As Button
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InstructorDataGridView As DataGridView
    Friend WithEvents InstructorID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lblInstructorID As Label
    Friend WithEvents tbInstructorID As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents InstructorTableAdapter1 As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Instructor_CarTableAdapter1 As ist3bbDataSetTableAdapters.Instructor_CarTableAdapter
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Ist3bbDataSet1 As ist3bbDataSet
    Friend WithEvents InstructorCarBindingSource As BindingSource
    Friend WithEvents btnInstructorTimeTable As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BookingTableAdapter1 As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
End Class
