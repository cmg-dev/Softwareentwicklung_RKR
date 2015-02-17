<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messwarte
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Messwarte))
        Me.GrBxDateiIO = New System.Windows.Forms.GroupBox
        Me.BttnOpenAusDat = New System.Windows.Forms.Button
        Me.BttnDisplayGraph = New System.Windows.Forms.Button
        Me.BttnOpenExcel = New System.Windows.Forms.Button
        Me.BttnOpenProzDat = New System.Windows.Forms.Button
        Me.BttnOpenParamDat = New System.Windows.Forms.Button
        Me.BttnLoadParamDat = New System.Windows.Forms.Button
        Me.TxtBxProzDat = New System.Windows.Forms.TextBox
        Me.TxtBxAusDat = New System.Windows.Forms.TextBox
        Me.BttnLoadProzDat = New System.Windows.Forms.Button
        Me.TxtBxParamDat = New System.Windows.Forms.TextBox
        Me.LblProzDat = New System.Windows.Forms.Label
        Me.LblAusDat = New System.Windows.Forms.Label
        Me.LblParamDat = New System.Windows.Forms.Label
        Me.GrBxProzessDaten = New System.Windows.Forms.GroupBox
        Me.DGVData = New System.Windows.Forms.DataGridView
        Me.TxtBxValueKD = New System.Windows.Forms.TextBox
        Me.TxtBxValueKP = New System.Windows.Forms.TextBox
        Me.LblValueKD = New System.Windows.Forms.Label
        Me.LblValueKP = New System.Windows.Forms.Label
        Me.TxtBxValueKI = New System.Windows.Forms.TextBox
        Me.LblValueKI = New System.Windows.Forms.Label
        Me.LblSimValuesErr = New System.Windows.Forms.Label
        Me.LblSimValuesOK = New System.Windows.Forms.Label
        Me.GrBxParamDaten = New System.Windows.Forms.GroupBox
        Me.LblTk = New System.Windows.Forms.Label
        Me.LblT0 = New System.Windows.Forms.Label
        Me.LblMges = New System.Windows.Forms.Label
        Me.LblMa = New System.Windows.Forms.Label
        Me.LblTa = New System.Windows.Forms.Label
        Me.LblAbtastzeit = New System.Windows.Forms.Label
        Me.LblS = New System.Windows.Forms.Label
        Me.LblIntN = New System.Windows.Forms.Label
        Me.LblBeta = New System.Windows.Forms.Label
        Me.TxtBxTk = New System.Windows.Forms.TextBox
        Me.LblAlpha = New System.Windows.Forms.Label
        Me.TxtBxt0 = New System.Windows.Forms.TextBox
        Me.TxtBxMges = New System.Windows.Forms.TextBox
        Me.TxtBxMa = New System.Windows.Forms.TextBox
        Me.TxtBxTa = New System.Windows.Forms.TextBox
        Me.TxtBxAbtastzeit = New System.Windows.Forms.TextBox
        Me.TxtBxS = New System.Windows.Forms.TextBox
        Me.TxtBxIntN = New System.Windows.Forms.TextBox
        Me.TxtBxBeta = New System.Windows.Forms.TextBox
        Me.TxtBxAlpha = New System.Windows.Forms.TextBox
        Me.BttnStartKessel = New System.Windows.Forms.Button
        Me.OFD_MW = New System.Windows.Forms.OpenFileDialog
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrBxDateiIO.SuspendLayout()
        Me.GrBxProzessDaten.SuspendLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrBxParamDaten.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrBxDateiIO
        '
        Me.GrBxDateiIO.Controls.Add(Me.BttnOpenAusDat)
        Me.GrBxDateiIO.Controls.Add(Me.BttnDisplayGraph)
        Me.GrBxDateiIO.Controls.Add(Me.BttnOpenExcel)
        Me.GrBxDateiIO.Controls.Add(Me.BttnOpenProzDat)
        Me.GrBxDateiIO.Controls.Add(Me.BttnOpenParamDat)
        Me.GrBxDateiIO.Controls.Add(Me.BttnLoadParamDat)
        Me.GrBxDateiIO.Controls.Add(Me.TxtBxProzDat)
        Me.GrBxDateiIO.Controls.Add(Me.TxtBxAusDat)
        Me.GrBxDateiIO.Controls.Add(Me.BttnLoadProzDat)
        Me.GrBxDateiIO.Controls.Add(Me.TxtBxParamDat)
        Me.GrBxDateiIO.Controls.Add(Me.LblProzDat)
        Me.GrBxDateiIO.Controls.Add(Me.LblAusDat)
        Me.GrBxDateiIO.Controls.Add(Me.LblParamDat)
        Me.GrBxDateiIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GrBxDateiIO.Location = New System.Drawing.Point(12, 1)
        Me.GrBxDateiIO.Name = "GrBxDateiIO"
        Me.GrBxDateiIO.Size = New System.Drawing.Size(764, 106)
        Me.GrBxDateiIO.TabIndex = 1
        Me.GrBxDateiIO.TabStop = False
        Me.GrBxDateiIO.Text = "DateiIO"
        '
        'BttnOpenAusDat
        '
        Me.BttnOpenAusDat.Location = New System.Drawing.Point(694, 66)
        Me.BttnOpenAusDat.Name = "BttnOpenAusDat"
        Me.BttnOpenAusDat.Size = New System.Drawing.Size(66, 20)
        Me.BttnOpenAusDat.TabIndex = 6
        Me.BttnOpenAusDat.Text = "-> öffnen"
        Me.BttnOpenAusDat.UseVisualStyleBackColor = True
        '
        'BttnDisplayGraph
        '
        Me.BttnDisplayGraph.Location = New System.Drawing.Point(622, 66)
        Me.BttnDisplayGraph.Name = "BttnDisplayGraph"
        Me.BttnDisplayGraph.Size = New System.Drawing.Size(66, 20)
        Me.BttnDisplayGraph.TabIndex = 6
        Me.BttnDisplayGraph.Text = "-> display"
        Me.BttnDisplayGraph.UseVisualStyleBackColor = True
        '
        'BttnOpenExcel
        '
        Me.BttnOpenExcel.Location = New System.Drawing.Point(550, 66)
        Me.BttnOpenExcel.Name = "BttnOpenExcel"
        Me.BttnOpenExcel.Size = New System.Drawing.Size(66, 20)
        Me.BttnOpenExcel.TabIndex = 6
        Me.BttnOpenExcel.Text = "-> Excel"
        Me.BttnOpenExcel.UseVisualStyleBackColor = True
        '
        'BttnOpenProzDat
        '
        Me.BttnOpenProzDat.Location = New System.Drawing.Point(694, 42)
        Me.BttnOpenProzDat.Name = "BttnOpenProzDat"
        Me.BttnOpenProzDat.Size = New System.Drawing.Size(66, 20)
        Me.BttnOpenProzDat.TabIndex = 6
        Me.BttnOpenProzDat.Text = "-> öffnen"
        Me.BttnOpenProzDat.UseVisualStyleBackColor = True
        '
        'BttnOpenParamDat
        '
        Me.BttnOpenParamDat.Location = New System.Drawing.Point(694, 19)
        Me.BttnOpenParamDat.Name = "BttnOpenParamDat"
        Me.BttnOpenParamDat.Size = New System.Drawing.Size(66, 20)
        Me.BttnOpenParamDat.TabIndex = 6
        Me.BttnOpenParamDat.Text = "-> öffnen"
        Me.BttnOpenParamDat.UseVisualStyleBackColor = True
        '
        'BttnLoadParamDat
        '
        Me.BttnLoadParamDat.Location = New System.Drawing.Point(550, 17)
        Me.BttnLoadParamDat.Name = "BttnLoadParamDat"
        Me.BttnLoadParamDat.Size = New System.Drawing.Size(66, 20)
        Me.BttnLoadParamDat.TabIndex = 6
        Me.BttnLoadParamDat.Text = "-> laden"
        Me.BttnLoadParamDat.UseVisualStyleBackColor = True
        '
        'TxtBxProzDat
        '
        Me.TxtBxProzDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxProzDat.Location = New System.Drawing.Point(100, 43)
        Me.TxtBxProzDat.Name = "TxtBxProzDat"
        Me.TxtBxProzDat.Size = New System.Drawing.Size(444, 20)
        Me.TxtBxProzDat.TabIndex = 5
        Me.TxtBxProzDat.Text = "..\..\Dateien\SE10_Prozess_Datei_0.txt"
        '
        'TxtBxAusDat
        '
        Me.TxtBxAusDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxAusDat.Location = New System.Drawing.Point(100, 68)
        Me.TxtBxAusDat.Name = "TxtBxAusDat"
        Me.TxtBxAusDat.Size = New System.Drawing.Size(444, 20)
        Me.TxtBxAusDat.TabIndex = 4
        Me.TxtBxAusDat.Text = "..\..\Dateien\ausgabe_0.txt"
        '
        'BttnLoadProzDat
        '
        Me.BttnLoadProzDat.Location = New System.Drawing.Point(550, 41)
        Me.BttnLoadProzDat.Name = "BttnLoadProzDat"
        Me.BttnLoadProzDat.Size = New System.Drawing.Size(66, 20)
        Me.BttnLoadProzDat.TabIndex = 6
        Me.BttnLoadProzDat.Text = "-> laden"
        Me.BttnLoadProzDat.UseVisualStyleBackColor = True
        '
        'TxtBxParamDat
        '
        Me.TxtBxParamDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxParamDat.Location = New System.Drawing.Point(100, 19)
        Me.TxtBxParamDat.Name = "TxtBxParamDat"
        Me.TxtBxParamDat.Size = New System.Drawing.Size(444, 20)
        Me.TxtBxParamDat.TabIndex = 3
        Me.TxtBxParamDat.Text = "..\..\Dateien\SE10_Parameter_Datei_0.txt"
        '
        'LblProzDat
        '
        Me.LblProzDat.AutoSize = True
        Me.LblProzDat.Location = New System.Drawing.Point(6, 46)
        Me.LblProzDat.Name = "LblProzDat"
        Me.LblProzDat.Size = New System.Drawing.Size(67, 13)
        Me.LblProzDat.TabIndex = 1
        Me.LblProzDat.Text = "Prozessdatei"
        '
        'LblAusDat
        '
        Me.LblAusDat.AutoSize = True
        Me.LblAusDat.Location = New System.Drawing.Point(6, 70)
        Me.LblAusDat.Name = "LblAusDat"
        Me.LblAusDat.Size = New System.Drawing.Size(72, 13)
        Me.LblAusDat.TabIndex = 2
        Me.LblAusDat.Text = "Ausgabedatei"
        '
        'LblParamDat
        '
        Me.LblParamDat.AutoSize = True
        Me.LblParamDat.Location = New System.Drawing.Point(6, 22)
        Me.LblParamDat.Name = "LblParamDat"
        Me.LblParamDat.Size = New System.Drawing.Size(78, 13)
        Me.LblParamDat.TabIndex = 0
        Me.LblParamDat.Text = "Parameterdatei"
        '
        'GrBxProzessDaten
        '
        Me.GrBxProzessDaten.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrBxProzessDaten.Controls.Add(Me.DGVData)
        Me.GrBxProzessDaten.Controls.Add(Me.TxtBxValueKD)
        Me.GrBxProzessDaten.Controls.Add(Me.TxtBxValueKP)
        Me.GrBxProzessDaten.Controls.Add(Me.LblValueKD)
        Me.GrBxProzessDaten.Controls.Add(Me.LblValueKP)
        Me.GrBxProzessDaten.Controls.Add(Me.TxtBxValueKI)
        Me.GrBxProzessDaten.Controls.Add(Me.LblValueKI)
        Me.GrBxProzessDaten.Controls.Add(Me.LblSimValuesErr)
        Me.GrBxProzessDaten.Controls.Add(Me.LblSimValuesOK)
        Me.GrBxProzessDaten.Location = New System.Drawing.Point(12, 112)
        Me.GrBxProzessDaten.Name = "GrBxProzessDaten"
        Me.GrBxProzessDaten.Size = New System.Drawing.Size(768, 173)
        Me.GrBxProzessDaten.TabIndex = 2
        Me.GrBxProzessDaten.TabStop = False
        Me.GrBxProzessDaten.Text = "Prozessdaten"
        '
        'DGVData
        '
        Me.DGVData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.Location = New System.Drawing.Point(15, 45)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(739, 114)
        Me.DGVData.TabIndex = 5
        '
        'TxtBxValueKD
        '
        Me.TxtBxValueKD.Location = New System.Drawing.Point(300, 19)
        Me.TxtBxValueKD.Name = "TxtBxValueKD"
        Me.TxtBxValueKD.Size = New System.Drawing.Size(45, 20)
        Me.TxtBxValueKD.TabIndex = 4
        Me.TxtBxValueKD.Text = "0,0"
        '
        'TxtBxValueKP
        '
        Me.TxtBxValueKP.Location = New System.Drawing.Point(39, 19)
        Me.TxtBxValueKP.Name = "TxtBxValueKP"
        Me.TxtBxValueKP.Size = New System.Drawing.Size(45, 20)
        Me.TxtBxValueKP.TabIndex = 4
        Me.TxtBxValueKP.Text = "0,0"
        '
        'LblValueKD
        '
        Me.LblValueKD.AutoSize = True
        Me.LblValueKD.Location = New System.Drawing.Point(272, 22)
        Me.LblValueKD.Name = "LblValueKD"
        Me.LblValueKD.Size = New System.Drawing.Size(22, 13)
        Me.LblValueKD.TabIndex = 3
        Me.LblValueKD.Text = "KD"
        '
        'LblValueKP
        '
        Me.LblValueKP.AutoSize = True
        Me.LblValueKP.Location = New System.Drawing.Point(12, 22)
        Me.LblValueKP.Name = "LblValueKP"
        Me.LblValueKP.Size = New System.Drawing.Size(21, 13)
        Me.LblValueKP.TabIndex = 3
        Me.LblValueKP.Text = "KP"
        '
        'TxtBxValueKI
        '
        Me.TxtBxValueKI.Location = New System.Drawing.Point(165, 19)
        Me.TxtBxValueKI.Name = "TxtBxValueKI"
        Me.TxtBxValueKI.Size = New System.Drawing.Size(45, 20)
        Me.TxtBxValueKI.TabIndex = 4
        Me.TxtBxValueKI.Text = "0,0"
        '
        'LblValueKI
        '
        Me.LblValueKI.AutoSize = True
        Me.LblValueKI.Location = New System.Drawing.Point(142, 22)
        Me.LblValueKI.Name = "LblValueKI"
        Me.LblValueKI.Size = New System.Drawing.Size(17, 13)
        Me.LblValueKI.TabIndex = 3
        Me.LblValueKI.Text = "KI"
        '
        'LblSimValuesErr
        '
        Me.LblSimValuesErr.AutoSize = True
        Me.LblSimValuesErr.BackColor = System.Drawing.Color.Red
        Me.LblSimValuesErr.Location = New System.Drawing.Point(362, 22)
        Me.LblSimValuesErr.Name = "LblSimValuesErr"
        Me.LblSimValuesErr.Size = New System.Drawing.Size(137, 13)
        Me.LblSimValuesErr.TabIndex = 2
        Me.LblSimValuesErr.Text = "<-- Problem bei der Eingabe"
        '
        'LblSimValuesOK
        '
        Me.LblSimValuesOK.AutoSize = True
        Me.LblSimValuesOK.BackColor = System.Drawing.Color.LawnGreen
        Me.LblSimValuesOK.Location = New System.Drawing.Point(362, 22)
        Me.LblSimValuesOK.Name = "LblSimValuesOK"
        Me.LblSimValuesOK.Size = New System.Drawing.Size(227, 13)
        Me.LblSimValuesOK.TabIndex = 2
        Me.LblSimValuesOK.Text = "<-- Neue Werte für die Simulation übernommen"
        '
        'GrBxParamDaten
        '
        Me.GrBxParamDaten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrBxParamDaten.Controls.Add(Me.LblTk)
        Me.GrBxParamDaten.Controls.Add(Me.LblT0)
        Me.GrBxParamDaten.Controls.Add(Me.LblMges)
        Me.GrBxParamDaten.Controls.Add(Me.LblMa)
        Me.GrBxParamDaten.Controls.Add(Me.LblTa)
        Me.GrBxParamDaten.Controls.Add(Me.LblAbtastzeit)
        Me.GrBxParamDaten.Controls.Add(Me.LblS)
        Me.GrBxParamDaten.Controls.Add(Me.LblIntN)
        Me.GrBxParamDaten.Controls.Add(Me.LblBeta)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxTk)
        Me.GrBxParamDaten.Controls.Add(Me.LblAlpha)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxt0)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxMges)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxMa)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxTa)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxAbtastzeit)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxS)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxIntN)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxBeta)
        Me.GrBxParamDaten.Controls.Add(Me.TxtBxAlpha)
        Me.GrBxParamDaten.Location = New System.Drawing.Point(12, 291)
        Me.GrBxParamDaten.Name = "GrBxParamDaten"
        Me.GrBxParamDaten.Size = New System.Drawing.Size(764, 160)
        Me.GrBxParamDaten.TabIndex = 3
        Me.GrBxParamDaten.TabStop = False
        Me.GrBxParamDaten.Text = "Parameterdaten"
        '
        'LblTk
        '
        Me.LblTk.AutoSize = True
        Me.LblTk.Location = New System.Drawing.Point(411, 118)
        Me.LblTk.Name = "LblTk"
        Me.LblTk.Size = New System.Drawing.Size(36, 13)
        Me.LblTk.TabIndex = 1
        Me.LblTk.Text = "Tk [K]"
        '
        'LblT0
        '
        Me.LblT0.AutoSize = True
        Me.LblT0.Location = New System.Drawing.Point(411, 90)
        Me.LblT0.Name = "LblT0"
        Me.LblT0.Size = New System.Drawing.Size(36, 13)
        Me.LblT0.TabIndex = 1
        Me.LblT0.Text = "T0 [K]"
        '
        'LblMges
        '
        Me.LblMges.AutoSize = True
        Me.LblMges.Location = New System.Drawing.Point(6, 122)
        Me.LblMges.Name = "LblMges"
        Me.LblMges.Size = New System.Drawing.Size(59, 13)
        Me.LblMges.TabIndex = 1
        Me.LblMges.Text = "m_ges [kg]"
        '
        'LblMa
        '
        Me.LblMa.AutoSize = True
        Me.LblMa.Location = New System.Drawing.Point(411, 64)
        Me.LblMa.Name = "LblMa"
        Me.LblMa.Size = New System.Drawing.Size(48, 13)
        Me.LblMa.TabIndex = 1
        Me.LblMa.Text = "m_a [kg]"
        '
        'LblTa
        '
        Me.LblTa.AutoSize = True
        Me.LblTa.Location = New System.Drawing.Point(6, 94)
        Me.LblTa.Name = "LblTa"
        Me.LblTa.Size = New System.Drawing.Size(36, 13)
        Me.LblTa.TabIndex = 1
        Me.LblTa.Text = "Ta [K]"
        '
        'LblAbtastzeit
        '
        Me.LblAbtastzeit.AutoSize = True
        Me.LblAbtastzeit.Location = New System.Drawing.Point(411, 38)
        Me.LblAbtastzeit.Name = "LblAbtastzeit"
        Me.LblAbtastzeit.Size = New System.Drawing.Size(67, 13)
        Me.LblAbtastzeit.TabIndex = 1
        Me.LblAbtastzeit.Text = "Abtastzeit [s]"
        '
        'LblS
        '
        Me.LblS.AutoSize = True
        Me.LblS.Location = New System.Drawing.Point(6, 68)
        Me.LblS.Name = "LblS"
        Me.LblS.Size = New System.Drawing.Size(37, 13)
        Me.LblS.TabIndex = 1
        Me.LblS.Text = "s [1/s]"
        '
        'LblIntN
        '
        Me.LblIntN.AutoSize = True
        Me.LblIntN.Location = New System.Drawing.Point(411, 12)
        Me.LblIntN.Name = "LblIntN"
        Me.LblIntN.Size = New System.Drawing.Size(96, 13)
        Me.LblIntN.TabIndex = 1
        Me.LblIntN.Text = "Integrationsschritte"
        '
        'LblBeta
        '
        Me.LblBeta.AutoSize = True
        Me.LblBeta.Location = New System.Drawing.Point(6, 42)
        Me.LblBeta.Name = "LblBeta"
        Me.LblBeta.Size = New System.Drawing.Size(53, 13)
        Me.LblBeta.TabIndex = 1
        Me.LblBeta.Text = "beta [1/s]"
        '
        'TxtBxTk
        '
        Me.TxtBxTk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxTk.Location = New System.Drawing.Point(550, 115)
        Me.TxtBxTk.Name = "TxtBxTk"
        Me.TxtBxTk.ReadOnly = True
        Me.TxtBxTk.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxTk.TabIndex = 0
        Me.TxtBxTk.Text = "0,0"
        '
        'LblAlpha
        '
        Me.LblAlpha.AutoSize = True
        Me.LblAlpha.Location = New System.Drawing.Point(6, 16)
        Me.LblAlpha.Name = "LblAlpha"
        Me.LblAlpha.Size = New System.Drawing.Size(76, 13)
        Me.LblAlpha.TabIndex = 1
        Me.LblAlpha.Text = "alpha [K/kg/s]"
        '
        'TxtBxt0
        '
        Me.TxtBxt0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxt0.Location = New System.Drawing.Point(550, 87)
        Me.TxtBxt0.Name = "TxtBxt0"
        Me.TxtBxt0.ReadOnly = True
        Me.TxtBxt0.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxt0.TabIndex = 0
        Me.TxtBxt0.Text = "0,0"
        '
        'TxtBxMges
        '
        Me.TxtBxMges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxMges.Location = New System.Drawing.Point(145, 119)
        Me.TxtBxMges.Name = "TxtBxMges"
        Me.TxtBxMges.ReadOnly = True
        Me.TxtBxMges.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxMges.TabIndex = 0
        Me.TxtBxMges.Text = "0,0"
        '
        'TxtBxMa
        '
        Me.TxtBxMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxMa.Location = New System.Drawing.Point(550, 61)
        Me.TxtBxMa.Name = "TxtBxMa"
        Me.TxtBxMa.ReadOnly = True
        Me.TxtBxMa.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxMa.TabIndex = 0
        Me.TxtBxMa.Text = "0,0"
        '
        'TxtBxTa
        '
        Me.TxtBxTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxTa.Location = New System.Drawing.Point(145, 91)
        Me.TxtBxTa.Name = "TxtBxTa"
        Me.TxtBxTa.ReadOnly = True
        Me.TxtBxTa.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxTa.TabIndex = 0
        Me.TxtBxTa.Text = "0,0"
        '
        'TxtBxAbtastzeit
        '
        Me.TxtBxAbtastzeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxAbtastzeit.Location = New System.Drawing.Point(550, 35)
        Me.TxtBxAbtastzeit.Name = "TxtBxAbtastzeit"
        Me.TxtBxAbtastzeit.ReadOnly = True
        Me.TxtBxAbtastzeit.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxAbtastzeit.TabIndex = 0
        Me.TxtBxAbtastzeit.Text = "0,0"
        '
        'TxtBxS
        '
        Me.TxtBxS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxS.Location = New System.Drawing.Point(145, 65)
        Me.TxtBxS.Name = "TxtBxS"
        Me.TxtBxS.ReadOnly = True
        Me.TxtBxS.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxS.TabIndex = 0
        Me.TxtBxS.Text = "0,0"
        '
        'TxtBxIntN
        '
        Me.TxtBxIntN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxIntN.Location = New System.Drawing.Point(550, 9)
        Me.TxtBxIntN.Name = "TxtBxIntN"
        Me.TxtBxIntN.ReadOnly = True
        Me.TxtBxIntN.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxIntN.TabIndex = 0
        Me.TxtBxIntN.Text = "0,0"
        '
        'TxtBxBeta
        '
        Me.TxtBxBeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxBeta.Location = New System.Drawing.Point(145, 39)
        Me.TxtBxBeta.Name = "TxtBxBeta"
        Me.TxtBxBeta.ReadOnly = True
        Me.TxtBxBeta.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxBeta.TabIndex = 0
        Me.TxtBxBeta.Text = "0,0"
        '
        'TxtBxAlpha
        '
        Me.TxtBxAlpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBxAlpha.Location = New System.Drawing.Point(145, 13)
        Me.TxtBxAlpha.Name = "TxtBxAlpha"
        Me.TxtBxAlpha.ReadOnly = True
        Me.TxtBxAlpha.Size = New System.Drawing.Size(200, 20)
        Me.TxtBxAlpha.TabIndex = 0
        Me.TxtBxAlpha.Text = "0,0"
        '
        'BttnStartKessel
        '
        Me.BttnStartKessel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BttnStartKessel.Location = New System.Drawing.Point(12, 459)
        Me.BttnStartKessel.Name = "BttnStartKessel"
        Me.BttnStartKessel.Size = New System.Drawing.Size(345, 54)
        Me.BttnStartKessel.TabIndex = 6
        Me.BttnStartKessel.Text = "Starte Rührkessel"
        Me.BttnStartKessel.UseVisualStyleBackColor = True
        '
        'OFD_MW
        '
        Me.OFD_MW.FileName = "OpenFileDialog1"
        '
        'Messwarte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 523)
        Me.Controls.Add(Me.BttnStartKessel)
        Me.Controls.Add(Me.GrBxParamDaten)
        Me.Controls.Add(Me.GrBxProzessDaten)
        Me.Controls.Add(Me.GrBxDateiIO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "Messwarte"
        Me.Text = "Leitstand Messwarte"
        Me.GrBxDateiIO.ResumeLayout(False)
        Me.GrBxDateiIO.PerformLayout()
        Me.GrBxProzessDaten.ResumeLayout(False)
        Me.GrBxProzessDaten.PerformLayout()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrBxParamDaten.ResumeLayout(False)
        Me.GrBxParamDaten.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrBxDateiIO As System.Windows.Forms.GroupBox
    Friend WithEvents BttnLoadParamDat As System.Windows.Forms.Button
    Friend WithEvents TxtBxProzDat As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxAusDat As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxParamDat As System.Windows.Forms.TextBox
    Friend WithEvents LblAusDat As System.Windows.Forms.Label
    Friend WithEvents LblProzDat As System.Windows.Forms.Label
    Friend WithEvents LblParamDat As System.Windows.Forms.Label
    Friend WithEvents BttnOpenExcel As System.Windows.Forms.Button
    Friend WithEvents BttnLoadProzDat As System.Windows.Forms.Button
    Friend WithEvents BttnOpenAusDat As System.Windows.Forms.Button
    Friend WithEvents BttnDisplayGraph As System.Windows.Forms.Button
    Friend WithEvents BttnOpenProzDat As System.Windows.Forms.Button
    Friend WithEvents BttnOpenParamDat As System.Windows.Forms.Button
    Friend WithEvents GrBxProzessDaten As System.Windows.Forms.GroupBox
    Friend WithEvents DGVData As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBxValueKD As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxValueKP As System.Windows.Forms.TextBox
    Friend WithEvents LblValueKD As System.Windows.Forms.Label
    Friend WithEvents LblValueKP As System.Windows.Forms.Label
    Friend WithEvents TxtBxValueKI As System.Windows.Forms.TextBox
    Friend WithEvents LblValueKI As System.Windows.Forms.Label
    Friend WithEvents GrBxParamDaten As System.Windows.Forms.GroupBox
    Friend WithEvents LblMges As System.Windows.Forms.Label
    Friend WithEvents LblTa As System.Windows.Forms.Label
    Friend WithEvents LblS As System.Windows.Forms.Label
    Friend WithEvents LblBeta As System.Windows.Forms.Label
    Friend WithEvents LblAlpha As System.Windows.Forms.Label
    Friend WithEvents TxtBxMges As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxTa As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxS As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxBeta As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxAlpha As System.Windows.Forms.TextBox
    Friend WithEvents LblTk As System.Windows.Forms.Label
    Friend WithEvents LblT0 As System.Windows.Forms.Label
    Friend WithEvents LblMa As System.Windows.Forms.Label
    Friend WithEvents LblAbtastzeit As System.Windows.Forms.Label
    Friend WithEvents LblIntN As System.Windows.Forms.Label
    Friend WithEvents TxtBxTk As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxt0 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxMa As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxAbtastzeit As System.Windows.Forms.TextBox
    Friend WithEvents TxtBxIntN As System.Windows.Forms.TextBox
    Friend WithEvents BttnStartKessel As System.Windows.Forms.Button
    Friend WithEvents OFD_MW As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblSimValuesOK As System.Windows.Forms.Label
    Friend WithEvents LblSimValuesErr As System.Windows.Forms.Label
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip

End Class
