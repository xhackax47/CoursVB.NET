Imports System.IO

Public Class ZBackup

    Const FichierIni As String = "Zbackup.ini"
    Const LignesFichierIni As Integer = 6
    Const CleSavePath As String = "SavePath"
    Const CleTempSave As String = "TempSave"
    Const CleNbSaves As String = "NbSaves"
    Const ClePaths As String = "Paths"

    Private Sub ZBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TIM_SAVE.Interval = Me.NUM_SAVETIME.Value * 3600000 'Conversion heure en ms
        Me.TIM_SAVE.Enabled = True

        'Récupération de la config
        If RecupereInfosFichierIni() Then
            'Sauvegarde d'office
            Save()
        End If
    End Sub

#Region "Interface"

    Private Sub TXT_SAVEPATH_Click(sender As Object, e As EventArgs) Handles TXT_SAVEPATH.Click

        'Ajoute la ligne seulement si un dossier a été sélectionné dans le dial
        If Me.BD_FOLDER.ShowDialog() Then
            Me.TXT_SAVEPATH.Text = Me.BD_FOLDER.SelectedPath
        End If

    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        'Ajoute la ligne seulement si un dossier a été sélectionné dans le dial
        If Me.BD_FOLDER.ShowDialog() Then
            Me.LB_SAVEDPATHS.Items.Add(Me.BD_FOLDER.SelectedPath)
        End If
    End Sub

    Private Sub BT_REMOVE_Click(sender As Object, e As EventArgs) Handles BT_REMOVE.Click
        'Vérifie si une ligne est selectionnée dans la listbox
        If Not Me.LB_SAVEDPATHS.SelectedItem Is Nothing Then
            Me.LB_SAVEDPATHS.Items.Remove(Me.LB_SAVEDPATHS.SelectedItem)
        Else
            MsgBox("Selectionner le chemin à supprimer")
        End If
    End Sub

    Private Sub BT_SAVECFG_Click(sender As Object, e As EventArgs) Handles BT_SAVECFG.Click
        'Sauvegarde Configuration dans fichier INI
        SaveINIConfigFile()
    End Sub

    Private Sub TIM_SAVE_Tick(sender As Object, e As EventArgs) Handles TIM_SAVE.Tick
        'Sauvegarde timer
        Save()
    End Sub

    Private Sub BT_MANUSAVE_Click(sender As Object, e As EventArgs) Handles BT_MANUSAVE.Click
        'Sauvegarde Manuelle
        Save()
    End Sub

#End Region

#Region "INI"

    Sub SaveINIConfigFile()
        'Vérification sur le path de sauvegarde
        If Me.TXT_SAVEPATH.Text = "" Then
            MsgBox("Veuillez selectionner un chemin de sauvegarde")
        ElseIf Not Directory.Exists(Me.TXT_SAVEPATH.Text) Then
            MsgBox("Chemin de sauvegarde n'existe pas")
        Else
            'Fonction recrée le fichier quoiqu'il arrive
            File.WriteAllLines(FichierIni, CreeStructureFichierIni(Me.TXT_SAVEPATH.Text, Me.NUM_SAVETIME.Value, Me.NUM_NBSAVE.Value, Me.LB_SAVEDPATHS.Items))
        End If
    End Sub

    Function CreeStructureFichierIni(SavePath As String, TempsSave As Integer, Nbsaves As Integer, PathsASave As ListBox.ObjectCollection) As String()

        'Crée un tableau du nombre de lignes requises
        Dim FichierIni(LignesFichierIni + PathsASave.Count) As String
        'Remplir la structure du fichier ini
        FichierIni(0) = ";Fichier de configuration du Zbackup"
        FichierIni(1) = "[configuration]"
        FichierIni(2) = CleSavePath & "=" & SavePath
        FichierIni(3) = CleTempSave & "=" & TempsSave
        FichierIni(4) = CleNbSaves & "=" & Nbsaves
        FichierIni(5) = ""
        FichierIni(6) = "[paths]"
        'Remplir dynamiquement les paths souhaités
        Dim Compteur As Integer = LignesFichierIni
        For Each Path As String In PathsASave
            Compteur += 1
            FichierIni(Compteur) = ClePaths & Compteur - LignesFichierIni & "=" & Path
        Next

        Return FichierIni

    End Function

    Function RecupereCleFichierIni(Cle As String) As String

        For Each Ligne As String In File.ReadAllLines(FichierIni)
            'Découpe la ligne au niveau de « = » (s'il existe), 
            'compare la première partie de la ligne (soit la clé)
            If Ligne.Split("=")(0) = Cle Then
                'Recupère la seconde partie de la ligne (soit la valeur)
                Return Ligne.Split("=")(1)
            End If
        Next
        'Sinon ne retourne rien
        Return ""

    End Function

    Function RecupereInfosFichierIni() As Boolean

        'Vérification de la présence du .ini
        If File.Exists(FichierIni) Then
            'Récuperation
            Dim SavePath As String = RecupereCleFichierIni(CleSavePath)
            Dim TempSAve As String = RecupereCleFichierIni(CleTempSave)
            Dim NbSaves As String = RecupereCleFichierIni(CleNbSaves)
            Dim Paths(100) As String
            Dim i As Integer = 0 '0 car le premier path est à 1 et on incrémente avant
            Do
                i += 1
                Paths(i - 1) = RecupereCleFichierIni(ClePaths & i)
            Loop While Paths(i - 1) <> ""
            'Donc nombre de paths valides : i-1

            'Vérification
            If (SavePath <> "") And (TempSAve <> "") And (NbSaves <> "") And (i - 1 > 0) Then
                'Attribution
                Me.TXT_SAVEPATH.Text = SavePath
                Me.NUM_NBSAVE.Value = NbSaves
                Me.NUM_SAVETIME.Value = TempSAve
                'Nettoie le LB, puis le remplit
                Me.LB_SAVEDPATHS.Items.Clear()
                For j As Integer = 0 To i - 1
                    Me.LB_SAVEDPATHS.Items.Add(Paths(j))
                Next
            Else
                'Sinon notification
                MsgBox("Le fichier " & FichierIni & " est corrompu, utilisation des paramètres par défaut")
                Return False
            End If
        Else
            'Sinon notification
            MsgBox("Le fichier " & FichierIni & " n'a pas été trouvé, utilisation des paramètres par défaut")
            Return False
        End If

        Return True

    End Function

