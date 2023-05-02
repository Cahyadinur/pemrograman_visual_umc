<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tiket
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdAnak = New System.Windows.Forms.RadioButton()
        Me.rdDewasa = New System.Windows.Forms.RadioButton()
        Me.rdLansia = New System.Windows.Forms.RadioButton()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ahmad Nur Cahyadi / 190511094 / R3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.rdLansia)
        Me.GroupBox1.Controls.Add(Me.rdDewasa)
        Me.GroupBox1.Controls.Add(Me.rdAnak)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 194)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Biaya"
        '
        'txHarga
        '
        Me.txHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txHarga.Location = New System.Drawing.Point(294, 31)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(161, 26)
        Me.txHarga.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Harga Tiket"
        '
        'rdAnak
        '
        Me.rdAnak.AutoSize = True
        Me.rdAnak.Location = New System.Drawing.Point(11, 35)
        Me.rdAnak.Name = "rdAnak"
        Me.rdAnak.Size = New System.Drawing.Size(114, 24)
        Me.rdAnak.TabIndex = 3
        Me.rdAnak.Text = "Anak - Anak"
        Me.rdAnak.UseVisualStyleBackColor = True
        '
        'rdDewasa
        '
        Me.rdDewasa.AutoSize = True
        Me.rdDewasa.Location = New System.Drawing.Point(11, 65)
        Me.rdDewasa.Name = "rdDewasa"
        Me.rdDewasa.Size = New System.Drawing.Size(85, 24)
        Me.rdDewasa.TabIndex = 3
        Me.rdDewasa.TabStop = True
        Me.rdDewasa.Text = "Dewasa"
        Me.rdDewasa.UseVisualStyleBackColor = True
        '
        'rdLansia
        '
        Me.rdLansia.AutoSize = True
        Me.rdLansia.Location = New System.Drawing.Point(11, 95)
        Me.rdLansia.Name = "rdLansia"
        Me.rdLansia.Size = New System.Drawing.Size(74, 24)
        Me.rdLansia.TabIndex = 3
        Me.rdLansia.Text = "Lansia"
        Me.rdLansia.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(15, 140)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(95, 37)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'tiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 235)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txHarga)
        Me.Controls.Add(Me.Label2)
        Me.Name = "tiket"
        Me.Text = "tiket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdLansia As RadioButton
    Friend WithEvents rdDewasa As RadioButton
    Friend WithEvents rdAnak As RadioButton
    Friend WithEvents btnHitung As Button
End Class
