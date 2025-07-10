Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstOccupations.Items.Add("Doctor")
        LstOccupations.Items.Add("Engineer")
        LstOccupations.Items.Add("Teacher")
        LstOccupations.Items.Add("Artist")

    End Sub

    Private Sub Btn_go_Click(sender As Object, e As EventArgs) Handles Btn_go.Click
        Dim stFirstnm As String     'this Is how you Declare a variable in vb.net
        Dim stLastnm As String      'follow the namign convention - super easy - always abbreviate the datatype along with the variable name
        'st stands for string, i stands for integer, b stands for boolean, dbl stands for double like that you can use ; it helps identifying the data type without eevn going to the declaration part
        Dim stOccupation As String
        Dim stGender As String
        Dim iAge As Integer
        stFirstnm = TxtFirstName.Text
        stLastnm = TxtLastName.Text
        stGender = TxtGender.Text
        stOccupation = LstOccupations.SelectedItem.ToString()
        iAge = TxtAge.Text
        MsgBox("Hi " & stFirstnm & " " & stLastnm & " You are a " & stGender & " " & stOccupation & ". You are " &
               iAge & " years old!")


    End Sub
End Class
