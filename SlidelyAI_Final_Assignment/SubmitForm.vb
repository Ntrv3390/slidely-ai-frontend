Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text

Public Class SubmitForm

    Private stopwatch As Stopwatch
    Private WithEvents Timer1 As New Timer
    Private Sub SubmitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        loading_label_submit.Visible = False
    End Sub
    Private Sub SetLoadingState(isLoading As Boolean)
        loading_label_submit.Visible = isLoading
        If isLoading Then
            loading_label_submit.Text = "Submitting..."
            ToggleControls(True)
        Else
            loading_label_submit.Text = ""
            ToggleControls(False)
        End If
    End Sub
    Private Sub ToggleControls(enable As Boolean)
        name_input.ReadOnly = enable
        email_input.ReadOnly = enable
        number_input.ReadOnly = enable
        github_link_input.ReadOnly = enable
        toggle_stopwatch_btn.Enabled = Not enable
        submit_btn.Enabled = Not enable
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            ToggleStopwatch()
            Return True
        End If
        If keyData = (Keys.Control Or Keys.S) Then
            SubmitForm()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub ToggleStopwatch()
        If Not stopwatch.IsRunning Then
            stopwatch.Start()
            Timer1.Start()
            toggle_stopwatch_btn.Text = "Stop (CTRL + T)"
        Else
            stopwatch.Stop()
            Timer1.Stop()
            toggle_stopwatch_btn.Text = "Start (CTRL + T)"
        End If
    End Sub



    Private Async Sub SubmitForm()
        Try
            SetLoadingState(True)
            Await Task.Delay(2000)
            Dim client As New HttpClient()
            Dim postData As New Dictionary(Of String, String)()

            postData("name") = name_input.Text
            postData("email") = email_input.Text
            postData("number") = number_input.Text
            postData("github_link") = github_link_input.Text
            postData("stopwatch_time") = elapsedTimeTextBox.Text

            Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(postData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Form submitted successfully!")
            Else
                MessageBox.Show("Error submitting form: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
            EmptyInputFields()
        End Try
    End Sub

    Private Sub EmptyInputFields()
        name_input.Text = ""
        email_input.Text = ""
        number_input.Text = ""
        github_link_input.Text = ""
        elapsedTimeTextBox.Text = ""
    End Sub


    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        SubmitForm()
    End Sub
    Private Sub toggle_stopwatch_btn_Click(sender As Object, e As EventArgs) Handles toggle_stopwatch_btn.Click
        ToggleStopwatch()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Dim totalSeconds As Integer = CInt(elapsed.TotalSeconds)
        Dim hours As Integer = totalSeconds \ 3600
        Dim minutes As Integer = (totalSeconds \ 60) Mod 60
        Dim seconds As Integer = totalSeconds Mod 60
        elapsedTimeTextBox.Text = String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds)
    End Sub


End Class