<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.TXTButton = New System.Windows.Forms.Button()
        Me.XMLButton = New System.Windows.Forms.Button()
        Me.JSONButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.Aquamarine
        Me.NameLabel.Location = New System.Drawing.Point(87, 66)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(75, 25)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name:"
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.ForeColor = System.Drawing.Color.Aquamarine
        Me.Age.Location = New System.Drawing.Point(87, 123)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(58, 25)
        Me.Age.TabIndex = 1
        Me.Age.Text = "Age:"
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.ForeColor = System.Drawing.Color.Aquamarine
        Me.Address.Location = New System.Drawing.Point(87, 178)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(99, 25)
        Me.Address.TabIndex = 2
        Me.Address.Text = "Address:"
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.ForeColor = System.Drawing.Color.AliceBlue
        Me.NameBox.Location = New System.Drawing.Point(194, 66)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(156, 30)
        Me.NameBox.TabIndex = 3
        '
        'AgeBox
        '
        Me.AgeBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AgeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AgeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeBox.ForeColor = System.Drawing.Color.AliceBlue
        Me.AgeBox.Location = New System.Drawing.Point(194, 123)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(156, 30)
        Me.AgeBox.TabIndex = 4
        '
        'AddressBox
        '
        Me.AddressBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressBox.ForeColor = System.Drawing.Color.AliceBlue
        Me.AddressBox.Location = New System.Drawing.Point(194, 182)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(156, 30)
        Me.AddressBox.TabIndex = 5
        '
        'TXTButton
        '
        Me.TXTButton.BackColor = System.Drawing.Color.Firebrick
        Me.TXTButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.TXTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TXTButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTButton.ForeColor = System.Drawing.Color.Gold
        Me.TXTButton.Location = New System.Drawing.Point(76, 232)
        Me.TXTButton.Name = "TXTButton"
        Me.TXTButton.Size = New System.Drawing.Size(75, 31)
        Me.TXTButton.TabIndex = 6
        Me.TXTButton.Text = "TXT"
        Me.TXTButton.UseVisualStyleBackColor = False
        '
        'XMLButton
        '
        Me.XMLButton.BackColor = System.Drawing.Color.Firebrick
        Me.XMLButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.XMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XMLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMLButton.ForeColor = System.Drawing.Color.Gold
        Me.XMLButton.Location = New System.Drawing.Point(184, 232)
        Me.XMLButton.Name = "XMLButton"
        Me.XMLButton.Size = New System.Drawing.Size(75, 31)
        Me.XMLButton.TabIndex = 7
        Me.XMLButton.Text = "XML"
        Me.XMLButton.UseVisualStyleBackColor = False
        '
        'JSONButton
        '
        Me.JSONButton.BackColor = System.Drawing.Color.Firebrick
        Me.JSONButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.JSONButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JSONButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSONButton.ForeColor = System.Drawing.Color.Gold
        Me.JSONButton.Location = New System.Drawing.Point(292, 232)
        Me.JSONButton.Name = "JSONButton"
        Me.JSONButton.Size = New System.Drawing.Size(75, 31)
        Me.JSONButton.TabIndex = 8
        Me.JSONButton.Text = "JSON"
        Me.JSONButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(463, 290)
        Me.Controls.Add(Me.JSONButton)
        Me.Controls.Add(Me.XMLButton)
        Me.Controls.Add(Me.TXTButton)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents Age As Label
    Friend WithEvents Address As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents TXTButton As Button
    Friend WithEvents XMLButton As Button
    Friend WithEvents JSONButton As Button
End Class