#End Region

#Region "Sauvegarde"
    Sub Save()
        'Vérifier paramètres
        If Directory.Exists(Me.TXT_SAVEPATH.Text) Then
            'Vérifier nb sauvegardes
            'Supprimer la plus vieille si limite
            CleanNbSaves()

            'Si dernier char est un "\", on le suppr
            If Me.TXT_SAVEPATH.Text.EndsWith("\") Then
                Me.TXT_SAVEPATH.Text.Trim("\")
            End If
            'Créer dossier sauvegarde
            'Supprime les "/" et ":" de la date/heure
            Dim savedDir As String = Me.TXT_SAVEPATH.Text & "\Sauvegarde du " & Date.Now.ToShortDateString.Replace("/", "-") & " a " & Date.Now.ToShortTimeString.Replace(":", "-")
            ' Si il existe deux saves dans la même minute, on ne la fait pas
            If Not Directory.Exists(savedDir) Then
                Directory.CreateDirectory(savedDir)
                'Pour chaque path demandé, copie son dossier
                For Each pathToSave As String In Me.LB_SAVEDPATHS.Items
                    If Directory.Exists(pathToSave) Then
                        DirCopy(New DirectoryInfo(pathToSave), New DirectoryInfo(savedDir & "\" & Path.GetFileName(pathToSave)))
                    End If
                Next
            End If
        Else
            MsgBox("Sauvegarde échouée : le path de sauvegarde est invalide, veuillez le redéfinir")
        End If
    End Sub

    Sub CleanNbSaves()
        Dim count As Integer = 1
        For Each dir As String In Directory.GetDirectories(Me.TXT_SAVEPATH.Text)
            'Si le répertoire est un répertoire de sauvegarde
            If Path.GetFileName(dir).Contains("Sauvegarde") Then
                count += 1
            End If
        Next

        If count > Me.NUM_NBSAVE.Value Then
            'Déterminer le plus ancien
            Dim older As DirectoryInfo
            Dim olderDate As Date = Date.Now
            For Each dir As String In Directory.GetDirectories(Me.TXT_SAVEPATH.Text)
                'Si le répertoire est un répertoire de sauvegarde
                If Path.GetFileName(dir).Contains("Sauvegarde") Then
                    'Si le répertoire est plus ancien que le précédent
                    If (Directory.GetCreationTime(dir) < olderDate) Then
                        'On le place en olderDate
                        olderDate = Directory.GetCreationTime(dir)
                        older = New DirectoryInfo(dir)
                    End If
                End If
            Next

            'Suppression du plus vieux
            If older IsNot Nothing Then
                If older.Exists Then
                    older.Delete(True)
                Else
                    MsgBox("Aucune vieille configuration")
                End If
            End If
        End If
    End Sub

    Sub DirCopy(sourceDir As DirectoryInfo, destinationDir As DirectoryInfo)
        'Création dossier
        destinationDir.Create()

        'Copie fichiers
        For Each file As FileInfo In sourceDir.GetFiles()
            file.CopyTo(Path.Combine(destinationDir.FullName, file.Name))
        Next

        'Copie sous-répertoires
        For Each subDir As DirectoryInfo In sourceDir.GetDirectories()
            DirCopy(subDir, destinationDir.CreateSubdirectory(subDir.Name))
        Next
    End Sub

#End Region
End Class
