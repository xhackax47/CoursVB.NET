Public Class Form1
    ' Méthode qui s'applique lors du chargement du programme (de la form plus précisément)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Les lignes suivantes peuvent être remplacées par Me.WB_NAVIGATEUR.Navigate("http://www.google.fr")
        Dim googleAdress As String = "http://www.google.fr"
        Me.TXT_ADRESS.Text = googleAdress
        'Simulation clic avec comme argument nothing (null)
        Me.BT_SEND_Click(Nothing, Nothing)

        'Au démarrage, désactivé BT_NEXT, BT_PREVIOUS & BT_STOP
        Me.BT_NEXT.Enabled = False
        Me.BT_PREVIOUS.Enabled = False
        Me.BT_STOP.Enabled = False
    End Sub
#Region "Evènements du WebBrowser"

    ' Méthode qui s'applique à chaque changement d'état, on met à jour les boutons
    Sub WB_BROWSER_CanGoForwardChanged(sender As Object, e As EventArgs) Handles WB_BROWSER.CanGoForwardChanged
        If Me.WB_BROWSER.CanGoForward Then
            Me.BT_NEXT.Enabled = True
        Else
            Me.BT_NEXT.Enabled = False
        End If
    End Sub

    ' Méthode qui s'applique à chaque changement d'état, on met à jour les boutons
    Sub WB_BROWSER_CanGoBackChanged(sender As Object, e As EventArgs) Handles WB_BROWSER.CanGoBackChanged
        If Me.WB_BROWSER.CanGoBack Then
            Me.BT_PREVIOUS.Enabled = True
        Else
            Me.BT_PREVIOUS.Enabled = False
        End If
    End Sub

    ' Méthode qui s'applique au changement de statut de la page
    Sub WB_BROWSER_StatutTextChanged(sender As Object, e As EventArgs) Handles WB_BROWSER.StatusTextChanged
        'On met le statut à jour
        Me.LBL_STATUS.Text = WB_BROWSER.StatusText
    End Sub

    ' Méthode qui s'applique au changement de progression de la page
    Sub WB_BROWSER_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WB_BROWSER.ProgressChanged
        Me.PGB_STATUS.Maximum = e.MaximumProgress
        If e.CurrentProgress >= 0 And e.CurrentProgress <= e.MaximumProgress Then
            Me.PGB_STATUS.Maximum = e.CurrentProgress
        End If
    End Sub

    ' Méthode qui s'applique lorsque le document web est complètement chargé
    Private Sub WB_BROWSER_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WB_BROWSER.DocumentCompleted
        'Lorsque le document est chargé, mettre StatusText du WebBrowser dans LBL_STATUS, désactiver le BT_STOP et appliquer la méthode ToString de Url sur le texte
        'contenu dans TXT_ADRESS
        Me.BT_STOP.Enabled = False
        Me.PGB_STATUS.Visible = False
        Me.LBL_STATUS.Text = WB_BROWSER.StatusText
        Me.TXT_ADRESS.Text = Me.WB_BROWSER.Url.ToString
    End Sub

    ' Méthode qui s'applique pendant le chargement du document web
    Private Sub WB_BROWSER_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WB_BROWSER.Navigating
        'Lors du chargement de la page, activer le BT_STOP, mettre le StatusText du WebBrowser dans le LBL_STATUS
        Me.BT_STOP.Enabled = True
        Me.PGB_STATUS.Visible = True
        Me.LBL_STATUS.Text = WB_BROWSER.StatusText
        'Si le WebBrowser peut faire Suivant, activer le BT_NEXT sinon le désactiver
        If Me.WB_BROWSER.CanGoForward Then
            Me.BT_NEXT.Enabled = True
        Else
            Me.BT_NEXT.Enabled = False
        End If
        'Si le WebBrowser peut faire Précédent, activer le BT_PREVIOUS sinon le désactiver
        If Me.WB_BROWSER.CanGoBack Then
            Me.BT_PREVIOUS.Enabled = True
        Else
            Me.BT_PREVIOUS.Enabled = False
        End If
    End Sub
#End Region

    ' Méthode d'envoi de l'adresse pour résolution et chargement du document web
    Private Sub BT_SEND_Click(sender As Object, e As EventArgs) Handles BT_SEND.Click
        'Aller à l'adresse entrée dans le TXT_ADRESS lors du click sur BT_SEND
        If Not Me.TXT_ADRESS Is Nothing Then
            Me.WB_BROWSER.Navigate(TXT_ADRESS.Text)
        End If
    End Sub

    ' Méthode de retour sur le clic du BT_PREVIOUS
    Private Sub BT_PREVIOUS_Click(sender As Object, e As EventArgs) Handles BT_PREVIOUS.Click
        Me.WB_BROWSER.GoBack()
    End Sub

    ' Méthode d'avance sur le clic du BT_NEXT
    Private Sub BT_NEXT_Click(sender As Object, e As EventArgs) Handles BT_NEXT.Click
        Me.WB_BROWSER.GoForward()
    End Sub

    ' Méthode d'actualisation sur le clic du BT_REFRESH
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        Me.WB_BROWSER.Refresh()
    End Sub

    ' Méthode d'arrêt sur le clic du BT_STOP
    Private Sub BT_STOP_Click(sender As Object, e As EventArgs) Handles BT_STOP.Click
        'Désactiver BT_STOP lors du clic sur celui-ci et appel de la méthode Stop() de WebBrowser
        Me.BT_STOP.Enabled = False
        Me.WB_BROWSER.Stop()
    End Sub

    ' Méthode pour quitter le programme
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Souhaitez-vous vraiment quitter ce navigateur ?", 36, "Quitter") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

End Class
