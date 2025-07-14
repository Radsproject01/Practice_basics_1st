Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim stcountry As String
        stcountry = txtCountry.Text

        ' stcountry = stcountry.ToUpper()--this will alter the value permanently for the entire program.
        '--to convert the string to uppercase   
        stcountry = stcountry.Trim() '--to remove any leading or trailing spaces
        'Note: The 'Trim' method is used to remove any leading or trailing spaces from the string.
        If stcountry.ToUpper = "India" Then MessageBox.Show("Namaste") '--one line if statement ; checking only 1 specicifed condition
        If stcountry = "USA" Or stcountry = "UK" Then
            MessageBox.Show("Hello")
        End If
        '--remember if you execute single command in 'if' statement , then you can use as in 5th line .
        'But if you have to execute multiple statements , DO NOT PUT ANYTHING AFTER 'THEN' KEYWORD
        If stcountry.ToUpper = "France" Then
            MessageBox.Show("Bonjour")
            MessageBox.Show("Bienvenue")
        End If
        'To check and get the clarity  try running the following codes :
        'If stcountry = "France" Then
        ' MessageBox.Show("Bonjour")
        ' MessageBox.Show("Bienvenue")
        '  End If
        'Or
        'If stcountry = "France" Then Msgbox("hi")
        ' MessageBox.Show("Bonjour")
        ' MessageBox.Show("Bienvenue")
        '  End If                                                    --thse will not work and you'll get syntax error
        'Note: The 'If' statement is case-sensitive, so "india" will not match "India".Make sure the case matches.

        If stcountry.ToUpper = "GERMANY" Then
            MessageBox.Show("Guten Tag")
        ElseIf stcountry.ToUpper = "Spain" Then
            MessageBox.Show("Hola")
        ElseIf stcountry.ToUpper = "ITALY" Then
            MessageBox.Show("Ciao")
        ElseIf stcountry.ToUpper = "JAPAN" Then
            MessageBox.Show("Konnichiwa")
            MessageBox.Show("Arigato")
            MessageBox.Show("Sayonara")
            'see if you fill the text with japan, then all three messages will be displayed...but why? because we used ToUpper() method!
        Else
            MessageBox.Show("Hello, World!") '--if none of the above conditions are met, this will be executed
        End If

        MessageBox.Show("You entered: " & stcountry)

    End Sub
End Class
