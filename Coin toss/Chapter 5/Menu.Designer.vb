<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnCoinToss = New System.Windows.Forms.Button()
        Me.btnRockPaperScissors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCoinToss
        '
        Me.btnCoinToss.Location = New System.Drawing.Point(98, 28)
        Me.btnCoinToss.Name = "btnCoinToss"
        Me.btnCoinToss.Size = New System.Drawing.Size(75, 23)
        Me.btnCoinToss.TabIndex = 0
        Me.btnCoinToss.Text = "Coin Toss"
        Me.btnCoinToss.UseVisualStyleBackColor = True
        '
        'btnRockPaperScissors
        '
        Me.btnRockPaperScissors.Location = New System.Drawing.Point(98, 66)
        Me.btnRockPaperScissors.Name = "btnRockPaperScissors"
        Me.btnRockPaperScissors.Size = New System.Drawing.Size(75, 38)
        Me.btnRockPaperScissors.TabIndex = 1
        Me.btnRockPaperScissors.Text = "Rock Paper Scissors"
        Me.btnRockPaperScissors.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Controls.Add(Me.btnCoinToss)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCoinToss As System.Windows.Forms.Button
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
End Class
