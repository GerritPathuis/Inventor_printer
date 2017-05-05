﻿Imports System.IO

Public Class Form1
    Dim Doelmap As String = ""
    Dim WP_ASSY_BB As String = ""
    Private inventorApplication As Inventor.Application
#Region "Inventor link"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim inventorRunning As Boolean = GetInventorApplication()
        'If Not inventorRunning Then
        If inventorRunning = False Then
            MsgBox("Inventor is nog niet gestart" & vbCr & "Start Inventor op en start dit programma nogmaals op" & vbCr & vbCr, MsgBoxStyle.Critical, "ALL IN ONE PRINTER")
        End If

    End Sub

    Private Function GetInventorApplication() As Boolean

        Try
            inventorApplication = System.Runtime.InteropServices.Marshal.GetActiveObject("Inventor.Application")
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
#End Region

#Region "Drag drop"
    Private Sub ListBox1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        Dim Files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each filename As String In Files
            ListBox1.Items.Add(filename)
        Next

    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    'Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    'End Sub
#End Region

#Region "set doelmap"
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'selecteer doelmap
        FolderBrowserDialog1.ShowDialog()
        Doelmap = FolderBrowserDialog1.SelectedPath
        TextBox1DOELMAP.Text = Doelmap



    End Sub

#End Region


    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
  
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Er staan geen tekeningen in de lijst", MsgBoxStyle.OkOnly, "ALLES_IN_1_PRINTER")
            Exit Sub
        End If
        If CheckBox1PDF.Checked = True Then
            If TextBox1DOELMAP.Text = "" Then
                MsgBox("Er is geen doelmap opgegeven", MsgBoxStyle.OkOnly, "ALLES_IN_1_PRINTER")
                Exit Sub
            End If
        End If
        If CheckBox2DXF.Checked = True Then
            If TextBox1DOELMAP.Text = "" Then
                MsgBox("Er is geen doelmap opgegeven", MsgBoxStyle.OkOnly, "ALLES_IN_1_PRINTER")
                Exit Sub
            End If
        End If
        If CheckBox3DWG.Checked = True Then
            If TextBox1DOELMAP.Text = "" Then
                MsgBox("Er is geen doelmap opgegeven", MsgBoxStyle.OkOnly, "ALLES_IN_1_PRINTER")
                Exit Sub
            End If
        End If

        Dim Aantal_tekeningen As Integer = ListBox1.Items.Count
        Dim i As Integer
        Dim endAt = ListBox1.Items.Count - 1

        For i = 0 To Aantal_tekeningen
            ListBox1.SelectedIndex = i
            Dim extension As String = Path.GetExtension(ListBox1.SelectedItem)
            If extension = ".idw" Then

            Else
                ListBox1.Items.Remove(ListBox1.SelectedItem)
                i = i - 1
                Aantal_tekeningen = Aantal_tekeningen - 1
            End If
            ListBox1.SelectedIndex = Nothing
            If i + 1 = Aantal_tekeningen Then
                Exit For
            End If
        Next (i)

        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        ListBox1.SelectedIndex = 0
        ''Toepassen --> coppy naar c:\temp dan openen

        ''''210 naar 3 mappen
        Dim di As New IO.DirectoryInfo("C:\Temp")
        Dim myfile As String = ListBox1.SelectedItem
        Dim fi As FileInfo = New FileInfo(myfile)
        Dim welkemap As String = "C:\Temp"
        Dim digitaalprinten As Boolean = True
        '' digitaal printen afhankelijk van een if statment maken

        Dim Aantal_tekeningen As Integer = ListBox1.Items.Count

        Dim i As Integer
        Dim endAt = ListBox1.Items.Count - 1

        For i = 0 To Aantal_tekeningen
            ListBox1.SelectedIndex = i
            myfile = ListBox1.SelectedItem
            fi = New FileInfo(myfile)


            If CheckBox_Assemblage.Checked = True Then
                welkemap = "C:\Temp\Assemblage"
                'fi.IsReadOnly = False
                If (Not System.IO.Directory.Exists(welkemap)) Then
                    System.IO.Directory.CreateDirectory(welkemap)
                End If
                fi.CopyTo(Path.Combine(welkemap, fi.Name), True)
            End If

            If CheckBox_Bedrijfsbureau.Checked = True Then
                welkemap = "C:\Temp\Bedrijfsbureau"
                'fi.IsReadOnly = False
                If (Not System.IO.Directory.Exists(welkemap)) Then
                    System.IO.Directory.CreateDirectory(welkemap)
                End If
                fi.CopyTo(Path.Combine(welkemap, fi.Name), True)
            End If

            If CheckBox_Werkplaats.Checked = True Then
                welkemap = "C:\Temp\Werkplaats"
                'fi.IsReadOnly = False
                If (Not System.IO.Directory.Exists(welkemap)) Then
                    System.IO.Directory.CreateDirectory(welkemap)
                End If
                fi.CopyTo(Path.Combine(welkemap, fi.Name), True)
            End If

            If CheckBox1PDF.Checked = False And CheckBox2DXF.Checked = False And CheckBox3DWG.Checked = False And CheckBox_Blanco.Checked = False Then
                digitaalprinten = False
            Else
                digitaalprinten = True

            End If
            If digitaalprinten = True Then
                welkemap = "C:\Temp"
                'fi.IsReadOnly = False
                fi.CopyTo(Path.Combine(welkemap, fi.Name), True)
            End If

            If i + 1 = Aantal_tekeningen Then
                i = 0
                ListBox1.SelectedIndex = Nothing
                Exit For
            End If
        Next (i)

        ''hieronder printen
        ''hieronder printen
        ''hieronder printen

        ''assemblage printen
        For i = 0 To Aantal_tekeningen
            ListBox1.SelectedIndex = i
            myfile = ListBox1.SelectedItem
            fi = New FileInfo(myfile)

            If CheckBox_Assemblage.Checked = True Then
                welkemap = "C:\Temp\Assemblage"
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.idw")
                Call Bestand_openen(fi, welkemap, digitaalprinten)
            Else
                Exit For
            End If

            If i + 1 = Aantal_tekeningen Then
                i = 0
                digitaalprinten = False
                Exit For
            End If
        Next (i)
        ''assemblage printen

        ''Bedrijfsbureau printen
        For i = 0 To Aantal_tekeningen
            ListBox1.SelectedIndex = i
            myfile = ListBox1.SelectedItem
            fi = New FileInfo(myfile)

            If CheckBox_Bedrijfsbureau.Checked = True Then
                welkemap = "C:\Temp\Bedrijfsbureau"
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.idw")
                Call Bestand_openen(fi, welkemap, digitaalprinten)
            Else
                Exit For
            End If

            If i + 1 = Aantal_tekeningen Then
                digitaalprinten = False
                i = 0
                Exit For
            End If
        Next (i)
        ''Bedrijfsbureau printen

        ''Werkplaats printen
        For i = 0 To Aantal_tekeningen
            ListBox1.SelectedIndex = i
            myfile = ListBox1.SelectedItem
            fi = New FileInfo(myfile)

            If CheckBox_Werkplaats.Checked = True Then
                welkemap = "C:\Temp\Werkplaats"
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.idw")
                Call Bestand_openen(fi, welkemap, digitaalprinten)
            Else
                Exit For
            End If

            If i + 1 = Aantal_tekeningen Then
                digitaalprinten = False
                i = 0
                Exit For
            End If
        Next (i)
        ''Werkplaats printen

        ''digitaal printen
        If digitaalprinten = True Then
            For i = 0 To Aantal_tekeningen
                ListBox1.SelectedIndex = i
                myfile = ListBox1.SelectedItem
                fi = New FileInfo(myfile)
                If digitaalprinten = True Then
                    welkemap = "C:\Temp"
                    Dim diar1 As IO.FileInfo() = di.GetFiles("*.idw")
                    Call Bestand_openen(fi, welkemap, digitaalprinten)
                Else
                    Exit For
                End If
                If i + 1 = Aantal_tekeningen Then
                    digitaalprinten = False
                    i = 0
                    Exit For
                End If
            Next (i)
        End If
        ''digitaal printen

        ''mappen in temp vernietigen
        ''Dim path1 As String = "x"
        System.Threading.Thread.Sleep(1000)

        If CheckBox_Assemblage.Checked = True Then
            welkemap = "C:\Temp\Assemblage"
            ''     path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & welkemap
            Call ProcessTree(welkemap)
            System.IO.Directory.Delete(welkemap, True)
        End If

        If CheckBox_Bedrijfsbureau.Checked = True Then
            welkemap = "C:\Temp\Bedrijfsbureau"
            ''     path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & welkemap
            Call ProcessTree(welkemap)
            System.IO.Directory.Delete(welkemap, True)
        End If

        If CheckBox_Werkplaats.Checked = True Then
            welkemap = "C:\Temp\Werkplaats"
            ''    path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & welkemap
            Call ProcessTree(welkemap)
            System.IO.Directory.Delete(welkemap, True)
        End If
        ''mappen in temp vernietigen

        If CheckBox1PDF.Checked = False And CheckBox2DXF.Checked = False And CheckBox3DWG.Checked = False Then
            ListBox1.Items.Clear()
        Else

            For i = 0 To Aantal_tekeningen
                'ListBox1.SelectedIndex = i
                ListBox1.SelectedIndex = 0
                myfile = ListBox1.SelectedItem
                fi = New FileInfo(myfile)
                welkemap = "C:\Temp"

                Dim FileToDelete As String = (Path.Combine(welkemap, fi.Name))
                ' Create the FileInfo object
                Dim oFileInfo As New FileInfo(FileToDelete)
                ' Check attributes
                ' If Read-Only, Set attribute to false

                If (oFileInfo.Attributes And FileAttributes.ReadOnly) > 0 Then
                    ' Update attributes
                    oFileInfo.Attributes = oFileInfo.Attributes Xor FileAttributes.ReadOnly
                    ' Delete the file
                    File.Delete(FileToDelete)
                End If

                ''Dim FileToDelete As String
                ''FileToDelete = (Path.Combine("C:\Temp", fi.Name))
                If System.IO.File.Exists(FileToDelete) = True Then
                    System.IO.File.Delete(FileToDelete)
                End If

                ListBox1.Items.Remove(ListBox1.SelectedItem)
                If ListBox1.Items.Count = 0 Then
                    Dim result = MessageBox.Show("Alle tekeningen zijn  geprint" & Environment.NewLine & "Wil je dit programma afsluiten", "Alles in een printer", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        Exit Sub
                    ElseIf result = DialogResult.Yes Then
                        Application.Exit()
                    End If
                    ''MsgBox("Alle tekeningen zijn geprint", MsgBoxStyle.YesNo, "ALLES_IN_1_PRINTER")
                    ''Exit Sub
                End If

                If i + 1 = Aantal_tekeningen Then
                    i = 0
                    Exit For
                End If

            Next (i)
        End If
        ''   System.Threading.Thread.Sleep(1000)
        ''   Timer1.Enabled = True
    End Sub

    Private Sub Bestand_openen(ByVal fi As FileInfo, ByVal Welkemap As String, ByVal digitaalprinten As Boolean)
        Dim oDoc As Inventor.DrawingDocument = inventorApplication.Documents.Open(Path.Combine(Welkemap, fi.Name))
        ''Dim oDoc As Inventor.DrawingDocument oude code van het net
        ''oDoc = inventorApplication.ActiveDocument

        Dim cTblock As Inventor.TitleBlock
        cTblock = oDoc.ActiveSheet.TitleBlock
        'Dim oTexts As Inventor.TextBoxes
        'Dim oText As Inventor.TextBox
        ' Dim oSketch As Inventor.Sketch
        ' cTblock.Definition.Edit(oSketch)
        'oTexts = oSketch.TextBoxes

        'For Each oText In oTexts
        '    If oText.Text = "<FILENAME AND PATH>" Then
        '        oText.Text = ListBox1.Text

        '    End If
        'Next

        cTblock.Definition.ExitEdit(True)

        ''''211 volgorde belangrijk

        If Welkemap.Contains("C:\Temp\Assemblage") Then
            WP_ASSY_BB = "ASSEMBLAGE"
            Call Locatie_stempel()
        End If

        If Welkemap.Contains("C:\Temp\Werkplaats") Then
            WP_ASSY_BB = "WERKPLAATS"
            Call Locatie_stempel()
        End If

        If Welkemap.Contains("C:\Temp\Bedrijfsbureau") Then
            WP_ASSY_BB = "BEDR. BUR."
            Call Locatie_stempel()
        End If

        If digitaalprinten = True Then

            If CheckBox_Blanco.Checked = True Then
                Call Print_fysiek()
            End If

            If CheckBox1PDF.Checked = True Then
                Call PlotPdf()
            End If

            If CheckBox2DXF.Checked = True Then
                Call PlotDXF()
            End If

            If CheckBox3DWG.Checked = True Then
                Call PlotDWG()
            End If
        End If

        oDoc.Close(True)

        ''TToepassen --> coppy van c:\temp verwijderen
        ''Toepassen --> read only aanpassen
        ' ''Dim FileToDelete As String = (Path.Combine(Welkemap, fi.Name))
        '' '' Create the FileInfo object
        ' ''Dim oFileInfo As New FileInfo(FileToDelete)
        '' '' Check attributes
        '' '' If Read-Only, Set attribute to false
        ' ''If (oFileInfo.Attributes And FileAttributes.ReadOnly) > 0 Then
        ' ''    ' Update attributes
        ' ''    oFileInfo.Attributes = oFileInfo.Attributes Xor FileAttributes.ReadOnly
        ' ''    ' Delete the file
        ' ''    File.Delete(FileToDelete)
        ' ''End If


        ' '' ''Dim FileToDelete As String
        ' '' ''FileToDelete = (Path.Combine("C:\Temp", fi.Name))
        ' ''If System.IO.File.Exists(FileToDelete) = True Then
        ' ''    System.IO.File.Delete(FileToDelete)
        ' ''End If

        ' ''ListBox1.Items.Remove(ListBox1.SelectedItem)

        ' ''If ListBox1.Items.Count = 0 Then
        ' ''    Dim result = MessageBox.Show("Alle tekeningen zijn  geprint" & Environment.NewLine & "Wil je dit programma afsluiten", "Alles in een printer", MessageBoxButtons.YesNo)
        ' ''    If result = DialogResult.No Then
        ' ''        Exit Sub
        ' ''    ElseIf result = DialogResult.Yes Then
        ' ''        Application.Exit()
        ' ''    End If
        ' ''    ''MsgBox("Alle tekeningen zijn geprint", MsgBoxStyle.YesNo, "ALLES_IN_1_PRINTER")
        ' ''    ''Exit Sub
        ' ''End If

    End Sub

