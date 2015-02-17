Option Explicit On
Option Strict On

Public Class SE2010StrukturSchablonen
    '#Sammlung an Strukturschablonen; diese Strukturen sollen global 
    'mehreren Klassen des Programms zur Verfügung stehen
    '#Es soll ein möglichst einfacher Austausch der Kesselinformationen realisiert werden

    Public Structure Prozess
        '# Materialkonstanten
        Public s As Double
        Public alpha As Double
        Public t_A As Double
        Public t_0 As Double
        Public beta As Double
        Public t_K As Double
        Public m_ges As Double
        Public m_a As Double 'Masse Stoff A (Startwert)
        Public integrationsschritte As Integer
        Public abtastzeit As Integer
        Public schrittweite As Integer
        Public x_start As Integer 'idR =0

    End Structure

    'geregelter Modus 0=nein/1=ja ; Abtastanzahl ; x(t) ; qk ; TSoll
    Public Structure Parameter
        Public geregelt As Boolean 'Regelung Ja/ Nein
        Public x As Double 'Zufluss
        Public q_k As Double 'Kühlmittel Fluss
        Public t_soll As Double 'Temp soll
        Public abtastanzahl As Integer

    End Structure

    Public Structure Regelparameter
        Public kp As Double
        Public ki As Double
        Public kd As Double

    End Structure
End Class
