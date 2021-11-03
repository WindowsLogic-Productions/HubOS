Public Class Hub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ContextMenuStrip1.Show(Button1, 0, Button1.Height)
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDownToolStripMenuItem.Click
        ShtDwnMgr.Show()
    End Sub

    Private Sub Hub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("Welcome to the Alpha of WindowsLogic Productions HubOS! On the table, there is an application that gives you the run down of everything in this version. ", MsgBoxStyle.Information, "/!\INFORMATION/!\")
        MsgBox("You are running version: A1.0.0.0.main.dev.Apr15, You can check for updates at http://www.windowslogic.co.uk/downloads!", MsgBoxStyle.Exclamation, "/!\ATTENTION/!\")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LinkLabel1.Text = TimeOfDay
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Date_and_Time.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bug_Reporter.Show()
    End Sub

    Private Sub SystemPreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemPreferencesToolStripMenuItem.Click
        System_Preferences.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("C:\windows\explorer.exe")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Internet.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub AddressBookToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressBookToolStripMenuItem1.Click
        AddressBook.Show()
    End Sub

    Private Sub ImageViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageViewerToolStripMenuItem.Click
        ImgView.Show()
    End Sub
End Class
