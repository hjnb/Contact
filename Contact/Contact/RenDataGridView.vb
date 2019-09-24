Public Class RenDataGridView
    Inherits DataGridView

    Protected Overrides Function ProcessDialogKey(keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Enter Then
            Return Me.ProcessTabKey(keyData)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Protected Overrides Function ProcessDataGridViewKey(e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim inputStr As String = Util.checkDBNullValue(Me.CurrentCell.Value)
        If e.KeyCode = Keys.Enter Then
            Me.ProcessTabKey(e.KeyCode)
            Return False
        End If

        Dim tb As DataGridViewTextBoxEditingControl = CType(Me.EditingControl, DataGridViewTextBoxEditingControl)
        If Not IsNothing(tb) AndAlso ((e.KeyCode = Keys.Left AndAlso tb.SelectionStart = 0) OrElse (e.KeyCode = Keys.Right AndAlso tb.SelectionStart = tb.TextLength)) Then
            Return False
        Else
            Return MyBase.ProcessDataGridViewKey(e)
        End If
    End Function

End Class
