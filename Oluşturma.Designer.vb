<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detay
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detay))
        Me.GeriD = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.GeriA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.isim = New System.Windows.Forms.TextBox()
        Me.Toplam = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Del = New System.Windows.Forms.Button()
        Me.Eklemek = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarihL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcıklamaL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorcL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlacakL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BakiyeL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tip = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bakiye = New System.Windows.Forms.TextBox()
        Me.Alacak = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Borc = New System.Windows.Forms.TextBox()
        Me.Acik = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tarih = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KayıtSay = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeriD
        '
        Me.GeriD.BackColor = System.Drawing.Color.Gray
        Me.GeriD.FlatAppearance.BorderSize = 0
        Me.GeriD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GeriD.ForeColor = System.Drawing.Color.White
        Me.GeriD.Location = New System.Drawing.Point(1100, 555)
        Me.GeriD.Margin = New System.Windows.Forms.Padding(6)
        Me.GeriD.Name = "GeriD"
        Me.GeriD.Size = New System.Drawing.Size(154, 101)
        Me.GeriD.TabIndex = 0
        Me.GeriD.Text = "Geri Dön"
        Me.GeriD.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Gray
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.Location = New System.Drawing.Point(0, 555)
        Me.Save.Margin = New System.Windows.Forms.Padding(6)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(189, 101)
        Me.Save.TabIndex = 1
        Me.Save.Text = "Kaydet"
        Me.Save.UseVisualStyleBackColor = False
        '
        'GeriA
        '
        Me.GeriA.BackColor = System.Drawing.Color.Gray
        Me.GeriA.FlatAppearance.BorderSize = 0
        Me.GeriA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GeriA.ForeColor = System.Drawing.Color.White
        Me.GeriA.Location = New System.Drawing.Point(944, 555)
        Me.GeriA.Margin = New System.Windows.Forms.Padding(6)
        Me.GeriA.Name = "GeriA"
        Me.GeriA.Size = New System.Drawing.Size(156, 101)
        Me.GeriA.TabIndex = 2
        Me.GeriA.Text = "Geri Al"
        Me.GeriA.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "İsim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(561, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Toplam"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.isim)
        Me.Panel1.Controls.Add(Me.Toplam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.selected)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1254, 63)
        Me.Panel1.TabIndex = 5
        '
        'isim
        '
        Me.isim.BackColor = System.Drawing.Color.DimGray
        Me.isim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.isim.ForeColor = System.Drawing.Color.White
        Me.isim.Location = New System.Drawing.Point(79, 9)
        Me.isim.MaxLength = 600
        Me.isim.Name = "isim"
        Me.isim.Size = New System.Drawing.Size(325, 31)
        Me.isim.TabIndex = 5
        '
        'Toplam
        '
        Me.Toplam.AutoSize = True
        Me.Toplam.Location = New System.Drawing.Point(748, 9)
        Me.Toplam.Name = "Toplam"
        Me.Toplam.Size = New System.Drawing.Size(104, 31)
        Me.Toplam.TabIndex = 6
        Me.Toplam.Text = "Toplam"
        '
        'selected
        '
        Me.selected.AutoSize = True
        Me.selected.Location = New System.Drawing.Point(79, 9)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(95, 31)
        Me.selected.TabIndex = 7
        Me.selected.Text = "Label9"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Del)
        Me.Panel2.Controls.Add(Me.Eklemek)
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1254, 494)
        Me.Panel2.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1100, 313)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 75)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Excel çıktısı"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Del
        '
        Me.Del.BackColor = System.Drawing.Color.Gray
        Me.Del.FlatAppearance.BorderSize = 0
        Me.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Del.ForeColor = System.Drawing.Color.White
        Me.Del.Location = New System.Drawing.Point(1100, 167)
        Me.Del.Margin = New System.Windows.Forms.Padding(6)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(154, 75)
        Me.Del.TabIndex = 7
        Me.Del.Text = "Sil"
        Me.Del.UseVisualStyleBackColor = False
        '
        'Eklemek
        '
        Me.Eklemek.BackColor = System.Drawing.Color.Gray
        Me.Eklemek.FlatAppearance.BorderSize = 0
        Me.Eklemek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eklemek.ForeColor = System.Drawing.Color.White
        Me.Eklemek.Location = New System.Drawing.Point(1100, 92)
        Me.Eklemek.Margin = New System.Windows.Forms.Padding(6)
        Me.Eklemek.Name = "Eklemek"
        Me.Eklemek.Size = New System.Drawing.Size(154, 75)
        Me.Eklemek.TabIndex = 8
        Me.Eklemek.Text = "Ekle"
        Me.Eklemek.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Grid.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TarihL, Me.TipL, Me.AcıklamaL, Me.BorcL, Me.AlacakL, Me.BakiyeL})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Grid.Location = New System.Drawing.Point(0, 92)
        Me.Grid.MaximumSize = New System.Drawing.Size(1100, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid.RowHeadersWidth = 30
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Grid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.Grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Grid.RowTemplate.Height = 24
        Me.Grid.Size = New System.Drawing.Size(1100, 402)
        Me.Grid.TabIndex = 1
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 73
        '
        'TarihL
        '
        Me.TarihL.Frozen = True
        Me.TarihL.HeaderText = "Tarih"
        Me.TarihL.MinimumWidth = 6
        Me.TarihL.Name = "TarihL"
        Me.TarihL.ReadOnly = True
        Me.TarihL.Width = 112
        '
        'TipL
        '
        Me.TipL.Frozen = True
        Me.TipL.HeaderText = "Tip"
        Me.TipL.MinimumWidth = 6
        Me.TipL.Name = "TipL"
        Me.TipL.ReadOnly = True
        Me.TipL.Width = 86
        '
        'AcıklamaL
        '
        Me.AcıklamaL.Frozen = True
        Me.AcıklamaL.HeaderText = "Açıklama"
        Me.AcıklamaL.MinimumWidth = 6
        Me.AcıklamaL.Name = "AcıklamaL"
        Me.AcıklamaL.ReadOnly = True
        Me.AcıklamaL.Width = 164
        '
        'BorcL
        '
        Me.BorcL.Frozen = True
        Me.BorcL.HeaderText = "Borç"
        Me.BorcL.MinimumWidth = 6
        Me.BorcL.Name = "BorcL"
        Me.BorcL.ReadOnly = True
        Me.BorcL.Width = 106
        '
        'AlacakL
        '
        Me.AlacakL.Frozen = True
        Me.AlacakL.HeaderText = "Alacak"
        Me.AlacakL.MinimumWidth = 6
        Me.AlacakL.Name = "AlacakL"
        Me.AlacakL.ReadOnly = True
        Me.AlacakL.Width = 134
        '
        'BakiyeL
        '
        Me.BakiyeL.Frozen = True
        Me.BakiyeL.HeaderText = "Bakiye"
        Me.BakiyeL.MinimumWidth = 6
        Me.BakiyeL.Name = "BakiyeL"
        Me.BakiyeL.ReadOnly = True
        Me.BakiyeL.Width = 133
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Tip)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Bakiye)
        Me.Panel3.Controls.Add(Me.Alacak)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Borc)
        Me.Panel3.Controls.Add(Me.Acik)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Tarih)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1254, 92)
        Me.Panel3.TabIndex = 0
        '
        'Tip
        '
        Me.Tip.BackColor = System.Drawing.Color.Gray
        Me.Tip.FlatAppearance.BorderSize = 0
        Me.Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tip.ForeColor = System.Drawing.Color.White
        Me.Tip.Location = New System.Drawing.Point(128, 43)
        Me.Tip.Margin = New System.Windows.Forms.Padding(6)
        Me.Tip.Name = "Tip"
        Me.Tip.Size = New System.Drawing.Size(263, 41)
        Me.Tip.TabIndex = 7
        Me.Tip.Text = "Fatura"
        Me.Tip.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tarih"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bakiye
        '
        Me.Bakiye.BackColor = System.Drawing.Color.DimGray
        Me.Bakiye.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bakiye.ForeColor = System.Drawing.Color.White
        Me.Bakiye.Location = New System.Drawing.Point(988, 48)
        Me.Bakiye.MaxLength = 600
        Me.Bakiye.Name = "Bakiye"
        Me.Bakiye.Size = New System.Drawing.Size(263, 31)
        Me.Bakiye.TabIndex = 17
        '
        'Alacak
        '
        Me.Alacak.BackColor = System.Drawing.Color.DimGray
        Me.Alacak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Alacak.ForeColor = System.Drawing.Color.White
        Me.Alacak.Location = New System.Drawing.Point(988, 3)
        Me.Alacak.MaxLength = 600
        Me.Alacak.Name = "Alacak"
        Me.Alacak.Size = New System.Drawing.Size(263, 31)
        Me.Alacak.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(862, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bakiye"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(862, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Alacak"
        '
        'Borc
        '
        Me.Borc.BackColor = System.Drawing.Color.DimGray
        Me.Borc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Borc.ForeColor = System.Drawing.Color.White
        Me.Borc.Location = New System.Drawing.Point(547, 48)
        Me.Borc.MaxLength = 600
        Me.Borc.Name = "Borc"
        Me.Borc.Size = New System.Drawing.Size(263, 31)
        Me.Borc.TabIndex = 13
        '
        'Acik
        '
        Me.Acik.BackColor = System.Drawing.Color.DimGray
        Me.Acik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Acik.ForeColor = System.Drawing.Color.White
        Me.Acik.Location = New System.Drawing.Point(547, 3)
        Me.Acik.MaxLength = 600
        Me.Acik.Name = "Acik"
        Me.Acik.Size = New System.Drawing.Size(263, 31)
        Me.Acik.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 31)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Borç"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Açıklama"
        '
        'Tarih
        '
        Me.Tarih.BackColor = System.Drawing.Color.DimGray
        Me.Tarih.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tarih.ForeColor = System.Drawing.Color.White
        Me.Tarih.Location = New System.Drawing.Point(128, 3)
        Me.Tarih.MaxLength = 600
        Me.Tarih.Name = "Tarih"
        Me.Tarih.Size = New System.Drawing.Size(263, 31)
        Me.Tarih.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tip"
        '
        'KayıtSay
        '
        Me.KayıtSay.AutoSize = True
        Me.KayıtSay.Location = New System.Drawing.Point(329, 588)
        Me.KayıtSay.Name = "KayıtSay"
        Me.KayıtSay.Size = New System.Drawing.Size(104, 31)
        Me.KayıtSay.TabIndex = 8
        Me.KayıtSay.Text = "Toplam"
        '
        'Detay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 656)
        Me.Controls.Add(Me.KayıtSay)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GeriA)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.GeriD)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "Detay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeriD As Button
    Friend WithEvents Save As Button
    Friend WithEvents GeriA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Toplam As Label
    Friend WithEvents isim As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Bakiye As TextBox
    Friend WithEvents Alacak As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Borc As TextBox
    Friend WithEvents Acik As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tarih As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Del As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents Eklemek As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents TarihL As DataGridViewTextBoxColumn
    Friend WithEvents TipL As DataGridViewTextBoxColumn
    Friend WithEvents AcıklamaL As DataGridViewTextBoxColumn
    Friend WithEvents BorcL As DataGridViewTextBoxColumn
    Friend WithEvents AlacakL As DataGridViewTextBoxColumn
    Friend WithEvents BakiyeL As DataGridViewTextBoxColumn
    Friend WithEvents selected As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Tip As Button
    Friend WithEvents KayıtSay As Label
    Friend WithEvents Button2 As Button
End Class
