Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2, largerNum As Double
        If (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then



            

            If (num1 < 0 Or num2 < 0) Then
            Else : MessageBox.Show("Error: Type a positive number!")
            End If



            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)


            If (num1 > num2) Then
                txtResult.Text = "Larger number is " & num1 & "."
            ElseIf (num2 > num1) Then
                txtResult.Text = "Larger number is " & num2 & "."
            Else
                txtResult.Text = "The two numbers are equal."

            End If


        Else : MessageBox.Show("Error: Please write numbers only.")
        End If
    End Sub

End Class
