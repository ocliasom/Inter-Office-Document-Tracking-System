<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserInfoAdd
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
        Me.Office = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DocHistory = New System.Windows.Forms.Button()
        Me.UserLogs = New System.Windows.Forms.Button()
        Me.Logs = New System.Windows.Forms.Button()
        Me.UserInfo = New System.Windows.Forms.Button()
        Me.Offices = New System.Windows.Forms.Button()
        Me.DocumentType = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Role = New System.Windows.Forms.ComboBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Office
        '
        Me.Office.FormattingEnabled = True
        Me.Office.Items.AddRange(New Object() {"OFFICE", "USER"})
        Me.Office.Location = New System.Drawing.Point(285, 332)
        Me.Office.Name = "Office"
        Me.Office.Size = New System.Drawing.Size(286, 21)
        Me.Office.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.DocHistory)
        Me.Panel3.Controls.Add(Me.UserLogs)
        Me.Panel3.Controls.Add(Me.Logs)
        Me.Panel3.Controls.Add(Me.UserInfo)
        Me.Panel3.Controls.Add(Me.Offices)
        Me.Panel3.Controls.Add(Me.DocumentType)
        Me.Panel3.Location = New System.Drawing.Point(9, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 533)
        Me.Panel3.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(25, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(229, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DocHistory
        '
        Me.DocHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.DocHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DocHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocHistory.Location = New System.Drawing.Point(51, 360)
        Me.DocHistory.Name = "DocHistory"
        Me.DocHistory.Size = New System.Drawing.Size(160, 37)
        Me.DocHistory.TabIndex = 5
        Me.DocHistory.Text = "Documents History"
        Me.DocHistory.UseVisualStyleBackColor = True
        Me.DocHistory.Visible = False
        '
        'UserLogs
        '
        Me.UserLogs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.UserLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLogs.Location = New System.Drawing.Point(51, 317)
        Me.UserLogs.Name = "UserLogs"
        Me.UserLogs.Size = New System.Drawing.Size(103, 37)
        Me.UserLogs.TabIndex = 4
        Me.UserLogs.Text = "User Logs"
        Me.UserLogs.UseVisualStyleBackColor = True
        Me.UserLogs.Visible = False
        '
        'Logs
        '
        Me.Logs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logs.Location = New System.Drawing.Point(25, 274)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(229, 37)
        Me.Logs.TabIndex = 3
        Me.Logs.Text = "Logs"
        Me.Logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logs.UseVisualStyleBackColor = True
        '
        'UserInfo
        '
        Me.UserInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.UserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfo.Location = New System.Drawing.Point(25, 231)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(229, 37)
        Me.UserInfo.TabIndex = 2
        Me.UserInfo.Text = "User Info"
        Me.UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserInfo.UseVisualStyleBackColor = True
        '
        'Offices
        '
        Me.Offices.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Offices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Offices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Offices.Location = New System.Drawing.Point(25, 188)
        Me.Offices.Name = "Offices"
        Me.Offices.Size = New System.Drawing.Size(229, 37)
        Me.Offices.TabIndex = 1
        Me.Offices.Text = "Offices"
        Me.Offices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Offices.UseVisualStyleBackColor = True
        '
        'DocumentType
        '
        Me.DocumentType.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.DocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DocumentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentType.Location = New System.Drawing.Point(25, 145)
        Me.DocumentType.Name = "DocumentType"
        Me.DocumentType.Size = New System.Drawing.Size(229, 37)
        Me.DocumentType.TabIndex = 0
        Me.DocumentType.Text = "Document Types"
        Me.DocumentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DocumentType.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Home)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 81)
        Me.Panel2.TabIndex = 15
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(742, 27)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 27)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Pending Documents"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(618, 27)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 27)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Incoming Documents"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gold
        Me.Button5.Location = New System.Drawing.Point(519, 29)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Add Document"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Firebrick
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ForeColor = System.Drawing.Color.Gold
        Me.Home.Location = New System.Drawing.Point(450, 27)
        Me.Home.Margin = New System.Windows.Forms.Padding(2)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(56, 27)
        Me.Home.TabIndex = 5
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
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
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(281, 470)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(80, 20)
        Me.Label.TabIndex = 19
        Me.Label.Text = "User Role"
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(616, 253)
        Me.LastName.Margin = New System.Windows.Forms.Padding(2)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(302, 20)
        Me.LastName.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(614, 231)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Last Name"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.Gold
        Me.CancelButton.Location = New System.Drawing.Point(892, 553)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(86, 33)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Firebrick
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.ForeColor = System.Drawing.Color.Gold
        Me.AddButton.Location = New System.Drawing.Point(802, 553)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(86, 33)
        Me.AddButton.TabIndex = 12
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'FirstName
        '
        Me.FirstName.BackColor = System.Drawing.Color.White
        Me.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstName.Location = New System.Drawing.Point(282, 253)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(287, 20)
        Me.FirstName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 231)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Add your document here for tracking."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add User"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Role)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.UserName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Office)
        Me.Panel1.Controls.Add(Me.LastName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.FirstName)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 14
        '
        'Role
        '
        Me.Role.FormattingEnabled = True
        Me.Role.Items.AddRange(New Object() {"OFFICE", "USER", "SECRETARY"})
        Me.Role.Location = New System.Drawing.Point(286, 493)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(286, 21)
        Me.Role.TabIndex = 27
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.White
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Location = New System.Drawing.Point(619, 417)
        Me.Password.Margin = New System.Windows.Forms.Padding(2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(287, 20)
        Me.Password.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(615, 395)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Password"
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.Color.White
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Location = New System.Drawing.Point(285, 417)
        Me.UserName.Margin = New System.Windows.Forms.Padding(2)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(287, 20)
        Me.UserName.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(281, 395)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(614, 309)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "E-mail Address"
        '
        'Email
        '
        Me.Email.BackColor = System.Drawing.SystemColors.Window
        Me.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email.Location = New System.Drawing.Point(618, 333)
        Me.Email.Margin = New System.Windows.Forms.Padding(2)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(302, 20)
        Me.Email.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 309)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Office"
        '
        'AdminUserInfoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminUserInfoAdd"
        Me.Text = "AdminUserInfoAdd"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents DocHistory As Button
    Friend WithEvents UserLogs As Button
    Friend WithEvents Logs As Button
    Friend WithEvents UserInfo As Button
    Friend WithEvents Offices As Button
    Friend WithEvents DocumentType As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Home As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Role As ComboBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label4 As Label
End Class
