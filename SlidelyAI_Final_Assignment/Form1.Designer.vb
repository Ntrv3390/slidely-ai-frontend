<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        heading = New Label()
        view_submission_btn = New Button()
        create_submission_btn = New Button()
        SuspendLayout()
        ' 
        ' heading
        ' 
        heading.AutoSize = True
        heading.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        heading.Location = New Point(55, 34)
        heading.Name = "heading"
        heading.Size = New Size(626, 29)
        heading.TabIndex = 0
        heading.Text = "Mohammed Puthawala, Slidely Task 2 - Slidely Form App"
        heading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' view_submission_btn
        ' 
        view_submission_btn.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        view_submission_btn.BackgroundImageLayout = ImageLayout.None
        view_submission_btn.Cursor = Cursors.Hand
        view_submission_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        view_submission_btn.ForeColor = SystemColors.ActiveCaptionText
        view_submission_btn.Location = New Point(64, 82)
        view_submission_btn.Name = "view_submission_btn"
        view_submission_btn.Size = New Size(599, 53)
        view_submission_btn.TabIndex = 1
        view_submission_btn.Text = "VIEW SUBMISSIONS (CTRV + V)"
        view_submission_btn.UseVisualStyleBackColor = False
        ' 
        ' create_submission_btn
        ' 
        create_submission_btn.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        create_submission_btn.Cursor = Cursors.Hand
        create_submission_btn.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        create_submission_btn.ForeColor = SystemColors.ActiveCaptionText
        create_submission_btn.Location = New Point(64, 159)
        create_submission_btn.Name = "create_submission_btn"
        create_submission_btn.Size = New Size(599, 53)
        create_submission_btn.TabIndex = 2
        create_submission_btn.Text = "CREATE NEW SUBMISSIONS (CTRV + N)"
        create_submission_btn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(731, 251)
        Controls.Add(create_submission_btn)
        Controls.Add(view_submission_btn)
        Controls.Add(heading)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents heading As Label
    Friend WithEvents view_submission_btn As Button
    Friend WithEvents create_submission_btn As Button

End Class
