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
        tmrQuestion2.Enabled = False
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
            frmQuestion3.Show()
            frmQuestion3.init()
            Me.Hide()
        End If

        frmQuestion3.Show()
        frmQuestion3.init()
        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub tmrQuestion2_Tick(sender As Object, e As EventArgs) Handles tmrQuestion2.Tick
        progressCount = progressCount + 1

        ProgressBar2.PerformStep()
        If progressCount = 10 Then
            tmrQuestion2.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion3.Show()
            frmQuestion3.init()
            Me.Hide()

        End If
    End Sub
End Class