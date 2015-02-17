Option Explicit On
Option Strict On

Public Class Toaster
    Inherits SE2010.simulation

    'Dim ProzessData As Double
    'Anzahl DGL
    Private anzahl_dgl As Integer
    Private schritte_insg As Integer
    Private t_aktuell As Double
    Private m_aktuell As Double
    Private Temp_aktuell As Double
    'Schrittweite fuer das RK4-Verfahren
    Private delta_t As Double

    Private Prz As SE2010StrukturSchablonen.Prozess
    Private Par As SE2010StrukturSchablonen.Parameter

    '## Ueberschreiben der in der DLL vorhandenen derivs-Sub
    Protected Overrides Sub derivs(ByVal x As Double, ByVal y() As Double, ByVal dydx() As Double)
        '## Zufluss - Reaktionsverlust - Abfluss
        dydx(1) = Par.x - (Par.x * (y(1) / Prz.m_ges)) - (Prz.s * Math.Exp((-1) * (Prz.t_A / y(2))) * y(1))
        '## Temperaturanstieg
        dydx(2) = (Prz.alpha * Math.Exp((-1) * (Prz.t_A / y(2))) * y(1)) - (Prz.beta * Par.q_k * (y(2) - Prz.t_K))

    End Sub

    Public Function read_Temp_aktuell() As Double
        Return Temp_aktuell

    End Function

    Public Function read_m_aktuell() As Double
        Return m_aktuell

    End Function

    Public Sub next_step(ByVal _Par As SE2010StrukturSchablonen.Parameter)
        Par = _Par
        Try
            With Prz
                For j As Integer = 1 To Prz.integrationsschritte
                    y(1) = .m_a
                    y(2) = .t_0

                    'y : ist der Vektor der Länge n der Lösungsfunktionen des Differentialgleichungssystems bei x
                    'n : ist Anzahl der Differentialgleichungen.
                    'x : ist die aktuelle Stelle.
                    'h : ist die Integrationsschrittweite.
                    'yout  : ist der Vektor der Lösungsfunktionen des Differentialgleichungssystems bei x+h.
                    Call rk4(y, anzahl_dgl, t_aktuell, delta_t, yout)

                    '# kopiere die berechnungsergebnisse dynamisch
                    For i As Integer = 1 To anzahl_dgl
                        y(i) = yout(i)

                    Next
                    t_aktuell += delta_t
                    .m_a = yout(1)
                    .t_0 = yout(2)

                Next j
                Temp_aktuell = .t_0
                m_aktuell = .m_a

            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub New(ByVal value As Integer, ByVal _Prz As SE2010StrukturSchablonen.Prozess)
        anzahl_dgl = value
        Prz = _Prz
        delta_t = Prz.schrittweite / Prz.integrationsschritte
        Temp_aktuell = _Prz.t_0
        t_aktuell = 0

        ReDim y(anzahl_dgl)
        ReDim yout(anzahl_dgl)

    End Sub

    Public Sub set_anzahl_dgl(ByVal val As Integer)
        anzahl_dgl = Math.Abs(val)

    End Sub

    Public Sub Get_anzahl_dgl(ByRef val As Integer)
        val = anzahl_dgl

    End Sub
End Class
