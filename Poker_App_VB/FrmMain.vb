' Programme: Jeu de Poker
' 
' Fait Par:  Mathieu Blackburn Rogers
' Le:        31-01-2021


Imports System.Drawing
Public Class FrmMain
    Dim Deck(52) As Integer
    Dim cardsPicked(52) As Boolean
    Dim playerBet As Integer
    Dim playerCredits As Integer
    Dim cardPicTable(4) As PictureBox
    Dim Current_Hand(4) As Card
    Dim PlayerWins As Win_Categories

    Private Enum CardColor
        Clubs
        Diamonds
        Hearts
        Spades
    End Enum

    Private Enum Win_Categories
        None
        HighCard
        Pair
        TwoPairs
        ThreeofaKind
        Straight
        Flush
        FullHouse
        FourofaKind
        StraightFlush
        RoyalFlush
    End Enum

    Private Structure Card
        Public value As Integer
        Public face As Integer
        Public color As CardColor
        Public number As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Init_CardPickTable()
        Reset()
        Init_Font()
        tmrShapes.Start()

    End Sub



#Region "General Methods"

    ''' <summary>
    ''' Method initializing the "Arcade" font
    ''' </summary>
    Private Sub Init_Font()

        Me.Font = ModuleFont.GetInstance(14, FontStyle.Bold)
        Me.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        Me.ForeColor = Color.Black
        ChangeFont(48, lblBetName, lblBet, lblCreditName, lblCredit, lblCenter)
        ChangeFont(24, lblBetButtons, lblDrawPic1, lblDrawPic2, lblDrawPic3, lblDrawPic4, lblDrawPic5, lblWin)

    End Sub

    ''' <summary>
    ''' Method initializing cardPickTable @Form_Load
    ''' </summary>
    Private Sub Init_CardPickTable()

        cardPicTable(0) = picCard1
        cardPicTable(1) = picCard2
        cardPicTable(2) = picCard3
        cardPicTable(3) = picCard4
        cardPicTable(4) = picCard5

    End Sub

    ''' <summary>
    ''' Method to draw yellow rectangles
    ''' </summary>
    ''' <param name="x">'X' rectangle starting point</param>
    ''' <param name="y">'Y' rectangle starting point></param>
    ''' <param name="width">Width of the rectangle to draw</param>
    ''' <param name="height">Height of the rectangle to draw</param>
    Private Sub Draw_Rectangle(x As Integer, y As Integer, width As Integer, height As Integer)

        Dim myPen As Pen = New Pen(Color.FromArgb(230, 230, 25))
        myPen.Width = 5
        Dim formGraphics As Graphics
        formGraphics = Me.CreateGraphics
        formGraphics.DrawRectangle(myPen, New Rectangle(x, y, width, height))
        myPen.Dispose()
        formGraphics.Dispose()


    End Sub

    ''' <summary>
    ''' Method to change the "Draw" label 'Enabled' property for each card
    ''' </summary>
    ''' <param name="sender">Selected card's Draw label to change</param>
    Private Sub Change_Draw_Label_Status(sender As Object)

        Select Case sender.Name

            Case "picCard1"
                lblDrawPic1.Visible = Not lblDrawPic1.Visible

            Case "picCard2"
                lblDrawPic2.Visible = Not lblDrawPic2.Visible

            Case "picCard3"
                lblDrawPic3.Visible = Not lblDrawPic3.Visible

            Case "picCard4"
                lblDrawPic4.Visible = Not lblDrawPic4.Visible

            Case "picCard5"
                lblDrawPic5.Visible = Not lblDrawPic5.Visible

        End Select

    End Sub

    ''' <summary>
    ''' Method wrapping the end sequence of the game
    ''' </summary>
    Private Sub End_Sequence()
        Calculate_Winnings()
        Wins_Handler()

    End Sub


    ''' <summary>
    ''' Method that parses through every card in hand to determine what type of hand it is
    ''' </summary>
    Private Sub Calculate_Winnings()

        ' Section to parse through the player's hand to see what they have
        Dim Highest_Face As Integer = 0
        Dim Best_Color As Integer = 0
        Dim Faces_Counter(13) As Integer
        Dim Colors_Counter(3) As Integer
        Dim Straight_Counter As Integer = 0
        Dim Flush_Counter As Integer = 0
        Dim Two_oafK(1, 1) As Integer
        Dim Card_Faces(4) As Integer
        Dim isThree_ofaK As Boolean = False
        Dim isFour_ofaK As Boolean = False
        Dim isStraight As Boolean = False
        Dim isFlush As Boolean = False
        Dim isStraightAce As Boolean = False
        Dim Cpt_Temp As Integer = 0
        Dim i As Integer = 0

        For i = 0 To 4
            Faces_Counter(Current_Hand(i).face) += 1
            Colors_Counter(Current_Hand(i).color) += 1
            If Colors_Counter(Current_Hand(i).color) = 5 Then
                isStraight = True
            End If
            Card_Faces(i) = Current_Hand(i).face
        Next

        Array.Sort(Card_Faces)

        For i = 1 To 4
            If Card_Faces(i) = (Card_Faces(i - 1) + 1) Then
                Straight_Counter += 1
                If Straight_Counter = 4 Then
                    isStraight = True
                End If
            End If
        Next

        If (Card_Faces.Contains(13) And Card_Faces.Contains(12) And Card_Faces.Contains(11) _
            And Card_Faces.Contains(10) And Card_Faces.Contains(1)) Then
            isStraightAce = True

        End If

        For i = 1 To 13

            If Faces_Counter(i) = 4 Then
                isFour_ofaK = True
            End If

            If Faces_Counter(i) = 3 Then
                isThree_ofaK = True
            End If

            If Faces_Counter(i) = 2 Then
                Two_oafK(Cpt_Temp, 0) = 1
                Two_oafK(Cpt_Temp, 1) = i + 1
                Cpt_Temp += 1
            End If

            If Faces_Counter(i) <> 0 Then
                Highest_Face = (i + 1)
            End If

        Next


        ' Section to determine if the player wins
        ' Best hands possible first, then goes straight down

        If (isFlush = True And isStraightAce) Then
            PlayerWins = Win_Categories.RoyalFlush

        ElseIf isStraight = True And isFlush = True Then
            PlayerWins = Win_Categories.StraightFlush

        ElseIf isFour_ofaK = True Then
            PlayerWins = Win_Categories.FourofaKind

        ElseIf (Two_oafK(0, 0) = 1 Or Two_oafK(1, 0) = 1) And isThree_ofaK = True Then
            PlayerWins = Win_Categories.FullHouse

        ElseIf isFlush = True Then
            PlayerWins = Win_Categories.Flush

        ElseIf isStraight = True Then
            PlayerWins = Win_Categories.Straight

        ElseIf isThree_ofaK = True Then
            PlayerWins = Win_Categories.ThreeofaKind

        ElseIf (Two_oafK(0, 0) = 1 And Two_oafK(1, 0) = 1) Then
            PlayerWins = Win_Categories.TwoPairs

        ElseIf ((Two_oafK(0, 0) = 1 And Two_oafK(0, 1) > 10) Or (Two_oafK(1, 0) = 1 And Two_oafK(1, 1) > 10)) Then
            PlayerWins = Win_Categories.Pair

        Else
            PlayerWins = Win_Categories.None

        End If
    End Sub

    ''' <summary>
    ''' Method handling the credit handout and the screen labels if the player wins
    ''' </summary>
    Private Sub Wins_Handler()
        Dim strWin As String = ""
        Dim intWin As Integer = 0

        Select Case PlayerWins

            Case Win_Categories.None
                lblCenter.Visible = True
                lblCenter.Text = "GAME OVER"
                Sound_Play("gameover")
                tmrIncreaseCredit.Start()
                Exit Sub

            Case Win_Categories.Pair
                strWin = "A PAIR"
                intWin = (playerBet * 1)
                playerCredits = playerCredits + intWin

            Case Win_Categories.TwoPairs
                strWin = "TWO PAIRS"
                intWin = (playerBet * 3)
                playerCredits = playerCredits + intWin

            Case Win_Categories.ThreeofaKind
                strWin = "A THREE OF A KIND"
                intWin = (playerBet * 5)
                playerCredits = playerCredits + intWin

            Case Win_Categories.Straight
                strWin = "A STRAIGHT"
                intWin = (playerBet * 10)
                playerCredits = playerCredits + intWin

            Case Win_Categories.Flush
                strWin = "A FLUSH"
                intWin = (playerBet * 15)
                playerCredits = playerCredits + intWin

            Case Win_Categories.FullHouse
                strWin = "A FULL HOUSE"
                intWin = (playerBet * 20)
                playerCredits = playerCredits + intWin

            Case Win_Categories.FourofaKind
                strWin = "A FOUR OF A KIND"
                intWin = (playerBet * 25)
                playerCredits = playerCredits + intWin

            Case Win_Categories.StraightFlush
                strWin = "A STRAIGHT FLUSH"
                intWin = (playerBet * 50)
                playerCredits = playerCredits + intWin

            Case Win_Categories.RoyalFlush
                strWin = "ROYAL FLUSH"
                intWin = (playerBet * 100)
                playerCredits = playerCredits + intWin

            Case Else
                Reset()

        End Select

        Sound_Play("win")

        lblCenter.Visible = True
        lblCenter.Text = "YOU WIN!" & vbCrLf & "WITH " & strWin & "!"
        lblWin.Visible = True
        lblWin.Text = "WIN: " & intWin & "c"

        Ctrl_Lock(btnContinue)
        'btnContinue.Enabled = False                                   
        tmrIncreaseCredit.Start()

    End Sub

    ''' <summary>
    ''' Method resetting the game
    ''' </summary>
    Private Sub Reset()

        Init_Cards()
        Shuffle()

        picCard1.Image = imgCartes.Images(0)
        picCard2.Image = imgCartes.Images(0)
        picCard3.Image = imgCartes.Images(0)
        picCard4.Image = imgCartes.Images(0)
        picCard5.Image = imgCartes.Images(0)

        For i As Integer = 0 To 4

            Define_Card(i, 0)

            If cardPicTable(i).Tag = "Selected" Then
                'Change_Card(cardPicTable(i))
                Change_Card(i)
                Reset_Card_Position(i + 1)

            End If
        Next

        btnContinue.Tag = "Start"
        btnContinue.Text = "Start"
        playerBet = 0
        lblBet.Text = "0"
        PlayerWins = Win_Categories.None
        lblWin.Visible = False
        lblWin.Text = "Win: "
        lblCenter.Text = "ENTER 25C" & vbCrLf & "AND PRESS START"

        tmrFlashLabel.Start()
        Ctrl_Unlock(pnlSideButtons)

    End Sub

    ''' <summary>
    ''' Method locking changing the "Enabled" parameter of handed Control to False
    ''' </summary>
    ''' <param name="c">'Control' items to disable</param>
    Private Sub Ctrl_Lock(ParamArray ByVal c() As Control)

        For i As Integer = 0 To c.Length - 1
            c(i).Enabled = False
        Next

    End Sub

    ''' <summary>
    ''' Method locking changing the "Enabled" parameter of handed Control to True
    ''' </summary>
    ''' <param name="c">'Control' items to enable</param>
    Private Sub Ctrl_Unlock(ParamArray ByVal c() As Control)

        For i As Integer = 0 To c.Length - 1
            c(i).Enabled = True
        Next

    End Sub

#End Region



#Region "Buttons"

    ''' <summary>
    ''' 'Click' event for btnContinue
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Sound_Play("click")

        Select Case btnContinue.Tag

            Case "Start"

                If (Val(lblBet.Text)) > 0 Then

                    tmrFlashLabel.Stop()

                    Ctrl_Lock(pnlSideButtons, btnContinue)
                    playerBet = Val(lblBet.Text)
                    playerCredits = Val(lblCredit.Text)

                    Shuffle()
                    Give_Cards()

                    lblCenter.Text = "CHOOSE CARDS" & vbCrLf & "TO DISCARD"
                    lblCenter.Visible = True
                    'Ctrl_Unlock(btnQuit)
                End If

            Case "Continue"

                Give_Cards()
                Ctrl_Lock(btnContinue)
                'btnContinue.Enabled = False

            Case "End"
                Reset()
            Case Else
                Reset()
        End Select
    End Sub

    ''' <summary>
    ''' 'Click' event for picAdd100
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picAdd100.Click
        Dim credit As Integer

        credit = Val(lblCredit.Text)

        credit += 100
        Sound_Play("coin")

        lblCredit.Text = Str(credit)
    End Sub

    ''' <summary>
    ''' 'Click' event for btnBetPlus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBetPlus_Click(sender As Object, e As EventArgs) Handles btnBetPlus.Click

        Dim bet, credit As Integer
        bet = Val(lblBet.Text.Trim)
        credit = Val(lblCredit.Text)

        If credit > 0 Then
            bet += 25
            credit -= 25
            Sound_Play("click")
        Else
            Exit Sub
        End If

        lblBet.Text = Str(bet)
        lblCredit.Text = Str(credit)

    End Sub

    ''' <summary>
    ''' 'Click' event for btnBetLess
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBetLess_Click(sender As Object, e As EventArgs) Handles btnBetLess.Click

        Dim bet, credit As Integer
        bet = Val(lblBet.Text.Trim)
        credit = Val(lblCredit.Text)

        If bet > 0 Then
            Sound_Play("click")
            bet -= 25
            credit += 25
        Else
            Exit Sub
        End If

        lblBet.Text = Str(bet)
        lblCredit.Text = Str(credit)
    End Sub

    ''' <summary>
    ''' 'Click' event for btnQuit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Sound_Play("click")
        Application.Exit()

    End Sub

    ''' <summary>
    ''' 'Click' event for cmdReset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Reset()
    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        Dim frm = New FrmRules()
        frm.ShowDialog()

    End Sub


#End Region



#Region "Card Manipulations"

    ''' <summary>
    ''' Method initializing the deck of cards
    ''' </summary>
    Private Sub Init_Cards()

        For i As Integer = 1 To 52
            Deck(i) = i
            cardsPicked(i) = False
        Next

    End Sub

    ''' <summary>
    ''' Method shuffling the deck of cards
    ''' </summary>
    Private Sub Shuffle()

        Dim temp, pos1, pos2 As Integer
        Randomize()

        For cpt As Integer = 1 To 500
            pos1 = Rnd() * 51 + 1
            pos2 = Rnd() * 51 + 1

            If pos1 = pos2 Then
                Continue For
            End If

            temp = Deck(pos1)
            Deck(pos1) = Deck(pos2)
            Deck(pos2) = temp
        Next

    End Sub

    ''' <summary>
    ''' Method starting the timer used to give cards to the player
    ''' </summary>
    Private Sub Give_Cards()
        tmrChangeCard.Start()
    End Sub

    ''' <summary>
    ''' Method to change the selected card face
    ''' </summary>
    ''' <param name="card">Selected card to change</param>
    Private Sub Change_Card(card As Integer)

        Dim value As Integer
        value = Pick_Card()
        Define_Card(card, value)
        cardPicTable(card).Image = imgCartes.Images(value)
        Sound_Play("tap")

    End Sub

    ''' <summary>
    ''' Function used to pick a card from the deck
    ''' </summary>
    ''' <returns></returns>
    Private Function Pick_Card()
        Dim i As Integer

        For i = 1 To 52
            If cardsPicked(i) = False Then
                cardsPicked(i) = True
                Exit For
            Else

            End If
        Next
        Return Deck(i)
    End Function

    ''' <summary>
    ''' Method used to select a card to change with a mouse-click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Click_Card(sender As Object, e As EventArgs) Handles picCard1.Click, picCard3.Click, picCard2.Click, picCard5.Click, picCard4.Click

        If btnContinue.Tag = "Continue" And sender.Tag IsNot "Selected" Then

            sender.Location = New Point(sender.Location.X, sender.Location.Y - 25)
            sender.Tag = "Selected"
            Change_Draw_Label_Status(sender)
            Sound_Play("tap")

        ElseIf btnContinue.Tag = "Continue" And sender.Tag Is "Selected" Then

            sender.Location = New Point(sender.Location.X, sender.Location.Y + 25)
            sender.Tag = ""
            Change_Draw_Label_Status(sender)
            Sound_Play("tap")
            Draw_Rectangle(40, 335, 732, 207)

        End If
    End Sub

    ''' <summary>
    ''' Method used to analyze a given card to know it's characteristics
    ''' </summary>
    ''' <param name="card"></param>
    ''' <param name="value"></param>
    Private Sub Define_Card(card As Integer, value As Integer)

        Current_Hand(card).value = value
        Current_Hand(card).color = Math.Floor((value - 1) / 13)
        Current_Hand(card).face = value - (Current_Hand(card).color * 13)

    End Sub

    ''' <summary>
    ''' Method used to put back a given card to it's original position
    ''' </summary>
    ''' <param name="cpt">Card to reset</param>
    Private Sub Reset_Card_Position(cpt As Integer)
        Select Case cpt
            Case 1
                lblDrawPic1.Visible = False
                picCard1.Location = New Point(picCard1.Location.X, picCard1.Location.Y + 25)
                picCard1.Tag = ""
            Case 2
                lblDrawPic2.Visible = False
                picCard2.Location = New Point(picCard2.Location.X, picCard2.Location.Y + 25)
                picCard2.Tag = ""
            Case 3
                lblDrawPic3.Visible = False
                picCard3.Location = New Point(picCard3.Location.X, picCard3.Location.Y + 25)
                picCard3.Tag = ""
            Case 4
                lblDrawPic4.Visible = False
                picCard4.Location = New Point(picCard4.Location.X, picCard4.Location.Y + 25)
                picCard4.Tag = ""
            Case 5
                lblDrawPic5.Visible = False
                picCard5.Location = New Point(picCard5.Location.X, picCard5.Location.Y + 25)
                picCard5.Tag = ""
        End Select

        Draw_Rectangle(40, 335, 732, 207)

    End Sub

#End Region



#Region "Timers"

    ''' <summary>
    ''' Timer used to give cards to the player with an animation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrChangeCard_Tick(sender As Object, e As EventArgs) Handles tmrChangeCard.Tick
        Static Dim cpt As Integer = 0

        Select Case btnContinue.Tag
            Case "Start"
                'Change_Card(cardPicTable(cpt))
                Change_Card(cpt)
                cpt += 1
                If cpt < 5 Then
                    Exit Sub
                End If

            Case "Continue"
                Do While cpt < 5
                    If cardPicTable(cpt).Tag = "Selected" Then
                        'Change_Card(cardPicTable(cpt))
                        Change_Card(cpt)
                        Reset_Card_Position(cpt + 1)
                        If cpt < 4 Then
                            cpt = 0
                            Exit Sub
                        End If
                    End If
                    cpt += 1
                Loop

            Case "End"
            Case Else
                tmrChangeCard.Stop()
        End Select

        If cpt = 5 Then

            If btnContinue.Tag = "Start" Then
                Ctrl_Unlock(btnContinue)
                btnContinue.Tag = "Continue"
                btnContinue.Text = "Continue"

            ElseIf btnContinue.Tag = "Continue" Then
                btnContinue.Tag = "End"
                btnContinue.Text = "End"
                End_Sequence()
            End If

            cpt = 0
            tmrChangeCard.Stop()
        End If
    End Sub

    ''' <summary>
    ''' Timer used to make the center label flash at the start
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrFlashLabel_Tick(sender As Object, e As EventArgs) Handles tmrFlashLabel.Tick

        lblCenter.Visible = Not lblCenter.Visible
    End Sub

    ''' <summary>
    ''' Timer used to draw the game's yellow rectangles after Form_Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrShapes_Tick(sender As Object, e As EventArgs) Handles tmrShapes.Tick

        Draw_Rectangle(15, 15, 790, 590)
        Draw_Rectangle(805, 15, 190, 590)

        Draw_Rectangle(40, 335, 732, 207)
        Draw_Rectangle(40, 545, 732, 53)

        tmrShapes.Stop()
    End Sub

    ''' <summary>
    ''' Timer used to raised or lower the Credit label at the end of the game
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrIncreaseCredit_Tick(sender As Object, e As EventArgs) Handles tmrIncreaseCredit.Tick

        Static cpt = 0
        Dim c As Integer

        If cpt < 100 Then
            cpt += 1
            Exit Sub
        End If

        c = Val(lblCredit.Text)

        If c < playerCredits Then
            c += 1
            lblCredit.Text = c
            Exit Sub
        ElseIf c = playerCredits Then
            tmrIncreaseCredit.Stop()
            cpt = 0
            Ctrl_Unlock(btnContinue)
            'btnContinue.Enabled = True
        ElseIf c > playerCredits Then
            c -= 1
            lblCredit.Text = c
        End If
    End Sub

#End Region


End Class
