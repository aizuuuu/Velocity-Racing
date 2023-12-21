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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        lblSpeed = New Label()
        lblScore = New Label()
        race3 = New PictureBox()
        race2 = New PictureBox()
        race1 = New PictureBox()
        car = New PictureBox()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RacerMover1 = New Timer(components)
        RacerMover2 = New Timer(components)
        RacerMover3 = New Timer(components)
        lblGameover = New Label()
        btnPlayAgain = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(97, -32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 98)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Location = New Point(224, -32)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(12, 98)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(224, 114)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(12, 98)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Location = New Point(97, 114)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 98)
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Location = New Point(224, 242)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(12, 98)
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Location = New Point(97, 242)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 98)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.Location = New Point(226, 386)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(12, 98)
        PictureBox7.TabIndex = 7
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.White
        PictureBox8.Location = New Point(99, 386)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(12, 98)
        PictureBox8.TabIndex = 6
        PictureBox8.TabStop = False
        ' 
        ' lblSpeed
        ' 
        lblSpeed.AutoSize = True
        lblSpeed.Font = New Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblSpeed.ForeColor = Color.LightGreen
        lblSpeed.Location = New Point(4, 9)
        lblSpeed.Name = "lblSpeed"
        lblSpeed.Size = New Size(89, 20)
        lblSpeed.TabIndex = 8
        lblSpeed.Text = "SPEED 0"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblScore.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lblScore.Location = New Point(244, 9)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(90, 20)
        lblScore.TabIndex = 9
        lblScore.Text = "SCORE 0"
        ' 
        ' race3
        ' 
        race3.Image = My.Resources.Resources._10
        race3.Location = New Point(26, 242)
        race3.Name = "race3"
        race3.Size = New Size(40, 68)
        race3.SizeMode = PictureBoxSizeMode.Zoom
        race3.TabIndex = 10
        race3.TabStop = False
        ' 
        ' race2
        ' 
        race2.Image = My.Resources.Resources._8
        race2.Location = New Point(149, 158)
        race2.Name = "race2"
        race2.Size = New Size(40, 68)
        race2.SizeMode = PictureBoxSizeMode.Zoom
        race2.TabIndex = 11
        race2.TabStop = False
        ' 
        ' race1
        ' 
        race1.Image = My.Resources.Resources._1
        race1.Location = New Point(272, 180)
        race1.Name = "race1"
        race1.Size = New Size(40, 68)
        race1.SizeMode = PictureBoxSizeMode.Zoom
        race1.TabIndex = 12
        race1.TabStop = False
        ' 
        ' car
        ' 
        car.Image = My.Resources.Resources._11
        car.Location = New Point(149, 347)
        car.Name = "car"
        car.Size = New Size(40, 68)
        car.SizeMode = PictureBoxSizeMode.Zoom
        car.TabIndex = 13
        car.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RacerMover1
        ' 
        RacerMover1.Enabled = True
        RacerMover1.Interval = 8
        ' 
        ' RacerMover2
        ' 
        RacerMover2.Enabled = True
        RacerMover2.Interval = 8
        ' 
        ' RacerMover3
        ' 
        RacerMover3.Enabled = True
        RacerMover3.Interval = 8
        ' 
        ' lblGameover
        ' 
        lblGameover.AutoSize = True
        lblGameover.BackColor = Color.Transparent
        lblGameover.Font = New Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblGameover.ForeColor = Color.Firebrick
        lblGameover.Location = New Point(67, 191)
        lblGameover.Name = "lblGameover"
        lblGameover.Size = New Size(199, 35)
        lblGameover.TabIndex = 14
        lblGameover.Text = "GAMEOVER"
        lblGameover.Visible = False
        ' 
        ' btnPlayAgain
        ' 
        btnPlayAgain.BackColor = Color.Transparent
        btnPlayAgain.BackgroundImageLayout = ImageLayout.None
        btnPlayAgain.FlatAppearance.BorderSize = 0
        btnPlayAgain.FlatStyle = FlatStyle.Flat
        btnPlayAgain.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPlayAgain.ForeColor = Color.PaleGreen
        btnPlayAgain.Location = New Point(90, 232)
        btnPlayAgain.Name = "btnPlayAgain"
        btnPlayAgain.Size = New Size(146, 35)
        btnPlayAgain.TabIndex = 15
        btnPlayAgain.Text = "PLAY AGAIN"
        btnPlayAgain.UseVisualStyleBackColor = False
        btnPlayAgain.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(334, 461)
        Controls.Add(btnPlayAgain)
        Controls.Add(lblGameover)
        Controls.Add(car)
        Controls.Add(race1)
        Controls.Add(race2)
        Controls.Add(race3)
        Controls.Add(lblScore)
        Controls.Add(lblSpeed)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "Velocity Racing"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RacerMover2 As Timer
    Friend WithEvents RacerMover3 As Timer
    Friend WithEvents lblGameover As Label
    Friend WithEvents btnPlayAgain As Button
End Class
