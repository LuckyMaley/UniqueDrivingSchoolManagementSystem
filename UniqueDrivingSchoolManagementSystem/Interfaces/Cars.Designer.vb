<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cars
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
        Dim ModelLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.btnSaveCar = New System.Windows.Forms.Button()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.tbCarID = New System.Windows.Forms.TextBox()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.tbStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbText1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbcarType = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InstructorCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.CarTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CarTableAdapter()
        Me.Instructor_CarTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.Instructor_CarTableAdapter()
        Me.Ist3bbDataSet2 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.BookingTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.CarTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CarTableAdapter()
        Me.Ist3bbDataSet3 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.InstructorTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        Me.InstructorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CarIDLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.InstructorCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarIDLabel
        '
        CarIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        CarIDLabel.AutoSize = True
        CarIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarIDLabel.Location = New System.Drawing.Point(24, 20)
        CarIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CarIDLabel.Name = "CarIDLabel"
        CarIDLabel.Size = New System.Drawing.Size(80, 29)
        CarIDLabel.TabIndex = 12
        CarIDLabel.Text = "Car ID"
        '
        'ModelLabel
        '
        ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ModelLabel.AutoSize = True
        ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModelLabel.Location = New System.Drawing.Point(24, 68)
        ModelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(81, 29)
        ModelLabel.TabIndex = 16
        ModelLabel.Text = "Model"
        '
        'StatusLabel
        '
        StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(24, 118)
        StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(79, 29)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "Status"
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(725, -11)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(304, 135)
        Label1.TabIndex = 22
        Label1.Text = "Cars"
        '
        'Label2
        '
        Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(24, 170)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(112, 29)
        Label2.TabIndex = 24
        Label2.Text = "Car Type"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(560, 134)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(209, 29)
        Label3.TabIndex = 26
        Label3.Text = "Search by model"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(8, 231)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(217, 29)
        Label4.TabIndex = 26
        Label4.Text = "Assigned Instructor"
        '
        'btnSaveCar
        '
        Me.btnSaveCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveCar.Enabled = False
        Me.btnSaveCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCar.Location = New System.Drawing.Point(347, 278)
        Me.btnSaveCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveCar.Name = "btnSaveCar"
        Me.btnSaveCar.Size = New System.Drawing.Size(100, 46)
        Me.btnSaveCar.TabIndex = 21
        Me.btnSaveCar.Text = "Save"
        Me.btnSaveCar.UseVisualStyleBackColor = True
        '
        'btnAddCar
        '
        Me.btnAddCar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCar.Location = New System.Drawing.Point(11, 278)
        Me.btnAddCar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(100, 46)
        Me.btnAddCar.TabIndex = 20
        Me.btnAddCar.Text = "Add Car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'tbCarID
        '
        Me.tbCarID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbCarID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "CarID", True))
        Me.tbCarID.Enabled = False
        Me.tbCarID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCarID.Location = New System.Drawing.Point(161, 16)
        Me.tbCarID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCarID.Name = "tbCarID"
        Me.tbCarID.ReadOnly = True
        Me.tbCarID.Size = New System.Drawing.Size(267, 34)
        Me.tbCarID.TabIndex = 13
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "Car"
        Me.CarBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbModel
        '
        Me.tbModel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "Model", True))
        Me.tbModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbModel.Location = New System.Drawing.Point(161, 59)
        Me.tbModel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(267, 34)
        Me.tbModel.TabIndex = 17
        '
        'tbStatus
        '
        Me.tbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "Status", True))
        Me.tbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatus.Location = New System.Drawing.Point(161, 112)
        Me.tbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbStatus.Name = "tbStatus"
        Me.tbStatus.Size = New System.Drawing.Size(267, 34)
        Me.tbStatus.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(552, 527)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(648, 119)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Navigate"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(507, 34)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(133, 78)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(152, 34)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 78)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(11, 34)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(133, 78)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(365, 34)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(133, 78)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'CarDataGridView
        '
        Me.CarDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CarDataGridView.AutoGenerateColumns = False
        Me.CarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CarDataGridView.BackgroundColor = System.Drawing.Color.LightBlue
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CarDataGridView.DataSource = Me.CarBindingSource
        Me.CarDataGridView.Location = New System.Drawing.Point(8, 26)
        Me.CarDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.Size = New System.Drawing.Size(632, 314)
        Me.CarDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(792, 130)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 34)
        Me.TextBox2.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(1235, 171)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(457, 347)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(441, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.tbText1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.tbcarType)
        Me.GroupBox3.Controls.Add(Me.btnAddCar)
        Me.GroupBox3.Controls.Add(Me.btnSaveCar)
        Me.GroupBox3.Controls.Add(CarIDLabel)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(StatusLabel)
        Me.GroupBox3.Controls.Add(ModelLabel)
        Me.GroupBox3.Controls.Add(Me.tbStatus)
        Me.GroupBox3.Controls.Add(Me.tbModel)
        Me.GroupBox3.Controls.Add(Me.tbCarID)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(455, 347)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'tbText1
        '
        Me.tbText1.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.tbText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbText1.FormattingEnabled = True
        Me.tbText1.Location = New System.Drawing.Point(239, 222)
        Me.tbText1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbText1.Name = "tbText1"
        Me.tbText1.Size = New System.Drawing.Size(189, 37)
        Me.tbText1.TabIndex = 82
        Me.tbText1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(120, 278)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 46)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(239, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 46)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbcarType
        '
        Me.tbcarType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbcarType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "Type", True))
        Me.tbcarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbcarType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcarType.FormattingEnabled = True
        Me.tbcarType.Items.AddRange(New Object() {"Car", "Truck"})
        Me.tbcarType.Location = New System.Drawing.Point(161, 170)
        Me.tbcarType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbcarType.Name = "tbcarType"
        Me.tbcarType.Size = New System.Drawing.Size(267, 37)
        Me.tbcarType.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.CarDataGridView)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(552, 171)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(648, 347)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1776, 123)
        Me.Panel1.TabIndex = 31
        '
        'InstructorCarBindingSource
        '
        Me.InstructorCarBindingSource.DataMember = "Instructor_Car"
        Me.InstructorCarBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'Ist3bbDataSet1
        '
        Me.Ist3bbDataSet1.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'Instructor_CarTableAdapter
        '
        Me.Instructor_CarTableAdapter.ClearBeforeFill = True
        '
        'Ist3bbDataSet2
        '
        Me.Ist3bbDataSet2.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'CarTableAdapter1
        '
        Me.CarTableAdapter1.ClearBeforeFill = True
        '
        'Ist3bbDataSet3
        '
        Me.Ist3bbDataSet3.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstructorTableAdapter1
        '
        Me.InstructorTableAdapter1.ClearBeforeFill = True
        '
        'InstructorBindingSource
        '
        Me.InstructorBindingSource.DataMember = "Instructor"
        Me.InstructorBindingSource.DataSource = Me.Ist3bbDataSet1
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1776, 722)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Cars"
        Me.Text = " Cars"
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.InstructorCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveCar As Button
    Friend WithEvents btnAddCar As Button
    Friend WithEvents tbCarID As TextBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents tbStatus As TextBox
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarTableAdapter As ist3bbDataSetTableAdapters.CarTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbcarType As ComboBox
    Friend WithEvents Ist3bbDataSet1 As ist3bbDataSet
    Friend WithEvents InstructorCarBindingSource As BindingSource
    Friend WithEvents Instructor_CarTableAdapter As ist3bbDataSetTableAdapters.Instructor_CarTableAdapter
    Friend WithEvents Ist3bbDataSet2 As ist3bbDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookingTableAdapter1 As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents CarTableAdapter1 As ist3bbDataSetTableAdapters.CarTableAdapter
    Friend WithEvents Ist3bbDataSet3 As ist3bbDataSet
    Friend WithEvents InstructorTableAdapter1 As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents tbText1 As ComboBox
    Friend WithEvents InstructorBindingSource As BindingSource
End Class
