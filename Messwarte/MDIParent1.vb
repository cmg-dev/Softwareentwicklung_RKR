Option Explicit On
Option Strict On

Imports System.Windows.Forms

Public Class MesswarteMDI
    Private m_ChildFormNumber As Integer

    Private Sub LeitstandVater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'starte mich im maximierten Fenster
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ShowNewRuehrkessel(ByVal sender As Object, ByVal e As EventArgs) Handles NewRuehrkessel.Click
        Try
            Dim MesswarteChildForm As New Messwarte()
            ' Vor der Anzeige dem MDI-Formular unterordnen.
            MesswarteChildForm.MdiParent = Me

            m_ChildFormNumber += 1
            MesswarteChildForm.Text = "Messwarte Rührkessel"
            '#insert exeption handling here
            MesswarteChildForm.Show()

        Catch ex As Exception
            MsgBox("Messwarte konnte nicht erstellt werden: " + vbCrLf + ex.Message.ToString)

        End Try

    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel.Click


    End Sub
End Class
