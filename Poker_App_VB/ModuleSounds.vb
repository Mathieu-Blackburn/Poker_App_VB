' Programme: Jeu de Poker
' 
' Fait Par:  Mathieu Blackburn Rogers
' Le:        31-01-2021

Imports System.Media

Module ModuleSounds
    Dim sp As SoundPlayer

    ''' <summary>
    ''' Method that plays the given sound
    ''' </summary>
    ''' <param name="name">Sound to play</param>
    Public Sub Sound_Play(name As String)
        Dim path As String = ""
        Select Case name
            Case "tap"
                path = "..\\Ressources\\CardTap.wav"
            Case "click"
                path = "..\\Ressources\\Click.wav"
            Case "shuffle"
                path = "..\\Ressources\\CardShuffle.wav"
            Case "win"
                path = "..\\Ressources\\Win.wav"
            Case "gameover"
                path = "..\\Ressources\\GameOver.Wav"
            Case "coin"
                path = "..\\Ressources\\Coin.wav"
            Case Else
                Exit Sub
        End Select

        sp = New SoundPlayer(path)
        sp.Play()
    End Sub

End Module
