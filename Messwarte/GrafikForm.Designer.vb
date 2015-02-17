<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrafikForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblXZoomEnde = New System.Windows.Forms.Label
        Me.lblXZoomStart = New System.Windows.Forms.Label
        Me.TxtBxZoomSt = New System.Windows.Forms.TextBox
        Me.TxtBxZoomEnd = New System.Windows.Forms.TextBox
        Me.TxtBxLeg3 = New System.Windows.Forms.TextBox
        Me.TxtBxLeg4 = New System.Windows.Forms.TextBox
        Me.PicBxMesswerte = New System.Windows.Forms.PictureBox
        Me.TxtBxLeg1 = New System.Windows.Forms.TextBox
        Me.TxtBxLeg2 = New System.Windows.Forms.TextBox
        Me.TxtBxLeg0 = New System.Windows.Forms.TextBox
        Me.LblTitel = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TxtBxAktY = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TxtBxAktX = New System.Windows.Forms.TextBox
        Me.TxtBxYMax = New System.Windows.Forms.TextBox
        Me.TxtBxYMin = New System.Windows.Forms.TextBox
        Me.TxtBxXMax = New System.Windows.Forms.TextBox
        Me.TxtBxXMin = New System.Windows.Forms.TextBox
        Me.BttnClose = New System.Windows.Forms.Button
        Me.TxtBxRegAbw = New System.Windows.Forms.TextBox
        Me.TxtBxRegAbwVal = New System.Windows.Forms.TextBox
        CType(Me.PicBxMesswerte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblXZoomEnde
        '
        Me.lblXZoomEnde.AutoSize = True
        Me.lblXZoomEnde.Location = New System.Drawing.Point(0, 221)
        Me.lblXZoomEnde.Name = "lblXZoomEnde"
        Me.lblXZoomEnde.Size = New System.Drawing.Size(72, 13)
        Me.lblXZoomEnde.TabIndex = 66
        Me.lblXZoomEnde.Text = "X Zoom Ende"
        '
        'lblXZoomStart
        '
        Me.lblXZoomStart.AutoSize = True
        Me.lblXZoomStart.Location = New System.Drawing.Point(-1, 177)
        Me.lblXZoomStart.Name = "lblXZoomStart"
        Me.lblXZoomStart.Size = New System.Drawing.Size(69, 13)
        Me.lblXZoomStart.TabIndex = 65
        Me.lblXZoomStart.Text = "X Zoom Start"
        '
        'TxtBxZoomSt
        '
        Me.TxtBxZoomSt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxZoomSt.Location = New System.Drawing.Point(2, 193)
        Me.TxtBxZoomSt.Multiline = True
        Me.TxtBxZoomSt.Name = "TxtBxZoomSt"
        Me.TxtBxZoomSt.ReadOnly = True
        Me.TxtBxZoomSt.Size = New System.Drawing.Size(67, 20)
        Me.TxtBxZoomSt.TabIndex = 64
        Me.TxtBxZoomSt.Text = "0"
        Me.TxtBxZoomSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBxZoomEnd
        '
        Me.TxtBxZoomEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxZoomEnd.Location = New System.Drawing.Point(3, 237)
        Me.TxtBxZoomEnd.Multiline = True
        Me.TxtBxZoomEnd.Name = "TxtBxZoomEnd"
        Me.TxtBxZoomEnd.ReadOnly = True
        Me.TxtBxZoomEnd.Size = New System.Drawing.Size(67, 20)
        Me.TxtBxZoomEnd.TabIndex = 63
        Me.TxtBxZoomEnd.Text = "0"
        Me.TxtBxZoomEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBxLeg3
        '
        Me.TxtBxLeg3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxLeg3.Location = New System.Drawing.Point(427, 476)
        Me.TxtBxLeg3.Multiline = True
        Me.TxtBxLeg3.Name = "TxtBxLeg3"
        Me.TxtBxLeg3.ReadOnly = True
        Me.TxtBxLeg3.Size = New System.Drawing.Size(84, 20)
        Me.TxtBxLeg3.TabIndex = 62
        Me.TxtBxLeg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBxLeg4
        '
        Me.TxtBxLeg4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxLeg4.Location = New System.Drawing.Point(515, 476)
        Me.TxtBxLeg4.Multiline = True
        Me.TxtBxLeg4.Name = "TxtBxLeg4"
        Me.TxtBxLeg4.ReadOnly = True
        Me.TxtBxLeg4.Size = New System.Drawing.Size(84, 20)
        Me.TxtBxLeg4.TabIndex = 61
        Me.TxtBxLeg4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PicBxMesswerte
        '
        Me.PicBxMesswerte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBxMesswerte.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PicBxMesswerte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBxMesswerte.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PicBxMesswerte.Location = New System.Drawing.Point(78, 83)
        Me.PicBxMesswerte.Name = "PicBxMesswerte"
        Me.PicBxMesswerte.Size = New System.Drawing.Size(590, 376)
        Me.PicBxMesswerte.TabIndex = 60
        Me.PicBxMesswerte.TabStop = False
        '
        'TxtBxLeg1
        '
        Me.TxtBxLeg1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxLeg1.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtBxLeg1.Location = New System.Drawing.Point(251, 476)
        Me.TxtBxLeg1.Multiline = True
        Me.TxtBxLeg1.Name = "TxtBxLeg1"
        Me.TxtBxLeg1.ReadOnly = True
        Me.TxtBxLeg1.Size = New System.Drawing.Size(84, 20)
        Me.TxtBxLeg1.TabIndex = 59
        Me.TxtBxLeg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBxLeg2
        '
        Me.TxtBxLeg2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxLeg2.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtBxLeg2.Location = New System.Drawing.Point(339, 476)
        Me.TxtBxLeg2.Multiline = True
        Me.TxtBxLeg2.Name = "TxtBxLeg2"
        Me.TxtBxLeg2.ReadOnly = True
        Me.TxtBxLeg2.Size = New System.Drawing.Size(84, 20)
        Me.TxtBxLeg2.TabIndex = 58
        Me.TxtBxLeg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBxLeg0
        '
        Me.TxtBxLeg0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxLeg0.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtBxLeg0.Location = New System.Drawing.Point(163, 476)
        Me.TxtBxLeg0.Multiline = True
        Me.TxtBxLeg0.Name = "TxtBxLeg0"
        Me.TxtBxLeg0.ReadOnly = True
        Me.TxtBxLeg0.Size = New System.Drawing.Size(84, 20)
        Me.TxtBxLeg0.TabIndex = 57
        Me.TxtBxLeg0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTitel
        '
        Me.LblTitel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitel.Location = New System.Drawing.Point(3, 17)
        Me.LblTitel.Name = "LblTitel"
        Me.LblTitel.Size = New System.Drawing.Size(694, 23)
        Me.LblTitel.TabIndex = 56
        Me.LblTitel.Text = "Diagramm Titel"
        Me.LblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(197, 511)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(29, 20)
        Me.TextBox5.TabIndex = 55
        Me.TextBox5.Text = "x="
        '
        'TxtBxAktY
        '
        Me.TxtBxAktY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxAktY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxAktY.Location = New System.Drawing.Point(340, 511)
        Me.TxtBxAktY.Name = "TxtBxAktY"
        Me.TxtBxAktY.ReadOnly = True
        Me.TxtBxAktY.Size = New System.Drawing.Size(67, 20)
        Me.TxtBxAktY.TabIndex = 54
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(305, 511)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(29, 20)
        Me.TextBox7.TabIndex = 53
        Me.TextBox7.Text = "y="
        '
        'TxtBxAktX
        '
        Me.TxtBxAktX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxAktX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxAktX.Location = New System.Drawing.Point(232, 511)
        Me.TxtBxAktX.Name = "TxtBxAktX"
        Me.TxtBxAktX.ReadOnly = True
        Me.TxtBxAktX.Size = New System.Drawing.Size(67, 20)
        Me.TxtBxAktX.TabIndex = 52
        '
        'TxtBxYMax
        '
        Me.TxtBxYMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxYMax.Location = New System.Drawing.Point(3, 83)
        Me.TxtBxYMax.Name = "TxtBxYMax"
        Me.TxtBxYMax.ReadOnly = True
        Me.TxtBxYMax.Size = New System.Drawing.Size(63, 20)
        Me.TxtBxYMax.TabIndex = 51
        Me.TxtBxYMax.Text = "100"
        '
        'TxtBxYMin
        '
        Me.TxtBxYMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxYMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxYMin.Location = New System.Drawing.Point(3, 439)
        Me.TxtBxYMin.Name = "TxtBxYMin"
        Me.TxtBxYMin.ReadOnly = True
        Me.TxtBxYMin.Size = New System.Drawing.Size(63, 20)
        Me.TxtBxYMin.TabIndex = 50
        Me.TxtBxYMin.Text = "0"
        '
        'TxtBxXMax
        '
        Me.TxtBxXMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBxXMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxXMax.Location = New System.Drawing.Point(605, 478)
        Me.TxtBxXMax.Name = "TxtBxXMax"
        Me.TxtBxXMax.ReadOnly = True
        Me.TxtBxXMax.Size = New System.Drawing.Size(63, 20)
        Me.TxtBxXMax.TabIndex = 49
        Me.TxtBxXMax.Text = "100"
        '
        'TxtBxXMin
        '
        Me.TxtBxXMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxXMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxXMin.Location = New System.Drawing.Point(78, 476)
        Me.TxtBxXMin.Name = "TxtBxXMin"
        Me.TxtBxXMin.ReadOnly = True
        Me.TxtBxXMin.Size = New System.Drawing.Size(63, 20)
        Me.TxtBxXMin.TabIndex = 48
        Me.TxtBxXMin.Text = "0"
        '
        'BttnClose
        '
        Me.BttnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BttnClose.Location = New System.Drawing.Point(3, 477)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(67, 21)
        Me.BttnClose.TabIndex = 47
        Me.BttnClose.Text = "Schließen"
        Me.BttnClose.UseVisualStyleBackColor = True
        '
        'TxtBxRegAbw
        '
        Me.TxtBxRegAbw.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxRegAbw.Location = New System.Drawing.Point(413, 511)
        Me.TxtBxRegAbw.Name = "TxtBxRegAbw"
        Me.TxtBxRegAbw.ReadOnly = True
        Me.TxtBxRegAbw.Size = New System.Drawing.Size(29, 20)
        Me.TxtBxRegAbw.TabIndex = 53
        Me.TxtBxRegAbw.Text = "e="
        '
        'TxtBxRegAbwVal
        '
        Me.TxtBxRegAbwVal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBxRegAbwVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxRegAbwVal.Location = New System.Drawing.Point(448, 511)
        Me.TxtBxRegAbwVal.Name = "TxtBxRegAbwVal"
        Me.TxtBxRegAbwVal.ReadOnly = True
        Me.TxtBxRegAbwVal.Size = New System.Drawing.Size(67, 20)
        Me.TxtBxRegAbwVal.TabIndex = 54
        '
        'GrafikForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 543)
        Me.Controls.Add(Me.LblTitel)
        Me.Controls.Add(Me.lblXZoomEnde)
        Me.Controls.Add(Me.lblXZoomStart)
        Me.Controls.Add(Me.TxtBxZoomSt)
        Me.Controls.Add(Me.TxtBxZoomEnd)
        Me.Controls.Add(Me.TxtBxLeg3)
        Me.Controls.Add(Me.TxtBxLeg4)
        Me.Controls.Add(Me.PicBxMesswerte)
        Me.Controls.Add(Me.TxtBxLeg1)
        Me.Controls.Add(Me.TxtBxLeg2)
        Me.Controls.Add(Me.TxtBxLeg0)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TxtBxRegAbwVal)
        Me.Controls.Add(Me.TxtBxAktY)
        Me.Controls.Add(Me.TxtBxRegAbw)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TxtBxAktX)
        Me.Controls.Add(Me.TxtBxYMax)
        Me.Controls.Add(Me.TxtBxYMin)
        Me.Controls.Add(Me.TxtBxXMax)
        Me.Controls.Add(Me.TxtBxXMin)
        Me.Controls.Add(Me.BttnClose)
        Me.MinimumSize = New System.Drawing.Size(701, 570)
        Me.Name = "GrafikForm"
        Me.Text = "Simulationsergebnisse"
        CType(Me.PicBxMesswerte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXZoomEnde As System.Windows.Forms.Label
    Friend WithEvents lblXZoomStart As System.Windows.Forms.Label
    Friend WithEvents TxtBxZoomSt As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxZoomEnd As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxLeg3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxLeg4 As System.Windows.Forms.TextBox
    Friend WithEvents PicBxMesswerte As System.Windows.Forms.PictureBox
    Friend WithEvents TxtBxLeg1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxLeg2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxLeg0 As System.Windows.Forms.TextBox
    Friend WithEvents LblTitel As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxAktY As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxAktX As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxYMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxYMin As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxXMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxXMin As System.Windows.Forms.TextBox
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents TxtBxRegAbw As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxRegAbwVal As System.Windows.Forms.TextBox
End Class
