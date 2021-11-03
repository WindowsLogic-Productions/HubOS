Public Class ShtDwnMgr

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If ComboBox1.SelectedItem = "Exit HubOS shell" Then
            MsgBox("Thanks for taking the time to test out WLP HubOS, we are developing it with the consumer in mind, so if you want you can write a review on it pointing out all things good, bad and ugly. Please send your reviews to this e-mail: Timothyiles98@gmail.com. We hope you share this program with friends and consider getting the versions to come.", MsgBoxStyle.OkOnly, "Thank You!")
            ExitSplash.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Shut down" Then
            Label2.Text = "Closes HubOS and shuts down Windows."
        End If

        If ComboBox1.SelectedItem = "Restart" Then
            Label2.Text = "Closes HubOS and starts HubOS up again."
        End If

        If ComboBox1.SelectedItem = "Log off" Then
            Label2.Text = "Logs off your HubOS user."
        End If

        If ComboBox1.SelectedItem = "Exit HubOS shell" Then
            Label2.Text = "Ends your session and shuts down HubOS."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HelpTopics.Show()
    End Sub
End Class