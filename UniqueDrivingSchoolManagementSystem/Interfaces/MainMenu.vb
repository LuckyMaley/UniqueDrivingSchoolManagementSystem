Imports System.IO
Public Class MainMenu
    Dim strHelpPath As String = Path.Combine(Application.StartupPath, "Help.chm")

    Public Sub FormSetUp(ByVal ChildForm As Form)
        Try
            If ActiveMdiChild.Name <> ChildForm.Name Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception
        End Try
        With ChildForm
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LogoutToolStripMenuItem.Enabled = False
        tsBtnManager.Enabled = False
        tsBtnTimetable.Enabled = False
        tsBtnInstructor.Enabled = False
        tsBtnCars.Enabled = False
        tsBtnBooking.Enabled = False
        tsBtnDailySchedule.Enabled = False
        tsBtnHome.Enabled = False
        tsBtnBookedCustomers.Enabled = False
        Indicate.Text = "[Not Logged in]"
        Timer1.Start()

        HelpProvider1.HelpNamespace = strHelpPath
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp(LoginHelp)
        LoginToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Home.Close()
            Manager.Close()
            Customer.Close()
            Instructor.Close()
            Cars.Close()
            DailySchedule.Close()
            CreateTimetable.Close()
            CustomerBooking.Close()

            LogoutToolStripMenuItem.Enabled = False
            tsBtnManager.Enabled = False
            tsBtnTimetable.Enabled = False
            tsBtnInstructor.Enabled = False
            tsBtnCars.Enabled = False
            tsBtnBooking.Enabled = False
            tsBtnDailySchedule.Enabled = False
            tsBtnHome.Enabled = False
            tsBtnBookedCustomers.Enabled = False
            Indicate.Text = "[Not Logged in]"

            LoginToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = False

            tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
            tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
            tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
            tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
            tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
            tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
            tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
            tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

            ' Button Color
            tsBtnManager.BackColor = Color.CadetBlue
            tsBtnTimetable.BackColor = Color.CadetBlue
            tsBtnInstructor.BackColor = Color.CadetBlue
            tsBtnCars.BackColor = Color.CadetBlue
            tsBtnBooking.BackColor = Color.CadetBlue
            tsBtnDailySchedule.BackColor = Color.CadetBlue
            tsBtnHome.BackColor = Color.CadetBlue
            tsBtnBookedCustomers.BackColor = Color.CadetBlue
        End If
    End Sub

    Private Sub tsBtnManager_Click(sender As Object, e As EventArgs) Handles tsBtnManager.Click
        FormSetUp(Manager)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Bold)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.LightBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnInstructor_Click(sender As Object, e As EventArgs) Handles tsBtnInstructor.Click
        FormSetUp(Instructor)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Bold)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.LightBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnCars_Click(sender As Object, e As EventArgs) Handles tsBtnCars.Click
        FormSetUp(Cars)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Bold)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.LightBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnDailySchedule_Click(sender As Object, e As EventArgs) Handles tsBtnDailySchedule.Click
        FormSetUp(DailySchedule)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Bold)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.LightBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnHome_Click_1(sender As Object, e As EventArgs) Handles tsBtnHome.Click
        FormSetUp(Home)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Bold)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.LightBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnBooking_Click(sender As Object, e As EventArgs) Handles tsBtnBooking.Click
        FormSetUp(CustomerBooking)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Bold)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.LightBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub tsBtnTimetable_Click(sender As Object, e As EventArgs) Handles tsBtnTimetable.Click
        FormSetUp(CreateTimetable)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Bold)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Regular)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.LightBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.CadetBlue
    End Sub

    Private Sub btnBookedCustomers_Click(sender As Object, e As EventArgs) Handles tsBtnBookedCustomers.Click
        FormSetUp(Customer)
        tsBtnManager.Font = New Font(tsBtnManager.Font, FontStyle.Regular)
        tsBtnInstructor.Font = New Font(tsBtnInstructor.Font, FontStyle.Regular)
        tsBtnCars.Font = New Font(tsBtnCars.Font, FontStyle.Regular)
        tsBtnBooking.Font = New Font(tsBtnBooking.Font, FontStyle.Regular)
        tsBtnDailySchedule.Font = New Font(tsBtnDailySchedule.Font, FontStyle.Regular)
        tsBtnTimetable.Font = New Font(tsBtnTimetable.Font, FontStyle.Regular)
        tsBtnHome.Font = New Font(tsBtnHome.Font, FontStyle.Regular)
        tsBtnBookedCustomers.Font = New Font(tsBtnBookedCustomers.Font, FontStyle.Bold)

        ' Button Color
        tsBtnManager.BackColor = Color.CadetBlue
        tsBtnTimetable.BackColor = Color.CadetBlue
        tsBtnInstructor.BackColor = Color.CadetBlue
        tsBtnCars.BackColor = Color.CadetBlue
        tsBtnBooking.BackColor = Color.CadetBlue
        tsBtnDailySchedule.BackColor = Color.CadetBlue
        tsBtnHome.BackColor = Color.CadetBlue
        tsBtnBookedCustomers.BackColor = Color.LightBlue
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time.Text = DateTime.Now.ToString("hh:mm tt") & "  " & DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        'Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
        Help.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub PendingBookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendingBookingsToolStripMenuItem.Click
        FormSetUp(PendingBookings)
        PendingBookingsToolStripMenuItem.Enabled = False
    End Sub
End Class