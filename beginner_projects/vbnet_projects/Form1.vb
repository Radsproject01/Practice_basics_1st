' Required namespaces
Imports System.Drawing.Drawing2D    ' For gradient background
Imports System.Media                ' For playing .wav sounds
Imports System.Threading            ' For threading (background sound)

Public Class Form1

    ' 🪄 Optional: Form Load Event (currently unused)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can initialize stuff here later if needed
    End Sub

    ' 🌈 Custom gradient background for the main form
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Create a vertical gradient from LemonChiffon to MistyRose
        Dim brush As New LinearGradientBrush(Me.ClientRectangle, Color.LemonChiffon, Color.MistyRose, LinearGradientMode.Vertical)

        ' Fill the entire form area with the gradient
        e.Graphics.FillRectangle(brush, Me.ClientRectangle)

        ' Call base class method to ensure default painting behavior continues
        MyBase.OnPaint(e)
    End Sub

    ' 🍽️ When the "Add Recipe" button is clicked
    Private Sub btn_AddRecipe_Click(sender As Object, e As EventArgs) Handles btn_AddRecipe.Click
        ' 🛎️ Play bell sound in the background (non-blocking UI)
        Dim bellThread As New Thread(Sub()
                                         Dim player As New SoundPlayer("bell.wav")
                                         player.PlaySync() ' Play sound synchronously, but in this separate thread
                                     End Sub)
        bellThread.Start()

        ' ⏱️ Pause the main thread briefly so the sound starts before showing message
        Thread.Sleep(400)

        ' 📦 Show confirmation message
        MessageBox.Show("Let's add a new recipe!")

        ' 📝 Open the AddRecipe form as a popup (modal)
        Dim addForm As New AddRecipie()
        addForm.ShowDialog()
    End Sub

    Private Sub btn_Suggestions_Click(sender As Object, e As EventArgs) Handles btn_Suggestions.Click
        Dim stSuggestions As String() = {"🍫 Chocolate Lava Mug Cake",
        "🥔 Crispy Aloo Tikki Burger",
        "🥥 Coconut Cream Spaghetti",
        "🌯 Masala Paneer Wrap",
        "🍜 Rainbow Veggie Noodle Bowl",
        "🥗 Chilled Cucumber Mint Salad",
        "🍛 Khaja’s Spicy Rice Bites",
        "🍞 Butter-Garlic Pull-Apart Bread"}

        ' 🎲 Pick one at random
        Dim Rand As New Random()
        Dim stSelectRand As String = stSuggestions(Rand.Next(stSuggestions.Length))
        Try
            Dim player As New SoundPlayer("Magic.WAV")
            player.PlaySync() ' Play sound synchronously, but in this separate thread

        Catch ex As Exception
            'ignore if sound file not found
        End Try
        ' ✨ Display it in a cute message box
        MessageBox.Show("Today's surprise pick is:" & vbCrLf & stSelectRand, "💡 Recipe Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