#Region "DWG Printer"

    Private Sub PlotDWG()


        ' Get the DWG translator Add-In.
        Dim DWGAddIn As Inventor.TranslatorAddIn
        DWGAddIn = inventorApplication.ApplicationAddIns.ItemById("{C24E3AC2-122E-11D5-8E91-0010B541CD80}")

        'Set a reference to the active document (the document to be published).
        Dim oDocument As Inventor.Document
        oDocument = inventorApplication.ActiveDocument

        Dim oContext As Inventor.TranslationContext
        oContext = inventorApplication.TransientObjects.CreateTranslationContext
        oContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism

        ' Create a NameValueMap object
        Dim oOptions As Inventor.NameValueMap
        oOptions = inventorApplication.TransientObjects.CreateNameValueMap

        ' Create a DataMedium object
        Dim oDataMedium As Inventor.DataMedium
        oDataMedium = inventorApplication.TransientObjects.CreateDataMedium

        ' Check whether the translator has 'SaveCopyAs' options
        If DWGAddIn.HasSaveCopyAsOptions(oDocument, oContext, oOptions) Then

            Dim strIniFile As String
            strIniFile = "M:\Engineering\PDFprinterVTK\BASIS SETINGS RB.ini"

            ' Create the name-value that specifies the ini file to use.
            oOptions.Value("Export_Acad_IniFile") = strIniFile
        End If

        ''Set the destination file name
        'oDataMedium.FileName = "c:\temp\dxfout.dxf"

        ' ''Dim VTKDWGNR As String
        ' ''VTKDWGNR = oDocument.DisplayName
        ' ''Dim propSets As Inventor.PropertySets = oDocument.PropertySets
        ' ''For Each propSet As Inventor.PropertySet In propSets
        ' ''    Debug.Print(propSet.DisplayName)
        ' ''    For Each prop As Inventor.Property In propSet
        ' ''        Debug.Print(vbTab & prop.Name)
        ' ''        If prop.Name.Equals("VTKDWGNR", StringComparison.OrdinalIgnoreCase) Then
        ' ''            VTKDWGNR = prop.Value
        ' ''        End If

        ' ''    Next
        ' ''Next

        'Set the destination file name
        Dim VTKDWGNR As String = get_drawing_nr(oDocument)



        oDataMedium.FileName = TextBox1DOELMAP.Text + "\" + VTKDWGNR + ".dwg"
        ''oDataMedium.FileName = TextBox1.Text + "\dwg\" + VTKDWGNR + ".dwg" 
        ''oDataMedium.FileName = TextBox1.Text + "\" + VTKDWGNR + ".dwg"

        'Publish document.
        Call DWGAddIn.SaveCopyAs(oDocument, oContext, oOptions, oDataMedium)
    End Sub


