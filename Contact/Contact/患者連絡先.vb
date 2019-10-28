Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class 患者連絡先

    Private numArray() As String = {"1", "2", "3", "4", "5", "6", "7", "8"}

    ''' <summary>
    ''' 行ヘッダーのカレントセルを表す三角マークを非表示に設定する為のクラス。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class dgvRowHeaderCell

        'DataGridViewRowHeaderCell を継承
        Inherits DataGridViewRowHeaderCell

        'DataGridViewHeaderCell.Paint をオーバーライドして行ヘッダーを描画
        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, _
           ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, _
           ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, _
           ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
           ByVal paintParts As DataGridViewPaintParts)
            '標準セルの描画からセル内容の背景だけ除いた物を描画(-5)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, _
                     formattedValue, errorText, cellStyle, advancedBorderStyle, _
                     Not DataGridViewPaintParts.ContentBackground)
        End Sub

    End Class

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 患者連絡先_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データグリッドビュー初期設定
        initDgvPatientContact()

        '印刷ラジオボタンの初期設定
        initPrintState()

        '初期設定
        rbtnI.Checked = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvPatientContact()
        Util.EnableDoubleBuffering(dgvPatientContact)

        With dgvPatientContact
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersWidth = 35
            .RowTemplate.Height = 18
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = True
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 9)
            .ReadOnly = False
            .ImeMode = Windows.Forms.ImeMode.Hiragana
        End With
    End Sub

    ''' <summary>
    ''' 患者連絡先データ表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayDgvPatientContact(type As String)
        '内容クリア
        dgvPatientContact.Columns.Clear()

        'データ取得
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Patient)
        Dim rs As New ADODB.Recordset
        Dim sql As String = ""
        If type = "All" Then
            sql = "select P.*, C.Sonota, C.Tai, C.Hinan, C.Ido, C.Tanto, C.Biko from (select Cod, Nam, Kana, Int((Format(NOW(),'YYYYMMDD')-Format(Birth, 'YYYYMMDD'))/10000) as Age, Jyu1, KNam, Zok, Tel2, Jyu2 from UsrM where Sanato = 1 or Nurse = 1 order by Kana) as P left join [" & TopForm.dbFilePath & "].PInfo as C on P.Cod = C.Cod order by P.Kana"
        Else
            sql = "select P.*, C.Sonota, C.Tai, C.Hinan, C.Ido, C.Tanto, C.Biko from (select Cod, Nam, Kana, Int((Format(NOW(),'YYYYMMDD')-Format(Birth, 'YYYYMMDD'))/10000) as Age, Jyu1, KNam, Zok, Tel2, Jyu2 from UsrM where " & type & " = 1 order by Kana) as P left join [" & TopForm.dbFilePath & "].PInfo as C on P.Cod = C.Cod order by P.Kana"
        End If

        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "Patient")
        Dim dt As DataTable = ds.Tables("Patient")

        '表示
        dgvPatientContact.DataSource = dt
        cnn.Close()
        dgvPatientContact.ClearSelection()

        '幅設定等
        With dgvPatientContact

            '非表示
            .Columns("Cod").Visible = False

            With .Columns("Nam")
                .HeaderText = "氏名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 100
                .ReadOnly = True
            End With
            With .Columns("Kana")
                .HeaderText = "カナ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 75
                .ReadOnly = True
            End With
            With .Columns("Age")
                .HeaderText = "年齢"
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 8)
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 35
                .ReadOnly = True
            End With
            With .Columns("Jyu1")
                .HeaderText = "住所"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 290
                .ReadOnly = True
            End With
            With .Columns("KNam")
                .HeaderText = "ｷｰﾊﾟ氏名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 100
                .ReadOnly = True
            End With
            With .Columns("Zok")
                .HeaderText = "続柄"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 55
                .ReadOnly = True
            End With
            With .Columns("Tel2")
                .HeaderText = "電話番号"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = True
            End With
            With .Columns("Jyu2")
                .HeaderText = "住所"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 290
                .ReadOnly = True
            End With
            With .Columns("Sonota")
                .HeaderText = "その他"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 110
                .ReadOnly = False
            End With
            With .Columns("Tai")
                .HeaderText = "対応内容"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 120
                .ReadOnly = False
            End With
            With .Columns("Hinan")
                .HeaderText = "避難先"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 120
                .ReadOnly = False
            End With
            With .Columns("Ido")
                .HeaderText = "移動手段"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 120
                .ReadOnly = False
            End With
            With .Columns("Tanto")
                .HeaderText = "担当者"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = False
            End With
            With .Columns("Biko")
                .HeaderText = "備考"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.BackColor = Color.White
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 120
                .ReadOnly = False
            End With

            If dgvPatientContact.Rows.Count > 30 Then
                .Size = New Size(1769, 565)
            Else
                .Size = New Size(1752, 565)
            End If
        End With
    End Sub

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvPatientContact_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvPatientContact.CellPainting
        '行ヘッダーかどうか調べる
        If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
            'セルを描画する
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

            '行番号を描画する範囲を決定する
            'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
            Dim indexRect As Rectangle = e.CellBounds
            indexRect.Inflate(-2, -2)
            '行番号を描画する
            TextRenderer.DrawText(e.Graphics, _
                (e.RowIndex + 1).ToString(), _
                e.CellStyle.Font, _
                indexRect, _
                e.CellStyle.ForeColor, _
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            '描画が完了したことを知らせる
            e.Handled = True
        End If
        '選択したセルに枠を付ける
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

    ''' <summary>
    ''' 列ヘッダーダブルクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvPatientContact_ColumnHeaderMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPatientContact.ColumnHeaderMouseDoubleClick
        Dim targetColumn As DataGridViewColumn = dgvPatientContact.Columns(e.ColumnIndex) '選択列
        dgvPatientContact.Sort(targetColumn, System.ComponentModel.ListSortDirection.Ascending) '昇順でソート
    End Sub

    ''' <summary>
    ''' 印刷ラジオボタン初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initPrintState()
        Dim state As String = Util.getIniString("System", "Printer", TopForm.iniFilePath)
        If state = "Y" Then
            rbtnPrintout.Checked = True
        Else
            rbtnPreview.Checked = True
        End If
    End Sub

    Private Sub rbtnPreview_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPreview.CheckedChanged
        If rbtnPreview.Checked = True Then
            Util.putIniString("System", "Printer", "N", TopForm.iniFilePath)
        End If
    End Sub

    Private Sub rbtnPrint_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPrintout.CheckedChanged
        If rbtnPrintout.Checked = True Then
            Util.putIniString("System", "Printer", "Y", TopForm.iniFilePath)
        End If
    End Sub

    Private Sub rbtn_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnI.CheckedChanged, rbtnR.CheckedChanged, rbtnAll.CheckedChanged
        If DirectCast(sender, RadioButton).Checked Then
            Dim type As String = If(rbtnI.Checked, "Nurse", If(rbtnR.Checked, "Sanato", "All"))
            displayDgvPatientContact(type)
        End If
    End Sub

    ''' <summary>
    ''' 利用者連絡先印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRenPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnRenPrint.Click
        '件数
        Dim rowsCount As Integer = dgvPatientContact.Rows.Count

        '貼り付けデータ作成
        Dim dataList As New List(Of String(,))
        Dim dataArray(29, 7) As String
        Dim arrayRowIndex As Integer = 0
        For i As Integer = 0 To rowsCount - 1
            If arrayRowIndex = 30 Then
                dataList.Add(dataArray.Clone())
                Array.Clear(dataArray, 0, dataArray.Length)
                arrayRowIndex = 0
            End If

            '利用者氏名
            dataArray(arrayRowIndex, 0) = Util.checkDBNullValue(dgvPatientContact("Nam", i).Value)
            '年齢
            dataArray(arrayRowIndex, 1) = Util.checkDBNullValue(dgvPatientContact("Age", i).Value)
            '住所
            dataArray(arrayRowIndex, 2) = Util.checkDBNullValue(dgvPatientContact("Jyu1", i).Value)
            '緊急連絡先氏名
            dataArray(arrayRowIndex, 3) = Util.checkDBNullValue(dgvPatientContact("KNam", i).Value)
            '続柄
            dataArray(arrayRowIndex, 4) = Util.checkDBNullValue(dgvPatientContact("Zok", i).Value)
            '電話番号
            dataArray(arrayRowIndex, 5) = Util.checkDBNullValue(dgvPatientContact("Tel2", i).Value)
            '住所
            dataArray(arrayRowIndex, 6) = Util.checkDBNullValue(dgvPatientContact("Jyu2", i).Value)
            'その他（緊急連絡先等）
            dataArray(arrayRowIndex, 7) = Util.checkDBNullValue(dgvPatientContact("Sonota", i).Value)

            arrayRowIndex += 1
        Next
        dataList.Add(dataArray.Clone())

        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("利用者連絡先")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '日付
        Dim nowYmd As String = DateTime.Now.ToString("yyyy/MM/dd")
        oSheet.Range("I2").Value = nowYmd

        '必要枚数コピペ
        For i As Integer = 0 To dataList.Count - 2
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (38 + (37 * i))) 'ペースト先
            oSheet.Rows("1:37").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (38 + (37 * i)))) '改ページ
        Next

        'データ貼り付け
        For i As Integer = 0 To dataList.Count - 1
            oSheet.Range("I" & (3 + 37 * i)).Value = (i + 1) & " / " & dataList.Count & " 頁"
            oSheet.Range("B" & (7 + 37 * i), "I" & (36 + 37 * i)).Value = dataList(i)
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If rbtnPrintout.Checked = True Then
            oSheet.PrintOut()
        ElseIf rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 対応別避難先印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTaiPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnTaiPrint.Click
        '件数
        Dim rowsCount As Integer = dgvPatientContact.Rows.Count

        '貼り付けデータ作成
        Dim dataList As New List(Of String(,))
        Dim dataArray(29, 5) As String
        Dim arrayRowIndex As Integer = 0
        For i As Integer = 0 To rowsCount - 1
            If arrayRowIndex = 30 Then
                dataList.Add(dataArray.Clone())
                Array.Clear(dataArray, 0, dataArray.Length)
                arrayRowIndex = 0
            End If

            '対応内容
            dataArray(arrayRowIndex, 0) = Util.checkDBNullValue(dgvPatientContact("Tai", i).Value)
            '氏名
            dataArray(arrayRowIndex, 1) = Util.checkDBNullValue(dgvPatientContact("Nam", i).Value)
            '避難先
            dataArray(arrayRowIndex, 2) = Util.checkDBNullValue(dgvPatientContact("Hinan", i).Value)
            '移動手段
            dataArray(arrayRowIndex, 3) = Util.checkDBNullValue(dgvPatientContact("Ido", i).Value)
            '担当者
            dataArray(arrayRowIndex, 4) = Util.checkDBNullValue(dgvPatientContact("Tanto", i).Value)
            '備考
            dataArray(arrayRowIndex, 5) = Util.checkDBNullValue(dgvPatientContact("Biko", i).Value)

            arrayRowIndex += 1
        Next
        dataList.Add(dataArray.Clone())

        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("対応別避難誘導一覧")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '日付
        Dim nowYmd As String = DateTime.Now.ToString("yyyy/MM/dd")
        oSheet.Range("G2").Value = nowYmd

        '必要枚数コピペ
        For i As Integer = 0 To dataList.Count - 2
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (41 + (40 * i))) 'ペースト先
            oSheet.Rows("1:40").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (41 + (40 * i)))) '改ページ
        Next

        'データ貼り付け
        For i As Integer = 0 To dataList.Count - 1
            oSheet.Range("G" & (3 + 40 * i)).Value = (i + 1) & " / " & dataList.Count & " 頁"
            oSheet.Range("B" & (6 + 40 * i), "G" & (35 + 40 * i)).Value = dataList(i)
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If rbtnPrintout.Checked = True Then
            oSheet.PrintOut()
        ElseIf rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        Dim cnn As New ADODB.Connection
        cnn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cnn.Open(TopForm.DB_Contact)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select * from PInfo"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        For Each row As DataGridViewRow In dgvPatientContact.Rows
            Dim cod As Integer = row.Cells("Cod").Value
            Dim sonota As String = Util.checkDBNullValue(row.Cells("Sonota").Value)
            Dim tai As String = Util.checkDBNullValue(row.Cells("Tai").Value)
            Dim hinan As String = Util.checkDBNullValue(row.Cells("Hinan").Value)
            Dim ido As String = Util.checkDBNullValue(row.Cells("Ido").Value)
            Dim tanto As String = Util.checkDBNullValue(row.Cells("Tanto").Value)
            Dim biko As String = Util.checkDBNullValue(row.Cells("Biko").Value)

            '該当ｺｰﾄﾞを探す
            rs.Filter = "Cod = " & cod
            If rs.RecordCount > 0 Then
                'ｺｰﾄﾞが存在する場合はデータ更新
                rs.Fields("Sonota").Value = sonota
                rs.Fields("Tai").Value = tai
                rs.Fields("Hinan").Value = hinan
                rs.Fields("Ido").Value = ido
                rs.Fields("Tanto").Value = tanto
                rs.Fields("Biko").Value = biko
                rs.Update()
            Else
                '存在しない場合は新規データ登録
                rs.AddNew()
                rs.Fields("Cod").Value = cod
                rs.Fields("Sonota").Value = sonota
                rs.Fields("Tai").Value = tai
                rs.Fields("Hinan").Value = hinan
                rs.Fields("Ido").Value = ido
                rs.Fields("Tanto").Value = tanto
                rs.Fields("Biko").Value = biko
                rs.Update()
            End If
        Next
        rs.Close()
        cnn.Close()

        MsgBox("データを更新しました。", MsgBoxStyle.Information)

        '再表示
        Dim type As String = If(rbtnI.Checked, "Nurse", If(rbtnR.Checked, "Sanato", "All"))
        displayDgvPatientContact(type)
    End Sub

    Private Sub dgvPatientContact_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPatientContact.EditingControlShowing
        If TypeOf e.Control Is DataGridViewTextBoxEditingControl Then
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)

            '選択行index
            Dim selectedRowIndex As Integer = dgv.CurrentCell.RowIndex
            '選択列index
            Dim selectedColumnIndex As Integer = dgv.CurrentCell.ColumnIndex

            Dim tb As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)
            tb.ImeMode = Windows.Forms.ImeMode.Hiragana
            If selectedColumnIndex = 12 Then '移動手段列
                tb.ImeMode = Windows.Forms.ImeMode.Disable
            End If
        End If
    End Sub
End Class