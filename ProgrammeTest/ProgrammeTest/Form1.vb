Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabInt(9) As Integer
        For i As Integer = 0 To 9
            tabInt(i) = i + 1
        Next
        Me.CB_CHOICE.DataSource = tabInt
    End Sub

    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        Dim nbChkChecked As Integer = 0
        If Me.CHK_1.Checked Then
            nbChkChecked += 1
        End If
        If Me.CHK_2.Checked Then
            nbChkChecked += 2
        End If
        If Me.CHK_4.Checked Then
            nbChkChecked += 4
        End If
        If Me.CHK_8.Checked Then
            nbChkChecked += 8
        End If
        Me.TXT_CHK.Text = nbChkChecked
    End Sub

    Private Sub BT_2_Click(sender As Object, e As EventArgs) Handles BT_2.Click
        Dim btnChecked As String = ""
        If Me.RB_1.Checked Then
            btnChecked = Me.RB_1.Text
        End If
        If Me.RB_2.Checked Then
            btnChecked = Me.RB_2.Text
        End If
        If Me.RB_3.Checked Then
            btnChecked = Me.RB_3.Text
        End If
        If Me.RB_4.Checked Then
            btnChecked = Me.RB_4.Text
        End If
        Me.TXT_RBNB.Text = btnChecked
    End Sub

    Private Sub BT_3_Click(sender As Object, e As EventArgs) Handles BT_3.Click
        Dim colorChoice As String = ""
        If Me.RB_ROUGE.Checked Then
            colorChoice = Me.RB_ROUGE.Text
            Me.TXT_RBCOL.BackColor = Color.Red
        End If
        If Me.RB_VERT.Checked Then
            colorChoice = Me.RB_VERT.Text
            Me.TXT_RBCOL.BackColor = Color.Green
        End If
        If Me.RB_BLEU.Checked Then
            colorChoice = Me.RB_BLEU.Text
            Me.TXT_RBCOL.BackColor = Color.Blue
        End If
        If Me.RB_JAUNE.Checked Then
            colorChoice = Me.RB_JAUNE.Text
            Me.TXT_RBCOL.BackColor = Color.Yellow
        End If
        Me.TXT_RBCOL.Text = colorChoice
    End Sub

    Private Sub CB_CHOICE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_CHOICE.SelectedIndexChanged
        Me.TXT_CHOICE.Text = Me.CB_CHOICE.SelectedValue
    End Sub
End Class