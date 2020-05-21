Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim bmi As Double
        Dim weight As Double
        Dim height As Double

        weight = CDbl(txtWeight.Text)
        height = CDbl(txtHeight.Text)
        bmi = CDbl((weight * 703) / (height ^ 2))

        Try
            If bmi > 25 Then
                lblResult.Text = "You are overweight with bmi: " & bmi
            ElseIf bmi >= 18.5 And bmi <= 25 Then
                lblResult.Text = "You are in optimal shape with bmi: " & bmi
            ElseIf bmi < 18.5 Then
                lblResult.Text = "You are under weight with bmi: " & bmi
            End If
        Catch
            MessageBox.Show("Please enter a valid number. No other characters other than numbers.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
