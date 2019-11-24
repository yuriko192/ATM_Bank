<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CekSaldo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Saldo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "== Check Balance =="
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = false
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Saldo)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 112)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rp."
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Your current balance"
        '
        'Saldo
        '
        Me.Saldo.Location = New System.Drawing.Point(71, 70)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = true
        Me.Saldo.Size = New System.Drawing.Size(194, 20)
        Me.Saldo.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'CekSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(350, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CekSaldo"
        Me.Text = "CekSaldo"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Saldo As TextBox
    Friend WithEvents Button1 As Button
End Class
