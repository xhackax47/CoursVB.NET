<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZBackup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GB_SAVEDDIRS = New System.Windows.Forms.GroupBox()
        Me.BT_REMOVE = New System.Windows.Forms.Button()
        Me.BT_ADD = New System.Windows.Forms.Button()
        Me.LB_SAVEDPATHS = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NUM_NBSAVE = New System.Windows.Forms.NumericUpDown()
        Me.NUM_SAVETIME = New System.Windows.Forms.NumericUpDown()
        Me.TXT_SAVEPATH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BT_SAVECFG = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_MANUSAVE = New System.Windows.Forms.Button()
        Me.BD_FOLDER = New System.Windows.Forms.FolderBrowserDialog()
        Me.TIM_SAVE = New System.Windows.Forms.Timer(Me.components)
        Me.GB_SAVEDDIRS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUM_NBSAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_SAVETIME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_SAVEDDIRS
        '
        Me.GB_SAVEDDIRS.Controls.Add(Me.BT_REMOVE)
        Me.GB_SAVEDDIRS.Controls.Add(Me.BT_ADD)
        Me.GB_SAVEDDIRS.Controls.Add(Me.LB_SAVEDPATHS)
        Me.GB_SAVEDDIRS.Location = New System.Drawing.Point(13, 13)
        Me.GB_SAVEDDIRS.Name = "GB_SAVEDDIRS"
        Me.GB_SAVEDDIRS.Size = New System.Drawing.Size(739, 318)
        Me.GB_SAVEDDIRS.TabIndex = 0
        Me.GB_SAVEDDIRS.TabStop = False
        Me.GB_SAVEDDIRS.Text = "Dossiers à sauvegarder"
        '
        'BT_REMOVE
        '
        Me.BT_REMOVE.Location = New System.Drawing.Point(390, 264)
        Me.BT_REMOVE.Name = "BT_REMOVE"
        Me.BT_REMOVE.Size = New System.Drawing.Size(75, 23)
        Me.BT_REMOVE.TabIndex = 2
        Me.BT_REMOVE.Text = "Supprimer"
        Me.BT_REMOVE.UseVisualStyleBackColor = True
        '
        'BT_ADD
        '
        Me.BT_ADD.Location = New System.Drawing.Point(223, 264)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(75, 23)
        Me.BT_ADD.TabIndex = 1
        Me.BT_ADD.Text = "Ajouter"
        Me.BT_ADD.UseVisualStyleBackColor = True
        '
        'LB_SAVEDPATHS
        '
        Me.LB_SAVEDPATHS.FormattingEnabled = True
        Me.LB_SAVEDPATHS.Location = New System.Drawing.Point(7, 20)
        Me.LB_SAVEDPATHS.Name = "LB_SAVEDPATHS"
        Me.LB_SAVEDPATHS.Size = New System.Drawing.Size(726, 238)
        Me.LB_SAVEDPATHS.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NUM_NBSAVE)
        Me.GroupBox1.Controls.Add(Me.NUM_SAVETIME)
        Me.GroupBox1.Controls.Add(Me.TXT_SAVEPATH)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BT_SAVECFG)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 338)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuration"
        '
        'NUM_NBSAVE
        '
        Me.NUM_NBSAVE.Location = New System.Drawing.Point(193, 125)
        Me.NUM_NBSAVE.Name = "NUM_NBSAVE"
        Me.NUM_NBSAVE.Size = New System.Drawing.Size(31, 20)
        Me.NUM_NBSAVE.TabIndex = 8
        '
        'NUM_SAVETIME
        '
        Me.NUM_SAVETIME.Location = New System.Drawing.Point(208, 82)
        Me.NUM_SAVETIME.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUM_SAVETIME.Name = "NUM_SAVETIME"
        Me.NUM_SAVETIME.Size = New System.Drawing.Size(33, 20)
        Me.NUM_SAVETIME.TabIndex = 7
        Me.NUM_SAVETIME.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TXT_SAVEPATH
        '
        Me.TXT_SAVEPATH.Location = New System.Drawing.Point(250, 39)
        Me.TXT_SAVEPATH.Name = "TXT_SAVEPATH"
        Me.TXT_SAVEPATH.Size = New System.Drawing.Size(364, 20)
        Me.TXT_SAVEPATH.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "heures"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "sauvegardes différentes"
        '
        'BT_SAVECFG
        '
        Me.BT_SAVECFG.Location = New System.Drawing.Point(268, 186)
        Me.BT_SAVECFG.Name = "BT_SAVECFG"
        Me.BT_SAVECFG.Size = New System.Drawing.Size(163, 23)
        Me.BT_SAVECFG.TabIndex = 3
        Me.BT_SAVECFG.Text = "Sauvegarder la configuration"
        Me.BT_SAVECFG.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Garder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Toutes les"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sauvegarde sous :"
        '
        'BT_MANUSAVE
        '
        Me.BT_MANUSAVE.Location = New System.Drawing.Point(281, 594)
        Me.BT_MANUSAVE.Name = "BT_MANUSAVE"
        Me.BT_MANUSAVE.Size = New System.Drawing.Size(163, 23)
        Me.BT_MANUSAVE.TabIndex = 4
        Me.BT_MANUSAVE.Text = "Sauvegarder manuellement"
        Me.BT_MANUSAVE.UseVisualStyleBackColor = True
        '
        'BD_FOLDER
        '
        Me.BD_FOLDER.SelectedPath = "C:\Users\Y0771889\OneDrive - ArcelorMittal\Documents\Sauvegardes ZBackup"
        '
        'TIM_SAVE
        '
        '
        'ZBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 629)
        Me.Controls.Add(Me.BT_MANUSAVE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_SAVEDDIRS)
        Me.Name = "ZBackup"
        Me.Text = "ZBackup"
        Me.GB_SAVEDDIRS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUM_NBSAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_SAVETIME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_SAVEDDIRS As GroupBox
    Friend WithEvents BT_REMOVE As Button
    Friend WithEvents BT_ADD As Button
    Friend WithEvents LB_SAVEDPATHS As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_SAVECFG As Button
    Friend WithEvents BT_MANUSAVE As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_SAVEPATH As TextBox
    Friend WithEvents BD_FOLDER As FolderBrowserDialog
    Friend WithEvents NUM_NBSAVE As NumericUpDown
    Friend WithEvents NUM_SAVETIME As NumericUpDown
    Friend WithEvents TIM_SAVE As Timer
End Class
