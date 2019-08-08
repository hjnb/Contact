<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.btnStaffContact = New System.Windows.Forms.Button()
        Me.btnPatientContact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStaffContact
        '
        Me.btnStaffContact.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnStaffContact.Location = New System.Drawing.Point(29, 122)
        Me.btnStaffContact.Name = "btnStaffContact"
        Me.btnStaffContact.Size = New System.Drawing.Size(203, 70)
        Me.btnStaffContact.TabIndex = 5
        Me.btnStaffContact.Text = "職員連絡網"
        Me.btnStaffContact.UseVisualStyleBackColor = True
        '
        'btnPatientContact
        '
        Me.btnPatientContact.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPatientContact.Location = New System.Drawing.Point(28, 28)
        Me.btnPatientContact.Name = "btnPatientContact"
        Me.btnPatientContact.Size = New System.Drawing.Size(204, 70)
        Me.btnPatientContact.TabIndex = 3
        Me.btnPatientContact.Text = "入院患者様連絡先"
        Me.btnPatientContact.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 223)
        Me.Controls.Add(Me.btnStaffContact)
        Me.Controls.Add(Me.btnPatientContact)
        Me.Name = "TopForm"
        Me.Text = "Contact"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStaffContact As System.Windows.Forms.Button
    Friend WithEvents btnPatientContact As System.Windows.Forms.Button

End Class
