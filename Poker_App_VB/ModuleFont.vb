' Programme: Jeu de Poker
' 
' Fait Par:  Mathieu Blackburn Rogers
' Le:        31-01-2021

Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Text
Imports System.Text
Imports System.Runtime.InteropServices
Module ModuleFont

    Public pfc As PrivateFontCollection = Nothing

    ''' <summary>
    ''' Loads the custom font if it's not currently loaded. Returns the custom font.
    ''' </summary>
    ''' <param name="size">Font size</param>
    ''' <param name="style">FontStyle</param>
    ''' <returns></returns>
    Public ReadOnly Property GetInstance(ByVal size As Single, ByVal style As FontStyle) As Font
        Get
            If pfc Is Nothing Then LoadFont()
            LoadFont()

            Return New Font(pfc.Families(0), size, style)
        End Get
    End Property

    ''' <summary>
    ''' Loads the custom font into memory to be used by the application.
    ''' </summary>
    Private Sub LoadFont()
        Try
            pfc = New PrivateFontCollection

            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.ARCADECLASSIC.Length)

            Marshal.Copy(My.Resources.ARCADECLASSIC, 0, fontMemPointer, My.Resources.ARCADECLASSIC.Length)
            pfc.AddMemoryFont(fontMemPointer, My.Resources.ARCADECLASSIC.Length)

            Marshal.FreeCoTaskMem(fontMemPointer)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Changes the font of the given controls to the custom one.
    ''' </summary>
    ''' <param name="size">font Size</param>
    ''' <param name="controls">Controls to change their font</param>
    Public Sub ChangeFont(size As Integer, ByVal ParamArray controls() As Control)
        For Each c As Control In controls
            c.Font = New Font(pfc.Families(0), size, FontStyle.Regular)
            c.ForeColor = Color.FromArgb(230, 230, 25)
        Next


    End Sub
End Module
