<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaceCarGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RaceCarGame))
        Me.picRacer1 = New System.Windows.Forms.PictureBox()
        Me.picRacer2 = New System.Windows.Forms.PictureBox()
        Me.picRacer3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picRacer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRacer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRacer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRacer1
        '
        Me.picRacer1.Image = CType(resources.GetObject("picRacer1.Image"), System.Drawing.Image)
        Me.picRacer1.Location = New System.Drawing.Point(12, 12)
        Me.picRacer1.Name = "picRacer1"
        Me.picRacer1.Size = New System.Drawing.Size(182, 113)
        Me.picRacer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRacer1.TabIndex = 0
        Me.picRacer1.TabStop = False
        '
        'picRacer2
        '
        Me.picRacer2.Image = CType(resources.GetObject("picRacer2.Image"), System.Drawing.Image)
        Me.picRacer2.Location = New System.Drawing.Point(12, 157)
        Me.picRacer2.Name = "picRacer2"
        Me.picRacer2.Size = New System.Drawing.Size(182, 107)
        Me.picRacer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRacer2.TabIndex = 1
        Me.picRacer2.TabStop = False
        '
        'picRacer3
        '
        Me.picRacer3.Image = CType(resources.GetObject("picRacer3.Image"), System.Drawing.Image)
        Me.picRacer3.Location = New System.Drawing.Point(12, 287)
        Me.picRacer3.Name = "picRacer3"
        Me.picRacer3.Size = New System.Drawing.Size(182, 92)
        Me.picRacer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRacer3.TabIndex = 2
        Me.picRacer3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(549, 60)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 282)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(502, 31)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 4
        Me.btnRace.Text = "Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(583, 31)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RaceCarGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 433)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picRacer3)
        Me.Controls.Add(Me.picRacer2)
        Me.Controls.Add(Me.picRacer1)
        Me.Name = "RaceCarGame"
        Me.Text = "RaceCarGame"
        CType(Me.picRacer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRacer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRacer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picRacer1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRacer2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRacer3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
