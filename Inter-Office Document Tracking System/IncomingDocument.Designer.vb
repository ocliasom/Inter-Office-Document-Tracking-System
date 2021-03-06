﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IncomingDocument
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.From = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Receive = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TrackDocument = New System.Windows.Forms.Button()
        Me.PendingDocument = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.AddDocument = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTS, Me.Type, Me.From, Me.Remarks, Me.Receive, Me.Email, Me.Number})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(17, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(932, 403)
        Me.DataGridView1.TabIndex = 2
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
        'From
        '
        Me.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.From.DataPropertyName = "current_office"
        Me.From.HeaderText = "From"
        Me.From.MinimumWidth = 6
        Me.From.Name = "From"
        Me.From.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "remark"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.MinimumWidth = 6
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'Receive
        '
        Me.Receive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Receive.DataPropertyName = "trackingnum"
        Me.Receive.HeaderText = "Receive"
        Me.Receive.MinimumWidth = 6
        Me.Receive.Name = "Receive"
        Me.Receive.ReadOnly = True
        Me.Receive.Text = "Receive"
        Me.Receive.UseColumnTextForButtonValue = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "email_address"
        Me.Email.HeaderText = "Email"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 607)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Incoming Documents"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(2, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inter-Office Document Tracking System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.TrackDocument)
        Me.Panel2.Controls.Add(Me.PendingDocument)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Home)
        Me.Panel2.Controls.Add(Me.AddDocument)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(975, 81)
        Me.Panel2.TabIndex = 7
        '
        'TrackDocument
        '
        Me.TrackDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.TrackDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrackDocument.ForeColor = System.Drawing.Color.Gold
        Me.TrackDocument.Location = New System.Drawing.Point(643, 32)
        Me.TrackDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackDocument.Name = "TrackDocument"
        Me.TrackDocument.Size = New System.Drawing.Size(125, 27)
        Me.TrackDocument.TabIndex = 10
        Me.TrackDocument.Text = "Track Documents"
        Me.TrackDocument.UseVisualStyleBackColor = True
        '
        'PendingDocument
        '
        Me.PendingDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.PendingDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingDocument.ForeColor = System.Drawing.Color.Gold
        Me.PendingDocument.Location = New System.Drawing.Point(514, 32)
        Me.PendingDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.PendingDocument.Name = "PendingDocument"
        Me.PendingDocument.Size = New System.Drawing.Size(125, 27)
        Me.PendingDocument.TabIndex = 8
        Me.PendingDocument.Text = "Pending Documents"
        Me.PendingDocument.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Firebrick
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ForeColor = System.Drawing.Color.Gold
        Me.Home.Location = New System.Drawing.Point(454, 32)
        Me.Home.Margin = New System.Windows.Forms.Padding(2)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(56, 27)
        Me.Home.TabIndex = 5
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'AddDocument
        '
        Me.AddDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.AddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddDocument.ForeColor = System.Drawing.Color.Gold
        Me.AddDocument.Location = New System.Drawing.Point(772, 32)
        Me.AddDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.AddDocument.Name = "AddDocument"
        Me.AddDocument.Size = New System.Drawing.Size(95, 27)
        Me.AddDocument.TabIndex = 6
        Me.AddDocument.Text = "Add Document"
        Me.AddDocument.UseVisualStyleBackColor = True
        '
        'IncomingDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IncomingDocument"
        Me.Text = "IncomingDocument"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PendingDocument As Button
    Friend WithEvents Home As Button
    Friend WithEvents AddDocument As Button
    Friend WithEvents TrackDocument As Button
    Friend WithEvents CTS As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents From As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Receive As DataGridViewButtonColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Number As DataGridViewTextBoxColumn
End Class
