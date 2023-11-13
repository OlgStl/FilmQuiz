Public Class frmQuestion1

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click

    End Sub
    Public Sub init()

        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBar1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrQuestion1.Enabled = False
        If btnAnswer4.Checked Then
            playerScore = playerScore + 1
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If

        frmQuestion2.Show()

        Me.Hide()
    End Sub
    Private Sub tmrQuestion1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion1.Tick
        progressCount = progressCount + 1

        ProgressBar1.PerformStep()
        If progressCount = 10 Then
            tmrQuestion1.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class