Public Class Form1
    Private Sub TKB_IN_Scroll(sender As Object, e As EventArgs) Handles TKB_IN.Scroll
        Me.PGB_OUT.Value = Me.TKB_IN.Value
    End Sub
End Class
