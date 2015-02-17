Option Explicit On
Option Strict On

Public Class Regler
    '# Klasse eines PID Regler;
    Private DeviationErrorSum As Double 'Fehlersumme der Abweichung
    Private Deviation_t_k As Double 'berechnete Abweichung vom Sollwert
    Private Deviation_t_k1 As Double 'vorg�nger Wert f�r die Abweichung
    Private st_Reg As New SE2010StrukturSchablonen.Regelparameter '�bergebene Regelparameter
    Private delta_t As Double 'Schrittweite zwischen 2 Regelungen
    Private t_k As Double 'Temperatur des K�hlmittels
    Private ActVar_t_k As Double 'Wert f�r die Stellgr��e
    Private ActVar_t_k1 As Double 'vorg�nger Wert f�r die Stellgr��e

    '#PID- Regler; Konstruktor
    Public Sub New(ByVal _st_Reg As SE2010StrukturSchablonen.Regelparameter, ByVal _delta_t As Double, ByVal _t_k As Double, ByVal _ActVar As Double)
        delta_t = _delta_t
        t_k = _t_k
        ActVar_t_k = _ActVar
        ActVar_t_k1 = _ActVar
        st_Reg = _st_Reg

    End Sub

    '# Regelroutine; PID
    '# @param[in] _is Istwert der Regelgr��e
    '# @param[in] _must Sollwert der Regelgr��e
    '# @return Neue Stellgr��e
    Public Function NewActVar(ByVal _is As Double, ByVal _must As Double) As Double
        Deviation_t_k = _must - _is
        DeviationErrorSum += Deviation_t_k

        '# Berechnung und Skalierung
        ActVar_t_k = st_Reg.kp * Deviation_t_k + st_Reg.ki * DeviationErrorSum * delta_t + st_Reg.kd * ((Deviation_t_k - Deviation_t_k1) / delta_t)
        ActVar_t_k /= 100

        Deviation_t_k1 = Deviation_t_k

        '# kontrolliere die Grenzen
        If ActVar_t_k > 0.5 Then ActVar_t_k = 0.5
        If ActVar_t_k < -0.5 Then ActVar_t_k = -0.5

        If _is > t_k Then ActVar_t_k = (-1) * ActVar_t_k

        ActVar_t_k = 0.5 + ActVar_t_k

        Return ActVar_t_k
    End Function
End Class