Public Class frmInfoViewer

    Public Sub ShowInfo(title As String, content As String, boldWords As List(Of String), italicBoldWords As List(Of String))
        Me.Text = title
        rtbContent.Clear()
        rtbContent.SelectionFont = New Font("Segoe UI", 16, FontStyle.Bold Or FontStyle.Italic)
        rtbContent.SelectionAlignment = HorizontalAlignment.Center
        rtbContent.AppendText(title & vbCrLf & vbCrLf)
        rtbContent.SelectionFont = New Font("Segoe UI", 10, FontStyle.Regular)
        rtbContent.SelectionAlignment = HorizontalAlignment.Left
        rtbContent.AppendText(content)

        For Each word In boldWords
            Dim startIndex As Integer = 0
            Do
                startIndex = rtbContent.Find(word, startIndex, RichTextBoxFinds.MatchCase)
                If startIndex = -1 Then Exit Do
                rtbContent.Select(startIndex, word.Length)
                rtbContent.SelectionFont = New Font(rtbContent.Font, FontStyle.Bold)
                startIndex += word.Length
            Loop
        Next

        For Each word In italicBoldWords
            Dim startIndex As Integer = 0
            Do
                startIndex = rtbContent.Find(word, startIndex, RichTextBoxFinds.MatchCase)
                If startIndex = -1 Then Exit Do
                rtbContent.Select(startIndex, word.Length)
                rtbContent.SelectionFont = New Font(rtbContent.Font, FontStyle.Bold Or FontStyle.Italic)
                startIndex += word.Length
            Loop
        Next
        rtbContent.SelectionStart = 0
        rtbContent.ScrollToCaret()
        rtbContent.ReadOnly = True
        rtbContent.TabStop = False
        rtbContent.Cursor = Cursors.Default


        AddHandler rtbContent.SelectionChanged, Sub(sender, e)
                                                    rtbContent.SelectionLength = 0
                                                End Sub

        Me.ShowDialog()
    End Sub

End Class
