<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmitForm
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
        name_label = New Label()
        name_input = New TextBox()
        email = New Label()
        email_input = New TextBox()
        number = New Label()
        number_input = New TextBox()
        githublink = New Label()
        github_link_input = New TextBox()
        submit_btn = New Button()
        toggle_stopwatch_btn = New Button()
        elapsedTimeTextBox = New TextBox()
        loading_label_submit = New Label()
        SuspendLayout()
        ' 
        ' heading
        ' 
        heading.AutoSize = True
        heading.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        heading.Location = New Point(23, 36)
        heading.Name = "heading"
        heading.Size = New Size(645, 29)
        heading.TabIndex = 1
        heading.Text = "Mohammed Puthawala, Slidely Task 2 - Create Submission"
        heading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' name_label
        ' 
        name_label.AutoSize = True
        name_label.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        name_label.Location = New Point(52, 132)
        name_label.Name = "name_label"
        name_label.Size = New Size(78, 29)
        name_label.TabIndex = 2
        name_label.Text = "Name"
        ' 
        ' name_input
        ' 
        name_input.BorderStyle = BorderStyle.FixedSingle
        name_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        name_input.Location = New Point(193, 130)
        name_input.Name = "name_input"
        name_input.Size = New Size(471, 34)
        name_input.TabIndex = 3
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(56, 216)
        email.Name = "email"
        email.Size = New Size(74, 29)
        email.TabIndex = 4
        email.Text = "Email"
        ' 
        ' email_input
        ' 
        email_input.BorderStyle = BorderStyle.FixedSingle
        email_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email_input.Location = New Point(193, 213)
        email_input.Name = "email_input"
        email_input.Size = New Size(471, 34)
        email_input.TabIndex = 5
        ' 
        ' number
        ' 
        number.AutoSize = True
        number.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        number.Location = New Point(27, 300)
        number.Name = "number"
        number.Size = New Size(140, 29)
        number.TabIndex = 6
        number.Text = "Phone Num"
        ' 
        ' number_input
        ' 
        number_input.BorderStyle = BorderStyle.FixedSingle
        number_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        number_input.Location = New Point(193, 297)
        number_input.Name = "number_input"
        number_input.Size = New Size(471, 34)
        number_input.TabIndex = 7
        ' 
        ' githublink
        ' 
        githublink.AutoSize = True
        githublink.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        githublink.Location = New Point(27, 371)
        githublink.Name = "githublink"
        githublink.Size = New Size(134, 58)
        githublink.TabIndex = 8
        githublink.Text = "Github Link" & vbCrLf & " For Task 2"
        ' 
        ' github_link_input
        ' 
        github_link_input.BorderStyle = BorderStyle.FixedSingle
        github_link_input.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        github_link_input.Location = New Point(193, 380)
        github_link_input.Name = "github_link_input"
        github_link_input.Size = New Size(471, 34)
        github_link_input.TabIndex = 9
        ' 
        ' submit_btn
        ' 
        submit_btn.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        submit_btn.Cursor = Cursors.Hand
        submit_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        submit_btn.ForeColor = SystemColors.ActiveCaptionText
        submit_btn.Location = New Point(45, 604)
        submit_btn.Name = "submit_btn"
        submit_btn.Size = New Size(599, 53)
        submit_btn.TabIndex = 10
        submit_btn.Text = "SUBMIT (CTRL + S)"
        submit_btn.UseVisualStyleBackColor = False
        ' 
        ' toggle_stopwatch_btn
        ' 
        toggle_stopwatch_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        toggle_stopwatch_btn.BackgroundImageLayout = ImageLayout.None
        toggle_stopwatch_btn.Cursor = Cursors.Hand
        toggle_stopwatch_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toggle_stopwatch_btn.ForeColor = SystemColors.ActiveCaptionText
        toggle_stopwatch_btn.Location = New Point(45, 468)
        toggle_stopwatch_btn.Name = "toggle_stopwatch_btn"
        toggle_stopwatch_btn.Size = New Size(408, 53)
        toggle_stopwatch_btn.TabIndex = 11
        toggle_stopwatch_btn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        toggle_stopwatch_btn.UseVisualStyleBackColor = False
        ' 
        ' elapsedTimeTextBox
        ' 
        elapsedTimeTextBox.BorderStyle = BorderStyle.FixedSingle
        elapsedTimeTextBox.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        elapsedTimeTextBox.Location = New Point(485, 478)
        elapsedTimeTextBox.Name = "elapsedTimeTextBox"
        elapsedTimeTextBox.ReadOnly = True
        elapsedTimeTextBox.Size = New Size(159, 34)
        elapsedTimeTextBox.TabIndex = 12
        elapsedTimeTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' loading_label_submit
        ' 
        loading_label_submit.AutoSize = True
        loading_label_submit.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loading_label_submit.Location = New Point(328, 85)
        loading_label_submit.Name = "loading_label_submit"
        loading_label_submit.Size = New Size(82, 25)
        loading_label_submit.TabIndex = 40
        loading_label_submit.Text = "Loading"
        ' 
        ' SubmitForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(689, 693)
        Controls.Add(loading_label_submit)
        Controls.Add(elapsedTimeTextBox)
        Controls.Add(toggle_stopwatch_btn)
        Controls.Add(submit_btn)
        Controls.Add(github_link_input)
        Controls.Add(githublink)
        Controls.Add(number_input)
        Controls.Add(number)
        Controls.Add(email_input)
        Controls.Add(email)
        Controls.Add(name_input)
        Controls.Add(name_label)
        Controls.Add(heading)
        Name = "SubmitForm"
        Text = "SubmitForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents heading As Label
    Friend WithEvents name_label As Label
    Friend WithEvents name_input As TextBox
    Friend WithEvents email As Label
    Friend WithEvents email_input As TextBox
    Friend WithEvents number As Label
    Friend WithEvents number_input As TextBox
    Friend WithEvents githublink As Label
    Friend WithEvents github_link_input As TextBox
    Friend WithEvents submit_btn As Button
    Friend WithEvents toggle_stopwatch_btn As Button
    Friend WithEvents elapsedTimeTextBox As TextBox
    Friend WithEvents loading_label_submit As Label
End Class
