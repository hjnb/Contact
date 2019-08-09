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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.dgvContact = New System.Windows.Forms.DataGridView()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "在職職員リスト（ｶﾅ順）"
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(35, 45)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 21
        Me.dgvStaff.Size = New System.Drawing.Size(114, 543)
        Me.dgvStaff.TabIndex = 1
        '
        'dgvContact
        '
        Me.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContact.Location = New System.Drawing.Point(179, 45)
        Me.dgvContact.Name = "dgvContact"
        Me.dgvContact.RowTemplate.Height = 21
        Me.dgvContact.Size = New System.Drawing.Size(603, 543)
        Me.dgvContact.TabIndex = 2
        '
        '職員連絡網
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 615)
        Me.Controls.Add(Me.dgvContact)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "職員連絡網"
        Me.Text = "職員連絡網"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents dgvContact As System.Windows.Forms.DataGridView
End Class
