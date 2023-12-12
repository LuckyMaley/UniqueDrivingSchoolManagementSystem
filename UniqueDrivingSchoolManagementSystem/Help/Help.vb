Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IntroductionHelp.TopLevel = False
        HelpPanel.Controls.Add(IntroductionHelp)
        IntroductionHelp.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Not (TreeView1.SelectedNode Is Nothing) Then
            Select Case TreeView1.SelectedNode.Name
                Case "Node0"
                    IntroductionHelp.TopLevel = False
                    HelpPanel.Controls.Add(IntroductionHelp)
                    IntroductionHelp.Show()
                    BookCustomerHelp.Close()
                    EditCustomerHelp.Close()
                    LoginHelp.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node1"
                    Login_Help.TopLevel = False
                    HelpPanel.Controls.Add(Login_Help)
                    Login_Help.Show()
                    IntroductionHelp.Close()
                    BookCustomerHelp.Close()
                    EditCustomerHelp.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node2"
                    HomeHelp.TopLevel = False
                    HelpPanel.Controls.Add(HomeHelp)
                    HomeHelp.Show()
                    BookCustomerHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    IntroductionHelp.Close()
                    TimetableHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node3"
                    BookCustomerHelp.TopLevel = False
                    HelpPanel.Controls.Add(BookCustomerHelp)
                    BookCustomerHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node4"
                    EditCustomerHelp.TopLevel = False
                    HelpPanel.Controls.Add(EditCustomerHelp)
                    EditCustomerHelp.Show()
                    IntroductionHelp.Close()
                    BookCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node5"
                    TimetableHelp.TopLevel = False
                    HelpPanel.Controls.Add(TimetableHelp)
                    TimetableHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    BookCustomerHelp.Close()
                    InstructorHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node6"
                    InstructorHelp.TopLevel = False
                    HelpPanel.Controls.Add(InstructorHelp)
                    InstructorHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    BookCustomerHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node7"
                    DailyScheduleHelp.TopLevel = False
                    HelpPanel.Controls.Add(DailyScheduleHelp)
                    DailyScheduleHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    BookCustomerHelp.Close()
                    InstructorHelp.Close()
                    ManagerHelp.Close()
                    CarsHelp.Close()
                Case "Node8"
                    ManagerHelp.TopLevel = False
                    HelpPanel.Controls.Add(ManagerHelp)
                    ManagerHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    BookCustomerHelp.Close()
                    DailyScheduleHelp.Close()
                    InstructorHelp.Close()
                    CarsHelp.Close()
                Case "Node9"
                    CarsHelp.TopLevel = False
                    HelpPanel.Controls.Add(CarsHelp)
                    CarsHelp.Show()
                    IntroductionHelp.Close()
                    EditCustomerHelp.Close()
                    Login_Help.Close()
                    HomeHelp.Close()
                    TimetableHelp.Close()
                    BookCustomerHelp.Close()
                    DailyScheduleHelp.Close()
                    ManagerHelp.Close()
                    InstructorHelp.Close()
            End Select
        End If
    End Sub
End Class