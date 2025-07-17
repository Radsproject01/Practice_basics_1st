<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlBckgrnd = New System.Windows.Forms.Panel()
        Me.btn_AddRecipe = New System.Windows.Forms.Button()
        Me.btn_Suggestions = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picbackground = New System.Windows.Forms.PictureBox()
        Me.pnlBckgrnd.SuspendLayout()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBckgrnd
        '
        Me.pnlBckgrnd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlBckgrnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlBckgrnd.Controls.Add(Me.btn_Suggestions)
        Me.pnlBckgrnd.Controls.Add(Me.Button2)
        Me.pnlBckgrnd.Controls.Add(Me.btn_AddRecipe)
        Me.pnlBckgrnd.Controls.Add(Me.lblTitle)
        Me.pnlBckgrnd.Controls.Add(Me.picbackground)
        Me.pnlBckgrnd.Location = New System.Drawing.Point(-49, -14)
        Me.pnlBckgrnd.Name = "pnlBckgrnd"
        Me.pnlBckgrnd.Size = New System.Drawing.Size(1217, 816)
        Me.pnlBckgrnd.TabIndex = 5
        '
        'btn_AddRecipe
        '
        Me.btn_AddRecipe.BackColor = System.Drawing.Color.MistyRose
        Me.btn_AddRecipe.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddRecipe.Location = New System.Drawing.Point(61, 168)
        Me.btn_AddRecipe.Name = "btn_AddRecipe"
        Me.btn_AddRecipe.Size = New System.Drawing.Size(296, 101)
        Me.btn_AddRecipe.TabIndex = 6
        Me.btn_AddRecipe.Text = "+ Add Recepie"
        Me.btn_AddRecipe.UseVisualStyleBackColor = False
        '
        'btn_Suggestions
        '
        Me.btn_Suggestions.BackColor = System.Drawing.Color.NavajoWhite
        Me.btn_Suggestions.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Suggestions.Location = New System.Drawing.Point(61, 512)
        Me.btn_Suggestions.Name = "btn_Suggestions"
        Me.btn_Suggestions.Size = New System.Drawing.Size(296, 92)
        Me.btn_Suggestions.TabIndex = 8
        Me.btn_Suggestions.Text = "Suggest Something! 🍭 "
        Me.btn_Suggestions.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PeachPuff
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(61, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 103)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "📖 View Recipes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.HotPink
        Me.lblTitle.Location = New System.Drawing.Point(322, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(572, 44)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "My Recipe Book -Home Chef Edition!"
        '
        'picbackground
        '
        Me.picbackground.Image = Global.LetsCook.My.Resources.Resources.Hungrisch_gif
        Me.picbackground.Location = New System.Drawing.Point(424, 142)
        Me.picbackground.Name = "picbackground"
        Me.picbackground.Size = New System.Drawing.Size(704, 552)
        Me.picbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbackground.TabIndex = 5
        Me.picbackground.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1146, 773)
        Me.Controls.Add(Me.pnlBckgrnd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlBckgrnd.ResumeLayout(False)
        Me.pnlBckgrnd.PerformLayout()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBckgrnd As Panel
    Friend WithEvents btn_Suggestions As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_AddRecipe As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picbackground As PictureBox
End Class
