<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 患者連絡先
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
        Me.rbtnI = New System.Windows.Forms.RadioButton()
        Me.rbtnR = New System.Windows.Forms.RadioButton()
        Me.rbtnAll = New System.Windows.Forms.RadioButton()
        Me.btnRenPrint = New System.Windows.Forms.Button()
        Me.rbtnPreview = New System.Windows.Forms.RadioButton()
        Me.rbtnPrintout = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnTaiPrint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPatientContact = New Contact.RenDataGridView(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPatientContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtnI
        '
        Me.rbtnI.AutoSize = True
        Me.rbtnI.Location = New System.Drawing.Point(95, 45)
        Me.rbtnI.Name = "rbtnI"
        Me.rbtnI.Size = New System.Drawing.Size(71, 16)
        Me.rbtnI.TabIndex = 0
        Me.rbtnI.TabStop = True
        Me.rbtnI.Text = "一般患者"
        Me.rbtnI.UseVisualStyleBackColor = True
        '
        'rbtnR
        '
        Me.rbtnR.AutoSize = True
        Me.rbtnR.Location = New System.Drawing.Point(95, 63)
        Me.rbtnR.Name = "rbtnR"
        Me.rbtnR.Size = New System.Drawing.Size(71, 16)
        Me.rbtnR.TabIndex = 1
        Me.rbtnR.TabStop = True
        Me.rbtnR.Text = "療養患者"
        Me.rbtnR.UseVisualStyleBackColor = True
        '
        'rbtnAll
        '
        Me.rbtnAll.AutoSize = True
        Me.rbtnAll.Location = New System.Drawing.Point(95, 81)
        Me.rbtnAll.Name = "rbtnAll"
        Me.rbtnAll.Size = New System.Drawing.Size(44, 16)
        Me.rbtnAll.TabIndex = 2
        Me.rbtnAll.TabStop = True
        Me.rbtnAll.Text = "全て"
        Me.rbtnAll.UseVisualStyleBackColor = True
        '
        'btnRenPrint
        '
        Me.btnRenPrint.Location = New System.Drawing.Point(196, 16)
        Me.btnRenPrint.Name = "btnRenPrint"
        Me.btnRenPrint.Size = New System.Drawing.Size(89, 38)
        Me.btnRenPrint.TabIndex = 3
        Me.btnRenPrint.Text = "利用者連絡先印刷"
        Me.btnRenPrint.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(93, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "表示方法"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnPrintout)
        Me.Panel1.Controls.Add(Me.rbtnPreview)
        Me.Panel1.Location = New System.Drawing.Point(309, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 38)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(194, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ﾀﾞﾌﾞﾙｸﾘｯｸした項目で並び替えます"
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(460, 60)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(82, 38)
        Me.btnRegist.TabIndex = 10
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnTaiPrint
        '
        Me.btnTaiPrint.Location = New System.Drawing.Point(196, 63)
        Me.btnTaiPrint.Name = "btnTaiPrint"
        Me.btnTaiPrint.Size = New System.Drawing.Size(89, 38)
        Me.btnTaiPrint.TabIndex = 11
        Me.btnTaiPrint.Text = "対応別避難先印刷"
        Me.btnTaiPrint.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(1217, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(570, 100)
        Me.Panel2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "対応内容番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(39, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "6.自宅に帰宅　7.病院に搬送　8.そのほか"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "そのほかの対応"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(39, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(449, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "1.単独歩行が可能　2.介助が必要　3.車いすを使用　4.ストレッチャーや担架が必要　5.そのほか"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "避難場所へ移動"
        '
        'dgvPatientContact
        '
        Me.dgvPatientContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientContact.Location = New System.Drawing.Point(35, 138)
        Me.dgvPatientContact.Name = "dgvPatientContact"
        Me.dgvPatientContact.RowTemplate.Height = 21
        Me.dgvPatientContact.Size = New System.Drawing.Size(1752, 565)
        Me.dgvPatientContact.TabIndex = 12
        '
        '患者連絡先
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1881, 712)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvPatientContact)
        Me.Controls.Add(Me.btnTaiPrint)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRenPrint)
        Me.Controls.Add(Me.rbtnAll)
        Me.Controls.Add(Me.rbtnR)
        Me.Controls.Add(Me.rbtnI)
        Me.Name = "患者連絡先"
        Me.Text = "患者連絡先"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPatientContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnI As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnRenPrint As System.Windows.Forms.Button
    Friend WithEvents rbtnPreview As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPrintout As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnTaiPrint As System.Windows.Forms.Button
    Friend WithEvents dgvPatientContact As Contact.RenDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
