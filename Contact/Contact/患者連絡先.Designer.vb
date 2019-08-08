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
        Me.rbtnI = New System.Windows.Forms.RadioButton()
        Me.rbtnR = New System.Windows.Forms.RadioButton()
        Me.rbtnAll = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.rbtnPreview = New System.Windows.Forms.RadioButton()
        Me.rbtnPrintout = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPatientContact = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvPatientContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnI
        '
        Me.rbtnI.AutoSize = True
        Me.rbtnI.Location = New System.Drawing.Point(95, 48)
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
        Me.rbtnR.Location = New System.Drawing.Point(95, 66)
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
        Me.rbtnAll.Location = New System.Drawing.Point(95, 84)
        Me.rbtnAll.Name = "rbtnAll"
        Me.rbtnAll.Size = New System.Drawing.Size(44, 16)
        Me.rbtnAll.TabIndex = 2
        Me.rbtnAll.TabStop = True
        Me.rbtnAll.Text = "全て"
        Me.rbtnAll.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(289, 62)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 38)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "印刷"
        Me.btnPrint.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(94, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "表示方法"
        '
        'dgvPatientContact
        '
        Me.dgvPatientContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientContact.Location = New System.Drawing.Point(35, 129)
        Me.dgvPatientContact.Name = "dgvPatientContact"
        Me.dgvPatientContact.RowTemplate.Height = 21
        Me.dgvPatientContact.Size = New System.Drawing.Size(609, 580)
        Me.dgvPatientContact.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnPrintout)
        Me.Panel1.Controls.Add(Me.rbtnPreview)
        Me.Panel1.Location = New System.Drawing.Point(399, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 38)
        Me.Panel1.TabIndex = 8
        '
        '患者連絡先
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 737)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvPatientContact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.rbtnAll)
        Me.Controls.Add(Me.rbtnR)
        Me.Controls.Add(Me.rbtnI)
        Me.Name = "患者連絡先"
        Me.Text = "患者連絡先"
        CType(Me.dgvPatientContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnI As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents rbtnPreview As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPrintout As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPatientContact As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
