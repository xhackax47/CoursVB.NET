Public Class form_voyages
    Private Sub BT_CALCUL_Click(sender As Object, e As EventArgs) Handles BT_CALCUL.Click
        If Verification() Then
            Me.LBL_ERROR.Visible = False
            Dim result As Double = Calcul(Me.TXT_CONSO.Text, Me.TXT_NBKM.Text, Me.TXT_PRIXCARBURANT.Text)
            Me.LBL_RESULT.Text = "Le cout du voyage sera de " & result & "€"
            Me.LBL_RESULT.Visible = True
        Else
            Me.LBL_RESULT.Visible = False
            Me.LBL_ERROR.Text = "Veuillez entrer des informations valides"
            Me.LBL_ERROR.ForeColor = Color.Red
            Me.LBL_ERROR.Visible = True
        End If
    End Sub

    Function Calcul(consommation As Double, NbKm As Double, PrixConso As Double) As Double
        Dim result As Double

        result = ((NbKm / 100) * consommation) * PrixConso

        Return result
    End Function

    Function Verification() As Boolean
        Dim bool As Boolean = True
        If Me.TXT_CONSO.Text Is Nothing Or Not IsNumeric(Me.TXT_CONSO.Text) Then
            bool = False
        End If
        If Me.TXT_NBKM.Text Is Nothing Or Not IsNumeric(Me.TXT_NBKM.Text) Then
            bool = False
        End If
        If Me.TXT_PRIXCARBURANT.Text Is Nothing Or Not IsNumeric(Me.TXT_PRIXCARBURANT.Text) Then
            bool = False
        End If
        Return bool
    End Function

    Private Sub LBL_RESULT_Click(sender As Object, e As EventArgs) Handles LBL_RESULT.Click

    End Sub
End Class
