<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_go = New System.Windows.Forms.Button()
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.LblFirstname = New System.Windows.Forms.Label()
        Me.LblLastname = New System.Windows.Forms.Label()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.LstOccupations = New System.Windows.Forms.ListBox()
        Me.Occupations = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(356, 357)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(176, 81)
        Me.Btn_go.TabIndex = 0
        Me.Btn_go.Text = "Go"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Location = New System.Drawing.Point(193, 54)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(161, 22)
        Me.TxtFirstname.TabIndex = 1
        '
        'TxtGender
        '
        Me.TxtGender.Location = New System.Drawing.Point(193, 110)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(161, 22)
        Me.TxtGender.TabIndex = 2
        '
        'TxtLastname
        '
        Me.TxtLastname.Location = New System.Drawing.Point(193, 82)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(161, 22)
        Me.TxtLastname.TabIndex = 3
        '
        'LblFirstname
        '
        Me.LblFirstname.AutoSize = True
        Me.LblFirstname.Location = New System.Drawing.Point(115, 57)
        Me.LblFirstname.Name = "LblFirstname"
        Me.LblFirstname.Size = New System.Drawing.Size(72, 16)
        Me.LblFirstname.TabIndex = 4
        Me.LblFirstname.Text = "First Name"
        '
        'LblLastname
        '
        Me.LblLastname.AutoSize = True
        Me.LblLastname.Location = New System.Drawing.Point(115, 88)
        Me.LblLastname.Name = "LblLastname"
        Me.LblLastname.Size = New System.Drawing.Size(72, 16)
        Me.LblLastname.TabIndex = 5
        Me.LblLastname.Text = "Last Name"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(135, 116)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(52, 16)
        Me.LblGender.TabIndex = 6
        Me.LblGender.Text = "Gender"
        '
        'LstOccupations
        '
        Me.LstOccupations.FormattingEnabled = True
        Me.LstOccupations.ItemHeight = 16
        Me.LstOccupations.Items.AddRange(New Object() {"Actor", "Singer", "Broadway", "Teacher", "Driver"})
        Me.LstOccupations.Location = New System.Drawing.Point(356, 153)
        Me.LstOccupations.Name = "LstOccupations"
        Me.LstOccupations.Size = New System.Drawing.Size(160, 196)
        Me.LstOccupations.TabIndex = 7
        '
        'Occupations
        '
        Me.Occupations.AutoSize = True
        Me.Occupations.Location = New System.Drawing.Point(268, 219)
        Me.Occupations.Name = "Occupations"
        Me.Occupations.Size = New System.Drawing.Size(82, 16)
        Me.Occupations.TabIndex = 8
        Me.Occupations.Text = "Occupations"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(423, 57)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(32, 16)
        Me.LblAge.TabIndex = 9
        Me.LblAge.Text = "Age"
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(494, 53)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(122, 22)
        Me.TxtAge.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.Occupations)
        Me.Controls.Add(Me.LstOccupations)
        Me.Controls.Add(Me.LblGender)
        Me.Controls.Add(Me.LblLastname)
        Me.Controls.Add(Me.LblFirstname)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.TxtGender)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.Btn_go)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_go As Button
    Friend WithEvents TxtFirstname As TextBox
    Friend WithEvents TxtGender As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents LblFirstname As Label
    Friend WithEvents LblLastname As Label
    Friend WithEvents LblGender As Label
    Friend WithEvents LstOccupations As ListBox
    Friend WithEvents Occupations As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents TxtAge As TextBox
End Class