#End Region


#Region "get name"

    Private Function Get_drawing_nr(ByVal oDocument As Inventor.Document) As String

        'Dim VTKDWGNR As String
        Get_drawing_nr = oDocument.DisplayName
        Dim propSets As Inventor.PropertySets = oDocument.PropertySets
        For Each propSet As Inventor.PropertySet In propSets
            Debug.Print(propSet.DisplayName)
            For Each prop As Inventor.Property In propSet
                Debug.Print(vbTab & prop.Name)
                If prop.Name.Equals("VTKDWGNR", StringComparison.OrdinalIgnoreCase) Then
                    Get_drawing_nr = prop.Value
                End If

            Next
        Next

        ''Inbouwen if getdrawing nr niet groter dan 10 tekens dan msgbox vraag naam voor bestand

        Return Get_drawing_nr
    End Function
#End Region


#Region "DXF PRINTER"


    Private Sub PlotDXF()


        ' Get the DXF translator Add-In.
        Dim DXFAddIn As Inventor.TranslatorAddIn
        DXFAddIn = inventorApplication.ApplicationAddIns.ItemById("{C24E3AC4-122E-11D5-8E91-0010B541CD80}")

        'Set a reference to the active document (the document to be published).
        Dim oDocument As Inventor.Document
        oDocument = inventorApplication.ActiveDocument

        Dim oContext As Inventor.TranslationContext
        oContext = inventorApplication.TransientObjects.CreateTranslationContext
        oContext.Type = Inventor.IOMechanismEnum.kFileBrowseIOMechanism

        ' Create a NameValueMap object
        Dim oOptions As Inventor.NameValueMap
        oOptions = inventorApplication.TransientObjects.CreateNameValueMap

        ' Create a DataMedium object
        Dim oDataMedium As Inventor.DataMedium
        oDataMedium = inventorApplication.TransientObjects.CreateDataMedium

        ' Check whether the translator has 'SaveCopyAs' options
        If DXFAddIn.HasSaveCopyAsOptions(oDocument, oContext, oOptions) Then

            Dim strIniFile As String
            strIniFile = "M:\Engineering\PDFprinterVTK\DXF OUTPUTE.ini"

            ' Create the name-value that specifies the ini file to use.
            oOptions.Value("Export_Acad_IniFile") = strIniFile
        End If

        ''Set the destination file name
        'oDataMedium.FileName = "c:\temp\dxfout.dxf"



        Dim VTKDWGNR As String = get_drawing_nr(oDocument)



        oDataMedium.FileName = TextBox1DOELMAP.Text + "\" + VTKDWGNR + ".dxf"

        Call DXFAddIn.SaveCopyAs(oDocument, oContext, oOptions, oDataMedium)
    End Sub


