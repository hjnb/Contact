﻿Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class 職員連絡網

    'データグリッドビュー配列
    Private dgvArray() As DataGridView

    '選択者情報保持用
    Private selectedName As String
    Private selectedTel1 As String
    Private selectedTel2 As String

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 職員連絡網_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データグリッドビュー
        dgvArray = {dgvContactA1, dgvContactA2, dgvContactB1, dgvContactB2, dgvContactB3, dgvContactB4, dgvContactB5, dgvContactC1, dgvContactC2, dgvContactC3, dgvContactC4, dgvContactC5, dgvContactD1, dgvContactD2, dgvContactD3, dgvContactD4, dgvContactD5, dgvContactE1, dgvContactE2, dgvContactE3, dgvContactE4, dgvContactE5}

        '印刷ラジオボタンの初期設定
        initPrintState()

        '在職職員リスト初期設定
        initDgvStaff()

        '連絡網dgv初期設定
        initDgvContact()

        '連絡網データ表示
        displayDgvContact()

        '各データグリッドビューのイベント設定
        setEvent()
    End Sub

    ''' <summary>
    ''' イベント設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub setEvent()
        For Each dgv As DataGridView In dgvArray
            AddHandler dgv.CellEnter, AddressOf dgvContact_CellEnter
            AddHandler dgv.GotFocus, AddressOf dgvContact_GotFocus
            AddHandler dgv.CellMouseClick, AddressOf dgvContact_CellMouseClick
            AddHandler dgv.CellPainting, AddressOf dgvContact_CellPainting
        Next
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
        For Each dgv As DataGridView In dgvArray
            Util.EnableDoubleBuffering(dgv)

            With dgv
                .AllowUserToAddRows = False '行追加禁止
                .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
                .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
                .AllowUserToDeleteRows = False '行削除禁止
                .BorderStyle = BorderStyle.None
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.CellSelect
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersVisible = False
                .RowHeadersVisible = False
                .RowTemplate.Height = 20
                .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
                .ShowCellToolTips = False
                .EnableHeadersVisualStyles = False
                .Font = New Font("ＭＳ Ｐゴシック", 12)
                .ReadOnly = False
            End With

            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("Info", GetType(String))
            For i As Integer = 0 To 3
                dt.Rows.Add(dt.NewRow())
            Next

            '表示
            dgv.DataSource = dt
            dgv.ClearSelection()
            dgv.CurrentCell = Nothing

            '幅設定等
            With dgv
                '列設定
                With .Columns("Info")
                    .Width = 120
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
                '1行目設定
                .Rows(0).Height = 18
                .Rows(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Rows(0).DefaultCellStyle.Font = New Font("ＭＳ Ｐゴシック", 9)
                '2行目設定
                .Rows(1).Height = 35
                '3,4行目設定
                .Rows(2).Height = 22
                .Rows(2).DefaultCellStyle.Font = New Font("ＭＳ Ｐゴシック", 10)
                .Rows(3).Height = 22
                .Rows(3).DefaultCellStyle.Font = New Font("ＭＳ Ｐゴシック", 10)
            End With
        Next

    End Sub

    ''' <summary>
    ''' データグリッドビュー入力クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        For Each dgv As DataGridView In dgvArray
            dgv("Info", 0).Value = ""
            dgv("Info", 1).Value = ""
            dgv("Info", 2).Value = ""
            dgv("Info", 3).Value = ""
        Next
        clearSelection()
    End Sub

    ''' <summary>
    ''' データグリッドビュー選択クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearSelection(Optional exceptionDgvName As String = "")
        For Each dgv As DataGridView In dgvArray
            If dgv.Name = exceptionDgvName Then
                Continue For
            End If
            dgv.ClearSelection()
            dgv.CurrentCell = Nothing
        Next
    End Sub

    ''' <summary>
    ''' 連絡網データ表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayDgvContact()
        '入力データクリア
        clearInput()

        'データ取得
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Contact)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Area, Nam, Tel1, Tel2, Syo from Contact order by Area"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        While Not rs.EOF
            '場所名
            Dim area As String = Util.checkDBNullValue(rs.Fields("Area").Value)

            '表示対象のデータグリッドビュ－
            Dim dgv As DataGridView = DirectCast(Controls("dgvContact" & area), DataGridView)

            'データ表示
            dgv("Info", 0).Value = Util.checkDBNullValue(rs.Fields("Syo").Value) '所属等
            dgv("Info", 1).Value = Util.checkDBNullValue(rs.Fields("Nam").Value) '氏名
            dgv("Info", 2).Value = Util.checkDBNullValue(rs.Fields("Tel1").Value) '電話番号1
            dgv("Info", 3).Value = Util.checkDBNullValue(rs.Fields("Tel2").Value) '電話番号2

            rs.MoveNext()
        End While
        rs.Close()
        cnn.Close()

        clearSelection()
    End Sub

    ''' <summary>
    ''' 連絡網データグリッドビューCellMouseClickイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContact_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 AndAlso selectedName <> "" Then
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)
            '選択者情報をセット
            '氏名
            dgv("Info", 1).Value = selectedName
            'Tel1
            dgv("Info", 2).Value = selectedTel1
            'Tel2
            dgv("Info", 3).Value = selectedTel2
            '所属等消す
            dgv("Info", 0).Value = ""

            '選択者情報クリア
            selectedName = ""
            selectedTel1 = ""
            selectedTel2 = ""
            dgvStaff.ClearSelection()
        End If
    End Sub

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContact_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
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
    ''' 在職職員リストCellMouseClickイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvStaff_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvStaff.CellMouseClick
        If e.RowIndex >= 0 Then
            '氏名
            selectedName = Util.checkDBNullValue(dgvStaff("Nam", e.RowIndex).Value)
            '電話番号1
            selectedTel1 = Util.checkDBNullValue(dgvStaff("Tel1", e.RowIndex).Value)
            '電話番号2
            selectedTel2 = Util.checkDBNullValue(dgvStaff("Tel2", e.RowIndex).Value)

            '各dgvの選択解除
            clearSelection()
        End If
    End Sub

    ''' <summary>
    ''' データグリッドビューGotFocusイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContact_GotFocus(sender As Object, e As System.EventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        clearSelection(dgv.Name)
    End Sub

    ''' <summary>
    ''' セルエンターイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvContact_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        '選択行によってIMEの設定
        If e.RowIndex = 0 OrElse e.RowIndex = 1 Then
            dgv.ImeMode = Windows.Forms.ImeMode.Hiragana
        Else
            dgv.ImeMode = Windows.Forms.ImeMode.Disable
        End If
    End Sub

    ''' <summary>
    ''' 選択解除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClearSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnClearSelect.Click
        '選択者情報クリア
        selectedName = ""
        selectedTel1 = ""
        selectedTel2 = ""
        dgvStaff.ClearSelection()
    End Sub

    ''' <summary>
    ''' 入力クリアボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInputClear_Click(sender As System.Object, e As System.EventArgs) Handles btnInputClear.Click
        clearInput()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        '登録確認
        Dim result As DialogResult = MessageBox.Show("現在の内容で登録してよろしいですか？", "登録", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Dim cnn As New ADODB.Connection
            cnn.Open(TopForm.DB_Contact)

            '削除
            Dim cmd As New ADODB.Command()
            cmd.ActiveConnection = cnn
            cmd.CommandText = "delete from Contact"
            cmd.Execute()

            '登録
            Dim rs As New ADODB.Recordset
            rs.Open("Contact", cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
            For Each dgv As DataGridView In dgvArray
                Dim area As String = dgv.Name.Substring(dgv.Name.Length - 2, 2)
                Dim syo As String = Util.checkDBNullValue(dgv("Info", 0).Value)
                Dim nam As String = Util.checkDBNullValue(dgv("Info", 1).Value)
                Dim tel1 As String = Util.checkDBNullValue(dgv("Info", 2).Value)
                Dim tel2 As String = Util.checkDBNullValue(dgv("Info", 3).Value)

                rs.AddNew()
                rs.Fields("Area").Value = area
                rs.Fields("Nam").Value = nam
                rs.Fields("Tel1").Value = tel1
                rs.Fields("Tel2").Value = tel2
                rs.Fields("Syo").Value = syo
            Next
            rs.Update()
            rs.Close()
            cnn.Close()

            clearSelection()
        End If
    End Sub

    ''' <summary>
    ''' 印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        '登録データ取得
        Dim infoDic As New Dictionary(Of String, String(,))
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Contact)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Area, Nam, Tel1, Tel2, Syo from Contact order by Area"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        While Not rs.EOF
            Dim area As String = Util.checkDBNullValue(rs.Fields("Area").Value)
            Dim infoArray(3, 0) As String
            infoArray(0, 0) = Util.checkDBNullValue(rs.Fields("Syo").Value)
            infoArray(1, 0) = Util.checkDBNullValue(rs.Fields("Nam").Value)
            infoArray(2, 0) = Util.checkDBNullValue(rs.Fields("Tel1").Value)
            infoArray(3, 0) = Util.checkDBNullValue(rs.Fields("Tel2").Value)
            infoDic.Add(area, infoArray.Clone())
            rs.MoveNext()
        End While
        rs.Close()
        cnn.Close()

        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePass)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("緊急連絡網")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '日付
        Dim nowYmd As String = DateTime.Now.ToString("yyyy/MM/dd")
        oSheet.Range("T2").Value = nowYmd & "現在"

        'データ書き込み
        '1番上
        oSheet.Range("L6", "P9").Value = infoDic("A1")
        '2番目
        oSheet.Range("L12", "P15").Value = infoDic("A2")
        '1列目
        For i As Integer = 0 To 4
            oSheet.Range("C" & (18 + i * 5), "G" & (21 + i * 5)).Value = infoDic("B" & (i + 1))
        Next
        '2列目
        For i As Integer = 0 To 4
            oSheet.Range("I" & (18 + i * 5), "M" & (21 + i * 5)).Value = infoDic("C" & (i + 1))
        Next
        '3列目
        For i As Integer = 0 To 4
            oSheet.Range("O" & (18 + i * 5), "S" & (21 + i * 5)).Value = infoDic("D" & (i + 1))
        Next
        '4列目
        For i As Integer = 0 To 4
            oSheet.Range("U" & (18 + i * 5), "Y" & (21 + i * 5)).Value = infoDic("E" & (i + 1))
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
End Class