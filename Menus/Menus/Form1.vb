Public Class Form1
    'Méthode de Pause pour la barre de chargement
    Private Sub PauseFactice()
        LBL_STATUS.Text = "Chargement ..."
        PGB_STATUS.Value = 0
        TIM_STATUS.Enabled = True
    End Sub
    'Méthode de Reset pour le bouton Reset qui remet à zéro le label
    Private Sub ResetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        'Efface le label
        PauseFactice()
        Me.LBL_TEXT.Text = ""
    End Sub
    'Méthode pour le MenuItem "Quitter" pour fermer l'application
    Private Sub QuitterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        'Fermeture avec confirmation
        If MsgBox("Souhaitez-vous vraiment quitter ce magnifique programme ?", 36, "Quitter") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    'Méthode qui permet d'afficher dans le label le texte correspondant à l'index de la combobox
    Private Sub CB_MENU_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        'Écrit le texte de la combobox lors du changement d'index
        PauseFactice()
        Me.LBL_TEXT.Text = Me.CB_MENU.SelectedItem
    End Sub
    'Méthode qui permet avec le bouton "Ecrire" d'écrire le texte de la TextBox dans le Label
    Private Sub EcrireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EcrireToolStripMenuItem.Click
        'Écrit le texte de la textbox lors de l'appui sur « Écrire »
        PauseFactice()
        Me.LBL_TEXT.Text = Me.TXT_MENU.Text
    End Sub
    'Méthode qui permet de lier la ProgressBar au Timer
    Private Sub TIM_STATUS_Tick(sender As Object, e As EventArgs) Handles TIM_STATUS.Tick
        'Si la progressbar est arrivée au bout, on désactive le timer
        If Me.PGB_STATUS.Value = 100 Then
            Me.TIM_STATUS.Enabled = False
            LBL_STATUS.Text = "Prêt"
        Else
            'Incrémente de 1 la progressbar
            Me.PGB_STATUS.Value += 1
        End If
    End Sub
    'Méthode qui permet de déplacer le label via un clic droit (ContextMenuStrip)
    Private Sub DéplacerLeLabelIciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéplacerLeLabelIciToolStripMenuItem.Click
        Me.LBL_TEXT.Location = Control.MousePosition
    End Sub

End Class
