<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissors
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
        Me.RockRadioButton = New System.Windows.Forms.RadioButton()
        Me.PaperRadioButton = New System.Windows.Forms.RadioButton()
        Me.ScissorsRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayerWins = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RockRadioButton
        '
        Me.RockRadioButton.AutoSize = True
        Me.RockRadioButton.Location = New System.Drawing.Point(175, 49)
        Me.RockRadioButton.Name = "RockRadioButton"
        Me.RockRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.RockRadioButton.TabIndex = 0
        Me.RockRadioButton.TabStop = True
        Me.RockRadioButton.Text = "Rock"
        Me.RockRadioButton.UseVisualStyleBackColor = True
        '
        'PaperRadioButton
        '
        Me.PaperRadioButton.AutoSize = True
        Me.PaperRadioButton.Location = New System.Drawing.Point(173, 82)
        Me.PaperRadioButton.Name = "PaperRadioButton"
        Me.PaperRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.PaperRadioButton.TabIndex = 1
        Me.PaperRadioButton.TabStop = True
        Me.PaperRadioButton.Text = "Paper"
        Me.PaperRadioButton.UseVisualStyleBackColor = True
        '
        'ScissorsRadioButton
        '
        Me.ScissorsRadioButton.AutoSize = True
        Me.ScissorsRadioButton.Location = New System.Drawing.Point(173, 123)
        Me.ScissorsRadioButton.Name = "ScissorsRadioButton"
        Me.ScissorsRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.ScissorsRadioButton.TabIndex = 2
        Me.ScissorsRadioButton.TabStop = True
        Me.ScissorsRadioButton.Text = "Scissors"
        Me.ScissorsRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player Wins"
        '
        'lblPlayerWins
        '
        Me.lblPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerWins.Location = New System.Drawing.Point(81, 172)
        Me.lblPlayerWins.Name = "lblPlayerWins"
        Me.lblPlayerWins.Size = New System.Drawing.Size(100, 23)
        Me.lblPlayerWins.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CPU Wins"
        '
        'lblCPU
        '
        Me.lblCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPU.Location = New System.Drawing.Point(310, 171)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(100, 23)
        Me.lblCPU.TabIndex = 6
        '
        'lblresult
        '
        Me.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblresult.Location = New System.Drawing.Point(89, 232)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(254, 23)
        Me.lblresult.TabIndex = 7
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(81, 272)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(75, 26)
        Me.btnPlayAgain.TabIndex = 8
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(175, 272)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(75, 26)
        Me.btnShoot.TabIndex = 9
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 26)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 310)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.lblCPU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayerWins)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScissorsRadioButton)
        Me.Controls.Add(Me.PaperRadioButton)
        Me.Controls.Add(Me.RockRadioButton)
        Me.Name = "RockPaperScissors"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RockRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PaperRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ScissorsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerWins As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents btnShoot As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
