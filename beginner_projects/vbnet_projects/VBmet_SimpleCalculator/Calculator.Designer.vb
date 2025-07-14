<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Me.lblcalcy = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnquotient = New System.Windows.Forms.Button()
        Me.btnpower = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumone = New System.Windows.Forms.TextBox()
        Me.txtnumtwo = New System.Windows.Forms.TextBox()
        Me.lbloperands = New System.Windows.Forms.Label()
        Me.lblOperators = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblcalcy
        '
        Me.lblcalcy.AutoSize = True
        Me.lblcalcy.BackColor = System.Drawing.SystemColors.Control
        Me.lblcalcy.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcalcy.Location = New System.Drawing.Point(29, 26)
        Me.lblcalcy.Name = "lblcalcy"
        Me.lblcalcy.Size = New System.Drawing.Size(176, 26)
        Me.lblcalcy.TabIndex = 0
        Me.lblcalcy.Text = "Simple calculator"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Location = New System.Drawing.Point(34, 145)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSub.Location = New System.Drawing.Point(161, 145)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(75, 35)
        Me.btnSub.TabIndex = 2
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnmultiply
        '
        Me.btnmultiply.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmultiply.Location = New System.Drawing.Point(34, 186)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(75, 35)
        Me.btnmultiply.TabIndex = 3
        Me.btnmultiply.Text = "*"
        Me.btnmultiply.UseVisualStyleBackColor = False
        '
        'btndivide
        '
        Me.btndivide.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btndivide.Location = New System.Drawing.Point(161, 186)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(75, 35)
        Me.btndivide.TabIndex = 4
        Me.btndivide.Text = "/"
        Me.btndivide.UseVisualStyleBackColor = False
        '
        'btnquotient
        '
        Me.btnquotient.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnquotient.Location = New System.Drawing.Point(34, 227)
        Me.btnquotient.Name = "btnquotient"
        Me.btnquotient.Size = New System.Drawing.Size(75, 35)
        Me.btnquotient.TabIndex = 5
        Me.btnquotient.Text = "\"
        Me.btnquotient.UseVisualStyleBackColor = False
        '
        'btnpower
        '
        Me.btnpower.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnpower.Location = New System.Drawing.Point(161, 227)
        Me.btnpower.Name = "btnpower"
        Me.btnpower.Size = New System.Drawing.Size(75, 35)
        Me.btnpower.TabIndex = 6
        Me.btnpower.Text = "^"
        Me.btnpower.UseVisualStyleBackColor = False
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmod.Location = New System.Drawing.Point(34, 268)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(202, 35)
        Me.btnmod.TabIndex = 7
        Me.btnmod.Text = "Mod"
        Me.btnmod.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(387, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Num 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(387, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Num 2"
        '
        'txtnumone
        '
        Me.txtnumone.Location = New System.Drawing.Point(491, 151)
        Me.txtnumone.Name = "txtnumone"
        Me.txtnumone.Size = New System.Drawing.Size(154, 22)
        Me.txtnumone.TabIndex = 10
        '
        'txtnumtwo
        '
        Me.txtnumtwo.Location = New System.Drawing.Point(491, 240)
        Me.txtnumtwo.Name = "txtnumtwo"
        Me.txtnumtwo.Size = New System.Drawing.Size(154, 22)
        Me.txtnumtwo.TabIndex = 11
        '
        'lbloperands
        '
        Me.lbloperands.AutoSize = True
        Me.lbloperands.Location = New System.Drawing.Point(404, 83)
        Me.lbloperands.Name = "lbloperands"
        Me.lbloperands.Size = New System.Drawing.Size(67, 16)
        Me.lbloperands.TabIndex = 12
        Me.lbloperands.Text = "Operands"
        '
        'lblOperators
        '
        Me.lblOperators.AutoSize = True
        Me.lblOperators.Location = New System.Drawing.Point(61, 83)
        Me.lblOperators.Name = "lblOperators"
        Me.lblOperators.Size = New System.Drawing.Size(67, 16)
        Me.lblOperators.TabIndex = 13
        Me.lblOperators.Text = "Operators"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result"
        '
        'txtresult
        '
        Me.txtresult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtresult.Location = New System.Drawing.Point(491, 314)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(154, 22)
        Me.txtresult.TabIndex = 15
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOperators)
        Me.Controls.Add(Me.lbloperands)
        Me.Controls.Add(Me.txtnumtwo)
        Me.Controls.Add(Me.txtnumone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnpower)
        Me.Controls.Add(Me.btnquotient)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblcalcy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcalcy As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnquotient As Button
    Friend WithEvents btnpower As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumone As TextBox
    Friend WithEvents txtnumtwo As TextBox
    Friend WithEvents lbloperands As Label
    Friend WithEvents lblOperators As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresult As TextBox
End Class
