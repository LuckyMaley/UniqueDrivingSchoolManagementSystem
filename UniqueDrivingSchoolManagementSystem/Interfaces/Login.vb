Public Class LoginHelp
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Ist3bbDataSet1.EnforceConstraints = False
            ManagerTableAdapter1.FillByLogin(Ist3bbDataSet1.Manager, tbUsername.Text, tbPassword.Text)
            If Ist3bbDataSet1.Manager.Rows.Count > 0 Then
                MessageBox.Show("Welcome, you will be directed to the system.")
                MainMenu.tsBtnHome.Font = New Font(MainMenu.tsBtnHome.Font, FontStyle.Bold)
                MainMenu.tsBtnHome.BackColor = Color.LightBlue
                MainMenu.tsBtnManager.Enabled = True
                MainMenu.tsBtnTimetable.Enabled = True
                MainMenu.tsBtnInstructor.Enabled = True
                MainMenu.tsBtnCars.Enabled = True
                MainMenu.tsBtnBooking.Enabled = True
                MainMenu.tsBtnDailySchedule.Enabled = True
                MainMenu.tsBtnHome.Enabled = True
                MainMenu.tsBtnBookedCustomers.Enabled = True
                MainMenu.Indicate.Text = "[Logged in - " & Ist3bbDataSet1.Manager.Rows(0).Item(1) & " " & Ist3bbDataSet1.Manager.Rows(0).Item(2) & "]"
                MainMenu.FormSetUp(Home)
                MainMenu.LoginToolStripMenuItem.Enabled = False
                MainMenu.LogoutToolStripMenuItem.Enabled = True
                MainMenu.PendingBookingsToolStripMenuItem.Visible = True
            Else
                MessageBox.Show("Username or Password incorrect, please try again")
                tbUsername.Clear()
                tbUsername.Focus()
                tbPassword.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbShowPwd_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPwd.CheckedChanged
        'Hides the password if checked
        If cbShowPwd.CheckState = CheckState.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        'Dim DS As ist3bbDataSet = New ist3bbDataSet
        'Dim TA As ist3bbDataSetTableAdapters.ManagerTableAdapter = New ist3bbDataSetTableAdapters.ManagerTableAdapter
        'DS.EnforceConstraints = False
        Ist3bbDataSet1.EnforceConstraints = False
        ManagerTableAdapter1.Fill(Ist3bbDataSet1.Manager)
            'TA.Fill(DS.Manager)
            If Ist3bbDataSet1.Manager.Rows.Count = 0 Then
                ManagerTableAdapter1.InsertDefault(1, "Jack", "Daniels", "42", "Unique Street", "Pietermaritzburg", "3201", "80", "50", "120", "80", "1800", "2200", "admin", "admin")
            End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        tbPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MainMenu.LoginToolStripMenuItem.Enabled = True
    End Sub
End Class