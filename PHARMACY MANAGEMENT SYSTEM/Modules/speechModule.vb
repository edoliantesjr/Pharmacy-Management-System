
Imports System.Speech.Synthesis
Module speechModule
    Dim speech As New SpeechSynthesizer
    Public Sub speakNow(s As String)
        speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen)
        speech.Rate = 1
        speech.Volume = 100
        speech.SpeakAsync(s)
    End Sub


End Module

