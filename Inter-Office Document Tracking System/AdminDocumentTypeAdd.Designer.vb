<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDocumentTypeAdd
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DocumentCode = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DocumentDescription = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.DocHistory = New System.Windows.Forms.Button()
        Me.UserLogs = New System.Windows.Forms.Button()
        Me.Logs = New System.Windows.Forms.Button()
        Me.UserInfo = New System.Windows.Forms.Button()
        Me.Offices = New System.Windows.Forms.Button()
        Me.DocumentType = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(272, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add Document Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(275, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Add a document type here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(274, 226)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Document Code"
        '
        'DocumentCode
        '
        Me.DocumentCode.BackColor = System.Drawing.Color.White
        Me.DocumentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DocumentCode.Location = New System.Drawing.Point(277, 258)
        Me.DocumentCode.Margin = New System.Windows.Forms.Padding(2)
        Me.DocumentCode.Name = "DocumentCode"
        Me.DocumentCode.Size = New System.Drawing.Size(148, 20)
        Me.DocumentCode.TabIndex = 9
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Firebrick
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ForeColor = System.Drawing.Color.Gold
        Me.AddButton.Location = New System.Drawing.Point(803, 558)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(86, 33)
        Me.AddButton.TabIndex = 12
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.Gold
        Me.CancelButton.Location = New System.Drawing.Point(893, 558)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(86, 33)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(447, 226)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Document Type Description"
        '
        'DocumentDescription
        '
        Me.DocumentDescription.Location = New System.Drawing.Point(451, 258)
        Me.DocumentDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.DocumentDescription.Name = "DocumentDescription"
        Me.DocumentDescription.Size = New System.Drawing.Size(347, 20)
        Me.DocumentDescription.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.DocumentDescription)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.DocumentCode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inter-Office Document Tracking System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 81)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(9, 91)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(257, 136)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSalmon
        Me.PictureBox1.Image = Global.Inter_Office_Document_Tracking_System.My.Resources.Resources.img_415067
        Me.PictureBox1.Location = New System.Drawing.Point(93, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Administrator"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaShell
        Me.Panel3.Controls.Add(Me.Home)
        Me.Panel3.Controls.Add(Me.DocHistory)
        Me.Panel3.Controls.Add(Me.UserLogs)
        Me.Panel3.Controls.Add(Me.Logs)
        Me.Panel3.Controls.Add(Me.UserInfo)
        Me.Panel3.Controls.Add(Me.Offices)
        Me.Panel3.Controls.Add(Me.DocumentType)
        Me.Panel3.Location = New System.Drawing.Point(9, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 530)
        Me.Panel3.TabIndex = 13
        '
        'Home
        '
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(14, 145)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(229, 37)
        Me.Home.TabIndex = 6
        Me.Home.Text = "Home"
        Me.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Home.UseVisualStyleBackColor = True
        Me.Home.Visible = False
        '
        'DocHistory
        '
        Me.DocHistory.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.DocHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DocHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocHistory.Location = New System.Drawing.Point(40, 403)
        Me.DocHistory.Name = "DocHistory"
        Me.DocHistory.Size = New System.Drawing.Size(160, 37)
        Me.DocHistory.TabIndex = 5
        Me.DocHistory.Text = "Documents History"
        Me.DocHistory.UseVisualStyleBackColor = True
        Me.DocHistory.Visible = False
        '
        'UserLogs
        '
        Me.UserLogs.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.UserLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLogs.Location = New System.Drawing.Point(40, 360)
        Me.UserLogs.Name = "UserLogs"
        Me.UserLogs.Size = New System.Drawing.Size(103, 37)
        Me.UserLogs.TabIndex = 4
        Me.UserLogs.Text = "User Logs"
        Me.UserLogs.UseVisualStyleBackColor = True
        Me.UserLogs.Visible = False
        '
        'Logs
        '
        Me.Logs.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logs.Location = New System.Drawing.Point(14, 317)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(229, 37)
        Me.Logs.TabIndex = 3
        Me.Logs.Text = "Logs"
        Me.Logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logs.UseVisualStyleBackColor = True
        '
        'UserInfo
        '
        Me.UserInfo.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.UserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfo.Location = New System.Drawing.Point(14, 274)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(229, 37)
        Me.UserInfo.TabIndex = 2
        Me.UserInfo.Text = "User Info"
        Me.UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserInfo.UseVisualStyleBackColor = True
        '
        'Offices
        '
        Me.Offices.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.Offices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Offices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Offices.Location = New System.Drawing.Point(14, 231)
        Me.Offices.Name = "Offices"
        Me.Offices.Size = New System.Drawing.Size(229, 37)
        Me.Offices.TabIndex = 1
        Me.Offices.Text = "Offices"
        Me.Offices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Offices.UseVisualStyleBackColor = True
        '
        'DocumentType
        '
        Me.DocumentType.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.DocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DocumentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentType.Location = New System.Drawing.Point(14, 188)
        Me.DocumentType.Name = "DocumentType"
        Me.DocumentType.Size = New System.Drawing.Size(229, 37)
        Me.DocumentType.TabIndex = 0
        Me.DocumentType.Text = "Document Types"
        Me.DocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DocumentType.UseVisualStyleBackColor = True
        '
        'AdminDocumentTypeAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminDocumentTypeAdd"
        Me.Text = "AdminDocumentTypeAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DocumentCode As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DocumentDescription As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Home As Button
    Friend WithEvents DocHistory As Button
    Friend WithEvents UserLogs As Button
    Friend WithEvents Logs As Button
    Friend WithEvents UserInfo As Button
    Friend WithEvents Offices As Button
    Friend WithEvents DocumentType As Button
End Class
