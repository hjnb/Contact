Public Class TopForm

    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\Contact.mdb"
    Public DB_Contact As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    'エクセルのパス
    Public excelFilePass As String = My.Application.Info.DirectoryPath & "\Contact.xls"

    '.iniファイルのパス
    Public iniFilePath As String = My.Application.Info.DirectoryPath & "\Contact.ini"

    '画像パス
    'Public imageFilePath As String = My.Application.Info.DirectoryPath & "\Contact.PNG"

    'Patientのデータベースパス
    Public dbPatientFilePath As String = Util.getIniString("System", "PatientDir", iniFilePath) & "\Patient.mdb"
    Public DB_Patient As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPatientFilePath

    'Personのデータベースパス
    Public dbPersonFilePath As String = Util.getIniString("System", "PersonDir", iniFilePath) & "\Person.mdb"
    Public DB_Person As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPersonFilePath

    '各フォーム
    Private patientContactForm As 患者連絡先
    Private staffContactForm As 職員連絡網改

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データベース、エクセル、構成ファイルの存在チェック
        If Not System.IO.File.Exists(iniFilePath) Then
            MsgBox("構成ファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("Contactデータベースファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If
        If Not System.IO.File.Exists(dbPatientFilePath) Then
            MsgBox("Patientデータベースファイルが存在しません。" & Environment.NewLine & "iniファイルのPatientDirに適切なパスを設定して下さい。")
            Me.Close()
            Exit Sub
        End If
        If Not System.IO.File.Exists(dbPersonFilePath) Then
            MsgBox("Personデータベースファイルが存在しません。" & Environment.NewLine & "iniファイルのPersonDirに適切なパスを設定して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(excelFilePass) Then
            MsgBox("エクセルファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' 入院患者様連絡先ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPatientContact_Click(sender As System.Object, e As System.EventArgs) Handles btnPatientContact.Click
        If IsNothing(patientContactForm) OrElse patientContactForm.IsDisposed Then
            patientContactForm = New 患者連絡先()
            patientContactForm.Owner = Me
            patientContactForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 職員連絡網ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnStaffContact_Click(sender As System.Object, e As System.EventArgs) Handles btnStaffContact.Click
        If IsNothing(staffContactForm) OrElse staffContactForm.IsDisposed Then
            staffContactForm = New 職員連絡網改()
            staffContactForm.Owner = Me
            staffContactForm.Show()
        End If
    End Sub
End Class
