Public Class Calculator
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblOperand1 As Double
        Dim dblOperand2 As Double
        Dim dblResult As Double

        If Not Double.TryParse(txtnumone.Text, dblOperand1) Then
            MessageBox.Show("Please enter a valid number for the first operand.")
            Return
        End If

        If Not Double.TryParse(txtnumtwo.Text, dblOperand2) Then
            MessageBox.Show("Please enter a valid number for the second operand.")
            Return
        End If

        dblResult = dblOperand1 + dblOperand2
        lblOperators.Text = "+"
        txtresult.Text = dblResult.ToString("N")
    End Sub







End Class
