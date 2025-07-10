Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstOccupations.Items.Add("Doctor")
        LstOccupations.Items.Add("Engineer")
        LstOccupations.Items.Add("Teacher")
        LstOccupations.Items.Add("Artist")

    End Sub

    Private Sub Btn_go_Click(sender As Object, e As EventArgs) Handles Btn_go.Click
        Dim stFirstnm As String
        Dim stLastnm As String
        Dim stOccupation As String
        Dim stGender As String

        stFirstnm = TxtFirstName.Text
        stLastnm = TxtLastName.Text
        stGender = TxtGender.Text
        stOccupation = LstOccupations.SelectedItem.ToString()
        If LstOccupations.SelectedItem IsNot Nothing Then
            stOccupation = LstOccupations.SelectedItem.ToString()
        Else
            stOccupation = "Not selected"
        End If

        MsgBox("Hi " & stFirstnm & " " & stLastnm & " You are a " & stGender & " " & stOccupation & ".")


    End Sub
End Class
