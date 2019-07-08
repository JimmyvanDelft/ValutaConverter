<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Startbttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close Converter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To what country are you travelling?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "What amount of currency do you have?"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 53)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 52)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Convert"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 73)
        Me.Label3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Startbttn
        '
        Me.Startbttn.BackColor = System.Drawing.SystemColors.ControlText
        Me.Startbttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startbttn.ForeColor = System.Drawing.Color.Lime
        Me.Startbttn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Startbttn.Location = New System.Drawing.Point(-452, -235)
        Me.Startbttn.Name = "Startbttn"
        Me.Startbttn.Size = New System.Drawing.Size(514, 288)
        Me.Startbttn.TabIndex = 10
        Me.Startbttn.Text = "MoneyConverter 1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By: Jimmy van Delft" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Build: 08/07/2019" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caution: This convert" &
    "er is made for European Inhabitants." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to continue..."
        Me.Startbttn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Startbttn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 287)
        Me.Controls.Add(Me.Startbttn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "MoneyConverter By: Jimmy van Delft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Startbttn As Button
End Class
