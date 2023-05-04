Public Class Form1
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim f2 As New Form2
        f2.ShowDialog()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim f3 As New Form3
        f3.ShowDialog()
    End Sub

    Private Sub Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form4ToolStripMenuItem.Click
        Dim f4 As New Form4
        f4.ShowDialog()
    End Sub

    Private Sub Form5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form5ToolStripMenuItem.Click
        Dim f5 As New Form5
        f5.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
