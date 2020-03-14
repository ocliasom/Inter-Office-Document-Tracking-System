<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForwardDocument
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OfficeBox = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Remarks = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DestOffice = New System.Windows.Forms.ComboBox()
        Me.Forward = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceOffice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.OfficeBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Remarks)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DestOffice)
        Me.Panel1.Controls.Add(Me.Forward)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 6
        '
        'OfficeBox
        '
        Me.OfficeBox.AutoSize = True
        Me.OfficeBox.Location = New System.Drawing.Point(746, 101)
        Me.OfficeBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OfficeBox.Name = "OfficeBox"
        Me.OfficeBox.Size = New System.Drawing.Size(68, 13)
        Me.OfficeBox.TabIndex = 10
        Me.OfficeBox.Text = "hidden office"
        Me.OfficeBox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(332, 322)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Remarks"
        '
        'Remarks
        '
        Me.Remarks.Location = New System.Drawing.Point(337, 354)
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(278, 119)
        Me.Remarks.TabIndex = 8
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Firebrick
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.ForeColor = System.Drawing.Color.Gold
        Me.Cancel.Location = New System.Drawing.Point(478, 496)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 32)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(332, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Destination Office"
        '
        'DestOffice
        '
        Me.DestOffice.FormattingEnabled = True
        Me.DestOffice.Location = New System.Drawing.Point(337, 279)
        Me.DestOffice.Margin = New System.Windows.Forms.Padding(2)
        Me.DestOffice.Name = "DestOffice"
        Me.DestOffice.Size = New System.Drawing.Size(278, 21)
        Me.DestOffice.TabIndex = 5
        '
        'Forward
        '
        Me.Forward.BackColor = System.Drawing.Color.Firebrick
        Me.Forward.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Forward.ForeColor = System.Drawing.Color.Gold
        Me.Forward.Location = New System.Drawing.Point(364, 496)
        Me.Forward.Margin = New System.Windows.Forms.Padding(2)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(110, 32)
        Me.Forward.TabIndex = 4
        Me.Forward.Text = "Forward"
        Me.Forward.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTS, Me.Type, Me.DateReceived, Me.SourceOffice, Me.Description, Me.Email, Me.Number})
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
        'DateReceived
        '
        Me.DateReceived.DataPropertyName = "date_received"
        Me.DateReceived.HeaderText = "Date Received"
        Me.DateReceived.MinimumWidth = 6
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ReadOnly = True
        '
        'SourceOffice
        '
        Me.SourceOffice.DataPropertyName = "source_office"
        Me.SourceOffice.HeaderText = "Source Office"
        Me.SourceOffice.MinimumWidth = 6
        Me.SourceOffice.Name = "SourceOffice"
        Me.SourceOffice.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "description"
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "email_address"
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Visible = False
        '
        'Number
        '
        Me.Number.DataPropertyName = "Number"
        Me.Number.HeaderText = "Number"
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        Me.Number.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forwarding Document"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 81)
        Me.Panel2.TabIndex = 7
        '
        'ForwardDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ForwardDocument"
        Me.Text = "ForwardDocument"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Forward As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DestOffice As ComboBox
    Friend WithEvents Cancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Remarks As TextBox
    Friend WithEvents OfficeBox As Label
    Friend WithEvents CTS As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DateReceived As DataGridViewTextBoxColumn
    Friend WithEvents SourceOffice As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Number As DataGridViewTextBoxColumn
End Class
