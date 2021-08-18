<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.imgCartes = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBet = New System.Windows.Forms.Label()
        Me.btnBetPlus = New System.Windows.Forms.Button()
        Me.lblCreditName = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnBetLess = New System.Windows.Forms.Button()
        Me.lblBetName = New System.Windows.Forms.Label()
        Me.lblBetButtons = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.tmrChangeCard = New System.Windows.Forms.Timer(Me.components)
        Me.lblCenter = New System.Windows.Forms.Label()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.tmrFlashLabel = New System.Windows.Forms.Timer(Me.components)
        Me.picAdd100 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.tmrShapes = New System.Windows.Forms.Timer(Me.components)
        Me.lblDrawPic1 = New System.Windows.Forms.Label()
        Me.lblDrawPic2 = New System.Windows.Forms.Label()
        Me.lblDrawPic4 = New System.Windows.Forms.Label()
        Me.lblDrawPic3 = New System.Windows.Forms.Label()
        Me.lblDrawPic5 = New System.Windows.Forms.Label()
        Me.tmrIncreaseCredit = New System.Windows.Forms.Timer(Me.components)
        Me.lblWin = New System.Windows.Forms.Label()
        Me.pnlSideButtons = New System.Windows.Forms.Panel()
        CType(Me.picAdd100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSideButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgCartes
        '
        Me.imgCartes.ImageStream = CType(resources.GetObject("imgCartes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCartes.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCartes.Images.SetKeyName(0, "back.png")
        Me.imgCartes.Images.SetKeyName(1, "Ac.gif")
        Me.imgCartes.Images.SetKeyName(2, "2c.gif")
        Me.imgCartes.Images.SetKeyName(3, "3c.gif")
        Me.imgCartes.Images.SetKeyName(4, "4c.gif")
        Me.imgCartes.Images.SetKeyName(5, "5c.gif")
        Me.imgCartes.Images.SetKeyName(6, "6c.gif")
        Me.imgCartes.Images.SetKeyName(7, "7c.gif")
        Me.imgCartes.Images.SetKeyName(8, "8c.gif")
        Me.imgCartes.Images.SetKeyName(9, "9c.gif")
        Me.imgCartes.Images.SetKeyName(10, "10c.gif")
        Me.imgCartes.Images.SetKeyName(11, "Jc.gif")
        Me.imgCartes.Images.SetKeyName(12, "Qc.gif")
        Me.imgCartes.Images.SetKeyName(13, "Kc.gif")
        Me.imgCartes.Images.SetKeyName(14, "Ad.gif")
        Me.imgCartes.Images.SetKeyName(15, "2d.gif")
        Me.imgCartes.Images.SetKeyName(16, "3d.gif")
        Me.imgCartes.Images.SetKeyName(17, "4d.gif")
        Me.imgCartes.Images.SetKeyName(18, "5d.gif")
        Me.imgCartes.Images.SetKeyName(19, "6d.gif")
        Me.imgCartes.Images.SetKeyName(20, "7d.gif")
        Me.imgCartes.Images.SetKeyName(21, "8d.gif")
        Me.imgCartes.Images.SetKeyName(22, "9d.gif")
        Me.imgCartes.Images.SetKeyName(23, "10d.gif")
        Me.imgCartes.Images.SetKeyName(24, "Jd.gif")
        Me.imgCartes.Images.SetKeyName(25, "Qd.gif")
        Me.imgCartes.Images.SetKeyName(26, "Kd.gif")
        Me.imgCartes.Images.SetKeyName(27, "Ah.gif")
        Me.imgCartes.Images.SetKeyName(28, "2h.gif")
        Me.imgCartes.Images.SetKeyName(29, "3h.gif")
        Me.imgCartes.Images.SetKeyName(30, "4h.gif")
        Me.imgCartes.Images.SetKeyName(31, "5h.gif")
        Me.imgCartes.Images.SetKeyName(32, "6h.gif")
        Me.imgCartes.Images.SetKeyName(33, "7h.gif")
        Me.imgCartes.Images.SetKeyName(34, "8h.gif")
        Me.imgCartes.Images.SetKeyName(35, "9h.gif")
        Me.imgCartes.Images.SetKeyName(36, "10h.gif")
        Me.imgCartes.Images.SetKeyName(37, "Jh.gif")
        Me.imgCartes.Images.SetKeyName(38, "Qh.gif")
        Me.imgCartes.Images.SetKeyName(39, "Kh.gif")
        Me.imgCartes.Images.SetKeyName(40, "As.gif")
        Me.imgCartes.Images.SetKeyName(41, "2s.gif")
        Me.imgCartes.Images.SetKeyName(42, "3s.gif")
        Me.imgCartes.Images.SetKeyName(43, "4s.gif")
        Me.imgCartes.Images.SetKeyName(44, "5s.gif")
        Me.imgCartes.Images.SetKeyName(45, "6s.gif")
        Me.imgCartes.Images.SetKeyName(46, "7s.gif")
        Me.imgCartes.Images.SetKeyName(47, "8s.gif")
        Me.imgCartes.Images.SetKeyName(48, "9s.gif")
        Me.imgCartes.Images.SetKeyName(49, "10s.gif")
        Me.imgCartes.Images.SetKeyName(50, "Js.gif")
        Me.imgCartes.Images.SetKeyName(51, "Qs.gif")
        Me.imgCartes.Images.SetKeyName(52, "Ks.gif")
        '
        'lblBet
        '
        Me.lblBet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBet.Location = New System.Drawing.Point(40, 88)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(182, 65)
        Me.lblBet.TabIndex = 5
        Me.lblBet.Text = "0"
        Me.lblBet.UseCompatibleTextRendering = True
        '
        'btnBetPlus
        '
        Me.btnBetPlus.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnBetPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBetPlus.Location = New System.Drawing.Point(97, 171)
        Me.btnBetPlus.Name = "btnBetPlus"
        Me.btnBetPlus.Size = New System.Drawing.Size(45, 45)
        Me.btnBetPlus.TabIndex = 6
        Me.btnBetPlus.Text = "+"
        Me.btnBetPlus.UseVisualStyleBackColor = False
        '
        'lblCreditName
        '
        Me.lblCreditName.AutoSize = True
        Me.lblCreditName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditName.Location = New System.Drawing.Point(564, 31)
        Me.lblCreditName.Name = "lblCreditName"
        Me.lblCreditName.Size = New System.Drawing.Size(205, 65)
        Me.lblCreditName.TabIndex = 7
        Me.lblCreditName.Text = "CREDIT"
        Me.lblCreditName.UseCompatibleTextRendering = True
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.Transparent
        Me.lblCredit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(599, 83)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(188, 65)
        Me.lblCredit.TabIndex = 8
        Me.lblCredit.Text = "0"
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblCredit.UseCompatibleTextRendering = True
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Location = New System.Drawing.Point(856, 549)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 45)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnBetLess
        '
        Me.btnBetLess.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnBetLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBetLess.Location = New System.Drawing.Point(46, 171)
        Me.btnBetLess.Name = "btnBetLess"
        Me.btnBetLess.Size = New System.Drawing.Size(45, 45)
        Me.btnBetLess.TabIndex = 10
        Me.btnBetLess.Text = "-"
        Me.btnBetLess.UseVisualStyleBackColor = False
        '
        'lblBetName
        '
        Me.lblBetName.AutoSize = True
        Me.lblBetName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBetName.Location = New System.Drawing.Point(40, 31)
        Me.lblBetName.Name = "lblBetName"
        Me.lblBetName.Size = New System.Drawing.Size(116, 65)
        Me.lblBetName.TabIndex = 11
        Me.lblBetName.Text = "BET"
        Me.lblBetName.UseCompatibleTextRendering = True
        '
        'lblBetButtons
        '
        Me.lblBetButtons.AutoSize = True
        Me.lblBetButtons.Location = New System.Drawing.Point(63, 132)
        Me.lblBetButtons.Name = "lblBetButtons"
        Me.lblBetButtons.Size = New System.Drawing.Size(39, 24)
        Me.lblBetButtons.TabIndex = 12
        Me.lblBetButtons.Text = "BET"
        Me.lblBetButtons.UseCompatibleTextRendering = True
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Location = New System.Drawing.Point(47, 549)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(720, 45)
        Me.btnContinue.TabIndex = 13
        Me.btnContinue.Tag = "Start"
        Me.btnContinue.Text = "Start"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'tmrChangeCard
        '
        Me.tmrChangeCard.Interval = 250
        '
        'lblCenter
        '
        Me.lblCenter.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCenter.Location = New System.Drawing.Point(116, 136)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(583, 121)
        Me.lblCenter.TabIndex = 16
        Me.lblCenter.Text = "ENTER 25C " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND PRESS START"
        Me.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCenter.UseCompatibleTextRendering = True
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.LemonChiffon
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Location = New System.Drawing.Point(50, 390)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(96, 45)
        Me.cmdReset.TabIndex = 17
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        Me.cmdReset.Visible = False
        '
        'btnScores
        '
        Me.btnScores.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScores.Location = New System.Drawing.Point(50, 339)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(96, 45)
        Me.btnScores.TabIndex = 18
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = False
        Me.btnScores.Visible = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Location = New System.Drawing.Point(50, 288)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(96, 45)
        Me.btnRules.TabIndex = 19
        Me.btnRules.Text = "Rules"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'tmrFlashLabel
        '
        Me.tmrFlashLabel.Interval = 1000
        '
        'picAdd100
        '
        Me.picAdd100.Image = Global.Poker_App_VB.My.Resources.Resources.ADD_100C_BLACK
        Me.picAdd100.Location = New System.Drawing.Point(46, 21)
        Me.picAdd100.Name = "picAdd100"
        Me.picAdd100.Size = New System.Drawing.Size(100, 100)
        Me.picAdd100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdd100.TabIndex = 15
        Me.picAdd100.TabStop = False
        '
        'picCard5
        '
        Me.picCard5.Image = CType(resources.GetObject("picCard5.Image"), System.Drawing.Image)
        Me.picCard5.Location = New System.Drawing.Point(629, 340)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(140, 200)
        Me.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard5.TabIndex = 4
        Me.picCard5.TabStop = False
        '
        'picCard4
        '
        Me.picCard4.Image = CType(resources.GetObject("picCard4.Image"), System.Drawing.Image)
        Me.picCard4.Location = New System.Drawing.Point(483, 340)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(140, 200)
        Me.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard4.TabIndex = 3
        Me.picCard4.TabStop = False
        '
        'picCard3
        '
        Me.picCard3.Image = CType(resources.GetObject("picCard3.Image"), System.Drawing.Image)
        Me.picCard3.Location = New System.Drawing.Point(337, 340)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(140, 200)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard3.TabIndex = 2
        Me.picCard3.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.Image = CType(resources.GetObject("picCard2.Image"), System.Drawing.Image)
        Me.picCard2.Location = New System.Drawing.Point(191, 340)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(140, 200)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard2.TabIndex = 1
        Me.picCard2.TabStop = False
        '
        'picCard1
        '
        Me.picCard1.BackColor = System.Drawing.Color.Transparent
        Me.picCard1.Image = CType(resources.GetObject("picCard1.Image"), System.Drawing.Image)
        Me.picCard1.Location = New System.Drawing.Point(45, 340)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(140, 200)
        Me.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        '
        'tmrShapes
        '
        '
        'lblDrawPic1
        '
        Me.lblDrawPic1.AutoSize = True
        Me.lblDrawPic1.Location = New System.Drawing.Point(77, 276)
        Me.lblDrawPic1.Name = "lblDrawPic1"
        Me.lblDrawPic1.Size = New System.Drawing.Size(57, 24)
        Me.lblDrawPic1.TabIndex = 20
        Me.lblDrawPic1.Text = "DRAW"
        Me.lblDrawPic1.UseCompatibleTextRendering = True
        Me.lblDrawPic1.Visible = False
        '
        'lblDrawPic2
        '
        Me.lblDrawPic2.AutoSize = True
        Me.lblDrawPic2.Location = New System.Drawing.Point(222, 276)
        Me.lblDrawPic2.Name = "lblDrawPic2"
        Me.lblDrawPic2.Size = New System.Drawing.Size(57, 24)
        Me.lblDrawPic2.TabIndex = 21
        Me.lblDrawPic2.Text = "DRAW"
        Me.lblDrawPic2.UseCompatibleTextRendering = True
        Me.lblDrawPic2.Visible = False
        '
        'lblDrawPic4
        '
        Me.lblDrawPic4.AutoSize = True
        Me.lblDrawPic4.Location = New System.Drawing.Point(515, 276)
        Me.lblDrawPic4.Name = "lblDrawPic4"
        Me.lblDrawPic4.Size = New System.Drawing.Size(57, 24)
        Me.lblDrawPic4.TabIndex = 23
        Me.lblDrawPic4.Text = "DRAW"
        Me.lblDrawPic4.UseCompatibleTextRendering = True
        Me.lblDrawPic4.Visible = False
        '
        'lblDrawPic3
        '
        Me.lblDrawPic3.AutoSize = True
        Me.lblDrawPic3.Location = New System.Drawing.Point(368, 276)
        Me.lblDrawPic3.Name = "lblDrawPic3"
        Me.lblDrawPic3.Size = New System.Drawing.Size(57, 24)
        Me.lblDrawPic3.TabIndex = 22
        Me.lblDrawPic3.Text = "DRAW"
        Me.lblDrawPic3.UseCompatibleTextRendering = True
        Me.lblDrawPic3.Visible = False
        '
        'lblDrawPic5
        '
        Me.lblDrawPic5.AutoSize = True
        Me.lblDrawPic5.Location = New System.Drawing.Point(659, 276)
        Me.lblDrawPic5.Name = "lblDrawPic5"
        Me.lblDrawPic5.Size = New System.Drawing.Size(57, 24)
        Me.lblDrawPic5.TabIndex = 24
        Me.lblDrawPic5.Text = "DRAW"
        Me.lblDrawPic5.UseCompatibleTextRendering = True
        Me.lblDrawPic5.Visible = False
        '
        'tmrIncreaseCredit
        '
        Me.tmrIncreaseCredit.Interval = 10
        '
        'lblWin
        '
        Me.lblWin.Location = New System.Drawing.Point(281, 48)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(255, 24)
        Me.lblWin.TabIndex = 25
        Me.lblWin.Text = "WIN: "
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWin.UseCompatibleTextRendering = True
        Me.lblWin.Visible = False
        '
        'pnlSideButtons
        '
        Me.pnlSideButtons.Controls.Add(Me.picAdd100)
        Me.pnlSideButtons.Controls.Add(Me.btnRules)
        Me.pnlSideButtons.Controls.Add(Me.btnScores)
        Me.pnlSideButtons.Controls.Add(Me.cmdReset)
        Me.pnlSideButtons.Controls.Add(Me.lblBetButtons)
        Me.pnlSideButtons.Controls.Add(Me.btnBetPlus)
        Me.pnlSideButtons.Controls.Add(Me.btnBetLess)
        Me.pnlSideButtons.Location = New System.Drawing.Point(810, 52)
        Me.pnlSideButtons.Name = "pnlSideButtons"
        Me.pnlSideButtons.Size = New System.Drawing.Size(180, 451)
        Me.pnlSideButtons.TabIndex = 26
        '
        'FrmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1017, 625)
        Me.Controls.Add(Me.pnlSideButtons)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblDrawPic5)
        Me.Controls.Add(Me.lblDrawPic4)
        Me.Controls.Add(Me.lblDrawPic3)
        Me.Controls.Add(Me.lblDrawPic2)
        Me.Controls.Add(Me.lblDrawPic1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblCenter)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblBetName)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblCreditName)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = " POKER"
        CType(Me.picAdd100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSideButtons.ResumeLayout(False)
        Me.pnlSideButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCard1 As PictureBox
    Friend WithEvents imgCartes As ImageList
    Friend WithEvents picCard2 As PictureBox
    Friend WithEvents picCard3 As PictureBox
    Friend WithEvents picCard4 As PictureBox
    Friend WithEvents picCard5 As PictureBox
    Friend WithEvents lblBet As Label
    Friend WithEvents btnBetPlus As Button
    Friend WithEvents lblCreditName As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnBetLess As Button
    Friend WithEvents lblBetName As Label
    Friend WithEvents lblBetButtons As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents tmrChangeCard As Timer
    Friend WithEvents picAdd100 As PictureBox
    Friend WithEvents lblCenter As Label
    Friend WithEvents cmdReset As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents tmrFlashLabel As Timer
    Friend WithEvents tmrShapes As Timer
    Friend WithEvents lblDrawPic1 As Label
    Friend WithEvents lblDrawPic2 As Label
    Friend WithEvents lblDrawPic4 As Label
    Friend WithEvents lblDrawPic3 As Label
    Friend WithEvents lblDrawPic5 As Label
    Friend WithEvents tmrIncreaseCredit As Timer
    Friend WithEvents lblWin As Label
    Friend WithEvents pnlSideButtons As Panel
End Class
