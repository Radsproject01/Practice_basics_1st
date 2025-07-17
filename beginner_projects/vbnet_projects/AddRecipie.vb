Public Class AddRecipie
    Private Sub AddRecipie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up animated GIF background
        picbackground.Dock = DockStyle.Fill
        picbackground.SizeMode = PictureBoxSizeMode.StretchImage
        ' Pseudocode:
        ' 1. Ensure the GIF is added to your project resources with a valid name (e.g., hungry_studio_ghibli_GIF).
        ' 2. Resource names cannot have spaces or special characters.
        ' 3. Reference the resource using the correct name in code.

        ' Example fix:
        picbackground.Image = My.Resources.Hungrisch_gif ' use the actual resource name as shown in Resources.resx
        picbackground.Enabled = False ' allows controls to be clicked through
        picbackground.SendToBack()

        ' Make labels transparent and text styled
        MakeLabelTransparent(lblTitle)
        MakeLabelTransparent(lblRecipeName)
        MakeLabelTransparent(lblIngredients)
        MakeLabelTransparent(lblCookingProcess)

        ' Optional: Semi-transparent textboxes for better readability
        MakeTextboxReadable(txtRecepieName)
        MakeTextboxReadable(txtIngredients)
        MakeTextboxReadable(txtCookingProcess)
    End Sub

    Private Sub MakeLabelTransparent(lbl As Label)
        lbl.BackColor = Color.Transparent
        lbl.ForeColor = Color.DarkRed
        lbl.Font = New Font("Segoe UI", 11, FontStyle.Bold)
    End Sub

    Private Sub MakeTextboxReadable(txt As TextBox)
        txt.BackColor = Color.FromArgb(230, 255, 255, 255) ' light translucent white
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    End Sub


End Class