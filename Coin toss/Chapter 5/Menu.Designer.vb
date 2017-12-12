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
        Me.btnRaceCarGame = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPopulation = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        'btnRaceCarGame
        '
        Me.btnRaceCarGame.Location = New System.Drawing.Point(82, 110)
        Me.btnRaceCarGame.Name = "btnRaceCarGame"
        Me.btnRaceCarGame.Size = New System.Drawing.Size(102, 36)
        Me.btnRaceCarGame.TabIndex = 2
        Me.btnRaceCarGame.Text = "Race Car Game"
        Me.btnRaceCarGame.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Sum Of Numbers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(98, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Distance Calculator"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPopulation
        '
        Me.btnPopulation.Location = New System.Drawing.Point(98, 256)
        Me.btnPopulation.Name = "btnPopulation"
        Me.btnPopulation.Size = New System.Drawing.Size(75, 23)
        Me.btnPopulation.TabIndex = 5
        Me.btnPopulation.Text = "Population"
        Me.btnPopulation.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 52)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Random Number Guessing Game"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 349)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPopulation)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRaceCarGame)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Controls.Add(Me.btnCoinToss)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCoinToss As System.Windows.Forms.Button
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
    Friend WithEvents btnRaceCarGame As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnPopulation As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
