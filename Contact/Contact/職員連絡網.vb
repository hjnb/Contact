Imports System.Data.OleDb

Public Class 職員連絡網

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 職員連絡網_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '在職職員リスト初期設定
        initDgvStaff()

        '連絡網dgv初期設定
        initDgvContact()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    ''' <summary>
    ''' 在職職員リスト表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvStaff()

        Util.EnableDoubleBuffering(dgvStaff)

        With dgvStaff
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersVisible = False
            .RowHeadersVisible = False
            .RowTemplate.Height = 18
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = False
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 9)
            .ReadOnly = True
        End With

        'データ取得
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Person)
        Dim sql As String = "select Nam, Tel1, Tel2 from Staff where Ymd2 = NULL or Ymd2 = '' order by Kana"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "Staff")
        Dim dt As DataTable = ds.Tables("Staff")

        '表示
        dgvStaff.DataSource = dt
        cn.Close()
        dgvStaff.ClearSelection()

        '幅設定等
        With dgvStaff
            .Columns("Tel1").Visible = False
            .Columns("Tel2").Visible = False

            With .Columns("Nam")
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 94
            End With
        End With
    End Sub

    ''' <summary>
    ''' 連絡網dgv初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvContact()
        Util.EnableDoubleBuffering(dgvContact)

        With dgvContact
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersVisible = False
            .RowHeadersVisible = False
            .RowTemplate.Height = 17
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = False
            .EnableHeadersVisualStyles = False
            '.Font = New Font("ＭＳ Ｐゴシック", 9)
            .ReadOnly = False
        End With

        Dim dt As DataTable = New DataTable()
        '列追加
        For i As Integer = 1 To 7
            dt.Columns.Add("C" & i, GetType(String))
        Next
        '行追加
        For i As Integer = 0 To 40
            dt.Rows.Add(dt.NewRow())
        Next

        '表示
        dgvContact.DataSource = dt
        dgvContact.ClearSelection()

        '幅設定等
        With dgvContact
            With .Columns("C2")
                .Width = 30
                .ReadOnly = True
            End With
            With .Columns("C6")
                .Width = 30
                .ReadOnly = True
            End With
        End With
    End Sub

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContact_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvContact.CellPainting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso (e.PaintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)

            If (e.PaintParts And DataGridViewPaintParts.SelectionBackground) = DataGridViewPaintParts.SelectionBackground AndAlso (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                e.Graphics.DrawRectangle(New Pen(Color.Black, 2I), e.CellBounds.X + 1I, e.CellBounds.Y + 1I, e.CellBounds.Width - 3I, e.CellBounds.Height - 3I)
            End If

            Dim pParts As DataGridViewPaintParts = e.PaintParts And Not DataGridViewPaintParts.Background
            e.Paint(e.ClipBounds, pParts)
            e.Handled = True
        End If
    End Sub
End Class