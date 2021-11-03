Public Class ExitSplash
    Private Sub ExitSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            End
        End If
    End Sub
End Class