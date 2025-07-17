<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecipie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtRecepieName = New System.Windows.Forms.TextBox()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lblIngredients = New System.Windows.Forms.Label()
        Me.txtIngredients = New System.Windows.Forms.TextBox()
        Me.lblCookingProcess = New System.Windows.Forms.Label()
        Me.txtCookingProcess = New System.Windows.Forms.TextBox()
        Me.btnSaveRecepie = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picbackground = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(273, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(219, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🍴 Add Recipe !!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRecepieName
        '
        Me.txtRecepieName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRecepieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecepieName.Location = New System.Drawing.Point(44, 16)
        Me.txtRecepieName.Multiline = True
        Me.txtRecepieName.Name = "txtRecepieName"
        Me.txtRecepieName.Size = New System.Drawing.Size(300, 30)
        Me.txtRecepieName.TabIndex = 1
        '
        'lblRecipeName
        '
        Me.lblRecipeName.AutoSize = True
        Me.lblRecipeName.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeName.Font = New System.Drawing.Font("Segoe Script", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeName.Location = New System.Drawing.Point(12, 126)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(138, 28)
        Me.lblRecipeName.TabIndex = 2
        Me.lblRecipeName.Text = "Recipie Name"
        '
        'lblIngredients
        '
        Me.lblIngredients.AutoSize = True
        Me.lblIngredients.Font = New System.Drawing.Font("Segoe Script", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredients.Location = New System.Drawing.Point(33, 212)
        Me.lblIngredients.Name = "lblIngredients"
        Me.lblIngredients.Size = New System.Drawing.Size(117, 30)
        Me.lblIngredients.TabIndex = 3
        Me.lblIngredients.Text = "Ingredients"
        '
        'txtIngredients
        '
        Me.txtIngredients.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngredients.Location = New System.Drawing.Point(44, 82)
        Me.txtIngredients.Multiline = True
        Me.txtIngredients.Name = "txtIngredients"
        Me.txtIngredients.Size = New System.Drawing.Size(200, 70)
        Me.txtIngredients.TabIndex = 4
        '
        'lblCookingProcess
        '
        Me.lblCookingProcess.AutoSize = True
        Me.lblCookingProcess.Font = New System.Drawing.Font("Segoe Script", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCookingProcess.Location = New System.Drawing.Point(-3, 335)
        Me.lblCookingProcess.Name = "lblCookingProcess"
        Me.lblCookingProcess.Size = New System.Drawing.Size(160, 30)
        Me.lblCookingProcess.TabIndex = 5
        Me.lblCookingProcess.Text = "Cooking process"
        '
        'txtCookingProcess
        '
        Me.txtCookingProcess.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCookingProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCookingProcess.Location = New System.Drawing.Point(44, 202)
        Me.txtCookingProcess.Multiline = True
        Me.txtCookingProcess.Name = "txtCookingProcess"
        Me.txtCookingProcess.Size = New System.Drawing.Size(200, 70)
        Me.txtCookingProcess.TabIndex = 6
        '
        'btnSaveRecepie
        '
        Me.btnSaveRecepie.BackColor = System.Drawing.Color.Salmon
        Me.btnSaveRecepie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRecepie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveRecepie.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRecepie.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnSaveRecepie.Location = New System.Drawing.Point(224, 278)
        Me.btnSaveRecepie.Name = "btnSaveRecepie"
        Me.btnSaveRecepie.Size = New System.Drawing.Size(200, 50)
        Me.btnSaveRecepie.TabIndex = 7
        Me.btnSaveRecepie.Text = "Save Recepie !  ❤️"
        Me.btnSaveRecepie.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.LetsCook.My.Resources.Resources.Studio_Ghibli_Indonesian_food_2
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 100)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSaveRecepie)
        Me.Panel2.Controls.Add(Me.txtRecepieName)
        Me.Panel2.Controls.Add(Me.txtCookingProcess)
        Me.Panel2.Controls.Add(Me.txtIngredients)
        Me.Panel2.Controls.Add(Me.picbackground)
        Me.Panel2.Location = New System.Drawing.Point(193, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(605, 337)
        Me.Panel2.TabIndex = 9
        '
        'picbackground
        '
        Me.picbackground.Image = Global.LetsCook.My.Resources.Resources.Hungrisch_gif1
        Me.picbackground.Location = New System.Drawing.Point(443, 164)
        Me.picbackground.Name = "picbackground"
        Me.picbackground.Size = New System.Drawing.Size(100, 50)
        Me.picbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbackground.TabIndex = 8
        Me.picbackground.TabStop = False
        '
        'AddRecipie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRecipeName)
        Me.Controls.Add(Me.lblIngredients)
        Me.Controls.Add(Me.lblCookingProcess)
        Me.Name = "AddRecipie"
        Me.Text = "AddRecipie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtRecepieName As TextBox
    Friend WithEvents lblRecipeName As Label
    Friend WithEvents lblIngredients As Label
    Friend WithEvents txtIngredients As TextBox
    Friend WithEvents lblCookingProcess As Label
    Friend WithEvents txtCookingProcess As TextBox
    Friend WithEvents btnSaveRecepie As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picbackground As PictureBox
End Class
