<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddDocument
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HiddenDate = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Officebox = New System.Windows.Forms.Label()
        Me.Datebox = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TrackDocument = New System.Windows.Forms.Button()
        Me.PendingDocument = New System.Windows.Forms.Button()
        Me.IncomingDocument = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.HiddenDate)
        Me.Panel1.Controls.Add(Me.Number)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Officebox)
        Me.Panel1.Controls.Add(Me.Datebox)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 611)
        Me.Panel1.TabIndex = 1
        '
        'HiddenDate
        '
        Me.HiddenDate.AutoSize = True
        Me.HiddenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiddenDate.Location = New System.Drawing.Point(203, 249)
        Me.HiddenDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HiddenDate.Name = "HiddenDate"
        Me.HiddenDate.Size = New System.Drawing.Size(99, 20)
        Me.HiddenDate.TabIndex = 19
        Me.HiddenDate.Text = "Date Hidden"
        Me.HiddenDate.Visible = False
        '
        'Number
        '
        Me.Number.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Number.Location = New System.Drawing.Point(563, 405)
        Me.Number.Margin = New System.Windows.Forms.Padding(2)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(187, 20)
        Me.Number.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(559, 373)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Phone Number"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(206, 477)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(543, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(203, 446)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Description"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.Gold
        Me.CancelButton.Location = New System.Drawing.Point(471, 538)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(86, 33)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(381, 538)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 33)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Officebox
        '
        Me.Officebox.AutoSize = True
        Me.Officebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Officebox.Location = New System.Drawing.Point(559, 233)
        Me.Officebox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Officebox.Name = "Officebox"
        Me.Officebox.Size = New System.Drawing.Size(59, 20)
        Me.Officebox.TabIndex = 11
        Me.Officebox.Text = "Offices"
        '
        'Datebox
        '
        Me.Datebox.AutoSize = True
        Me.Datebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datebox.Location = New System.Drawing.Point(203, 233)
        Me.Datebox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Datebox.Name = "Datebox"
        Me.Datebox.Size = New System.Drawing.Size(44, 20)
        Me.Datebox.TabIndex = 10
        Me.Datebox.Text = "Date"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(206, 405)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(188, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(203, 373)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "E-mail Address"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(206, 316)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(543, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 293)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Document Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(559, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Office"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 164)
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
        Me.Label2.Location = New System.Drawing.Point(203, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add Document"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.TrackDocument)
        Me.Panel2.Controls.Add(Me.PendingDocument)
        Me.Panel2.Controls.Add(Me.IncomingDocument)
        Me.Panel2.Controls.Add(Me.Home)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(9, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 81)
        Me.Panel2.TabIndex = 2
        '
        'TrackDocument
        '
        Me.TrackDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.TrackDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrackDocument.ForeColor = System.Drawing.Color.Gold
        Me.TrackDocument.Location = New System.Drawing.Point(748, 27)
        Me.TrackDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackDocument.Name = "TrackDocument"
        Me.TrackDocument.Size = New System.Drawing.Size(125, 27)
        Me.TrackDocument.TabIndex = 9
        Me.TrackDocument.Text = "Track Documents"
        Me.TrackDocument.UseVisualStyleBackColor = True
        '
        'PendingDocument
        '
        Me.PendingDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.PendingDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PendingDocument.ForeColor = System.Drawing.Color.Gold
        Me.PendingDocument.Location = New System.Drawing.Point(633, 27)
        Me.PendingDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.PendingDocument.Name = "PendingDocument"
        Me.PendingDocument.Size = New System.Drawing.Size(125, 27)
        Me.PendingDocument.TabIndex = 8
        Me.PendingDocument.Text = "Pending Documents"
        Me.PendingDocument.UseVisualStyleBackColor = True
        '
        'IncomingDocument
        '
        Me.IncomingDocument.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.IncomingDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncomingDocument.ForeColor = System.Drawing.Color.Gold
        Me.IncomingDocument.Location = New System.Drawing.Point(510, 27)
        Me.IncomingDocument.Margin = New System.Windows.Forms.Padding(2)
        Me.IncomingDocument.Name = "IncomingDocument"
        Me.IncomingDocument.Size = New System.Drawing.Size(119, 27)
        Me.IncomingDocument.TabIndex = 7
        Me.IncomingDocument.Text = "Incoming Documents"
        Me.IncomingDocument.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Firebrick
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ForeColor = System.Drawing.Color.Gold
        Me.Home.Location = New System.Drawing.Point(450, 29)
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
        'Timer1
        '
        '
        'AddDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddDocument"
        Me.Text = "AddDocument"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Officebox As Label
    Friend WithEvents Datebox As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Number As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HiddenDate As Label
    Friend WithEvents PendingDocument As Button
    Friend WithEvents IncomingDocument As Button
    Friend WithEvents Home As Button
    Friend WithEvents TrackDocument As Button
End Class
