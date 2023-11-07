Public Class frmQuestion2
    Public Sub init()

        progressCount = 0
        tmrQuestion2.Enabled = True
        ProgressBar2.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If

        frmQuestion3.Show()

        Me.Hide()
    End Sub
End Class