Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Interval = 5000
        Timer1.Start()

        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 5000
        Timer1.Start()

        Timer1.Stop()
        MainMenu.Show()
    End Sub
End Class
