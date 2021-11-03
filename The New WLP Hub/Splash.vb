Public Class Splash

    Private Sub ExitSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Thanks for taking the time to test out WLP Hub, we are developing it with the consumer in mind, so if you want you can write a review on it pointing out all things good, bad and ugly. Please send your reviews to this e-mail: CEO@windowslogic.url.ph. We hope you share this program with friends and consider getting the versions to come.", MsgBoxStyle.OkOnly, "Thank You!")

        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Hub.Show()
            Me.Close()
        End If
    End Sub
End Class