#End Region

#Region "PDF PRINTERT"


    Private Sub PlotPdf()

        On Error GoTo Err_Control

        Dim killit
        Dim numsheets As Integer
        Dim InitPrinter

        numsheets = 0

        ' Set reference to active drawing
        Dim oDrgDoc As Inventor.DrawingDocument
        oDrgDoc = inventorApplication.ActiveDocument

        ' Set reference to drawing print manager
        Dim oDrgPrintMgr As Inventor.DrawingPrintManager
        oDrgPrintMgr = oDrgDoc.PrintManager

        'Read printer so it can be set back
        InitPrinter = oDrgPrintMgr.Printer
        Dim PDFCreator1 = CreateObject("PDFCreator.clsPDFCreator")
        If inventorApplication.ActiveDocument.DocumentType = Inventor.DocumentTypeEnum.kDrawingDocumentObject Then

            With PDFCreator1
                If .cStart("/NoProcessingAtStartup") = False Then
                    killit = Shell("taskkill /f /im PDFCreator.exe", VBA.VbAppWinStyle.vbHide)
                    MsgBox("There was an error starting the pdf printer, please try (click) again!")
                    Debug.Print("Can't initialize PDFCreator.")
                    Exit Sub
                End If
            End With

            'Debug.Print "PDFCreator initialized."

            'Set some settings and clear queue
            With PDFCreator1
                .cOption("UseAutosave") = 1
                .cOption("UseAutosaveDirectory") = 1
                .cOption("AutosaveFormat") = 0 ' 0 = PDF
                .cClearCache()
            End With

            ' Set the printer to PDFCreator
            oDrgPrintMgr.Printer = "PDFCreator"

            Dim sht As Inventor.Sheet

            For Each sht In oDrgDoc.Sheets
                sht.Activate()
                'Set the paper size , scale and orientation
                oDrgPrintMgr.ScaleMode = Inventor.PrintScaleModeEnum.kPrintFullScale  ' kPrintBestFitScale
                ' Change the paper size to a custom size. The units are in centimeters.
                Dim shtsize As Long
                Dim shtorientation As Long
                shtsize = sht.Size
                shtorientation = sht.Orientation
                oDrgPrintMgr.PaperSize = Inventor.PaperSizeEnum.kPaperSizeCustom
                If shtsize = 9993 Then ' A0
                    oDrgPrintMgr.PaperHeight = 84.1
                    oDrgPrintMgr.PaperWidth = 118.9
                ElseIf shtsize = 9994 Then ' A1
                    oDrgPrintMgr.PaperHeight = 59.4
                    oDrgPrintMgr.PaperWidth = 84.1
                ElseIf shtsize = 9995 Then ' A2
                    oDrgPrintMgr.PaperHeight = 42
                    oDrgPrintMgr.PaperWidth = 59.4
                ElseIf shtsize = 9996 Then ' A3
                    oDrgPrintMgr.PaperHeight = 29.7
                    oDrgPrintMgr.PaperWidth = 42
                ElseIf shtsize = 9997 Then ' A4
                    oDrgPrintMgr.PaperHeight = 21
                    oDrgPrintMgr.PaperWidth = 29.7
                End If
                oDrgPrintMgr.PrintRange = Inventor.PrintRangeEnum.kPrintCurrentSheet
                If shtorientation = 10242 Then 'Landscape
                    oDrgPrintMgr.Orientation = Inventor.PrintOrientationEnum.kLandscapeOrientation
                ElseIf shtorientation = 10243 Then 'Portrait
                    oDrgPrintMgr.Orientation = Inventor.PrintOrientationEnum.kPortraitOrientation
                End If

                oDrgPrintMgr.AllColorsAsBlack = True
                oDrgPrintMgr.Rotate90Degrees = True


                Dim VTKDWGNR As String = get_drawing_nr(oDrgDoc)

                With PDFCreator1
                    .cOption("AutosaveDirectory") = TextBox1DOELMAP.Text
                    .cOption("AutosaveFilename") = VTKDWGNR
                    ''    .cOption("AutosaveFilename") = oDrgDoc.DisplayName
                End With

                ''With PDFCreator1
                ''    .cOption("AutosaveDirectory") = "M:\Engineering\PDFprinterVTK\\SWAP lijst"
                ''    .cOption("AutosaveFilename") = oDrgDoc.DisplayName
                ''End With

                oDrgPrintMgr.SubmitPrint()

                System.Threading.Thread.Sleep(1000)

                numsheets = numsheets + 1
            Next
        Else
            MsgBox("You aren't using an Inventor drawing!")
            Exit Sub
        End If

        'Wait until all prints are in queue
        Do Until PDFCreator1.cCountOfPrintjobs = numsheets
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        Loop

        'Combine sheets in queue to one pdf
        With PDFCreator1
            .cCombineAll()
            .cPrinterStop = False
        End With

        'Wait until job done
        Do Until PDFCreator1.cCountOfPrintjobs = 0
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        Loop

        'Set back to first sheet and set printer back
        oDrgDoc.Sheets(1).Activate()
        oDrgPrintMgr.Printer = InitPrinter

        'Clean up
        PDFCreator1.cClose()
        killit = Shell("taskkill /f /im PDFCreator.exe", VBA.VbAppWinStyle.vbHide)
        oDrgDoc = Nothing
        oDrgPrintMgr = Nothing

