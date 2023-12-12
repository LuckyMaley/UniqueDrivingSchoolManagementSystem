<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbShowPwd = New System.Windows.Forms.CheckBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.ManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateManager = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.butto1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbManagerID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManagerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.ManagerTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ManagerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5.SuspendLayout()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ManagerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.Controls.Add(Me.cbShowPwd)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.tbPassword)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(33, 472)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(461, 120)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Log in Details"
        '
        'cbShowPwd
        '
        Me.cbShowPwd.AutoSize = True
        Me.cbShowPwd.Location = New System.Drawing.Point(378, 56)
        Me.cbShowPwd.Name = "cbShowPwd"
        Me.cbShowPwd.Size = New System.Drawing.Size(77, 28)
        Me.cbShowPwd.TabIndex = 12
        Me.cbShowPwd.Text = "Show"
        Me.cbShowPwd.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "UserName", True))
        Me.TextBox11.Location = New System.Drawing.Point(180, 19)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(192, 29)
        Me.TextBox11.TabIndex = 11
        '
        'ManagerBindingSource
        '
        Me.ManagerBindingSource.DataMember = "Manager"
        Me.ManagerBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbPassword
        '
        Me.tbPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "PassWord", True))
        Me.tbPassword.Location = New System.Drawing.Point(180, 54)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(192, 29)
        Me.tbPassword.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "User name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.btnUpdateManager)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(33, 598)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(461, 85)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'btnUpdateManager
        '
        Me.btnUpdateManager.Location = New System.Drawing.Point(6, 28)
        Me.btnUpdateManager.Name = "btnUpdateManager"
        Me.btnUpdateManager.Size = New System.Drawing.Size(104, 48)
        Me.btnUpdateManager.TabIndex = 3
        Me.btnUpdateManager.Text = "Update"
        Me.btnUpdateManager.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.butto1)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.tbManagerID)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(29, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(461, 159)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'butto1
        '
        Me.butto1.AutoSize = True
        Me.butto1.Location = New System.Drawing.Point(32, 40)
        Me.butto1.Name = "butto1"
        Me.butto1.Size = New System.Drawing.Size(102, 24)
        Me.butto1.TabIndex = 3
        Me.butto1.Text = "ManagerID"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "LastName", True))
        Me.TextBox3.Location = New System.Drawing.Point(184, 118)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 29)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource1, "FirstName", True))
        Me.TextBox2.Location = New System.Drawing.Point(184, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 29)
        Me.TextBox2.TabIndex = 1
        '
        'tbManagerID
        '
        Me.tbManagerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "ManagerID", True))
        Me.tbManagerID.Enabled = False
        Me.tbManagerID.Location = New System.Drawing.Point(184, 40)
        Me.tbManagerID.Name = "tbManagerID"
        Me.tbManagerID.Size = New System.Drawing.Size(214, 29)
        Me.tbManagerID.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 195)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "HouseNumber", True))
        Me.TextBox10.Location = New System.Drawing.Point(184, 25)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(214, 29)
        Me.TextBox10.TabIndex = 11
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "ZipCode", True))
        Me.TextBox9.Location = New System.Drawing.Point(184, 146)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(214, 29)
        Me.TextBox9.TabIndex = 10
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "CityOrTown", True))
        Me.TextBox8.Location = New System.Drawing.Point(184, 106)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(214, 29)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "StreetName", True))
        Me.TextBox7.Location = New System.Drawing.Point(184, 66)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(214, 29)
        Me.TextBox7.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "City or Town"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Street Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Zip Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "House Number"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, -9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 109)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Manager"
        '
        'ManagerTableAdapter
        '
        Me.ManagerTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(379, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 63)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 162)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hour rates code 08 and 10"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 128)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Truck Hire:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Per Hour:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "TruckHireCost", True))
        Me.TextBox5.Location = New System.Drawing.Point(119, 89)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(105, 29)
        Me.TextBox5.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "TruckHourCost", True))
        Me.TextBox1.Location = New System.Drawing.Point(119, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Code 10/C1"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.TextBox6)
        Me.GroupBox7.Controls.Add(Me.TextBox4)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Location = New System.Drawing.Point(242, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(208, 128)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 24)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Car Hire:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Per Hour:"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "CarHireCost", True))
        Me.TextBox6.Location = New System.Drawing.Point(103, 90)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(95, 29)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "CarHourCost", True))
        Me.TextBox4.Location = New System.Drawing.Point(103, 44)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(95, 29)
        Me.TextBox4.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(50, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 24)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Code 08/EB"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.GroupBox10)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(20, 31)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(456, 154)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Full course code 08 and 10"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.TextBox12)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Location = New System.Drawing.Point(242, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(208, 122)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(149, 24)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Includes car hire"
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "Code08FullCourse", True))
        Me.TextBox12.Location = New System.Drawing.Point(11, 52)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(178, 29)
        Me.TextBox12.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(50, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 24)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Code 08/EB"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Controls.Add(Me.TextBox13)
        Me.GroupBox10.Controls.Add(Me.Label20)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(230, 122)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(42, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 24)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Includes truck hire"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManagerBindingSource, "Code10FullCourse", True))
        Me.TextBox13.Location = New System.Drawing.Point(28, 52)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(177, 29)
        Me.TextBox13.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(55, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 24)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Code 10/C1"
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox11.Controls.Add(Me.GroupBox8)
        Me.GroupBox11.Controls.Add(Me.Button1)
        Me.GroupBox11.Controls.Add(Me.GroupBox1)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(550, 106)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(495, 486)
        Me.GroupBox11.TabIndex = 23
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Prices"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 100)
        Me.Panel1.TabIndex = 24
        '
        'ManagerBindingSource1
        '
        Me.ManagerBindingSource1.DataMember = "Manager"
        Me.ManagerBindingSource1.DataSource = Me.Ist3bbDataSet
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 714)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Manager"
        Me.Text = "Manager"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ManagerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnUpdateManager As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents butto1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tbManagerID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents ManagerBindingSource As BindingSource
    Friend WithEvents ManagerTableAdapter As ist3bbDataSetTableAdapters.ManagerTableAdapter
    Friend WithEvents cbShowPwd As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ManagerBindingSource1 As BindingSource
End Class
