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
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeadsTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTailsTotal = New System.Windows.Forms.Label()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(223, 322)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(75, 23)
        Me.btnToss.TabIndex = 1
        Me.btnToss.Text = "Toss"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(392, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.Chapter_5.My.Resources.Resources.tails
        Me.picTails.Location = New System.Drawing.Point(366, 56)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(222, 225)
        Me.picTails.TabIndex = 4
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.Chapter_5.My.Resources.Resources.heads
        Me.picHeads.Location = New System.Drawing.Point(72, 56)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(226, 225)
        Me.picHeads.TabIndex = 3
        Me.picHeads.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of heads"
        '
        'lblHeadsTotal
        '
        Me.lblHeadsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeadsTotal.Location = New System.Drawing.Point(187, 375)
        Me.lblHeadsTotal.Name = "lblHeadsTotal"
        Me.lblHeadsTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblHeadsTotal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of tails"
        '
        'lblTailsTotal
        '
        Me.lblTailsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTailsTotal.Location = New System.Drawing.Point(533, 376)
        Me.lblTailsTotal.Name = "lblTailsTotal"
        Me.lblTailsTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTailsTotal.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 423)
        Me.Controls.Add(Me.lblTailsTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHeadsTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Name = "Form1"
        Me.Text = "Coin toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHeadsTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTailsTotal As System.Windows.Forms.Label

End Class
