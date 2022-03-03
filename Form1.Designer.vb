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
        Me.btnAmenos = New System.Windows.Forms.Button()
        Me.btnAmas = New System.Windows.Forms.Button()
        Me.btnBmenos = New System.Windows.Forms.Button()
        Me.btnBmas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAmenos
        '
        Me.btnAmenos.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnAmenos.Location = New System.Drawing.Point(90, 80)
        Me.btnAmenos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAmenos.Name = "btnAmenos"
        Me.btnAmenos.Size = New System.Drawing.Size(62, 48)
        Me.btnAmenos.TabIndex = 0
        Me.btnAmenos.Text = "-"
        Me.btnAmenos.UseVisualStyleBackColor = True
        '
        'btnAmas
        '
        Me.btnAmas.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnAmas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAmas.Location = New System.Drawing.Point(244, 80)
        Me.btnAmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAmas.Name = "btnAmas"
        Me.btnAmas.Size = New System.Drawing.Size(62, 48)
        Me.btnAmas.TabIndex = 1
        Me.btnAmas.Text = "+"
        Me.btnAmas.UseVisualStyleBackColor = True
        '
        'btnBmenos
        '
        Me.btnBmenos.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnBmenos.Location = New System.Drawing.Point(90, 176)
        Me.btnBmenos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBmenos.Name = "btnBmenos"
        Me.btnBmenos.Size = New System.Drawing.Size(62, 48)
        Me.btnBmenos.TabIndex = 2
        Me.btnBmenos.Text = "-"
        Me.btnBmenos.UseVisualStyleBackColor = True
        '
        'btnBmas
        '
        Me.btnBmas.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnBmas.Location = New System.Drawing.Point(244, 176)
        Me.btnBmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBmas.Name = "btnBmas"
        Me.btnBmas.Size = New System.Drawing.Size(62, 48)
        Me.btnBmas.TabIndex = 3
        Me.btnBmas.Text = "+"
        Me.btnBmas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label1.Location = New System.Drawing.Point(54, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label2.Location = New System.Drawing.Point(54, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Monospac821 BT", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbA.ForeColor = System.Drawing.Color.Cyan
        Me.lbA.Location = New System.Drawing.Point(178, 82)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(38, 41)
        Me.lbA.TabIndex = 6
        Me.lbA.Text = "0"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Font = New System.Drawing.Font("Monospac821 BT", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbB.ForeColor = System.Drawing.Color.Cyan
        Me.lbB.Location = New System.Drawing.Point(178, 178)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(38, 41)
        Me.lbB.TabIndex = 7
        Me.lbB.Text = "0"
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Monospac821 BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbResultado.ForeColor = System.Drawing.Color.LightCyan
        Me.lbResultado.Location = New System.Drawing.Point(52, 342)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(254, 32)
        Me.lbResultado.TabIndex = 8
        Me.lbResultado.Text = "Su Resultado es"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button1.Location = New System.Drawing.Point(519, 80)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Sumar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button2.Location = New System.Drawing.Point(519, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Restar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button3.Location = New System.Drawing.Point(519, 176)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 43)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Multiplicar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button4.Location = New System.Drawing.Point(519, 225)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 43)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Dividir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monospac821 BT", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(56, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(417, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Aldo Javier Abad Gonzalez - 201903835"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button5.Location = New System.Drawing.Point(519, 276)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 43)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Limpiar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(707, 400)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBmas)
        Me.Controls.Add(Me.btnBmenos)
        Me.Controls.Add(Me.btnAmas)
        Me.Controls.Add(Me.btnAmenos)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAmenos As Button
    Friend WithEvents btnAmas As Button
    Friend WithEvents btnBmenos As Button
    Friend WithEvents btnBmas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbA As Label
    Friend WithEvents lbB As Label
    Friend WithEvents lbResultado As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
End Class
