Public Class frmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtName.Text
        frmQuestion1.Show()
        frmQuestion1.init()
        Me.Hide()


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
