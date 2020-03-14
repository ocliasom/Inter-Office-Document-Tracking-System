<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDocumentDetails
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackDocButton = New System.Windows.Forms.Button()
        Me.AddDocButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceOffice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 81)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(3, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inter-Office Document Tracking System"
        '
        'TrackDocButton
        '
        Me.TrackDocButton.BackColor = System.Drawing.Color.Firebrick
        Me.TrackDocButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.TrackDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrackDocButton.ForeColor = System.Drawing.Color.Gold
        Me.TrackDocButton.Location = New System.Drawing.Point(489, 382)
        Me.TrackDocButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackDocButton.Name = "TrackDocButton"
        Me.TrackDocButton.Size = New System.Drawing.Size(110, 32)
        Me.TrackDocButton.TabIndex = 7
        Me.TrackDocButton.Text = "Track Document"
        Me.TrackDocButton.UseVisualStyleBackColor = False
        '
        'AddDocButton
        '
        Me.AddDocButton.BackColor = System.Drawing.Color.Firebrick
        Me.AddDocButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.AddDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddDocButton.ForeColor = System.Drawing.Color.Gold
        Me.AddDocButton.Location = New System.Drawing.Point(364, 382)
        Me.AddDocButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddDocButton.Name = "AddDocButton"
        Me.AddDocButton.Size = New System.Drawing.Size(110, 32)
        Me.AddDocButton.TabIndex = 4
        Me.AddDocButton.Text = "Add Document"
        Me.AddDocButton.UseVisualStyleBackColor = False
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTS, Me.Type, Me.DateReceived, Me.SourceOffice, Me.Description})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(17, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(962, 68)
        Me.DataGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Document Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.TrackDocButton)
        Me.Panel1.Controls.Add(Me.AddDocButton)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 8
        '
        'CTS
        '
        Me.CTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CTS.DataPropertyName = "trackingnum"
        Me.CTS.HeaderText = "CTS"
        Me.CTS.MinimumWidth = 6
        Me.CTS.Name = "CTS"
        Me.CTS.ReadOnly = True
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Type.DataPropertyName = "doctype"
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'DateReceived
        '
        Me.DateReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateReceived.DataPropertyName = "date_received"
        Me.DateReceived.HeaderText = "Date Received"
        Me.DateReceived.MinimumWidth = 6
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ReadOnly = True
        '
        'SourceOffice
        '
        Me.SourceOffice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SourceOffice.DataPropertyName = "source_office"
        Me.SourceOffice.HeaderText = "Source Office"
        Me.SourceOffice.MinimumWidth = 6
        Me.SourceOffice.Name = "SourceOffice"
        Me.SourceOffice.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.DataPropertyName = "description"
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'AddDocumentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddDocumentDetails"
        Me.Text = "AddDocumentDetails"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackDocButton As Button
    Friend WithEvents AddDocButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CTS As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DateReceived As DataGridViewTextBoxColumn
    Friend WithEvents SourceOffice As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
End Class
