<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Indicate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingBookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnBooking = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnBookedCustomers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnTimetable = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnInstructor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnDailySchedule = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnCars = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnManager = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Ist3bbDataSet = New UniqueDrivingSchoolManagementSystem.ist3bbDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.TableAdapterManager()
        Me.BookingTableAdapter = New UniqueDrivingSchoolManagementSystem.ist3bbDataSetTableAdapters.BookingTableAdapter()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Teal
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Indicate, Me.time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 706)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1360, 37)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Indicate
        '
        Me.Indicate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Indicate.Name = "Indicate"
        Me.Indicate.Size = New System.Drawing.Size(0, 32)
        '
        'time
        '
        Me.time.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.Name = "time"
        Me.time.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.time.Size = New System.Drawing.Size(1345, 32)
        Me.time.Spring = True
        Me.time.Text = "Time"
        Me.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1360, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.PendingBookingsToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.FileToolStripMenuItem.Text = "Access"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'PendingBookingsToolStripMenuItem
        '
        Me.PendingBookingsToolStripMenuItem.Name = "PendingBookingsToolStripMenuItem"
        Me.PendingBookingsToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.PendingBookingsToolStripMenuItem.Text = "Pending Bookings"
        Me.PendingBookingsToolStripMenuItem.Visible = False
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.HelpToolStripMenuItem.Text = "About"
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 677)
        Me.Panel1.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator12, Me.ToolStripButton1, Me.ToolStripSeparator10, Me.tsBtnHome, Me.ToolStripSeparator9, Me.tsBtnBooking, Me.ToolStripSeparator5, Me.tsBtnBookedCustomers, Me.ToolStripSeparator7, Me.tsBtnTimetable, Me.ToolStripSeparator3, Me.tsBtnInstructor, Me.ToolStripSeparator4, Me.tsBtnDailySchedule, Me.ToolStripSeparator6, Me.tsBtnCars, Me.ToolStripSeparator2, Me.tsBtnManager, Me.ToolStripSeparator8})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(200, 677)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(198, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = CType(resources.GetObject("ToolStripButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(198, 90)
        Me.ToolStripButton1.Text = "   "
        Me.ToolStripButton1.ToolTipText = "Go to Access to login/logout"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnHome
        '
        Me.tsBtnHome.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnHome.Image = CType(resources.GetObject("tsBtnHome.Image"), System.Drawing.Image)
        Me.tsBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnHome.Name = "tsBtnHome"
        Me.tsBtnHome.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnHome.Text = "Home"
        Me.tsBtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnBooking
        '
        Me.tsBtnBooking.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnBooking.Image = CType(resources.GetObject("tsBtnBooking.Image"), System.Drawing.Image)
        Me.tsBtnBooking.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnBooking.Name = "tsBtnBooking"
        Me.tsBtnBooking.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnBooking.Text = "Book Customer"
        Me.tsBtnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnBookedCustomers
        '
        Me.tsBtnBookedCustomers.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnBookedCustomers.Image = CType(resources.GetObject("tsBtnBookedCustomers.Image"), System.Drawing.Image)
        Me.tsBtnBookedCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnBookedCustomers.Name = "tsBtnBookedCustomers"
        Me.tsBtnBookedCustomers.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnBookedCustomers.Text = "Edit Customers"
        Me.tsBtnBookedCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnTimetable
        '
        Me.tsBtnTimetable.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnTimetable.Image = CType(resources.GetObject("tsBtnTimetable.Image"), System.Drawing.Image)
        Me.tsBtnTimetable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnTimetable.Name = "tsBtnTimetable"
        Me.tsBtnTimetable.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnTimetable.Text = "Timetable"
        Me.tsBtnTimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnInstructor
        '
        Me.tsBtnInstructor.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnInstructor.Image = CType(resources.GetObject("tsBtnInstructor.Image"), System.Drawing.Image)
        Me.tsBtnInstructor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnInstructor.Name = "tsBtnInstructor"
        Me.tsBtnInstructor.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnInstructor.Text = "Instructor"
        Me.tsBtnInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnDailySchedule
        '
        Me.tsBtnDailySchedule.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnDailySchedule.Image = CType(resources.GetObject("tsBtnDailySchedule.Image"), System.Drawing.Image)
        Me.tsBtnDailySchedule.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDailySchedule.Name = "tsBtnDailySchedule"
        Me.tsBtnDailySchedule.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnDailySchedule.Text = "Daily Schedule"
        Me.tsBtnDailySchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnCars
        '
        Me.tsBtnCars.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnCars.Image = CType(resources.GetObject("tsBtnCars.Image"), System.Drawing.Image)
        Me.tsBtnCars.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnCars.Name = "tsBtnCars"
        Me.tsBtnCars.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnCars.Text = "Cars"
        Me.tsBtnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        'tsBtnManager
        '
        Me.tsBtnManager.BackColor = System.Drawing.Color.CadetBlue
        Me.tsBtnManager.Image = CType(resources.GetObject("tsBtnManager.Image"), System.Drawing.Image)
        Me.tsBtnManager.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnManager.Name = "tsBtnManager"
        Me.tsBtnManager.Size = New System.Drawing.Size(198, 52)
        Me.tsBtnManager.Text = "Manager"
        Me.tsBtnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(198, 6)
        '
        'Ist3bbDataSet
        '
        Me.Ist3bbDataSet.DataSetName = "ist3bbDataSet"
        Me.Ist3bbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
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
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.Ist3bbDataSet
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 743)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "Unique Driving School Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Ist3bbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Ist3bbDataSet As ist3bbDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As ist3bbDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As ist3bbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookingTableAdapter As ist3bbDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents time As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsBtnHome As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsBtnBooking As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsBtnBookedCustomers As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsBtnTimetable As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsBtnInstructor As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsBtnDailySchedule As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsBtnManager As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsBtnCars As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Indicate As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PendingBookingsToolStripMenuItem As ToolStripMenuItem
End Class
