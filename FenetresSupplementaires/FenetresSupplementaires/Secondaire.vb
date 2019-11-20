Public Class Secondaire

    Public myString As String = ""

    Private Sub Secondaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LBL_SECOND.Text = myString
    End Sub

    Private Sub BT_CLOSE_Click(sender As Object, e As EventArgs) Handles BT_CLOSE.Click
        Main.LBL_MAIN.Text = "Test Secondaire ==> Main"
        Me.Close()
    End Sub

End Class