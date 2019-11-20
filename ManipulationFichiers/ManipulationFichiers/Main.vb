Imports System.IO

Public Class Main

    Const filepath As String = "Test.txt"
    'Dim myFile As FileStream

    'Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' Création objet FileStream
    '    myFile = New FileStream("Test.txt", FileMode.OpenOrCreate)
    'End Sub

    'Private Sub Main_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
    '    ' Libération mémoire
    '    myFile.Dispose()
    'End Sub

#Region "Gestion boutons"

    Private Sub BT_READ_Click(sender As Object, e As EventArgs) Handles BT_READ.Click

        Me.TXT_READ.Text = File.ReadAllText(filepath)
        '' Si myFile peut être lu
        'If myFile.CanRead() Then
        '    ' Création Tableau de Byte
        '    Dim content(1024) As Byte
        '    ' Mise à la position de départ
        '    myFile.Position = 0
        '    ' Lecture des bytes et entrée dans le tableau
        '    myFile.Read(content, 0, 1024)
        '    ' Affichage par parcours du tableau
        '    Me.TXT_READ.Text = ""
        '    For Each letter As Byte In content
        '        Me.TXT_READ.Text += Chr(letter)
        '    Next
        'End If
    End Sub

    Private Sub BT_WRITE_Click(sender As Object, e As EventArgs) Handles BT_WRITE.Click
        ' Si myFile peut être écrit
        'If myFile.CanWrite Then
        '    ' Création Tableau de Byte
        '    Dim content(1024) As Byte
        '    Dim count As Integer = 0
        '    ' Ecriture par parcours de la textbox
        '    For Each letter As Char In Me.TXT_WRITE.Text.ToCharArray
        '        'Convertit une lettre en sa valeur ASCII et incrémente le compteur
        '        content(count) = Asc(letter)
        '        count += 1
        '    Next
        ' Si la checkbox CHK_START est cochée alors
        If Me.CHK_START.Checked Then
                ' Mise à la position de départ
                'myFile.Position = 0
                ' Ecriture du texte dans le fichier depuis le début
                File.WriteAllText(filepath, Me.TXT_WRITE.Text)
            Else
                ' Ecriture du texte dans le fichier à la suite
                File.AppendAllText(filepath, Me.TXT_WRITE.Text)
            End If
        ' Ecriture dans le fichier
        'myFile.Write(content, 0, count)
        'End If
    End Sub

    Private Sub BT_CLEAN_READ_Click(sender As Object, e As EventArgs) Handles BT_CLEAN_READ.Click
        Me.TXT_READ.Text = ""
    End Sub

    Private Sub BT_CLEAN_WRITE_Click(sender As Object, e As EventArgs) Handles BT_CLEAN_WRITE.Click
        Me.TXT_WRITE.Text = ""
    End Sub

    Private Sub BT_CLEARFILE_Click(sender As Object, e As EventArgs) Handles BT_CLEARFILE.Click
        File.WriteAllText(filepath, "")
        ' Fermeture du fichier et libération mémoire
        'myFile.Dispose()
        ' Ouverture du fichier en écrasant ses données
        'myFile = New IO.FileStream("Test.txt", IO.FileMode.Create)
    End Sub

#End Region

End Class
