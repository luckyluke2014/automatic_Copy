Imports System
Imports System.IO
Imports System.Collections
Imports System.Xml.Linq
Imports org.apache.pdfbox.pdmodel
Imports org.apache.pdfbox.util

Public Class Form1

    Public files As Array
    Public oFile As IO.FileInfo
    Public Go() As String
    Public NoGo() As String
    Public listeZK As New List(Of String)()
    Public listeZKK As New List(Of String)()
    Public ultimateZaehler As Integer = 0

    Private Sub CopyFromBtn_Click(sender As Object, e As EventArgs) Handles CopyFromBtn.Click
        If FolderFrom.ShowDialog() = DialogResult.OK Then
            Label3.Text = FolderFrom.SelectedPath()
            My.Settings.folderFrom = FolderFrom.SelectedPath()
        End If
        If listeZK.Count() > 0 And Label4.Text <> "nothing" And Label3.Text <> "nothing" Then
            Copynowbtn.Visible = True

        Else
            Copynowbtn.Visible = False
        End If
    End Sub

    Private Sub CopyToBtn_Click(sender As Object, e As EventArgs) Handles CopyToBtn.Click
        If FolderTo.ShowDialog() = DialogResult.OK Then
            Label4.Text = FolderTo.SelectedPath()
            My.Settings.folderTo = FolderTo.SelectedPath()

        End If

        If listeZK.Count() > 0 And Label4.Text <> "nothing" And Label3.Text <> "nothing" Then
            Copynowbtn.Visible = True

        Else
            Copynowbtn.Visible = False
        End If

    End Sub


    Private Sub COPYBtn_Click(sender As Object, e As EventArgs) Handles COPYBtn.Click
         ' Verzeichnis, dessen Dateien ermittelt werden sollen
        
        resetandmore()


    End Sub
    Public Sub resetandmore()
        ProgressBar2.Value = 0

        ultimateZaehler = 0
        ListBox1.Items.Clear()
        listeZK.Clear()
        listeZKK.Clear()

        Dim sPath As String

        ' ggf. abschließenden Backslash entfernen
        sPath = Label3.Text()
        If sPath.EndsWith("\") And sPath.Length > 3 Then
            sPath = sPath.Substring(0, sPath.Length - 1)
        End If

        ' Directory-Object erstellen
        Try
            Dim oDir As New System.IO.DirectoryInfo(sPath)
       


            If Label3.Text <> "nothing" Then Rekursiv(oDir)
        Catch
        End Try
        If listeZK.Count() > 0 And Label4.Text <> "nothing" Then
            Copynowbtn.Visible = True

        Else
            Copynowbtn.Visible = False
        End If
        MsgBox(listeZK.Count() & " files found")
    End Sub
    Private Sub Rekursiv(ByVal oDir As IO.DirectoryInfo)
        Dim oSubDir As IO.DirectoryInfo
        Dim curname As String
        Dim curExtension() As String
        Dim cursize As Long
        Dim curDir As String
        ' zunächst alle Dateien des Ordners aufspüren
        For Each oFile In oDir.GetFiles()
            With oFile
                '  ListBox1.Items.Add(.DirectoryName & "\" & .Name & vbTab & _
                '    .Length & vbTab & .LastWriteTime)
                cursize = oFile.Length / 1000000
                cursize = Math.Round(cursize, 0)
                curname = oFile.Name
                curExtension = Split(curname, ".")
                curDir = oFile.DirectoryName
                auswahl(cursize, curname, curDir)
            End With
        Next

        ' Jetzt alle Unterverzeichnis durchlaufen
        ' und die Prozedur rekursiv selbst aufrufen
        For Each oSubDir In oDir.GetDirectories()
            Rekursiv(oSubDir)
        Next
    End Sub
    Public Sub auswahl(ByRef size As Long, ByRef name As String, ByRef dir As String)


        Dim extarray() As String
        Dim ext As String

        Dim zaehler1 As Integer = 0
        Dim zaehlerNoGo As Integer = 0

        Go = Split(Gotxt.Text, ";")

        NoGo = Split(NoGotxt.Text, ";")

        If Val(txtMB.Text) <= size Then
            For Each goo In Go
                ' For x As Integer = 1 To name.Length - goo.Length + 1
                If name.ToLower.Contains(goo.ToLower) Then
                    zaehler1 = zaehler1 + 1

                End If
                'Next
            Next
            If Go(0).Length = 0 Then zaehler1 = 1

            If zaehler1 = Go.Length Then
                If NoGo.Length > 0 And NoGo(0).Length > 0 Then
                    For Each Nogoo In NoGo
                        'For x As Integer = 1 To name.Length - Nogoo.Length + 1
                        If name.ToLower.Contains(Nogoo.ToLower) Then
                            zaehlerNoGo = zaehlerNoGo + 1

                        End If
                        'Next
                    Next
                End If


                If zaehlerNoGo = 0 Then
                    If txtFE.Text.Length > 0 Then
                        extarray = Split(name, ".")
                        ext = extarray(extarray.Length - 1)
                        If txtFE.Text = ext Then

                            listeZK.Add(dir.ToString & "\" & name.ToString)
                            If chkshow.Checked = False Then ListBox1.Items.Add(name.ToString)
                            If chkshow.Checked = True Then ListBox1.Items.Add(dir.ToString & "\" & name.ToString)

                        End If
                    Else

                        listeZK.Add(dir.ToString & "\" & name.ToString)
                        If chkshow.Checked = False Then ListBox1.Items.Add(name.ToString)
                        If chkshow.Checked = True Then ListBox1.Items.Add(dir.ToString & "\" & name.ToString)

                    End If

                End If

            End If

        End If
    End Sub
    Public Sub SearchPDF()
        Dim pdftotext As New PDFTextStripper

        Dim stringZuDurchsuchen As String
        Dim outputFileName As String = Application.StartupPath
        Dim zuSuchen As String
        ProgressBar2.Value = 0
        ProgressBar2.Maximum = listeZK.Count
        zuSuchen = SearchTxt.Text
        ListBox1.Items.Clear()
        ultimateZaehler = 0
        Dim errorcounter As Integer = 0

        For Each item In listeZK



            Dim doc As PDDocument = Nothing

            Try
                doc = PDDocument.load(item)
                Dim stripper As New PDFTextStripper()
                stringZuDurchsuchen = stripper.getText(doc)
                stringZuDurchsuchen = stringZuDurchsuchen.ToLower
            Catch
                errorcounter += 1
                ProgressBar2.Value += 1
                Continue For

            End Try
            If doc IsNot Nothing Then
                doc.close()
            End If


            If stringZuDurchsuchen.ToLower.Contains(zuSuchen) = True Then
                ListBox1.Items.Add(item)
                listeZKK.Add(item)
                ultimateZaehler += 1

            End If


            ProgressBar2.Value += 1

        Next

        ProgressBar2.Value = 0
        MsgBox(ultimateZaehler & " pdf found and " & errorcounter & " pdf files not searchable")
    End Sub
    Public Sub Searchphp()


        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim ganzertext As String = ""

        Dim outputFileName As String = Application.StartupPath
        Dim zuSuchen As String
        ProgressBar2.Value = 0
        ProgressBar2.Maximum = listeZK.Count
        zuSuchen = SearchTxt.Text.ToLower
        ListBox1.Items.Clear()
        ultimateZaehler = 0
        Dim pdftotext As New PDFTextStripper
        ProgressBar2.Value = 0
        ProgressBar2.Maximum = listeZK.Count
        zuSuchen = SearchTxt.Text
        ListBox1.Items.Clear()
        ultimateZaehler = 0
        Dim errorcounter As Integer = 0
        Dim extensionItemBefore As Array
        Dim extensionItem As String
        Dim stringZuDurchsuchen As String

        For Each item In listeZK
            extensionItemBefore = item.Split(".")
            extensionItem = extensionItemBefore(extensionItemBefore.Length - 1)
            If extensionItem = "pdf" Then

                Dim doc As PDDocument = Nothing

                Try
                    doc = PDDocument.load(item)
                    Dim stripper As New PDFTextStripper()
                    stringZuDurchsuchen = stripper.getText(doc)
                    stringZuDurchsuchen = stringZuDurchsuchen.ToLower
                Catch
                    errorcounter += 1
                    ProgressBar2.Value += 1
                    Continue For

                End Try
                If doc IsNot Nothing Then
                    doc.close()
                End If


                If stringZuDurchsuchen.ToLower.Contains(zuSuchen) = True Then
                    ListBox1.Items.Add(item)
                    listeZKK.Add(item)
                    ultimateZaehler += 1

                End If


                ProgressBar2.Value += 1


            Else


                 









                Try
                    Dim objReader As New StreamReader(item)
                    sLine = ""
                    arrText.Clear()




                    sLine = objReader.ReadToEnd()

                    arrText.Add(sLine)
                    ganzertext = sLine



                    objReader.Close()

                    If ganzertext.ToLower.Contains(zuSuchen.ToLower) = True And ganzertext.ToLower.Contains(SearchTxt.Text.ToLower) = True Then
                        ListBox1.Items.Add(item)
                        listeZKK.Add(item)
                        ultimateZaehler += 1

                    End If
                    ganzertext = ""


                    ProgressBar2.Value += 1
                Catch
                    errorcounter += 1
                    ProgressBar2.Value += 1
                    Continue For

                End Try

          
            End If
        Next



        ProgressBar2.Value = 0
        MsgBox(ultimateZaehler & " files found " & errorcounter & " errors")
    End Sub


    Public Sub KOPIEREN()
        Dim z1 As Integer = 0
        Dim zwischen() As String
        ProgressBar2.Value = 0
        ProgressBar2.Maximum = listeZK.Count()
        Dim dahinkopieren As String
        For Each item In listeZK
            
            zwischen = Split(listeZK(z1), "\")
            dahinkopieren = Label4.Text & "\" & zwischen(zwischen.Length - 1)

            System.IO.File.Copy(item, dahinkopieren, True)
            ProgressBar2.Value += 1
            z1 += 1
        Next
        Copynowbtn.Visible = False
    End Sub
 
    Private Sub Copynowbtn_Click(sender As Object, e As EventArgs) Handles Copynowbtn.Click
        KOPIEREN()

    End Sub

   
    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged
        resetandmore()

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If txtFE.Text = "pdf" Then
            'resetandmore()
            SearchPDF()
            listeZK = listeZKK
        Else
            Searchphp()


        End If


    End Sub

 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.folderFrom <> "" Then
            FolderFrom.SelectedPath = My.Settings.folderFrom
            Label3.Text = My.Settings.folderFrom
        End If
        If My.Settings.folderTo <> "" Then
            FolderTo.SelectedPath = My.Settings.folderTo
            Label4.Text = My.Settings.folderTo
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SearchBtn.Visible = True
            SearchTxt.Visible = True
        Else
            SearchBtn.Visible = False
            SearchTxt.Visible = False
        End If
         
    End Sub
End Class
