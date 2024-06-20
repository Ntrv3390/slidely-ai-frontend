Imports System.Net.Http
Imports System.Diagnostics
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class ViewForm
    Private stopwatch As Stopwatch
    Private WithEvents Timer1 As New Timer
    Private ReadOnly baseUrl As String = "http://localhost:3000"
    Dim index As Integer = 0
    Dim currIndex As Integer
    Dim getStopwatchValue As TimeSpan
    Private isEditing As Boolean = False

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If Not isEditing And keyData = (Keys.Control Or Keys.N) Then
            index = index + 1
            GetData()
            Return True
        End If
        If Not isEditing And keyData = (Keys.Control Or Keys.P) Then
            index = index - 1
            GetData()
            Return True
        End If
        If Not isEditing And keyData = (Keys.Control Or Keys.D) Then
            deleteCurrData()
            index = 0
            GetData()
            Return True
        End If
        If Not isEditing And keyData = (Keys.Control Or Keys.S) Then
            GetDataFromEmail()
            Return True
        End If
        If Not isEditing And keyData = (Keys.Control Or Keys.E) Then
            btnEdit_Click(Me, EventArgs.Empty)
            Return True
        End If
        If isEditing And keyData = (Keys.Control Or Keys.R) Then
            btnSaveChanges_Click(Me, EventArgs.Empty)
            Return True
        End If
        If keyData = (Keys.Control Or Keys.G) Then
            GetPingStatus()
            Return True
        End If
        If isEditing And keyData = (Keys.Control Or Keys.T) Then
            ToggleStopwatch()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Async Sub GetData()
        Dim apiUrl As String = $"{baseUrl}/read/{index}"
        Dim httpClient As New HttpClient()
        Try
            SetLoadingState(True)
            Await Task.Delay(2000)
            Dim response As HttpResponseMessage = httpClient.GetAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                Dim responseData As String = response.Content.ReadAsStringAsync().Result
                Dim jsonData As JObject = JObject.Parse(responseData)
                If jsonData.ContainsKey("user") Then
                    Dim user As JObject = jsonData("user")
                    currIndex = jsonData("index")
                    name_view_input.Text = user("name").ToString()
                    email_view_input.Text = user("email").ToString()
                    number_view_input.Text = user("number").ToString()
                    github_view_input.Text = user("github_link").ToString()
                    stopwatch_view_input.Text = user("stopwatch_time").ToString()
                Else
                    MessageBox.Show("No 'user' object found in the API response.")
                End If
            Else
                MessageBox.Show("No more users.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
            curr_user_label.Text = $"User - {currIndex + 1}"
        End Try
    End Sub

    Private Async Sub GetPingStatus()
        Dim apiUrl As String = $"{baseUrl}/ping"
        Dim httpClient As New HttpClient()
        Try
            SetLoadingState(True)
            Await Task.Delay(500)
            Dim response As HttpResponseMessage = httpClient.GetAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                Dim responseData As String = response.Content.ReadAsStringAsync().Result
                Dim jsonData As JObject = JObject.Parse(responseData)
                If jsonData.ContainsKey("ping") Then
                    ping_input.Text = jsonData("ping").ToString().ToUpper()
                Else
                    ping_input.Text = "FALSE"
                End If
            Else
                MessageBox.Show("Server not healthy.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
        End Try
    End Sub

    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        index = index - 1
        GetData()
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        index = index + 1
        GetData()
    End Sub
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingLabel.Text = ""
        btnSaveChanges.Visible = False
        toggle_stopwatch_edit_btn.Visible = False
        stopwatch = New Stopwatch()
        GetData()
        GetPingStatus()
    End Sub

    Private Sub ToggleStopwatch()
        If Not stopwatch.IsRunning Then
            getStopwatchValue = TimeSpan.Parse(stopwatch_view_input.Text)
            stopwatch.Start()
            Timer1.Start()
            toggle_stopwatch_edit_btn.Text = "Stop (CTRL + T)"
        Else
            stopwatch.Stop()
            stopwatch = New Stopwatch()
            Timer1.Stop()
            toggle_stopwatch_edit_btn.Text = "Start (CTRL + T)"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Dim total As TimeSpan = elapsed + getStopwatchValue
        Dim totalSeconds As Integer = CInt(total.TotalSeconds)
        Dim hours As Integer = totalSeconds \ 3600
        Dim minutes As Integer = (totalSeconds \ 60) Mod 60
        Dim seconds As Integer = totalSeconds Mod 60
        stopwatch_view_input.Text = String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        ToggleEditControls(False)
    End Sub

    Private Async Sub deleteCurrData()
        Dim httpClient As New HttpClient()
        Dim apiUrl As String = $"{baseUrl}/read/{index}"

        Try
            SetLoadingState(True)
            Await Task.Delay(2000)
            Dim response As HttpResponseMessage = httpClient.DeleteAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data deleted successfully.")
            Else
                MessageBox.Show("Failed to delete data.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
        End Try
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        deleteCurrData()
        index = currIndex
        GetData()
    End Sub

    Private Async Sub GetDataFromEmail()
        Dim email As String = search_input.Text
        If email = "" Then
            MessageBox.Show("Please enter an email.")
            Return
        End If
        Dim apiUrl As String = $"{baseUrl}/read/email/{email}"
        Dim httpClient As New HttpClient()
        Try
            SetLoadingState(True)
            Await Task.Delay(2000)
            Dim response As HttpResponseMessage = httpClient.GetAsync(apiUrl).Result
            If response.IsSuccessStatusCode Then
                Dim responseData As String = response.Content.ReadAsStringAsync().Result
                Dim jsonData As JObject = JObject.Parse(responseData)
                If jsonData.ContainsKey("user") Then
                    Dim user As JObject = jsonData("user")
                    currIndex = jsonData("index")
                    name_view_input.Text = user("name").ToString()
                    email_view_input.Text = user("email").ToString()
                    number_view_input.Text = user("number").ToString()
                    github_view_input.Text = user("github_link").ToString()
                    stopwatch_view_input.Text = user("stopwatch_time").ToString()
                Else
                    MessageBox.Show("No 'user' object found in the API response.")
                End If
            Else
                MessageBox.Show("User not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
            curr_user_label.Text = $"User - {currIndex + 1}"
        End Try
        search_input.Text = ""
        index = currIndex
    End Sub

    Private Async Sub UpdateData()
        If stopwatch.IsRunning Then
            Timer1.Stop()
            stopwatch.Stop()
        End If
        Dim apiUrl As String = $"{baseUrl}/read/{index}"
        Try
            SetLoadingState(True)
            Dim client As New HttpClient()
            Dim putData As New Dictionary(Of String, String)()

            putData("name") = name_view_input.Text.ToString()
            putData("email") = email_view_input.Text.ToString()
            putData("number") = number_view_input.Text
            putData("github_link") = github_view_input.Text.ToString()
            putData("stopwatch_time") = stopwatch_view_input.Text.ToString()

            Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(putData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PutAsync(apiUrl, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data updated successfully!")
            Else
                MessageBox.Show("Error updating data: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            SetLoadingState(False)
        End Try
    End Sub

    Private Sub SetLoadingState(isLoading As Boolean)
        loadingLabel.Visible = isLoading
        If isLoading Then
            loadingLabel.Text = "Loading..."
            curr_user_label.Text = ""
            ToggleControls(False)
        Else
            loadingLabel.Text = ""
            ToggleControls(True)
        End If
    End Sub

    Private Sub ToggleControls(enable As Boolean)
        name_view_input.Enabled = enable
        email_view_input.Enabled = enable
        number_view_input.Enabled = enable
        github_view_input.Enabled = enable
        stopwatch_view_input.Enabled = enable
        search_input.Enabled = enable
        search_btn.Enabled = enable
        prev_btn.Enabled = enable
        next_btn.Enabled = enable
        edit_btn.Enabled = enable
        delete_btn.Enabled = enable
        ping_btn.Enabled = enable
    End Sub
    Private Sub ToggleEditControls(enable As Boolean)
        isEditing = Not enable
        name_view_input.ReadOnly = enable
        email_view_input.ReadOnly = enable
        number_view_input.ReadOnly = enable
        github_view_input.ReadOnly = enable
        search_btn.Enabled = enable
        search_input.ReadOnly = Not enable
        delete_btn.Visible = enable
        btnSaveChanges.Visible = Not enable
        edit_btn.Visible = enable
        next_btn.Visible = enable
        prev_btn.Visible = enable
        toggle_stopwatch_edit_btn.Visible = Not enable
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        GetDataFromEmail()
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        ToggleEditControls(True)
        UpdateData()
    End Sub

    Private Sub toggle_stopwatch_edit_btn_Click(sender As Object, e As EventArgs) Handles toggle_stopwatch_edit_btn.Click
        ToggleStopwatch()
    End Sub

    Private Sub ping_btn_Click(sender As Object, e As EventArgs) Handles ping_btn.Click
        GetPingStatus()
    End Sub
End Class