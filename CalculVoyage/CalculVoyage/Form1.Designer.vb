<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_voyages
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
        Me.TXT_CONSO = New System.Windows.Forms.TextBox()
        Me.TXT_NBKM = New System.Windows.Forms.TextBox()
        Me.TXT_PRIXCARBURANT = New System.Windows.Forms.TextBox()
        Me.BT_CALCUL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_ERROR = New System.Windows.Forms.Label()
        Me.LBL_RESULT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_CONSO
        '
        Me.TXT_CONSO.Location = New System.Drawing.Point(313, 131)
        Me.TXT_CONSO.Name = "TXT_CONSO"
        Me.TXT_CONSO.Size = New System.Drawing.Size(179, 20)
        Me.TXT_CONSO.TabIndex = 0
        '
        'TXT_NBKM
        '
        Me.TXT_NBKM.Location = New System.Drawing.Point(313, 192)
        Me.TXT_NBKM.Name = "TXT_NBKM"
        Me.TXT_NBKM.Size = New System.Drawing.Size(179, 20)
        Me.TXT_NBKM.TabIndex = 1
        '
        'TXT_PRIXCARBURANT
        '
        Me.TXT_PRIXCARBURANT.Location = New System.Drawing.Point(313, 256)
        Me.TXT_PRIXCARBURANT.Name = "TXT_PRIXCARBURANT"
        Me.TXT_PRIXCARBURANT.Size = New System.Drawing.Size(179, 20)
        Me.TXT_PRIXCARBURANT.TabIndex = 2
        '
        'BT_CALCUL
        '
        Me.BT_CALCUL.Location = New System.Drawing.Point(179, 322)
        Me.BT_CALCUL.Name = "BT_CALCUL"
        Me.BT_CALCUL.Size = New System.Drawing.Size(132, 23)
        Me.BT_CALCUL.TabIndex = 3
        Me.BT_CALCUL.Text = "Calculer"
        Me.BT_CALCUL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Consommation véhicule (l/100KM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombres de kilomètres (KM)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prix du litre de carburant (€/L)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calcul Coût Voyage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBL_ERROR
        '
        Me.LBL_ERROR.AutoSize = True
        Me.LBL_ERROR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ERROR.Location = New System.Drawing.Point(219, 291)
        Me.LBL_ERROR.Name = "LBL_ERROR"
        Me.LBL_ERROR.Size = New System.Drawing.Size(57, 16)
        Me.LBL_ERROR.TabIndex = 8
        Me.LBL_ERROR.Text = "ERROR"
        Me.LBL_ERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_ERROR.Visible = False
        '
        'LBL_RESULT
        '
        Me.LBL_RESULT.AutoSize = True
        Me.LBL_RESULT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RESULT.Location = New System.Drawing.Point(222, 365)
        Me.LBL_RESULT.Name = "LBL_RESULT"
        Me.LBL_RESULT.Size = New System.Drawing.Size(62, 16)
        Me.LBL_RESULT.TabIndex = 9
        Me.LBL_RESULT.Text = "RESULT"
        Me.LBL_RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_RESULT.Visible = False
        '
        'form_voyages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 390)
        Me.Controls.Add(Me.LBL_RESULT)
        Me.Controls.Add(Me.LBL_ERROR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_CALCUL)
        Me.Controls.Add(Me.TXT_PRIXCARBURANT)
        Me.Controls.Add(Me.TXT_NBKM)
        Me.Controls.Add(Me.TXT_CONSO)
        Me.Name = "form_voyages"
        Me.Text = "Calcul Voyage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_CONSO As TextBox
    Friend WithEvents TXT_NBKM As TextBox
    Friend WithEvents TXT_PRIXCARBURANT As TextBox
    Friend WithEvents BT_CALCUL As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_ERROR As Label
    Friend WithEvents LBL_RESULT As Label
End Class
