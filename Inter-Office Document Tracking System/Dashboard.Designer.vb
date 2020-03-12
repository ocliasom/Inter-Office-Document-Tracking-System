<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PendingButton = New System.Windows.Forms.Button()
        Me.IncomingButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TrackButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.PendingButton)
        Me.Panel1.Controls.Add(Me.IncomingButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.TrackButton)
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 0
        '
        'PendingButton
        '
        Me.PendingButton.BackColor = System.Drawing.Color.Firebrick
        Me.PendingButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.PendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PendingButton.ForeColor = System.Drawing.Color.Gold
        Me.PendingButton.Location = New System.Drawing.Point(198, 323)
        Me.PendingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PendingButton.Name = "PendingButton"
        Me.PendingButton.Size = New System.Drawing.Size(266, 106)
        Me.PendingButton.TabIndex = 3
        Me.PendingButton.Text = "Pending Documents"
        Me.PendingButton.UseVisualStyleBackColor = False
        '
        'IncomingButton
        '
        Me.IncomingButton.BackColor = System.Drawing.Color.Firebrick
        Me.IncomingButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.IncomingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncomingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomingButton.ForeColor = System.Drawing.Color.Gold
        Me.IncomingButton.Location = New System.Drawing.Point(468, 323)
        Me.IncomingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.IncomingButton.Name = "IncomingButton"
        Me.IncomingButton.Size = New System.Drawing.Size(266, 106)
        Me.IncomingButton.TabIndex = 5
        Me.IncomingButton.Text = "Incoming Documents"
        Me.IncomingButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.DimGray
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.Gold
        Me.AddButton.Location = New System.Drawing.Point(198, 212)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(266, 106)
        Me.AddButton.TabIndex = 8
        Me.AddButton.Text = "Add Documents"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'TrackButton
        '
        Me.TrackButton.BackColor = System.Drawing.Color.DimGray
        Me.TrackButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackButton.ForeColor = System.Drawing.Color.Gold
        Me.TrackButton.Location = New System.Drawing.Point(468, 212)
        Me.TrackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackButton.Name = "TrackButton"
        Me.TrackButton.Size = New System.Drawing.Size(266, 106)
        Me.TrackButton.TabIndex = 4
        Me.TrackButton.Text = "Track Documents"
        Me.TrackButton.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 81)
        Me.Panel2.TabIndex = 0
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogoutButton As Button
    Friend WithEvents PendingButton As Button
    Friend WithEvents IncomingButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents TrackButton As Button
End Class
