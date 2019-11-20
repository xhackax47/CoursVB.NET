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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBL_STATUS = New System.Windows.Forms.Label()
        Me.TXT_ADRESS = New System.Windows.Forms.TextBox()
        Me.WB_BROWSER = New System.Windows.Forms.WebBrowser()
        Me.PGB_STATUS = New System.Windows.Forms.ProgressBar()
        Me.BT_SEND = New System.Windows.Forms.Button()
        Me.BT_STOP = New System.Windows.Forms.Button()
        Me.BT_REFRESH = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.BT_PREVIOUS = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(652, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBL_STATUS
        '
        Me.LBL_STATUS.AutoSize = True
        Me.LBL_STATUS.Location = New System.Drawing.Point(12, 567)
        Me.LBL_STATUS.Name = "LBL_STATUS"
        Me.LBL_STATUS.Size = New System.Drawing.Size(0, 13)
        Me.LBL_STATUS.TabIndex = 6
        '
        'TXT_ADRESS
        '
        Me.TXT_ADRESS.Location = New System.Drawing.Point(12, 87)
        Me.TXT_ADRESS.Name = "TXT_ADRESS"
        Me.TXT_ADRESS.ReadOnly = True
        Me.TXT_ADRESS.Size = New System.Drawing.Size(519, 20)
        Me.TXT_ADRESS.TabIndex = 8
        '
        'WB_BROWSER
        '
        Me.WB_BROWSER.Location = New System.Drawing.Point(0, 118)
        Me.WB_BROWSER.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_BROWSER.Name = "WB_BROWSER"
        Me.WB_BROWSER.Size = New System.Drawing.Size(652, 440)
        Me.WB_BROWSER.TabIndex = 10
        '
        'PGB_STATUS
        '
        Me.PGB_STATUS.Location = New System.Drawing.Point(540, 561)
        Me.PGB_STATUS.Name = "PGB_STATUS"
        Me.PGB_STATUS.Size = New System.Drawing.Size(100, 26)
        Me.PGB_STATUS.TabIndex = 7
        '
        'BT_SEND
        '
        Me.BT_SEND.FlatAppearance.BorderSize = 0
        Me.BT_SEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SEND.Image = Global.WebBrowser.My.Resources.Resources.BT_SEND
        Me.BT_SEND.Location = New System.Drawing.Point(541, 58)
        Me.BT_SEND.Name = "BT_SEND"
        Me.BT_SEND.Size = New System.Drawing.Size(75, 54)
        Me.BT_SEND.TabIndex = 9
        Me.BT_SEND.UseVisualStyleBackColor = True
        '
        'BT_STOP
        '
        Me.BT_STOP.FlatAppearance.BorderSize = 0
        Me.BT_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_STOP.Image = Global.WebBrowser.My.Resources.Resources.BT_STOP
        Me.BT_STOP.Location = New System.Drawing.Point(256, 28)
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(75, 53)
        Me.BT_STOP.TabIndex = 4
        Me.BT_STOP.UseVisualStyleBackColor = True
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.FlatAppearance.BorderSize = 0
        Me.BT_REFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_REFRESH.Image = Global.WebBrowser.My.Resources.Resources.BT_REFRESH
        Me.BT_REFRESH.Location = New System.Drawing.Point(175, 28)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(75, 53)
        Me.BT_REFRESH.TabIndex = 3
        Me.BT_REFRESH.UseVisualStyleBackColor = True
        '
        'BT_NEXT
        '
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.Image = Global.WebBrowser.My.Resources.Resources.BT_NEXT
        Me.BT_NEXT.Location = New System.Drawing.Point(94, 28)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(75, 53)
        Me.BT_NEXT.TabIndex = 2
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'BT_PREVIOUS
        '
        Me.BT_PREVIOUS.FlatAppearance.BorderSize = 0
        Me.BT_PREVIOUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PREVIOUS.Image = Global.WebBrowser.My.Resources.Resources.BT_PREVIOUS
        Me.BT_PREVIOUS.Location = New System.Drawing.Point(12, 28)
        Me.BT_PREVIOUS.Name = "BT_PREVIOUS"
        Me.BT_PREVIOUS.Size = New System.Drawing.Size(75, 53)
        Me.BT_PREVIOUS.TabIndex = 1
        Me.BT_PREVIOUS.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 583)
        Me.Controls.Add(Me.WB_BROWSER)
        Me.Controls.Add(Me.BT_SEND)
        Me.Controls.Add(Me.TXT_ADRESS)
        Me.Controls.Add(Me.PGB_STATUS)
        Me.Controls.Add(Me.LBL_STATUS)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BT_STOP)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_NEXT)
        Me.Controls.Add(Me.BT_PREVIOUS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Navigateur Web"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_PREVIOUS As Button
    Friend WithEvents BT_NEXT As Button
    Friend WithEvents BT_REFRESH As Button
    Friend WithEvents BT_STOP As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LBL_STATUS As Label
    Friend WithEvents TXT_ADRESS As TextBox
    Friend WithEvents BT_SEND As Button
    Friend WithEvents WB_BROWSER As System.Windows.Forms.WebBrowser
    Friend WithEvents PGB_STATUS As ProgressBar
End Class
