Public Class frmQuestion3
    Public Sub init()

        progressCount = 0
        tmrQuestion3.Enabled = True
        ProgressBar3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrQuestion3.Enabled = False
        If btnAnswer2.Checked Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub tmrQuestion3_Tick(sender As Object, e As EventArgs) Handles tmrQuestion3.Tick
        progressCount = progressCount + 1

        ProgressBar3.PerformStep()
        If progressCount = 10 Then
            tmrQuestion3.Enabled = False
            MsgBox("Too Slow Try Again")
            frmHighScore.Show()
            frmHighScore.doScore()
            Me.Hide()

        End If
    End Sub

    Private Sub frmQuestion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class