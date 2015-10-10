<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kalkulator
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
        Me.nol = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.satu = New System.Windows.Forms.Button()
        Me.dua = New System.Windows.Forms.Button()
        Me.tiga = New System.Windows.Forms.Button()
        Me.empat = New System.Windows.Forms.Button()
        Me.lima = New System.Windows.Forms.Button()
        Me.enam = New System.Windows.Forms.Button()
        Me.tujuh = New System.Windows.Forms.Button()
        Me.delapan = New System.Windows.Forms.Button()
        Me.sembilan = New System.Windows.Forms.Button()
        Me.Samadengan = New System.Windows.Forms.Button()
        Me.min = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.backspace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nol
        '
        Me.nol.Location = New System.Drawing.Point(12, 207)
        Me.nol.Name = "nol"
        Me.nol.Size = New System.Drawing.Size(50, 50)
        Me.nol.TabIndex = 0
        Me.nol.Text = "0"
        Me.nol.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'satu
        '
        Me.satu.Location = New System.Drawing.Point(12, 151)
        Me.satu.Name = "satu"
        Me.satu.Size = New System.Drawing.Size(50, 50)
        Me.satu.TabIndex = 2
        Me.satu.Text = "1"
        Me.satu.UseVisualStyleBackColor = True
        '
        'dua
        '
        Me.dua.Location = New System.Drawing.Point(68, 151)
        Me.dua.Name = "dua"
        Me.dua.Size = New System.Drawing.Size(50, 50)
        Me.dua.TabIndex = 3
        Me.dua.Text = "2"
        Me.dua.UseVisualStyleBackColor = True
        '
        'tiga
        '
        Me.tiga.Location = New System.Drawing.Point(124, 151)
        Me.tiga.Name = "tiga"
        Me.tiga.Size = New System.Drawing.Size(50, 50)
        Me.tiga.TabIndex = 4
        Me.tiga.Text = "3"
        Me.tiga.UseVisualStyleBackColor = True
        '
        'empat
        '
        Me.empat.Location = New System.Drawing.Point(12, 95)
        Me.empat.Name = "empat"
        Me.empat.Size = New System.Drawing.Size(50, 50)
        Me.empat.TabIndex = 5
        Me.empat.Text = "4"
        Me.empat.UseVisualStyleBackColor = True
        '
        'lima
        '
        Me.lima.Location = New System.Drawing.Point(68, 95)
        Me.lima.Name = "lima"
        Me.lima.Size = New System.Drawing.Size(50, 50)
        Me.lima.TabIndex = 6
        Me.lima.Text = "5"
        Me.lima.UseVisualStyleBackColor = True
        '
        'enam
        '
        Me.enam.Location = New System.Drawing.Point(124, 95)
        Me.enam.Name = "enam"
        Me.enam.Size = New System.Drawing.Size(50, 50)
        Me.enam.TabIndex = 7
        Me.enam.Text = "6"
        Me.enam.UseVisualStyleBackColor = True
        '
        'tujuh
        '
        Me.tujuh.Location = New System.Drawing.Point(12, 39)
        Me.tujuh.Name = "tujuh"
        Me.tujuh.Size = New System.Drawing.Size(50, 50)
        Me.tujuh.TabIndex = 8
        Me.tujuh.Text = "7"
        Me.tujuh.UseVisualStyleBackColor = True
        '
        'delapan
        '
        Me.delapan.Location = New System.Drawing.Point(68, 39)
        Me.delapan.Name = "delapan"
        Me.delapan.Size = New System.Drawing.Size(50, 50)
        Me.delapan.TabIndex = 9
        Me.delapan.Text = "8"
        Me.delapan.UseVisualStyleBackColor = True
        '
        'sembilan
        '
        Me.sembilan.Location = New System.Drawing.Point(124, 39)
        Me.sembilan.Name = "sembilan"
        Me.sembilan.Size = New System.Drawing.Size(50, 50)
        Me.sembilan.TabIndex = 10
        Me.sembilan.Text = "9"
        Me.sembilan.UseVisualStyleBackColor = True
        '
        'Samadengan
        '
        Me.Samadengan.Location = New System.Drawing.Point(68, 208)
        Me.Samadengan.Name = "Samadengan"
        Me.Samadengan.Size = New System.Drawing.Size(106, 49)
        Me.Samadengan.TabIndex = 11
        Me.Samadengan.Text = "="
        Me.Samadengan.UseVisualStyleBackColor = True
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(180, 208)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(50, 50)
        Me.min.TabIndex = 12
        Me.min.Text = "-"
        Me.min.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(180, 151)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(50, 50)
        Me.plus.TabIndex = 13
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(181, 39)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(50, 50)
        Me.clear.TabIndex = 14
        Me.clear.Text = "clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'backspace
        '
        Me.backspace.Location = New System.Drawing.Point(181, 95)
        Me.backspace.Name = "backspace"
        Me.backspace.Size = New System.Drawing.Size(50, 50)
        Me.backspace.TabIndex = 15
        Me.backspace.Text = "bckspc"
        Me.backspace.UseVisualStyleBackColor = True
        '
        'kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 265)
        Me.Controls.Add(Me.backspace)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Samadengan)
        Me.Controls.Add(Me.sembilan)
        Me.Controls.Add(Me.delapan)
        Me.Controls.Add(Me.tujuh)
        Me.Controls.Add(Me.enam)
        Me.Controls.Add(Me.lima)
        Me.Controls.Add(Me.empat)
        Me.Controls.Add(Me.tiga)
        Me.Controls.Add(Me.dua)
        Me.Controls.Add(Me.satu)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.nol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "kalkulator"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nol As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents satu As System.Windows.Forms.Button
    Friend WithEvents dua As System.Windows.Forms.Button
    Friend WithEvents tiga As System.Windows.Forms.Button
    Friend WithEvents empat As System.Windows.Forms.Button
    Friend WithEvents lima As System.Windows.Forms.Button
    Friend WithEvents enam As System.Windows.Forms.Button
    Friend WithEvents tujuh As System.Windows.Forms.Button
    Friend WithEvents delapan As System.Windows.Forms.Button
    Friend WithEvents sembilan As System.Windows.Forms.Button
    Friend WithEvents Samadengan As System.Windows.Forms.Button
    Friend WithEvents min As System.Windows.Forms.Button
    Friend WithEvents plus As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents backspace As System.Windows.Forms.Button

End Class
