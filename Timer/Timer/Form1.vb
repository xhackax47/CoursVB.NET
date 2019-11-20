Public Class Form1
    Private Sub TIM_TIMER_Tick(sender As Object, e As EventArgs) Handles TIM_TIMER.Tick
        If Me.PGB_TIMER.Value = 100 Then
            Me.TIM_TIMER.Enabled = False
            Me.BT_START.Enabled = True
        Else
            Me.PGB_TIMER.Value += 1
        End If
    End Sub

    Private Sub BT_START_Click(sender As Object, e As EventArgs) Handles BT_START.Click
        Me.TIM_TIMER.Enabled = True
        Me.BT_START.Enabled = False
        Me.BT_RAZ.Enabled = True
    End Sub

    Private Sub BT_RAZ_Click(sender As Object, e As EventArgs) Handles BT_RAZ.Click
        Me.PGB_TIMER.Value = 0
        Me.TIM_TIMER.Enabled = False
        Me.BT_START.Enabled = True
        Me.BT_RAZ.Enabled = False
    End Sub
End Class
