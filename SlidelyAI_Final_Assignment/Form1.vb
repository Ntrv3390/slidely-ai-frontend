Public Class Form1

    Private Sub view_submission_btn_Click(sender As Object, e As EventArgs) Handles view_submission_btn.Click
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub

    Private Sub create_submission_btn_Click(sender As Object, e As EventArgs) Handles create_submission_btn.Click
        Dim submitForm As New SubmitForm()
        submitForm.Show()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            Dim viewForm As New ViewForm()
            viewForm.Show()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            Dim submitForm As New SubmitForm()
            submitForm.Show()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
