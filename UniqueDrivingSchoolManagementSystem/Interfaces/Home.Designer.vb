<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ist3bbDataSet1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.Ist3bbDataSet2 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBookedCustomers = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CustomerTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Notification = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblPendingPayments = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.lblInstructors = New System.Windows.Forms.Label()
        Me.lblPerLessonCust = New System.Windows.Forms.Label()
        Me.lblFullCourseCust = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.BookingTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.InstructorTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.InstructorTableAdapter()
        Me.CarTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CarTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.PaymentTableAdapter1 = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.PaymentTableAdapter()
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Notification.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, -10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 135)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Home"
        '
        'Ist3bbDataSet1
        '
        Me.Ist3bbDataSet1.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ist3bbDataSet2
        '
        Me.Ist3bbDataSet2.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 36)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "140 Langalibalele Street"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Bramhill Building"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 36)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Pietermaritzburg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 36)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "3201"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 36)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "{First office on the left}"
        '
        'lblBookedCustomers
        '
        Me.lblBookedCustomers.AutoSize = True
        Me.lblBookedCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedCustomers.Location = New System.Drawing.Point(449, 42)
        Me.lblBookedCustomers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookedCustomers.Name = "lblBookedCustomers"
        Me.lblBookedCustomers.Size = New System.Drawing.Size(36, 39)
        Me.lblBookedCustomers.TabIndex = 29
        Me.lblBookedCustomers.Text = "#"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(346, 39)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Booked Customer(s): "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(447, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(580, 240)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'Notification
        '
        Me.Notification.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Notification.BackColor = System.Drawing.Color.LightBlue
        Me.Notification.Controls.Add(Me.Label15)
        Me.Notification.Controls.Add(Me.LblPendingPayments)
        Me.Notification.Controls.Add(Me.Label14)
        Me.Notification.Controls.Add(Me.Label12)
        Me.Notification.Controls.Add(Me.Label13)
        Me.Notification.Controls.Add(Me.lblCars)
        Me.Notification.Controls.Add(Me.lblInstructors)
        Me.Notification.Controls.Add(Me.lblPerLessonCust)
        Me.Notification.Controls.Add(Me.lblFullCourseCust)
        Me.Notification.Controls.Add(Me.Label11)
        Me.Notification.Controls.Add(Me.Label10)
        Me.Notification.Controls.Add(Me.Label9)
        Me.Notification.Controls.Add(Me.Label7)
        Me.Notification.Controls.Add(Me.Label8)
        Me.Notification.Controls.Add(Me.lblBookedCustomers)
        Me.Notification.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notification.Location = New System.Drawing.Point(319, 417)
        Me.Notification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Notification.Name = "Notification"
        Me.Notification.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Notification.Size = New System.Drawing.Size(999, 585)
        Me.Notification.TabIndex = 32
        Me.Notification.TabStop = False
        Me.Notification.Text = "Notifications:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 434)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(312, 39)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Pending Payments:"
        '
        'LblPendingPayments
        '
        Me.LblPendingPayments.AutoSize = True
        Me.LblPendingPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPendingPayments.Location = New System.Drawing.Point(349, 434)
        Me.LblPendingPayments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPendingPayments.Name = "LblPendingPayments"
        Me.LblPendingPayments.Size = New System.Drawing.Size(36, 39)
        Me.LblPendingPayments.TabIndex = 42
        Me.LblPendingPayments.Text = "#"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 331)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 39)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Instructor(s)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 331)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 39)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "#"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 331)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 39)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "#"
        '
        'lblCars
        '
        Me.lblCars.AutoSize = True
        Me.lblCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCars.Location = New System.Drawing.Point(449, 256)
        Me.lblCars.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCars.Name = "lblCars"
        Me.lblCars.Size = New System.Drawing.Size(36, 39)
        Me.lblCars.TabIndex = 37
        Me.lblCars.Text = "#"
        '
        'lblInstructors
        '
        Me.lblInstructors.AutoSize = True
        Me.lblInstructors.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructors.Location = New System.Drawing.Point(449, 198)
        Me.lblInstructors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructors.Name = "lblInstructors"
        Me.lblInstructors.Size = New System.Drawing.Size(36, 39)
        Me.lblInstructors.TabIndex = 35
        Me.lblInstructors.Text = "#"
        '
        'lblPerLessonCust
        '
        Me.lblPerLessonCust.AutoSize = True
        Me.lblPerLessonCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerLessonCust.Location = New System.Drawing.Point(449, 146)
        Me.lblPerLessonCust.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPerLessonCust.Name = "lblPerLessonCust"
        Me.lblPerLessonCust.Size = New System.Drawing.Size(36, 39)
        Me.lblPerLessonCust.TabIndex = 34
        Me.lblPerLessonCust.Text = "#"
        '
        'lblFullCourseCust
        '
        Me.lblFullCourseCust.AutoSize = True
        Me.lblFullCourseCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullCourseCust.Location = New System.Drawing.Point(452, 95)
        Me.lblFullCourseCust.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullCourseCust.Name = "lblFullCourseCust"
        Me.lblFullCourseCust.Size = New System.Drawing.Size(36, 39)
        Me.lblFullCourseCust.TabIndex = 33
        Me.lblFullCourseCust.Text = "#"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 256)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 39)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Car(s):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 198)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 39)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Instructor(s):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 146)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(393, 39)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Per Lesson Customer(s):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 39)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Full Course Customer(s):"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Ist3bbDataSet1
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
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'InstructorTableAdapter
        '
        Me.InstructorTableAdapter.ClearBeforeFill = True
        '
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1576, 123)
        Me.Panel1.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 146)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1059, 875)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(43, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(337, 240)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Booked Dates"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar2.Location = New System.Drawing.Point(19, 33)
        Me.MonthCalendar2.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 32
        '
        'PaymentTableAdapter1
        '
        Me.PaymentTableAdapter1.ClearBeforeFill = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1597, 922)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Notification)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.Ist3bbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist3bbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Notification.ResumeLayout(False)
        Me.Notification.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Ist3bbDataSet1 As ist3bbDataSet
    Friend WithEvents Ist3bbDataSet2 As ist3bbDataSet
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBookedCustomers As Label
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ist3bbDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Notification As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFullCourseCust As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BookingTableAdapter As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents lblPerLessonCust As Label
    Friend WithEvents lblInstructors As Label
    Friend WithEvents InstructorTableAdapter As ist3bbDataSetTableAdapters.InstructorTableAdapter
    Friend WithEvents lblCars As Label
    Friend WithEvents CarTableAdapter As ist3bbDataSetTableAdapters.CarTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LblPendingPayments As Label
    Friend WithEvents PaymentTableAdapter1 As ist3bbDataSetTableAdapters.PaymentTableAdapter
End Class
