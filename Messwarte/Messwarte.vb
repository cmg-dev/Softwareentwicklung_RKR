Option Explicit On
Option Strict On

Public Class Messwarte
    Private PrgPath As String
    Private st_Prz As SE2010StrukturSchablonen.Prozess
    Private st_Reg As SE2010StrukturSchablonen.Regelparameter
    Private st_Par() As SE2010StrukturSchablonen.Parameter
    Private anzahl_dgl As Integer = 2

    '# Konstruktor
    Public Sub New()
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        '# Verarbeite den Programmpfad; entferne die letzten beiden Ordner
        Dim PP() As String = My.Application.Info.DirectoryPath.Split(CChar("\"))
        For i As Integer = 0 To PP.GetUpperBound(0) - 2
            PrgPath += PP(i) + "\"

        Next
        LblSimValuesOK.Visible = False
        LblSimValuesErr.Visible = False

        '# lege die Tooltips fest
        TT1.SetToolTip(TxtBxAusDat, "Doppelklick zum Dateiauswählen")
        TT1.SetToolTip(TxtBxParamDat, "Doppelklick zum Dateiauswählen")
        TT1.SetToolTip(TxtBxProzDat, "Doppelklick zum Dateiauswählen")
        TT1.SetToolTip(BttnOpenExcel, "Stelle die Ausgewählte Datei mit Excel dar")
        TT1.SetToolTip(BttnDisplayGraph, "Stelle die Ausgewählte Datei in einem Grafik Formular dar")
        TT1.SetToolTip(BttnStartKessel, "Starte die Simulation des Rührkesselreaktors")
        TT1.SetToolTip(TxtBxValueKI, "Regelparameter K_I; Kann angepasst werden und wird bei einer neuen Simulation automatisch übernommen")
        TT1.SetToolTip(TxtBxValueKD, "Regelparameter K_D; Kann angepasst werden und wird bei einer neuen Simulation automatisch übernommen")
        TT1.SetToolTip(TxtBxValueKP, "Regelparameter K_P; Kann angepasst werden und wird bei einer neuen Simulation automatisch übernommen")
        TT1.SetToolTip(BttnOpenAusDat, "Öffne die Parameterdatei in Notepad")
        TT1.SetToolTip(BttnOpenProzDat, "Öffne die Prozessdatei in Notepad")
        TT1.SetToolTip(BttnOpenParamDat, "Öffne die Ausgabedatei in Notepad")

    End Sub

    '# Einleseroutine des Parameterdatei; schreibt die Werte in die entsprechendes Struktur
    '# @return 1 -> Erfolg
    '# -1 -> Fehler; Werte nicht eingelesen
    Private Function ReadParamDatFromFile(ByVal File As String) As Integer
        Try
            Dim srParamDataIn As New IO.StreamReader(File)

            '# Kontrolle der erten Zeile
            If Not srParamDataIn.ReadLine() = "SOFTWAREENTWICKLUNG SS2010 PARAMETERDATEI" Then
                '# keine gültige Datei mit Parametern
                Return -1

            End If
            srParamDataIn.ReadLine() '2 zeilen leer

            With st_Prz
                .alpha = CDbl(srParamDataIn.ReadLine())
                .beta = CDbl(srParamDataIn.ReadLine())
                .s = CDbl(srParamDataIn.ReadLine())
                .t_A = CDbl(srParamDataIn.ReadLine())
                .m_a = CDbl(srParamDataIn.ReadLine())
                .t_0 = CDbl(srParamDataIn.ReadLine())
                .m_ges = CDbl(srParamDataIn.ReadLine())
                .t_K = CDbl(srParamDataIn.ReadLine())
                .schrittweite = CInt(srParamDataIn.ReadLine())
                .integrationsschritte = CInt(srParamDataIn.ReadLine())
                .x_start = 0

            End With

            srParamDataIn.Close()

        Catch ex As Exception
            Return -1

        End Try
        Return 1

    End Function

    '# Einleseroutine der Prozessdatei; schreibt die Werte in die entsprechendes Struktur
    '# @return 1 -> Erfolg
    '# -1 -> Fehler; Werte nicht eingelesen
    Private Function ReadProzDatFromFile(ByVal File As String) As Integer
        Try
            Dim DataAmount As Integer
            Dim srProzDataIn As New IO.StreamReader(File)
            Dim _ReadLineValues() As String
            Dim FileData() As Double
            Dim step_length As Integer
            Dim i, j As Integer
            Dim schritte_insg As Integer

            '# Kontrolle der erten Zeile (Titel)
            If Not srProzDataIn.ReadLine().ToString = "SOFTWAREENTWICKLUNG SS2010 PROZESSDATEI" Then
                '# keine gültige Datei mit Parametern
                Return -1

            End If
            srProzDataIn.ReadLine()
            '# Lese die Regelparameter
            st_Reg.kp = CDbl(srProzDataIn.ReadLine())
            st_Reg.ki = CDbl(srProzDataIn.ReadLine())
            st_Reg.kd = CDbl(srProzDataIn.ReadLine())
            srProzDataIn.ReadLine() '1 zeile info

            ReDim FileData(0)
            '## Lese die Perameter Dynamisch aus der Datei
            While Not srProzDataIn.EndOfStream

                _ReadLineValues = srProzDataIn.ReadLine.Split(CChar(";"))

                If FileData.GetUpperBound(0) = 0 Then
                    ReDim Preserve FileData(_ReadLineValues.GetUpperBound(0))
                    FileData(0) = _ReadLineValues.Length

                Else
                    ReDim Preserve FileData((_ReadLineValues.Length + FileData.Length) - 1)
                End If

                '## Kopiere die gelesenen Werte nach FileData(); Für jede zeile Dynamisch
                For i = 1 To (_ReadLineValues.Length)
                    FileData(FileData.Length - _ReadLineValues.Length + i - 1) = CDbl(_ReadLineValues(i - 1))

                Next
                '# Kopieren Fertig
            End While
            '# Parameter einlesen Fertig

            step_length = _ReadLineValues.Length

            '# Bestimme die Dimension des Vektors st_Par()
            DataAmount = CInt((FileData.Length - 1) / _ReadLineValues.Length)

            ReDim Preserve st_Par(DataAmount)
            For j = 1 To DataAmount 'ProzessData Array in x,qk, ... arrays zerlegen

                st_Par(j).geregelt = CBool(FileData((step_length * j) - 5))
                st_Par(j).abtastanzahl = CInt(FileData((step_length * j) - 4))
                st_Par(j).x = FileData((step_length * j) - 3)
                st_Par(j).q_k = FileData((step_length * j) - 2)
                st_Par(j).t_soll = FileData((step_length * j) - 1)

            Next

            For i = 0 To DataAmount
                schritte_insg += st_Par(i).abtastanzahl

            Next

            srProzDataIn.Close()

        Catch ex As Exception
            Return -1

        End Try
        Return 1

    End Function

    '# Eventhandle Click von BttnLoadPrzDat
    Private Sub BttnLoadProzDat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnLoadProzDat.Click
        'Einlesen der Vorgegebenen Datei
        If ReadProzDatFromFile(TxtBxProzDat.Text) = 1 Then
            Call WriteParam2Display()

        Else
            MsgBox("Das ist keine Prozessdatei!")

        End If

    End Sub

    '# Eventhandle Click von BttnLoadParamDat
    Private Sub BttnLoadParamDat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnLoadParamDat.Click
        If ReadParamDatFromFile(CStr(TxtBxParamDat.Text)) = 1 Then
            Call WriteProzess2DataGrid()

        Else
            MsgBox("Das ist keine Parameterdatei!")

        End If

    End Sub

    '# Handle Click Event des Button BttnStartKessel startet die Berechnung des Rührkessels
    Private Sub BttnStartKessel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnStartKessel.Click
        Dim i, j, k, l As Integer

        Try
            Dim _st_par(st_Par.GetUpperBound(0)) As SE2010StrukturSchablonen.Parameter
            Dim swAusgabe As New IO.StreamWriter(CStr(TxtBxAusDat.Text))

            '##Erstelle Instanz und stelle die Anzahl der DGL`s ein
            Dim RKR As New Toaster(anzahl_dgl, st_Prz)

            Call checkRegParOnForm()
            ReDim _st_par(st_Par.GetUpperBound(0))
            Array.Copy(st_Par, _st_par, st_Par.Length)

            Dim R As New Regler(st_Reg, st_Prz.schrittweite, st_Prz.t_K, st_Par(1).q_k)

            '# schreibe die Regelparameter in die Datei
            With st_Reg
                swAusgabe.WriteLine(st_Reg.kp)
                swAusgabe.WriteLine(st_Reg.ki)
                swAusgabe.WriteLine(st_Reg.kd)

            End With
            '#Legende schreiben
            swAusgabe.WriteLine("t;ma;T(t);1000*Qk;100*x(t);t_soll(t)")
            '# Starte die Simulation des Kessels
            For i = 1 To _st_par.GetUpperBound(0)
                For j = 1 To CInt(_st_par(i).abtastanzahl)
                    If _st_par(i).geregelt = True Then
                        '# Berechne das neue q_k
                        _st_par(i).q_k = R.NewActVar(RKR.read_Temp_aktuell(), _st_par(i).t_soll)

                    End If
                    Call RKR.next_step(_st_par(i))

                    'schreibe in die Datei
                    swAusgabe.Write(CStr(st_Prz.schrittweite * l) & ";" & CStr(Math.Round(RKR.read_m_aktuell(), 2)) & ";" & CStr(Math.Round(RKR.read_Temp_aktuell(), 2)))
                    swAusgabe.WriteLine(";" & CStr(_st_par(i).q_k * 1000) & ";" & CStr(_st_par(i).x * 100) & ";" & CStr(_st_par(i).t_soll))

                    l += 1
                Next
                k += j - 1

            Next
            swAusgabe.Close()
            Call WriteSimRes2Display()

        Catch ex As Exception
            MsgBox("Simulation fehlgeschlagen :" + vbCrLf + ex.Message.ToString)

        End Try
    End Sub

    '# Sub überprüft, ob die Regelparameter durch Nutzereingabe geändert wurden; Übernimmt die neuen Parameter in st_Reg
    Private Sub checkRegParOnForm()
        Dim help As Integer

        LblSimValuesOK.Visible = False
        LblSimValuesErr.Visible = False
        Try
            '#wurden die Regelparameter in der Eingabemaske geändert??
            If CDbl(TxtBxValueKD.Text) <> st_Reg.kd Then
                st_Reg.kd = Math.Abs(CDbl(TxtBxValueKD.Text))
                TxtBxValueKD.Text = CStr(st_Reg.kd)
                help = 1

            End If
            If CDbl(TxtBxValueKI.Text) <> st_Reg.ki Then
                st_Reg.ki = Math.Abs(CDbl(TxtBxValueKI.Text))
                TxtBxValueKI.Text = CStr(st_Reg.ki)
                help = 1

            End If
            If CDbl(TxtBxValueKP.Text) <> st_Reg.kp Then
                st_Reg.kp = Math.Abs(CDbl(TxtBxValueKP.Text))
                TxtBxValueKP.Text = CStr(st_Reg.kp)
                help = 1

            End If

            If help = 1 Then
                LblSimValuesOK.Visible = True

            End If
        Catch ex As Exception
            LblSimValuesErr.Visible = True

        End Try
    End Sub

    '# lese Ergebnisse der Simulation aus der Textdatei und schreibe die Ergebnisse in das DataGrid- Element
    Private Sub WriteSimRes2Display()
        Dim i As Integer = 0
        Dim read() As String
        Dim srEin As New IO.StreamReader(CStr(TxtBxAusDat.Text))
        Dim srLC As New IO.StreamReader(CStr(TxtBxAusDat.Text))
        Dim lc As Integer = 0

        While Not srLC.EndOfStream
            srLC.ReadLine()
            lc += 1
        End While
        lc -= 4 '# beachte die Legende und die RegelParameter

        srLC.Close()
        Try
            srEin.ReadLine()
            srEin.ReadLine()
            srEin.ReadLine()
            read = srEin.ReadLine.Split(CChar(";")) 'Legende einlesen

            With DGVData
                .ColumnCount = 6
                .Columns(0).Name = read(0)
                .Columns(1).Name = read(1)
                .Columns(2).Name = read(2)
                .Columns(3).Name = read(3)
                .Columns(4).Name = read(4)
                .Columns(5).Name = read(5)
                .RowCount = lc
                i = 0
                While Not srEin.EndOfStream
                    read = srEin.ReadLine.Split(CChar(";"))
                    '("t;ma;T(t);1000*Qk;100*x(t);t_soll(t)") 
                    .Rows(i).Cells(0).Value = read(0)
                    .Rows(i).Cells(1).Value = read(1)
                    .Rows(i).Cells(2).Value = read(2)
                    .Rows(i).Cells(3).Value = read(3)
                    .Rows(i).Cells(4).Value = read(4)
                    .Rows(i).Cells(5).Value = read(5)
                    i += 1

                End While
            End With
            srEin.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

    '# schreibe die Prozessinformationen aus der st_Prz in das DataGrid- Element
    Private Sub WriteProzess2DataGrid()
        Try
            With DGVData
                .ColumnCount = 10
                .Columns(0).Name = "Alpha"
                .Columns(1).Name = "Beta"
                .Columns(2).Name = "S"
                .Columns(3).Name = "Ta"
                .Columns(4).Name = "ma"
                .Columns(5).Name = "T0"
                .Columns(6).Name = "mges"
                .Columns(7).Name = "Tk"
                .Columns(8).Name = "Abtastzeit"
                .Columns(9).Name = "Integrationsschritte"
                .RowCount = 1
                .Rows(0).Cells(0).Value = CStr(st_Prz.alpha)
                .Rows(0).Cells(1).Value = CStr(st_Prz.beta)
                .Rows(0).Cells(2).Value = CStr(st_Prz.s)
                .Rows(0).Cells(3).Value = CStr(st_Prz.t_A)
                .Rows(0).Cells(4).Value = CStr(st_Prz.m_a)
                .Rows(0).Cells(5).Value = CStr(st_Prz.t_0)
                .Rows(0).Cells(6).Value = CStr(st_Prz.m_ges)
                .Rows(0).Cells(7).Value = CStr(st_Prz.t_K)
                .Rows(0).Cells(8).Value = CStr(st_Prz.schrittweite)
                .Rows(0).Cells(9).Value = CStr(st_Prz.integrationsschritte)

                TxtBxAlpha.Text = CStr(st_Prz.alpha)
                TxtBxBeta.Text = CStr(st_Prz.beta)
                TxtBxS.Text = CStr(st_Prz.s)
                TxtBxTa.Text = CStr(st_Prz.t_A)
                TxtBxMa.Text = CStr(st_Prz.m_a)
                TxtBxt0.Text = CStr(st_Prz.t_0)
                TxtBxMges.Text = CStr(st_Prz.m_ges)
                TxtBxTk.Text = CStr(st_Prz.t_K)
                TxtBxAbtastzeit.Text = CStr(st_Prz.schrittweite)
                TxtBxIntN.Text = CStr(st_Prz.integrationsschritte)

            End With
        Catch ex As Exception
            'do nothing

        End Try
    End Sub

    '# schreibe die Parameter aus der st_Par in das DataGrid- Element
    Private Sub WriteParam2Display()
        Try
            With DGVData
                .ColumnCount = 5
                .RowCount = st_Par.GetUpperBound(0)
                .Columns(0).Name = "Geregelt [Ja/ Nein]"
                .Columns(1).Name = "Abtastanzahl"
                .Columns(2).Name = "x_t [kg/s]"
                .Columns(3).Name = "Q_k [0..1]"
                .Columns(4).Name = "t_soll [K]"

                For i As Integer = 0 To st_Par.GetUpperBound(0) - 1

                    If CInt(st_Par(i + 1).geregelt) = 0 Then
                        .Rows(i).Cells(0).Value = "Nein"
                    Else
                        .Rows(i).Cells(0).Value = "Ja"
                    End If
                    .Rows(i).Cells(1).Value = CStr(st_Par(i + 1).abtastanzahl)
                    .Rows(i).Cells(2).Value = CStr(st_Par(i + 1).x)
                    .Rows(i).Cells(3).Value = CStr(st_Par(i + 1).q_k)
                    .Rows(i).Cells(4).Value = CStr(st_Par(i + 1).t_soll)

                Next
            End With

            With st_Reg
                TxtBxValueKP.Text = CStr(.kp)
                TxtBxValueKI.Text = CStr(.ki)
                TxtBxValueKD.Text = CStr(.kd)

            End With
        Catch ex As Exception
            'do nothing

        End Try
    End Sub

    '# Startet einen Prozess Notepad.exe; Öffnet die Datein in _File darin
    Private Sub FileOpenNotepad(ByVal _File As String)
        Try
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "Notepad.exe"
            myProcess.StartInfo.Arguments = _File
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            myProcess.Start()
            myProcess.WaitForExit()

        Catch ex As Exception
            MsgBox("Fehler beim Öffnen des Editors")

        End Try

    End Sub

    '# Handle Click Event des Buttons BttnOpenParamDat(öffnet "Open File Dialog")
    Private Sub BttnOpenParamDat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnOpenParamDat.Click
        FileOpenNotepad(TxtBxParamDat.Text)

    End Sub

    '# Handle Click Event des Buttons BttnOpenProzDat (öffnet "Open File Dialog")
    Private Sub BttnOpenProzDat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnOpenProzDat.Click
        FileOpenNotepad(TxtBxProzDat.Text)

    End Sub

    '# Handle Click Event des Buttons BttnOpenAusDat (öffnet "Open File Dialog")
    Private Sub BttnOpenAusDat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnOpenAusDat.Click
        FileOpenNotepad(TxtBxAusDat.Text)

    End Sub

    '# Handle Click Event; Öffnet "Open File Dialog"; Wenn möglich verkürze den Dateipfad
    Private Sub TxtBxParamDat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBxParamDat.DoubleClick
        OFD_MW.ShowDialog()
        TxtBxParamDat.Text = OFD_MW.FileName
        ' kürze des Dateipfad, wenn möglich
        TxtBxParamDat.Text = trimDateiPfad(TxtBxParamDat.Text)

    End Sub

    '# Handle Click Event; Öffnet "Open File Dialog"; Wenn möglich verkürze den Dateipfad
    Private Sub TxtBxProzDat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBxProzDat.DoubleClick
        OFD_MW.ShowDialog()
        TxtBxProzDat.Text = OFD_MW.FileName
        TxtBxProzDat.Text = trimDateiPfad(TxtBxProzDat.Text)
    End Sub

    '# Handle Click Event; Öffnet "Open File Dialog"; Wenn möglich verkürze den Dateipfad
    Private Sub TxtBxAusDat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBxAusDat.DoubleClick
        OFD_MW.ShowDialog()
        TxtBxAusDat.Text = OFD_MW.FileName
        TxtBxAusDat.Text = trimDateiPfad(TxtBxAusDat.Text)

    End Sub

    '# Entfernt den Programmpfad von dem Dateipfad sofern möglich
    Private Function trimDateiPfad(ByVal _Path As String) As String
        If _Path.Contains(PrgPath) Then
            trimDateiPfad = "..\..\" + _Path.Remove(0, PrgPath.Length)

        Else
            trimDateiPfad = _Path
        End If

        Return trimDateiPfad
    End Function

    '# Öffnet eine Instanz der GrafikForm- Klasse und Exportiert die Ergebnisse der Simulation nach Excel 
    Private Sub BttnOpenExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnOpenExcel.Click
        Dim ExcelFo As New GrafikForm(Me.TxtBxAusDat.Text)
        Try
            Call ExcelFo.showInExcel()

        Catch ex As Exception
            MsgBox("Excel öffnen fehlgeschlagen: " + vbCrLf + ex.Message.ToString)

        Finally
            ExcelFo = Nothing
            GC.Collect()

        End Try
    End Sub

    '# Öffnet eine Instanz der GrafikForm- Klasse und Stellt diese interaktiv in einem Formular dar
    Private Sub BttnDisplayGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnDisplayGraph.Click
        Dim GraFo As New GrafikForm(Me.TxtBxAusDat.Text)
        Try
            Call GraFo.showInForm()

        Catch ex As Exception
            MsgBox("Grafik Augabe aufrgrund folgenden Fehlers nicht möglich: " + vbCrLf + ex.Message.ToString)

        Finally
            GraFo = Nothing
            GC.Collect()

        End Try
    End Sub

End Class
