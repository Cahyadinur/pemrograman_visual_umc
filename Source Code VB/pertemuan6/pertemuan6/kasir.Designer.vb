<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kasir
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
        Me.txIsi = New System.Windows.Forms.TextBox()
        Me.cmbPromo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdMenu1 = New System.Windows.Forms.RadioButton()
        Me.rdMenu2 = New System.Windows.Forms.RadioButton()
        Me.rdMenu3 = New System.Windows.Forms.RadioButton()
        Me.rdMenu4 = New System.Windows.Forms.RadioButton()
        Me.cbMember = New System.Windows.Forms.CheckBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ahmad Nur Cahyadi / 190511094 / R3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txHarga)
        Me.GroupBox1.Controls.Add(Me.txIsi)
        Me.GroupBox1.Controls.Add(Me.cmbPromo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Biaya"
        '
        'txIsi
        '
        Me.txIsi.Location = New System.Drawing.Point(152, 78)
        Me.txIsi.Name = "txIsi"
        Me.txIsi.Size = New System.Drawing.Size(243, 26)
        Me.txIsi.TabIndex = 2
        '
        'cmbPromo
        '
        Me.cmbPromo.FormattingEnabled = True
        Me.cmbPromo.Location = New System.Drawing.Point(152, 32)
        Me.cmbPromo.Name = "cmbPromo"
        Me.cmbPromo.Size = New System.Drawing.Size(166, 28)
        Me.cmbPromo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Isi Promo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promo Tersedia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Harga"
        '
        'txHarga
        '
        Me.txHarga.Location = New System.Drawing.Point(152, 120)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(166, 26)
        Me.txHarga.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdMenu4)
        Me.GroupBox2.Controls.Add(Me.rdMenu3)
        Me.GroupBox2.Controls.Add(Me.rdMenu2)
        Me.GroupBox2.Controls.Add(Me.rdMenu1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(419, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 186)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tambahan Menu"
        '
        'rdMenu1
        '
        Me.rdMenu1.AutoSize = True
        Me.rdMenu1.Location = New System.Drawing.Point(6, 25)
        Me.rdMenu1.Name = "rdMenu1"
        Me.rdMenu1.Size = New System.Drawing.Size(123, 24)
        Me.rdMenu1.TabIndex = 0
        Me.rdMenu1.TabStop = True
        Me.rdMenu1.Text = "Es Teh Manis"
        Me.rdMenu1.UseVisualStyleBackColor = True
        '
        'rdMenu2
        '
        Me.rdMenu2.AutoSize = True
        Me.rdMenu2.Location = New System.Drawing.Point(6, 55)
        Me.rdMenu2.Name = "rdMenu2"
        Me.rdMenu2.Size = New System.Drawing.Size(99, 24)
        Me.rdMenu2.TabIndex = 0
        Me.rdMenu2.TabStop = True
        Me.rdMenu2.Text = "Es Kelapa"
        Me.rdMenu2.UseVisualStyleBackColor = True
        '
        'rdMenu3
        '
        Me.rdMenu3.AutoSize = True
        Me.rdMenu3.Location = New System.Drawing.Point(6, 85)
        Me.rdMenu3.Name = "rdMenu3"
        Me.rdMenu3.Size = New System.Drawing.Size(110, 24)
        Me.rdMenu3.TabIndex = 0
        Me.rdMenu3.TabStop = True
        Me.rdMenu3.Text = "Pisang Keju"
        Me.rdMenu3.UseVisualStyleBackColor = True
        '
        'rdMenu4
        '
        Me.rdMenu4.AutoSize = True
        Me.rdMenu4.Location = New System.Drawing.Point(6, 115)
        Me.rdMenu4.Name = "rdMenu4"
        Me.rdMenu4.Size = New System.Drawing.Size(162, 24)
        Me.rdMenu4.TabIndex = 0
        Me.rdMenu4.TabStop = True
        Me.rdMenu4.Text = "Es Campur Special"
        Me.rdMenu4.UseVisualStyleBackColor = True
        '
        'cbMember
        '
        Me.cbMember.AutoSize = True
        Me.cbMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMember.Location = New System.Drawing.Point(12, 216)
        Me.cbMember.Name = "cbMember"
        Me.cbMember.Size = New System.Drawing.Size(196, 24)
        Me.cbMember.TabIndex = 4
        Me.cbMember.Text = "Apakah Anda Member?"
        Me.cbMember.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(436, 208)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(175, 39)
        Me.btnHitung.TabIndex = 5
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Biaya"
        '
        'txTotal
        '
        Me.txTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotal.Location = New System.Drawing.Point(368, 272)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(243, 26)
        Me.txTotal.TabIndex = 2
        '
        'kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 359)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txTotal)
        Me.Controls.Add(Me.cbMember)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "kasir"
        Me.Text = "kasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txIsi As TextBox
    Friend WithEvents cmbPromo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdMenu4 As RadioButton
    Friend WithEvents rdMenu3 As RadioButton
    Friend WithEvents rdMenu2 As RadioButton
    Friend WithEvents rdMenu1 As RadioButton
    Friend WithEvents cbMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txTotal As TextBox
End Class
