<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        heading = New Label()
        githublink = New Label()
        number = New Label()
        email = New Label()
        name_label = New Label()
        stopwatch_view_input = New TextBox()
        stopwatch_time = New Label()
        prev_btn = New Button()
        github_view_input = New TextBox()
        Label1 = New Label()
        number_view_input = New TextBox()
        Label2 = New Label()
        email_view_input = New TextBox()
        Label3 = New Label()
        name_view_input = New TextBox()
        Label4 = New Label()
        next_btn = New Button()
        delete_btn = New Button()
        edit_btn = New Button()
        search_input = New TextBox()
        search_btn = New Button()
        loadingLabel = New Label()
        btnSaveChanges = New Button()
        curr_user_label = New Label()
        toggle_stopwatch_edit_btn = New Button()
        ping_btn = New Button()
        ping_input = New TextBox()
        SuspendLayout()
        ' 
        ' heading
        ' 
        heading.AutoSize = True
        heading.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        heading.Location = New Point(29, 27)
        heading.Name = "heading"
        heading.Size = New Size(638, 29)
        heading.TabIndex = 1
        heading.Text = "Mohammed Puthawala, Slidely Task 2 - View Submissions"
        heading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' githublink
        ' 
        githublink.AutoSize = True
        githublink.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        githublink.Location = New Point(30, 496)
        githublink.Name = "githublink"
        githublink.Size = New Size(134, 58)
        githublink.TabIndex = 19
        githublink.Text = "Github Link" & vbCrLf & " For Task 2"
        githublink.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' number
        ' 
        number.AutoSize = True
        number.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        number.Location = New Point(30, 425)
        number.Name = "number"
        number.Size = New Size(140, 29)
        number.TabIndex = 17
        number.Text = "Phone Num"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(59, 341)
        email.Name = "email"
        email.Size = New Size(74, 29)
        email.TabIndex = 15
        email.Text = "Email"
        ' 
        ' name_label
        ' 
        name_label.AutoSize = True
        name_label.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        name_label.Location = New Point(55, 257)
        name_label.Name = "name_label"
        name_label.Size = New Size(78, 29)
        name_label.TabIndex = 13
        name_label.Text = "Name"
        ' 
        ' stopwatch_view_input
        ' 
        stopwatch_view_input.BorderStyle = BorderStyle.FixedSingle
        stopwatch_view_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stopwatch_view_input.Location = New Point(195, 590)
        stopwatch_view_input.Name = "stopwatch_view_input"
        stopwatch_view_input.ReadOnly = True
        stopwatch_view_input.Size = New Size(471, 34)
        stopwatch_view_input.TabIndex = 22
        stopwatch_view_input.TextAlign = HorizontalAlignment.Center
        ' 
        ' stopwatch_time
        ' 
        stopwatch_time.AutoSize = True
        stopwatch_time.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stopwatch_time.Location = New Point(29, 581)
        stopwatch_time.Name = "stopwatch_time"
        stopwatch_time.Size = New Size(131, 58)
        stopwatch_time.TabIndex = 21
        stopwatch_time.Text = "Stopwatch " & vbCrLf & "time"
        stopwatch_time.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' prev_btn
        ' 
        prev_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        prev_btn.BackgroundImageLayout = ImageLayout.None
        prev_btn.Cursor = Cursors.Hand
        prev_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prev_btn.ForeColor = SystemColors.ActiveCaptionText
        prev_btn.Location = New Point(22, 691)
        prev_btn.Name = "prev_btn"
        prev_btn.Size = New Size(317, 53)
        prev_btn.TabIndex = 31
        prev_btn.Text = "PREVIOUS (CTRL + P)"
        prev_btn.UseVisualStyleBackColor = False
        ' 
        ' github_view_input
        ' 
        github_view_input.BorderStyle = BorderStyle.FixedSingle
        github_view_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        github_view_input.Location = New Point(196, 510)
        github_view_input.Name = "github_view_input"
        github_view_input.ReadOnly = True
        github_view_input.Size = New Size(471, 34)
        github_view_input.TabIndex = 30
        github_view_input.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 501)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 58)
        Label1.TabIndex = 29
        Label1.Text = "Github Link" & vbCrLf & " For Task 2"
        ' 
        ' number_view_input
        ' 
        number_view_input.BorderStyle = BorderStyle.FixedSingle
        number_view_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        number_view_input.Location = New Point(196, 427)
        number_view_input.Name = "number_view_input"
        number_view_input.ReadOnly = True
        number_view_input.Size = New Size(471, 34)
        number_view_input.TabIndex = 28
        number_view_input.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 430)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 29)
        Label2.TabIndex = 27
        Label2.Text = "Phone Num"
        ' 
        ' email_view_input
        ' 
        email_view_input.BorderStyle = BorderStyle.FixedSingle
        email_view_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email_view_input.Location = New Point(196, 343)
        email_view_input.Name = "email_view_input"
        email_view_input.ReadOnly = True
        email_view_input.Size = New Size(471, 34)
        email_view_input.TabIndex = 26
        email_view_input.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(59, 346)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 29)
        Label3.TabIndex = 25
        Label3.Text = "Email"
        ' 
        ' name_view_input
        ' 
        name_view_input.BorderStyle = BorderStyle.FixedSingle
        name_view_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        name_view_input.Location = New Point(196, 260)
        name_view_input.Name = "name_view_input"
        name_view_input.ReadOnly = True
        name_view_input.Size = New Size(471, 34)
        name_view_input.TabIndex = 24
        name_view_input.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 29)
        Label4.TabIndex = 23
        Label4.Text = "Name"
        ' 
        ' next_btn
        ' 
        next_btn.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        next_btn.Cursor = Cursors.Hand
        next_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        next_btn.ForeColor = SystemColors.ActiveCaptionText
        next_btn.Location = New Point(352, 691)
        next_btn.Name = "next_btn"
        next_btn.Size = New Size(323, 53)
        next_btn.TabIndex = 32
        next_btn.Text = "NEXT (CTRL + N)"
        next_btn.UseVisualStyleBackColor = False
        ' 
        ' delete_btn
        ' 
        delete_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        delete_btn.BackgroundImageLayout = ImageLayout.None
        delete_btn.Cursor = Cursors.Hand
        delete_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        delete_btn.ForeColor = SystemColors.ActiveCaptionText
        delete_btn.Location = New Point(352, 784)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(317, 53)
        delete_btn.TabIndex = 33
        delete_btn.Text = "DELETE (CTRL + D)"
        delete_btn.UseVisualStyleBackColor = False
        ' 
        ' edit_btn
        ' 
        edit_btn.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        edit_btn.Cursor = Cursors.Hand
        edit_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        edit_btn.ForeColor = SystemColors.ActiveCaptionText
        edit_btn.Location = New Point(16, 784)
        edit_btn.Name = "edit_btn"
        edit_btn.Size = New Size(323, 53)
        edit_btn.TabIndex = 34
        edit_btn.Text = "EDIT (CTRL + E)"
        edit_btn.UseVisualStyleBackColor = False
        ' 
        ' search_input
        ' 
        search_input.BorderStyle = BorderStyle.FixedSingle
        search_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        search_input.Location = New Point(22, 155)
        search_input.Name = "search_input"
        search_input.PlaceholderText = "Enter email to search user"
        search_input.Size = New Size(407, 34)
        search_input.TabIndex = 35
        ' 
        ' search_btn
        ' 
        search_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        search_btn.BackgroundImageLayout = ImageLayout.None
        search_btn.Cursor = Cursors.Hand
        search_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        search_btn.ForeColor = SystemColors.ActiveCaptionText
        search_btn.Location = New Point(435, 145)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(249, 53)
        search_btn.TabIndex = 36
        search_btn.Text = "SEARCH (CTRL + S)"
        search_btn.UseVisualStyleBackColor = False
        ' 
        ' loadingLabel
        ' 
        loadingLabel.AutoSize = True
        loadingLabel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loadingLabel.Location = New Point(301, 212)
        loadingLabel.Name = "loadingLabel"
        loadingLabel.Size = New Size(97, 25)
        loadingLabel.TabIndex = 37
        loadingLabel.Text = "Loading..."
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSaveChanges.Cursor = Cursors.Hand
        btnSaveChanges.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSaveChanges.ForeColor = SystemColors.ActiveCaptionText
        btnSaveChanges.Location = New Point(195, 734)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(323, 53)
        btnSaveChanges.TabIndex = 38
        btnSaveChanges.Text = "SAVE EDITS (CTRL + R)"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' curr_user_label
        ' 
        curr_user_label.AutoSize = True
        curr_user_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        curr_user_label.Location = New Point(315, 212)
        curr_user_label.Name = "curr_user_label"
        curr_user_label.Size = New Size(58, 25)
        curr_user_label.TabIndex = 39
        curr_user_label.Text = "User "
        ' 
        ' toggle_stopwatch_edit_btn
        ' 
        toggle_stopwatch_edit_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        toggle_stopwatch_edit_btn.BackgroundImageLayout = ImageLayout.None
        toggle_stopwatch_edit_btn.Cursor = Cursors.Hand
        toggle_stopwatch_edit_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toggle_stopwatch_edit_btn.ForeColor = SystemColors.ActiveCaptionText
        toggle_stopwatch_edit_btn.Location = New Point(146, 663)
        toggle_stopwatch_edit_btn.Name = "toggle_stopwatch_edit_btn"
        toggle_stopwatch_edit_btn.Size = New Size(408, 53)
        toggle_stopwatch_edit_btn.TabIndex = 40
        toggle_stopwatch_edit_btn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        toggle_stopwatch_edit_btn.UseVisualStyleBackColor = False
        ' 
        ' ping_btn
        ' 
        ping_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        ping_btn.BackgroundImageLayout = ImageLayout.None
        ping_btn.Cursor = Cursors.Hand
        ping_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ping_btn.ForeColor = SystemColors.ActiveCaptionText
        ping_btn.Location = New Point(22, 84)
        ping_btn.Name = "ping_btn"
        ping_btn.Size = New Size(219, 36)
        ping_btn.TabIndex = 41
        ping_btn.Text = "PING (CTRL + G)"
        ping_btn.UseVisualStyleBackColor = False
        ' 
        ' ping_input
        ' 
        ping_input.BorderStyle = BorderStyle.FixedSingle
        ping_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ping_input.Location = New Point(247, 86)
        ping_input.Name = "ping_input"
        ping_input.ReadOnly = True
        ping_input.Size = New Size(83, 34)
        ping_input.TabIndex = 42
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(696, 873)
        Controls.Add(ping_input)
        Controls.Add(ping_btn)
        Controls.Add(toggle_stopwatch_edit_btn)
        Controls.Add(curr_user_label)
        Controls.Add(btnSaveChanges)
        Controls.Add(loadingLabel)
        Controls.Add(search_btn)
        Controls.Add(search_input)
        Controls.Add(edit_btn)
        Controls.Add(delete_btn)
        Controls.Add(next_btn)
        Controls.Add(prev_btn)
        Controls.Add(github_view_input)
        Controls.Add(Label1)
        Controls.Add(number_view_input)
        Controls.Add(Label2)
        Controls.Add(email_view_input)
        Controls.Add(Label3)
        Controls.Add(name_view_input)
        Controls.Add(Label4)
        Controls.Add(stopwatch_view_input)
        Controls.Add(stopwatch_time)
        Controls.Add(githublink)
        Controls.Add(number)
        Controls.Add(email)
        Controls.Add(name_label)
        Controls.Add(heading)
        Name = "ViewForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents heading As Label
    Friend WithEvents githublink As Label
    Friend WithEvents number As Label
    Friend WithEvents email As Label
    Friend WithEvents name_label As Label
    Friend WithEvents stopwatch_view_input As TextBox
    Friend WithEvents stopwatch_time As Label
    Friend WithEvents prev_btn As Button
    Friend WithEvents github_view_input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents number_view_input As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents email_view_input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents name_view_input As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents search_input As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents loadingLabel As Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents curr_user_label As Label
    Friend WithEvents toggle_stopwatch_edit_btn As Button
    Friend WithEvents ping_btn As Button
    Friend WithEvents ping_input As TextBox
End Class
