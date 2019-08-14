<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 職員連絡網
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnClearSelect = New System.Windows.Forms.Button()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnInputClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnPrintout = New System.Windows.Forms.RadioButton()
        Me.rbtnPreview = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvContactE5 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactE4 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactE3 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactE2 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactE1 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactD5 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactD4 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactD3 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactD2 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactD1 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactC5 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactC4 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactC3 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactC2 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactC1 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactB5 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactB4 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactB3 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactB2 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactB1 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactA2 = New Contact.ExDataGridView(Me.components)
        Me.dgvContactA1 = New Contact.ExDataGridView(Me.components)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvContactE5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactE4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactE3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactE2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactD5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactC5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactA1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "在職職員リスト（ｶﾅ順）"
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(35, 76)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 21
        Me.dgvStaff.Size = New System.Drawing.Size(114, 741)
        Me.dgvStaff.TabIndex = 1
        '
        'btnClearSelect
        '
        Me.btnClearSelect.Location = New System.Drawing.Point(35, 47)
        Me.btnClearSelect.Name = "btnClearSelect"
        Me.btnClearSelect.Size = New System.Drawing.Size(115, 23)
        Me.btnClearSelect.TabIndex = 24
        Me.btnClearSelect.Text = "選択解除"
        Me.btnClearSelect.UseVisualStyleBackColor = True
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(608, 93)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(74, 34)
        Me.btnRegist.TabIndex = 25
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(702, 161)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 34)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "印刷"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnInputClear
        '
        Me.btnInputClear.Location = New System.Drawing.Point(653, 211)
        Me.btnInputClear.Name = "btnInputClear"
        Me.btnInputClear.Size = New System.Drawing.Size(123, 26)
        Me.btnInputClear.TabIndex = 28
        Me.btnInputClear.Text = "入力クリア"
        Me.btnInputClear.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnPrintout)
        Me.Panel1.Controls.Add(Me.rbtnPreview)
        Me.Panel1.Location = New System.Drawing.Point(608, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 38)
        Me.Panel1.TabIndex = 29
        '
        'rbtnPrintout
        '
        Me.rbtnPrintout.AutoSize = True
        Me.rbtnPrintout.Location = New System.Drawing.Point(4, 3)
        Me.rbtnPrintout.Name = "rbtnPrintout"
        Me.rbtnPrintout.Size = New System.Drawing.Size(47, 16)
        Me.rbtnPrintout.TabIndex = 4
        Me.rbtnPrintout.TabStop = True
        Me.rbtnPrintout.Text = "印刷"
        Me.rbtnPrintout.UseVisualStyleBackColor = True
        '
        'rbtnPreview
        '
        Me.rbtnPreview.AutoSize = True
        Me.rbtnPreview.Location = New System.Drawing.Point(4, 19)
        Me.rbtnPreview.Name = "rbtnPreview"
        Me.rbtnPreview.Size = New System.Drawing.Size(63, 16)
        Me.rbtnPreview.TabIndex = 5
        Me.rbtnPreview.TabStop = True
        Me.rbtnPreview.Text = "ﾌﾟﾚﾋﾞｭｰ"
        Me.rbtnPreview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 12)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "役職、所属等"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "氏名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "電話番号1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "電話番号2"
        '
        'dgvContactE5
        '
        Me.dgvContactE5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactE5.Location = New System.Drawing.Point(653, 721)
        Me.dgvContactE5.Name = "dgvContactE5"
        Me.dgvContactE5.RowTemplate.Height = 21
        Me.dgvContactE5.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactE5.TabIndex = 55
        '
        'dgvContactE4
        '
        Me.dgvContactE4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactE4.Location = New System.Drawing.Point(653, 606)
        Me.dgvContactE4.Name = "dgvContactE4"
        Me.dgvContactE4.RowTemplate.Height = 21
        Me.dgvContactE4.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactE4.TabIndex = 54
        '
        'dgvContactE3
        '
        Me.dgvContactE3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactE3.Location = New System.Drawing.Point(653, 491)
        Me.dgvContactE3.Name = "dgvContactE3"
        Me.dgvContactE3.RowTemplate.Height = 21
        Me.dgvContactE3.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactE3.TabIndex = 53
        '
        'dgvContactE2
        '
        Me.dgvContactE2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactE2.Location = New System.Drawing.Point(653, 376)
        Me.dgvContactE2.Name = "dgvContactE2"
        Me.dgvContactE2.RowTemplate.Height = 21
        Me.dgvContactE2.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactE2.TabIndex = 52
        '
        'dgvContactE1
        '
        Me.dgvContactE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactE1.Location = New System.Drawing.Point(653, 261)
        Me.dgvContactE1.Name = "dgvContactE1"
        Me.dgvContactE1.RowTemplate.Height = 21
        Me.dgvContactE1.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactE1.TabIndex = 51
        '
        'dgvContactD5
        '
        Me.dgvContactD5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactD5.Location = New System.Drawing.Point(496, 721)
        Me.dgvContactD5.Name = "dgvContactD5"
        Me.dgvContactD5.RowTemplate.Height = 21
        Me.dgvContactD5.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactD5.TabIndex = 50
        '
        'dgvContactD4
        '
        Me.dgvContactD4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactD4.Location = New System.Drawing.Point(496, 606)
        Me.dgvContactD4.Name = "dgvContactD4"
        Me.dgvContactD4.RowTemplate.Height = 21
        Me.dgvContactD4.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactD4.TabIndex = 49
        '
        'dgvContactD3
        '
        Me.dgvContactD3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactD3.Location = New System.Drawing.Point(496, 491)
        Me.dgvContactD3.Name = "dgvContactD3"
        Me.dgvContactD3.RowTemplate.Height = 21
        Me.dgvContactD3.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactD3.TabIndex = 48
        '
        'dgvContactD2
        '
        Me.dgvContactD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactD2.Location = New System.Drawing.Point(496, 376)
        Me.dgvContactD2.Name = "dgvContactD2"
        Me.dgvContactD2.RowTemplate.Height = 21
        Me.dgvContactD2.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactD2.TabIndex = 47
        '
        'dgvContactD1
        '
        Me.dgvContactD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactD1.Location = New System.Drawing.Point(496, 261)
        Me.dgvContactD1.Name = "dgvContactD1"
        Me.dgvContactD1.RowTemplate.Height = 21
        Me.dgvContactD1.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactD1.TabIndex = 46
        '
        'dgvContactC5
        '
        Me.dgvContactC5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactC5.Location = New System.Drawing.Point(338, 721)
        Me.dgvContactC5.Name = "dgvContactC5"
        Me.dgvContactC5.RowTemplate.Height = 21
        Me.dgvContactC5.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactC5.TabIndex = 45
        '
        'dgvContactC4
        '
        Me.dgvContactC4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactC4.Location = New System.Drawing.Point(338, 606)
        Me.dgvContactC4.Name = "dgvContactC4"
        Me.dgvContactC4.RowTemplate.Height = 21
        Me.dgvContactC4.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactC4.TabIndex = 44
        '
        'dgvContactC3
        '
        Me.dgvContactC3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactC3.Location = New System.Drawing.Point(338, 491)
        Me.dgvContactC3.Name = "dgvContactC3"
        Me.dgvContactC3.RowTemplate.Height = 21
        Me.dgvContactC3.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactC3.TabIndex = 43
        '
        'dgvContactC2
        '
        Me.dgvContactC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactC2.Location = New System.Drawing.Point(338, 376)
        Me.dgvContactC2.Name = "dgvContactC2"
        Me.dgvContactC2.RowTemplate.Height = 21
        Me.dgvContactC2.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactC2.TabIndex = 42
        '
        'dgvContactC1
        '
        Me.dgvContactC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactC1.Location = New System.Drawing.Point(338, 261)
        Me.dgvContactC1.Name = "dgvContactC1"
        Me.dgvContactC1.RowTemplate.Height = 21
        Me.dgvContactC1.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactC1.TabIndex = 41
        '
        'dgvContactB5
        '
        Me.dgvContactB5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactB5.Location = New System.Drawing.Point(179, 721)
        Me.dgvContactB5.Name = "dgvContactB5"
        Me.dgvContactB5.RowTemplate.Height = 21
        Me.dgvContactB5.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactB5.TabIndex = 40
        '
        'dgvContactB4
        '
        Me.dgvContactB4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactB4.Location = New System.Drawing.Point(179, 606)
        Me.dgvContactB4.Name = "dgvContactB4"
        Me.dgvContactB4.RowTemplate.Height = 21
        Me.dgvContactB4.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactB4.TabIndex = 39
        '
        'dgvContactB3
        '
        Me.dgvContactB3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactB3.Location = New System.Drawing.Point(179, 491)
        Me.dgvContactB3.Name = "dgvContactB3"
        Me.dgvContactB3.RowTemplate.Height = 21
        Me.dgvContactB3.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactB3.TabIndex = 38
        '
        'dgvContactB2
        '
        Me.dgvContactB2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactB2.Location = New System.Drawing.Point(179, 376)
        Me.dgvContactB2.Name = "dgvContactB2"
        Me.dgvContactB2.RowTemplate.Height = 21
        Me.dgvContactB2.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactB2.TabIndex = 37
        '
        'dgvContactB1
        '
        Me.dgvContactB1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactB1.Location = New System.Drawing.Point(179, 261)
        Me.dgvContactB1.Name = "dgvContactB1"
        Me.dgvContactB1.RowTemplate.Height = 21
        Me.dgvContactB1.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactB1.TabIndex = 36
        '
        'dgvContactA2
        '
        Me.dgvContactA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactA2.Location = New System.Drawing.Point(417, 139)
        Me.dgvContactA2.Name = "dgvContactA2"
        Me.dgvContactA2.RowTemplate.Height = 21
        Me.dgvContactA2.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactA2.TabIndex = 35
        '
        'dgvContactA1
        '
        Me.dgvContactA1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactA1.Location = New System.Drawing.Point(417, 23)
        Me.dgvContactA1.Name = "dgvContactA1"
        Me.dgvContactA1.RowTemplate.Height = 21
        Me.dgvContactA1.Size = New System.Drawing.Size(123, 98)
        Me.dgvContactA1.TabIndex = 34
        '
        '職員連絡網
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 840)
        Me.Controls.Add(Me.dgvContactE5)
        Me.Controls.Add(Me.dgvContactE4)
        Me.Controls.Add(Me.dgvContactE3)
        Me.Controls.Add(Me.dgvContactE2)
        Me.Controls.Add(Me.dgvContactE1)
        Me.Controls.Add(Me.dgvContactD5)
        Me.Controls.Add(Me.dgvContactD4)
        Me.Controls.Add(Me.dgvContactD3)
        Me.Controls.Add(Me.dgvContactD2)
        Me.Controls.Add(Me.dgvContactD1)
        Me.Controls.Add(Me.dgvContactC5)
        Me.Controls.Add(Me.dgvContactC4)
        Me.Controls.Add(Me.dgvContactC3)
        Me.Controls.Add(Me.dgvContactC2)
        Me.Controls.Add(Me.dgvContactC1)
        Me.Controls.Add(Me.dgvContactB5)
        Me.Controls.Add(Me.dgvContactB4)
        Me.Controls.Add(Me.dgvContactB3)
        Me.Controls.Add(Me.dgvContactB2)
        Me.Controls.Add(Me.dgvContactB1)
        Me.Controls.Add(Me.dgvContactA2)
        Me.Controls.Add(Me.dgvContactA1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnInputClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.btnClearSelect)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "職員連絡網"
        Me.Text = "職員連絡網"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvContactE5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactE4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactE3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactE2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactD5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactC5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactA1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents btnClearSelect As System.Windows.Forms.Button
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnInputClear As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtnPrintout As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPreview As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvContactA1 As Contact.ExDataGridView
    Friend WithEvents dgvContactA2 As Contact.ExDataGridView
    Friend WithEvents dgvContactB2 As Contact.ExDataGridView
    Friend WithEvents dgvContactB1 As Contact.ExDataGridView
    Friend WithEvents dgvContactB4 As Contact.ExDataGridView
    Friend WithEvents dgvContactB3 As Contact.ExDataGridView
    Friend WithEvents dgvContactB5 As Contact.ExDataGridView
    Friend WithEvents dgvContactC5 As Contact.ExDataGridView
    Friend WithEvents dgvContactC4 As Contact.ExDataGridView
    Friend WithEvents dgvContactC3 As Contact.ExDataGridView
    Friend WithEvents dgvContactC2 As Contact.ExDataGridView
    Friend WithEvents dgvContactC1 As Contact.ExDataGridView
    Friend WithEvents dgvContactD5 As Contact.ExDataGridView
    Friend WithEvents dgvContactD4 As Contact.ExDataGridView
    Friend WithEvents dgvContactD3 As Contact.ExDataGridView
    Friend WithEvents dgvContactD2 As Contact.ExDataGridView
    Friend WithEvents dgvContactD1 As Contact.ExDataGridView
    Friend WithEvents dgvContactE5 As Contact.ExDataGridView
    Friend WithEvents dgvContactE4 As Contact.ExDataGridView
    Friend WithEvents dgvContactE3 As Contact.ExDataGridView
    Friend WithEvents dgvContactE2 As Contact.ExDataGridView
    Friend WithEvents dgvContactE1 As Contact.ExDataGridView
End Class
