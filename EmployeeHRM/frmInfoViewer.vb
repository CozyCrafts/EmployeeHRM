Public Class frmInfoViewer

    ' This is the single RichTextBox you need on your form named: rtbContent
    ' Set properties: Multiline=True, WordWrap=True, ScrollBars=Vertical, Dock=Fill

    Public Sub ShowInfo(title As String, content As String, boldWords As List(Of String), italicBoldWords As List(Of String))
        ' Set form title
        Me.Text = title

        ' Clear previous content
        rtbContent.Clear()

        ' Title formatting: centered, larger, bold + italic
        rtbContent.SelectionFont = New Font("Segoe UI", 16, FontStyle.Bold Or FontStyle.Italic)
        rtbContent.SelectionAlignment = HorizontalAlignment.Center
        rtbContent.AppendText(title & vbCrLf & vbCrLf)

        ' Body formatting: left aligned, regular font
        rtbContent.SelectionFont = New Font("Segoe UI", 10, FontStyle.Regular)
        rtbContent.SelectionAlignment = HorizontalAlignment.Left
        rtbContent.AppendText(content)

        ' Highlight bold words
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

        ' Highlight bold + italic words
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

        ' Scroll to top
        rtbContent.SelectionStart = 0
        rtbContent.ScrollToCaret()

        ' Show the form
        Me.ShowDialog()
    End Sub

End Class
