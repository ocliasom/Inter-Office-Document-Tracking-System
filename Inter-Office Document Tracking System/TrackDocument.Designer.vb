<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackDocument
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentOffice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PendingDocument = New System.Windows.Forms.Button()
        Me.IncomingDocument = New System.Windows.Forms.Button()
        Me.AddDocButton = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 611)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTS, Me.Type, Me.CurrentOffice, Me.DateReceived, Me.Status})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.DimGray
        Me.DataGridView1.Location = New System.Drawing.Point(17, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(941, 402)
        Me.DataGridView1.TabIndex = 2
        '
        'CTS
        '
        Me.CTS.DataPropertyName = "trackingnum"
        Me.CTS.HeaderText = "CTS"
        Me.CTS.MinimumWidth = 6
        Me.CTS.Name = "CTS"
        Me.CTS.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "doctype"
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'CurrentOffice
        '
        Me.CurrentOffice.DataPropertyName = "current_office"
        Me.CurrentOffice.HeaderText = "Current Office"
        Me.CurrentOffice.MinimumWidth = 6
        Me.CurrentOffice.Name = "CurrentOffice"
        Me.CurrentOffice.ReadOnly = True
        '
        'DateReceived
        '
        Me.DateReceived.DataPropertyName = "date_received"
        Me.DateReceived.HeaderText = "Date Received"
        Me.DateReceived.MinimumWidth = 6
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Track Documents"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(2, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inter-Office Document Tracking System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.PendingDocument)
        Me.Panel2.Controls.Add(Me.IncomingDocument)
        Me.Panel2.Controls.Add(Me.AddDocButton)
        Me.Panel2.Controls.Add(Me.Home)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 81)
        Me.Panel2.TabIndex = 3
        '
        'PendingDocument
        '
        Me.PendingDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.PendingDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingDocument.ForeColor = System.Drawing.Color.Gold
        Me.PendingDocument.Location = New System.Drawing.Point(620, 29)
        Me.PendingDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.PendingDocument.Name = "PendingDocument"
        Me.PendingDocument.Size = New System.Drawing.Size(125, 27)
        Me.PendingDocument.TabIndex = 4
        Me.PendingDocument.Text = "Pending Documents"
        Me.PendingDocument.UseVisualStyleBackColor = True
        '
        'IncomingDocument
        '
        Me.IncomingDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.IncomingDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncomingDocument.ForeColor = System.Drawing.Color.Gold
        Me.IncomingDocument.Location = New System.Drawing.Point(497, 29)
        Me.IncomingDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.IncomingDocument.Name = "IncomingDocument"
        Me.IncomingDocument.Size = New System.Drawing.Size(119, 27)
        Me.IncomingDocument.TabIndex = 3
        Me.IncomingDocument.Text = "Incoming Documents"
        Me.IncomingDocument.UseVisualStyleBackColor = True
        '
        'AddDocButton
        '
        Me.AddDocButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.AddDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddDocButton.ForeColor = System.Drawing.Color.Gold
        Me.AddDocButton.Location = New System.Drawing.Point(749, 29)
        Me.AddDocButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddDocButton.Name = "AddDocButton"
        Me.AddDocButton.Size = New System.Drawing.Size(95, 27)
        Me.AddDocButton.TabIndex = 2
        Me.AddDocButton.Text = "Add Document"
        Me.AddDocButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Firebrick
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ForeColor = System.Drawing.Color.Gold
        Me.Home.Location = New System.Drawing.Point(437, 29)
        Me.Home.Margin = New System.Windows.Forms.Padding(2)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(56, 27)
        Me.Home.TabIndex = 1
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(688, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*Red - Document has been here for more than 7 days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(688, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*Yellow - Document has been here for more than 3 days"
        '
        'TrackDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TrackDocument"
        Me.Text = "TrackDocument"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CTS As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents CurrentOffice As DataGridViewTextBoxColumn
    Friend WithEvents DateReceived As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents PendingDocument As Button
    Friend WithEvents IncomingDocument As Button
    Friend WithEvents AddDocButton As Button
    Friend WithEvents Home As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
