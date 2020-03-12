<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserLogs
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Home = New System.Windows.Forms.Button()
        Me.DocHistory = New System.Windows.Forms.Button()
        Me.UserLogs = New System.Windows.Forms.Button()
        Me.Logs = New System.Windows.Forms.Button()
        Me.UserInfo = New System.Windows.Forms.Button()
        Me.Offices = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DocumentType = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Home
        '
        Me.Home.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(25, 102)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(229, 37)
        Me.Home.TabIndex = 6
        Me.Home.Text = "Home"
        Me.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Home.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateTime, Me.CTS, Me.Action, Me.Remarks})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(268, 193)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(692, 312)
        Me.DataGridView1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "User Logs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inter-Office Document Tracking System"
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
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.Firebrick
        Me.LogoutButton.ForeColor = System.Drawing.Color.Gold
        Me.LogoutButton.Location = New System.Drawing.Point(837, 536)
        Me.LogoutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(123, 49)
        Me.LogoutButton.TabIndex = 7
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.Home)
        Me.Panel3.Controls.Add(Me.DocHistory)
        Me.Panel3.Controls.Add(Me.UserLogs)
        Me.Panel3.Controls.Add(Me.Logs)
        Me.Panel3.Controls.Add(Me.UserInfo)
        Me.Panel3.Controls.Add(Me.Offices)
        Me.Panel3.Controls.Add(Me.DocumentType)
        Me.Panel3.Location = New System.Drawing.Point(0, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 533)
        Me.Panel3.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 81)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 5
        '
        'DateTime
        '
        Me.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateTime.DataPropertyName = "datetime"
        Me.DateTime.HeaderText = "DateTime"
        Me.DateTime.Name = "DateTime"
        Me.DateTime.ReadOnly = True
        Me.DateTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CTS
        '
        Me.CTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CTS.DataPropertyName = "cts"
        Me.CTS.HeaderText = "CTS"
        Me.CTS.Name = "CTS"
        Me.CTS.ReadOnly = True
        Me.CTS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Action
        '
        Me.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Action.DataPropertyName = "action"
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "remark"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'AdminUserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminUserLogs"
        Me.Text = "AdminUserLogs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Home As Button
    Friend WithEvents DocHistory As Button
    Friend WithEvents UserLogs As Button
    Friend WithEvents Logs As Button
    Friend WithEvents UserInfo As Button
    Friend WithEvents Offices As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DocumentType As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTime As DataGridViewTextBoxColumn
    Friend WithEvents CTS As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
End Class
