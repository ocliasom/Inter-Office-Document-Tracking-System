<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Sign_in = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Sign_in)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 258)
        Me.Panel1.TabIndex = 4
        '
        'Sign_in
        '
        Me.Sign_in.BackColor = System.Drawing.Color.Firebrick
        Me.Sign_in.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sign_in.ForeColor = System.Drawing.Color.Gold
        Me.Sign_in.Location = New System.Drawing.Point(156, 210)
        Me.Sign_in.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Sign_in.Name = "Sign_in"
        Me.Sign_in.Size = New System.Drawing.Size(70, 33)
        Me.Sign_in.TabIndex = 8
        Me.Sign_in.Text = "Sign in"
        Me.Sign_in.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(115, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(115, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Gray
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(118, 154)
        Me.Password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(149, 20)
        Me.Password.TabIndex = 5
        Me.Password.Text = "$2a$10$rguqKi7Bnq416OIcZCJuA.YafJxUHNdJcBDX7fuQhiSsZ5UVlA/NS"
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Gray
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Username.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Username.Location = New System.Drawing.Point(118, 97)
        Me.Username.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(149, 20)
        Me.Username.TabIndex = 4
        Me.Username.Text = "cpedept"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 51)
        Me.Panel2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(28, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inter-Office Document Tracking System"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 277)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Sign_in As Button
End Class
