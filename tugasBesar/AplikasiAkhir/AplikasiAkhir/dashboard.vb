Public Class dashboard
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        FormObat.ShowDialog()
    End Sub
    Private Sub DataPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        FormJual.ShowDialog()
    End Sub

    Private Sub dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            LogoutBar.Visible = True
        End If
    End Sub
    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class