Public Class ImgView

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetImage(PictureBox1.Image)

        'Create a JPG on disk and add the location to the clipboard
        Dim TempName As String = "TempName.jpg"
        Dim TempPath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, TempName)
        Using FS As New System.IO.FileStream(TempPath, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Read)
            PictureBox1.Image.Save(FS, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Using
        Dim Paths As New System.Collections.Specialized.StringCollection()
        Paths.Add(TempPath)
        Clipboard.SetFileDropList(Paths)
    End Sub

    Private Sub StrechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrechToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub BackgroundColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColourToolStripMenuItem.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = cd.Color
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub RotateLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateLeftToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY)
    End Sub
End Class