Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculate.Click

        If weightLifted.Text = "" Then
            MsgBox("Weight Lifted must have a value", MsgBoxStyle.Critical, "Error")
        ElseIf repsCompleted.Text = "" Then
            MsgBox("Reps Completed must have a value", MsgBoxStyle.Critical, "Error")
        ElseIf Not IsNumeric(weightLifted.Text) Then
            MsgBox("Weight Lifted must be a number", MsgBoxStyle.Critical, "Error")
        ElseIf Not IsNumeric(repsCompleted.Text) Then
            MsgBox("Reps Completed must be a number", MsgBoxStyle.Critical, "Error")
        Else
            oneRepMax.Text = Convert.ToString(CInt(Convert.ToInt32(weightLifted.Text) / (1.0278 - (0.0278 * Convert.ToInt32(repsCompleted.Text)))))
        End If

    End Sub

End Class
