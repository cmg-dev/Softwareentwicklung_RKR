Option Strict Off
Option Explicit On

Public Class GrafikForm
    Private Structure PictureBoxInfo
        Dim xmax As Double
        Dim xmin As Double
        Dim ymax As Double
        Dim ymin As Double
        Dim zoom_ende As Integer
        Dim zoom_anfang As Integer
        Dim sx, sy, dx, dy As Double
        Dim delta_x As Double
        Dim delta_y As Double
        Dim xkor As Double
        Dim ykor As Double

    End Structure

    '#Strukturen!
    '# Struktur sammelt die Datenpunkte X/ Y der Graphen die gezeichnet werden sollen
    Private Structure Graphen
        Dim Legende As String
        Dim AnzahlDatenpunkte As Integer
        Dim schrittweite As Integer
        Dim Datenpunkte() As PointF
        Dim Zeichendaten() As PointF

    End Structure

    Private gfx As System.Drawing.Graphics
    Private Graphs() As Graphen
    Private PicBxInfo As PictureBoxInfo

    Public Sub New(ByVal dat As String)
        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()
        PicBxInfo.ykor = 0.995
        PicBxInfo.xkor = 0.995
        Call ReadFromInputFile(dat)

    End Sub

    Public Sub showInExcel()
        export2excel()

    End Sub

    Public Sub showInForm()
        TxtBxLeg0.Text = Graphs(0).Legende
        TxtBxLeg0.BackColor = Color.Blue
        TxtBxLeg1.Text = Graphs(1).Legende
        TxtBxLeg1.BackColor = Color.Black
        TxtBxLeg2.Text = Graphs(2).Legende
        TxtBxLeg2.BackColor = Color.Purple
        TxtBxLeg3.Text = Graphs(3).Legende
        TxtBxLeg3.BackColor = Color.Green
        TxtBxLeg4.Text = Graphs(4).Legende
        TxtBxLeg4.BackColor = Color.Red

        PicBxInfo.zoom_ende = Graphs(0).AnzahlDatenpunkte
        PicBxInfo.zoom_anfang = 0
        Me.TxtBxZoomEnd.Text = CStr(Graphs(0).AnzahlDatenpunkte * Graphs(0).schrittweite)

        Call MinMaxFromGraphs()
        Me.Show()

    End Sub

    '# Funktion liefet die Anzahl der Zeilen in der in _File angegebenen Datei zurück
    Private Function FileCountLines(ByVal _File As String) As Integer
        Try
            Dim srLineCount As New IO.StreamReader(_File)

            While Not srLineCount.EndOfStream
                srLineCount.ReadLine()
                FileCountLines += 1

            End While
            srLineCount.Close()
            Return FileCountLines

        Catch ex As Exception
            'do nothing

        End Try
    End Function

    Private Sub MinMaxFromGraphs()
        Dim i As Integer = 0
        Dim j As Integer = 0
        With PicBxInfo
            .xmin = Double.MaxValue
            .xmax = Double.MinValue
            .ymin = Double.MaxValue
            .ymax = Double.MinValue

            '# suche in dem Intervall [zoom_anfang, zoom_ende] nach Min-/ Maximum
            .xmin = Graphs(0).Datenpunkte(.zoom_anfang).X
            .xmax = Graphs(0).Datenpunkte(.zoom_ende).X

            For i = .zoom_anfang To .zoom_ende
                For j = 0 To Graphs.GetUpperBound(0)
                    '# Finde t Minimum; t steht in der 0. Dimension
                    '# Finde das y Minimum
                    If Graphs(j).Datenpunkte(i).Y < .ymin Then
                        .ymin = Graphs(j).Datenpunkte(i).Y

                    End If
                    If Graphs(j).Datenpunkte(i).Y > .ymax Then
                        .ymax = Graphs(j).Datenpunkte(i).Y

                    End If
                Next
            Next
            '#+10% -> verbessert die Anzeige
            .ymax += .ymax * 0.1
            .ymin -= .ymin * 0.1

            '# gefundenen Min-/ Maxwerte anzeigen
            TxtBxXMin.Text = "xmin: " & CStr(.xmin)
            TxtBxXMax.Text = "xmax: " & CStr(.xmax)
            TxtBxYMin.Text = "ymin: " & CStr(.ymin)
            TxtBxYMax.Text = "ymax: " & CStr(.ymax)
        End With


    End Sub

    Private Function fx(ByVal x As Double) As Integer
        Try
            With PicBxInfo
                .delta_x = .xmax - .xmin
                .sx = (PicBxMesswerte.Width * .xkor) / .delta_x
                .dx = .xmin
                Return CInt(((x - .dx) * .sx))

            End With
        Catch ex As Exception
            'do nothing
        End Try

    End Function

    Private Function fy(ByVal y As Double) As Integer
        Try
            With PicBxInfo
                .delta_y = .ymax - .ymin
                .sy = (PicBxMesswerte.Height * .ykor) / .delta_y
                .dy = .ymin
                Return CInt(-(y - .dy) * .sy + (PicBxMesswerte.Height * .ykor))

            End With
        Catch ex As Exception
            'do nothing
        End Try
    End Function

    Private Sub ReadFromInputFile(ByVal dat As String)
        Try
            Dim LineCount As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim sr1 As New IO.StreamReader(dat)
            '# zähle die Zeilen/ Datensätze
            LineCount = FileCountLines(dat)

            '# An die Legende denken sowie letzte Leerzeile wegen WriteLine()
            LineCount -= 5
            sr1.Close()

            Dim sr2 As New IO.StreamReader(dat)
            Dim Line() As String
            LblTitel.Text = "Softwareentwicklung SS 2010 K_p: " + "{" + sr2.ReadLine() + "}"
            LblTitel.Text += " K_i: " + "{" + sr2.ReadLine() + "}"
            LblTitel.Text += " K_d: " + "{" + sr2.ReadLine() + "}"

            Line = sr2.ReadLine.Split(CChar(";"))

            '# neudimensionieren (dynamisch) der Graphs Struct
            '# -1 da die erste Spalte die x- Werte enthält
            ReDim Graphs(Line.GetUpperBound(0) - 1)
            '# lese Legend aus 1. Zeile der Datei
            '###t;ma;T(t);1000*Qk;100*x(t);t_soll(t)
            For i = 0 To Graphs.GetUpperBound(0)
                Graphs(i).Legende = Line(i + 1)

            Next
            '# dynamische Datenpunkt Dimensionierung
            For i = 0 To Graphs.GetUpperBound(0)
                ReDim Graphs(i).Datenpunkte(LineCount)

            Next
            '#einlesen der Datenpunkte aus den Spalten der Textdatei
            For i = 0 To LineCount
                Line = sr2.ReadLine.Split(CChar(";"))

                For j = 0 To Graphs.GetUpperBound(0)
                    Graphs(j).Datenpunkte(i).Y = CSng(Line(j + 1))
                    Graphs(j).Datenpunkte(i).X = CSng(Line(0))

                Next
                j = 0
            Next
            For i = 0 To Graphs.GetUpperBound(0)
                Graphs(i).AnzahlDatenpunkte = LineCount
                '# Schrittweite zwischen 2 Datenpunkten ermitteln
                Graphs(i).schrittweite = CInt(Graphs(i).Datenpunkte(LineCount).X / LineCount)

            Next
        Catch ex As Exception
            'do nothing

        End Try
    End Sub

    Private Sub prepare4draw(ByVal size As Integer)
        For j As Integer = 0 To Graphs.GetUpperBound(0)
            ReDim Graphs(j).Zeichendaten(size)

        Next
        '# Kopiere die Datengrundlage auf die Zeichnungsdaten
        For j As Integer = 0 To Graphs.GetUpperBound(0)
            For i As Integer = 0 To size
                Graphs(j).Zeichendaten(i).X = fx(Graphs(j).Datenpunkte(PicBxInfo.zoom_anfang + i).X)
                Graphs(j).Zeichendaten(i).Y = fy(Graphs(j).Datenpunkte(PicBxInfo.zoom_anfang + i).Y)

            Next
        Next
    End Sub

    Private Sub PicBxMesswerte_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PicBxMesswerte.Paint
        Dim pen(Graphs.GetUpperBound(0)) As Pen
        pen(0) = New Pen(TxtBxLeg0.BackColor, CSng(1))
        pen(1) = New Pen(TxtBxLeg1.BackColor, CSng(1))
        pen(2) = New Pen(TxtBxLeg2.BackColor, CSng(1))
        pen(3) = New Pen(TxtBxLeg3.BackColor, CSng(1))
        pen(4) = New Pen(TxtBxLeg4.BackColor, CSng(1))

        gfx = e.Graphics
        gfx.Clear(Me.BackColor)

        Call MinMaxFromGraphs()
        Call prepare4draw(PicBxInfo.zoom_ende - PicBxInfo.zoom_anfang)

        For k As Integer = 0 To Graphs.GetUpperBound(0)
            gfx.DrawLines(Pen(k), Graphs(k).Zeichendaten)

        Next
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBxMesswerte.MouseMove
        Dim x_nonscaled As Integer

        Try
            With PicBxInfo
                TxtBxAktX.Text = CStr(CInt((e.X / .sx) + .dx))
                TxtBxAktY.Text = CStr(CInt((-e.Y + PicBxMesswerte.Height * .ykor) / .sy + .dy))
                x_nonscaled = CInt(TxtBxAktX.Text / Graphs(0).schrittweite)
                '# Regelabweichung ermitteln und in das entsprechende Feld eintragen
                TxtBxRegAbwVal.Text = CStr(Math.Round(Math.Abs(Graphs(4).Datenpunkte(x_nonscaled).Y - Graphs(1).Datenpunkte(x_nonscaled).Y), 2))

            End With
        Catch ex As Exception
            'do nothing

        End Try
    End Sub

    Private Sub ResetBxs()
        With PicBxInfo
            TxtBxZoomEnd.Text = .zoom_ende * Graphs(0).schrittweite
            TxtBxZoomEnd.BackColor = Color.White
            TxtBxZoomSt.Text = .zoom_anfang
            TxtBxZoomSt.BackColor = Color.White

        End With
    End Sub

    Private Sub PicBxMesswerte_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBxMesswerte.MouseDown
        '# e ist vom Typ MouseEventArgs
        If e.Button = Windows.Forms.MouseButtons.Right Then
            With PicBxInfo
                .zoom_anfang = 0
                .zoom_ende = Graphs(0).AnzahlDatenpunkte
                '#resete boxen
                Call resetBxs()

            End With
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then

            With PicBxInfo
                .zoom_anfang = CInt((e.X / .sx) + .dx)
                TxtBxZoomSt.Text = .zoom_anfang
                TxtBxZoomSt.BackColor = Color.BlueViolet
                .zoom_anfang = CInt(.zoom_anfang / Graphs(0).schrittweite)

            End With
        End If

    End Sub

    Private Sub PicBxMesswerte_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicBxMesswerte.MouseUp
        With PicBxInfo
            If e.Button = Windows.Forms.MouseButtons.Left Then
                .zoom_ende = CInt((e.X / .sx) + .dx)
                TxtBxZoomEnd.Text = .zoom_ende
                .zoom_ende = CInt(.zoom_ende / Graphs(0).schrittweite)

                '# Prüfe die Eingaben
                If ((.zoom_ende - .zoom_anfang) = 0) Then
                    .zoom_anfang = 0
                    .zoom_ende = Graphs(0).AnzahlDatenpunkte
                    Call ResetBxs()
                    Return

                ElseIf .zoom_anfang > .zoom_ende Then
                    Dim temp As Double
                    temp = .zoom_ende
                    .zoom_ende = .zoom_anfang
                    .zoom_anfang = temp
                    '# Tausche auch die Label aus
                    temp = CDbl(TxtBxZoomEnd.Text)
                    TxtBxZoomEnd.Text = TxtBxZoomSt.Text
                    TxtBxZoomSt.Text = CStr(temp)

                End If
                '# kontrolliere ob die obere und untere Grenzen eingehalten werden
                If .zoom_anfang < 0 Then
                    .zoom_anfang = 0
                    TxtBxZoomSt.Text = .zoom_anfang

                End If
                If .zoom_ende > Graphs(0).AnzahlDatenpunkte Then
                    .zoom_ende = Graphs(0).AnzahlDatenpunkte
                    TxtBxZoomEnd.Text = .zoom_ende * Graphs(0).schrittweite

                End If
                'TxtBxZoomSt.Text = .zoom_anfang
                TxtBxZoomEnd.BackColor = Color.BlueViolet

            End If
        End With
        PicBxMesswerte.Refresh()

    End Sub

    '# Beginn Excel Export
    Private Sub wert2excel(ByVal sheet As Object, ByVal zeile As Integer, ByVal spalte As Integer, ByVal matrix(,) As Object)
        sheet.Range(sheet.Cells(zeile, spalte), sheet.Cells(zeile + matrix.GetUpperBound(0) - 1, spalte + matrix.GetUpperBound(1) - 1 + 1)).value = matrix

    End Sub

    Private Sub export2excel()
        Dim i As Integer
        Dim OMat(,) As Object
        Dim legende() As String

        '# Objectmatrix + 1 da die Zeit in Excel Form übergeben wird
        ReDim OMat(Graphs(0).AnzahlDatenpunkte, Graphs.GetUpperBound(0) + 1)
        Call Create_Object_Matrix(OMat)

        ReDim legende(1)
        legende(0) = "t"

        For i = 0 To Graphs.GetUpperBound(0)
            ReDim Preserve legende(i + 1)
            legende(i + 1) = Graphs(i).Legende
        Next

        '#### EXCEL per sppätes Binden eingeführt
        Dim objExcelApp As Object = Nothing
        Dim objBooks As Object
        Dim objDataSheet As Object

        Try
            'erstelle Insantz von Excel
            objExcelApp = CreateObject("Excel.Application")
            objExcelApp.visible = True
            objBooks = objExcelApp.Workbooks.Add
            objDataSheet = objExcelApp.ActiveSheet

            '### Zugriff auf eine EXCEL-Zelle
            '### per 'objDataSheet.Cells(zeile,spalte).value = wert'
            For i = 0 To legende.GetUpperBound(0)
                objDataSheet.Cells(1, i + 1).value = legende(i)

            Next

            '### Zugriff auf einen Bereich (RANGE) in EXCEL; entspricht dem Einfügen unter EXCEL
            '### --> Call wert2excel(objDataSheet, Zeile, Spalte, matrix)
            '### --> Zeile und Spalte entspricht der Zelle in dem das Datenfeld beginnent eingefügt wird
            '### --> matrix ist eine 2D Matrix vom Datentyp Object, erster Datenwert an der Stelle (1,1)
            Call wert2excel(objDataSheet, 2, 1, OMat)

            '### zwischen 1. und 2. Zeile das Fenster teilen und fixieren 
            '### --> beim Scollen in Excel bleib dann die 1. Zeile stehen
            objDataSheet.Range("A2").Select()
            With objExcelApp.ActiveWindow
                .SplitColumn = 0
                .SplitRow = 1

            End With
            objExcelApp.ActiveWindow.FreezePanes = True
            ' 73 definiert Diagrammtyp: ScatterSmoothNoMarks
            Const xlXYScatterSmoothNoMarkers As Integer = 73
            ' 1 = Neues Datenblatt
            Const xlLocationAsNewSheet As Integer = 1
            ' schreibe in Spalte 2
            Const xlCols As Integer = 2
            Const xlCategoryX As Integer = 1
            Const xlPrimaryX As Integer = 1

            With objExcelApp.ActiveSheet.Parent.Charts.Add
                .PlotBy = xlCols
                .ChartType = xlXYScatterSmoothNoMarkers
                .SetSourceData(Source:=objDataSheet.Range("A:F"), PlotBy:=xlCols)
                .Location(Where:=xlLocationAsNewSheet, Name:="Diagramm 1")
                .HasTitle = True
                .ChartTitle.Text = "RKR 2010"
                .Axes(xlCategoryX, xlPrimaryX).HasTitle = True
                .Axes(xlCategoryX, xlPrimaryX).AxisTitle.Characters.Text = "t [s]"
                .Axes(2, 1).HasTitle = False

            End With

            objExcelApp.Visible = True
            objExcelApp.UserControl = True

        Catch ex As Exception
            Dim rc_msgbox As MsgBoxResult = MsgBox("Fehler bei der EXCEL Bindung!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "INFO")
            Try
                If objExcelApp IsNot Nothing Then
                    objExcelApp.ActiveWorkbook.Close(savechanges:=False)
                    objExcelApp.Quit()
                End If
            Catch _nullRefEx As NullReferenceException
                ' do nothing.
            Catch _ex As Exception
                ' do nothing.
            End Try

        Finally
            ' Räume auf
            objExcelApp = Nothing
            objBooks = Nothing
            objDataSheet = Nothing
            GC.Collect()

        End Try
    End Sub

    Private Sub Create_Object_Matrix(ByRef ObjMatrix(,) As Object)

        For m As Integer = 0 To Graphs(0).AnzahlDatenpunkte
            ObjMatrix(m, 0) = CObj(Graphs(0).Datenpunkte(m).X)

            For l As Integer = 0 To (Graphs.GetUpperBound(0))
                ObjMatrix(m, l + 1) = CObj(Graphs(l).Datenpunkte(m).Y)

            Next
        Next

    End Sub

    Private Sub PicBxMesswerte_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Resize
        PicBxMesswerte.Refresh()

    End Sub

    Private Sub BttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnClose.Click
        Me.Close()

    End Sub
End Class