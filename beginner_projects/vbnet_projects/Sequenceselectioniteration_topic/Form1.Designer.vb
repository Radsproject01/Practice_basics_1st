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
        Me.lblwherefrom = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblwherefrom
        '
        Me.lblwherefrom.AutoSize = True
        Me.lblwherefrom.Location = New System.Drawing.Point(69, 81)
        Me.lblwherefrom.Name = "lblwherefrom"
        Me.lblwherefrom.Size = New System.Drawing.Size(124, 16)
        Me.lblwherefrom.TabIndex = 0
        Me.lblwherefrom.Text = "Where are you from"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(350, 75)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(259, 22)
        Me.txtCountry.TabIndex = 1
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(276, 222)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(214, 48)
        Me.btnGreet.TabIndex = 2
        Me.btnGreet.Text = "Greetings"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.lblwherefrom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblwherefrom As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnGreet As Button
End Class
