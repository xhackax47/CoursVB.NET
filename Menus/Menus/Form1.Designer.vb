<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_MENU = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_MENU = New System.Windows.Forms.ToolStripTextBox()
        Me.EcrireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBL_TEXT = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PGB_STATUS = New System.Windows.Forms.ProgressBar()
        Me.LBL_STATUS = New System.Windows.Forms.Label()
        Me.TIM_STATUS = New System.Windows.Forms.Timer(Me.components)
        Me.CMS_LABEL = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DéplacerLeLabelIciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.CMS_LABEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.AfficherToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'AfficherToolStripMenuItem
        '
        Me.AfficherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CB_MENU, Me.ToolStripComboBox2})
        Me.AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem"
        Me.AfficherToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AfficherToolStripMenuItem.Text = "Afficher"
        '
        'CB_MENU
        '
        Me.CB_MENU.Enabled = False
        Me.CB_MENU.Items.AddRange(New Object() {"Bonjour !", "Au revoir.", "Ciao.", "Bye bye.", "Astalavista baby !"})
        Me.CB_MENU.Name = "CB_MENU"
        Me.CB_MENU.Size = New System.Drawing.Size(189, 23)
        Me.CB_MENU.Text = "Message prédéfini"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TXT_MENU, Me.EcrireToolStripMenuItem})
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(249, 22)
        Me.ToolStripComboBox2.Text = "Message personnalisé"
        '
        'TXT_MENU
        '
        Me.TXT_MENU.Name = "TXT_MENU"
        Me.TXT_MENU.Size = New System.Drawing.Size(100, 23)
        '
        'EcrireToolStripMenuItem
        '
        Me.EcrireToolStripMenuItem.Name = "EcrireToolStripMenuItem"
        Me.EcrireToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EcrireToolStripMenuItem.Text = "Ecrire"
        '
        'LBL_TEXT
        '
        Me.LBL_TEXT.AutoSize = True
        Me.LBL_TEXT.ContextMenuStrip = Me.CMS_LABEL
        Me.LBL_TEXT.Location = New System.Drawing.Point(236, 143)
        Me.LBL_TEXT.Name = "LBL_TEXT"
        Me.LBL_TEXT.Size = New System.Drawing.Size(60, 13)
        Me.LBL_TEXT.TabIndex = 1
        Me.LBL_TEXT.Text = "LBL_TEXT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 277)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(620, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PGB_STATUS
        '
        Me.PGB_STATUS.Location = New System.Drawing.Point(106, 277)
        Me.PGB_STATUS.Name = "PGB_STATUS"
        Me.PGB_STATUS.Size = New System.Drawing.Size(100, 23)
        Me.PGB_STATUS.TabIndex = 3
        '
        'LBL_STATUS
        '
        Me.LBL_STATUS.AutoSize = True
        Me.LBL_STATUS.Location = New System.Drawing.Point(27, 286)
        Me.LBL_STATUS.Name = "LBL_STATUS"
        Me.LBL_STATUS.Size = New System.Drawing.Size(0, 13)
        Me.LBL_STATUS.TabIndex = 4
        '
        'TIM_STATUS
        '
        '
        'CMS_LABEL
        '
        Me.CMS_LABEL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DéplacerLeLabelIciToolStripMenuItem})
        Me.CMS_LABEL.Name = "CMS_LABEL"
        Me.CMS_LABEL.Size = New System.Drawing.Size(182, 26)
        '
        'DéplacerLeLabelIciToolStripMenuItem
        '
        Me.DéplacerLeLabelIciToolStripMenuItem.Name = "DéplacerLeLabelIciToolStripMenuItem"
        Me.DéplacerLeLabelIciToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DéplacerLeLabelIciToolStripMenuItem.Text = "Déplacer Le Label Ici"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 299)
        Me.Controls.Add(Me.LBL_STATUS)
        Me.Controls.Add(Me.PGB_STATUS)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LBL_TEXT)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CMS_LABEL.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBL_TEXT As Label
    Friend WithEvents ToolStripComboBox2 As ToolStripMenuItem
    Friend WithEvents TXT_MENU As ToolStripTextBox
    Friend WithEvents EcrireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PGB_STATUS As ProgressBar
    Friend WithEvents LBL_STATUS As Label
    Friend WithEvents TIM_STATUS As Timer
    Friend WithEvents CMS_LABEL As ContextMenuStrip
    Friend WithEvents DéplacerLeLabelIciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CB_MENU As ToolStripComboBox
End Class