Exit_Here:
        Exit Sub
Err_Control:
        Select Case Err.Number
            'Add your Case selections here
            'Case Is = 1000
            'Handle error
            'Err.Clear
            'Resume Exit_Here
            Case Else
                MsgBox(Err.Number & ", " & Err.Description, , "PlotPdf")
                Err.Clear()
                Resume Exit_Here
        End Select
    End Sub


#End Region

#Region "Stempelen"

    Private Sub Locatie_stempel()
        Dim hoogte_titelblok As Double = 0
        Dim breete_titelblok As Double = 0
        Dim oDrawDoc As Inventor.DrawingDocument
        oDrawDoc = inventorApplication.ActiveDocument
        Dim sheet As Inventor.Sheet

        For Each sheet In oDrawDoc.Sheets
            sheet.Activate()
            'Set the paper size , scale and orientation

            ' Change the paper size to a custom size. The units are in centimeters.
            Dim shtsize As Long
            ''     Dim shtorientation As Long
            shtsize = sheet.Size

            If shtsize = 9993 Then ' A0
                hoogte_titelblok = 1
                breete_titelblok = 99.1
                Call Stempelen(hoogte_titelblok, breete_titelblok)
            ElseIf shtsize = 9994 Then ' A1
                hoogte_titelblok = 1
                breete_titelblok = 64.3
                Call Stempelen(hoogte_titelblok, breete_titelblok)
            ElseIf shtsize = 9995 Then ' A2
                hoogte_titelblok = 1
                breete_titelblok = 39.6
                Call Stempelen(hoogte_titelblok, breete_titelblok)
            ElseIf shtsize = 9996 Then ' A3
                hoogte_titelblok = 1
                breete_titelblok = 22.2
                Call Stempelen(hoogte_titelblok, breete_titelblok)
            ElseIf shtsize = 9997 Then ' A4
                hoogte_titelblok = 1
                breete_titelblok = 1
                Call Stempelen(hoogte_titelblok, breete_titelblok)
            End If

            ''If shtorientation = 10242 Then 'Landscape

            ''ElseIf shtorientation = 10243 Then 'Portrait

            ''End If

            ''Call stempelen(hoogte_titelblok, breete_titelblok) verplaatst ivm multie sheet
        Next
    End Sub

    Public Sub Stempelen(ByVal Hoogte As Double, ByVal breete As Double)
        ' Set a reference to the drawing document.
        ' This assumes a drawing document is active.
        Dim oDrawDoc As Inventor.DrawingDocument
        oDrawDoc = inventorApplication.ActiveDocument

        ' Create a new sketch on the active sheet.
        Dim oSketch As Inventor.DrawingSketch
        oSketch = oDrawDoc.ActiveSheet.Sketches.Add

        ' Open the sketch for edit so the text boxes can be created.
        ' This is only required for drawing sketches, not part.
        oSketch.Edit()

        Dim oTG As Inventor.TransientGeometry
        oTG = inventorApplication.TransientGeometry

        ' Create text with simple string as input. Since this doesn't use
        ' any text overrides, it will default to the active text style.
        Dim oLines(0 To 1) As Inventor.SketchLine
        Try

            Dim sText As String
            sText = "<StyleOverride FontSize='0,7'>" & WP_ASSY_BB & "</StyleOverride>"
            Dim oTextBox As Inventor.TextBox
            oTextBox = oSketch.TextBoxes.AddFitted(oTG.CreatePoint2d(breete - 0.1, Hoogte), sText)


            'rgb systeem 120,120,120=grijs
            ' 255,0,0=rood
            Dim kleur As Inventor.Color = inventorApplication.TransientObjects.CreateColor(255, 0, 0)
            ' must be 0, pi/2, pi, or pi*1.5
            oTextBox.Rotation = Math.PI / 2
            oTextBox.Color() = kleur


        Catch ex As Exception
            ''  MsgBox("Peter H special error detected rerouting code", )


            oSketch.ExitEdit()

            ' Set a reference to the active drawing document


            ' Set a reference to the active sheet
            Dim oActiveSheet As Inventor.Sheet
            oActiveSheet = oDrawDoc.ActiveSheet

            ' Create the placement point for the text
            Dim oPoint As Inventor.Point2d
            oPoint = inventorApplication.TransientGeometry.CreatePoint2d(breete - 0.1, Hoogte)

            ' Define horizontally stacked text
            Dim strHorizontalStack As String
            '' strHorizontalStack = WP_ASSY_BB & "1  <Stack FractionalTextScale='0.7'>1/2</Stack>"

            strHorizontalStack = WP_ASSY_BB

            Dim strText As String
            strText = strHorizontalStack ''& "<Br/>"

            Dim oGeneralNote As Inventor.GeneralNote
            oGeneralNote = oActiveSheet.DrawingNotes.GeneralNotes.AddFitted(oPoint, strText)
            oGeneralNote.Rotation = Math.PI / 2
            oGeneralNote.FormattedText = "<StyleOverride FontSize = '0.7'>" & WP_ASSY_BB & "<StyleOverride Color = '255,0,0'>" & "</StyleOverride>" & "</StyleOverride>"



            ''Nieuw voor jan zorgt dat note juist wordt uitgelijnd
            oGeneralNote.VerticalJustification = Inventor.VerticalTextAlignmentEnum.kAlignTextLower
            oGeneralNote.Position = oPoint
            ''Nieuw voor jan 


            oSketch = oDrawDoc.ActiveSheet.Sketches.Add
            oSketch.Edit()


            oLines(0) = oSketch.SketchLines.AddByTwoPoints(oTG.CreatePoint2d(breete, 7.9), oTG.CreatePoint2d(breete - 1.2, 7.9))
            oLines(1) = oSketch.SketchLines.AddByTwoPoints(oLines(0).EndSketchPoint, oTG.CreatePoint2d(breete - 1.2, 0.8))

            oSketch.ExitEdit()

            'toevoegen naam aan schets V
            oSketch.Name = WP_ASSY_BB




            Call print_fysiek()


            ''schets verwijderen
            oSketch.Delete()
            oGeneralNote.Delete()
            Exit Sub

        End Try

        ''   oTextBox.width = 10

        oLines(0) = oSketch.SketchLines.AddByTwoPoints(oTG.CreatePoint2d(breete, 7.9), oTG.CreatePoint2d(breete - 1.2, 7.9))
        oLines(1) = oSketch.SketchLines.AddByTwoPoints(oLines(0).EndSketchPoint, oTG.CreatePoint2d(breete - 1.2, 0.8))

        oSketch.ExitEdit()

        'toevoegen naam aan schets V
        oSketch.Name = WP_ASSY_BB




        Call print_fysiek()




        ''Toevoegen sheet 2 bestempelen






        ''schets verwijderen
        oSketch.Delete()



    End Sub


    Private Sub Print_fysiek()

        'Print all sheets in drawing document
        'Get the active document and check whether it's drawing document
        If inventorApplication.ActiveDocument.DocumentType = Inventor.DocumentTypeEnum.kDrawingDocumentObject Then
            Dim oDrgDoc As Inventor.DrawingDocument
            oDrgDoc = inventorApplication.ActiveDocument

            ' Set reference to drawing print manager
            ' DrawingPrintManager has more options than PrintManager
            ' as it's specific to drawing document
            Dim oDrgPrintMgr As Inventor.DrawingPrintManager
            oDrgPrintMgr = oDrgDoc.PrintManager
            ' Set the printer name
            ' comment this line to use default printer or assign another one
            If RadioButton_HP_5100.Checked = True Then
                oDrgPrintMgr.Printer = "\\VTKFILE\HP5100"
            ElseIf RadioButton_Xerox_Boven.Checked = True Then
                ''  oDrgPrintMgr.Printer = "\\VTKFILE\Xerox WorkCentre 5632 PS"

                ''perforeeren of niet optie makenp erforeeren of niet optie maken
                ''perforeeren of niet optie maken
                ' '''perforeeren of niet optie maken
                '' '''perforeeren of niet optie maken
                '' '''perforeeren of niet optie maken
                '' '''perforeeren of niet optie maken
                '' '''perforeeren of niet optie maken

                '' '''perforeeren of niet optie maken
                oDrgPrintMgr.Printer = "\\VTKFILE\Xerox 5632 Engineering (Perforeren)"



            ElseIf RadioButton_default.Checked = True Then
                ''  oDrgPrintMgr.Printer = Nothing
                '' alles weg hier zodat iv laatst gebruikte printer neemt
            End If





            'Set the paper size , scale and orientation
            oDrgPrintMgr.ScaleMode = Inventor.PrintScaleModeEnum.kPrintBestFitScale
            oDrgPrintMgr.PaperSize = Inventor.PaperSizeEnum.kPaperSizeA3
            oDrgPrintMgr.PrintRange = Inventor.PrintRangeEnum.kPrintCurrentSheet
            oDrgPrintMgr.Orientation = Inventor.PrintOrientationEnum.kLandscapeOrientation
            oDrgPrintMgr.SubmitPrint()
        End If


    End Sub

#End Region

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            GroupBox_Stempeltype.Visible = True
            GroupBox_Printer.Visible = True
            CheckBox_Werkplaats.Checked = True
            CheckBox_Assemblage.Checked = True
            CheckBox_Bedrijfsbureau.Checked = True
        Else
            GroupBox_Stempeltype.Visible = False
            GroupBox_Printer.Visible = False
            CheckBox_Werkplaats.Checked = False
            CheckBox_Assemblage.Checked = False
            CheckBox_Bedrijfsbureau.Checked = False
        End If
    End Sub

    Sub ProcessTree(ByVal Dir As String)
        Dim DirObj As New DirectoryInfo(Dir)
        Dim Files As FileInfo() = DirObj.GetFiles("*.*")
        Dim Dirs As DirectoryInfo() = DirObj.GetDirectories("*.*")
        Dim Filename As FileInfo
        Dim DirectoryName As DirectoryInfo

        For Each Filename In Files
            Try
                If (Filename.Attributes And FileAttributes.ReadOnly) Then
                    Filename.Attributes = (Filename.Attributes And Not FileAttributes.ReadOnly)
                End If
            Catch E As Exception
                Console.WriteLine("Error changing attribute for {0}", Filename.FullName)
                Console.WriteLine("Error: {0}", E.Message)
            End Try
        Next
        For Each DirectoryName In Dirs
            Try
                ProcessTree(DirectoryName.FullName)
            Catch E As Exception
                Console.WriteLine("Error accessing {0}", DirectoryName.FullName)
                Console.WriteLine("Error: {0}", E.Message)
            End Try
        Next
    End Sub

End Class