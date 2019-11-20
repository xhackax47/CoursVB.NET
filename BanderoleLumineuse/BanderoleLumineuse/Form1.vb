Public Class Form1
    Private Sub TIM_TIMER_Tick(sender As Object, e As EventArgs) Handles TIM_TIMER.Tick
        Dim turn As Boolean = True
        Dim btn As Integer = 0
        Dim RB(9) As RadioButton

        RB(0) = Me.RB_1
        RB(1) = Me.RB_2
        RB(2) = Me.RB_3
        RB(3) = Me.RB_4
        RB(4) = Me.RB_5
        RB(5) = Me.RB_6
        RB(6) = Me.RB_7
        RB(7) = Me.RB_8
        RB(8) = Me.RB_9
        RB(9) = Me.RB_10

        While turn
            If btn = 10 Then
                turn = False
            Else
                If RB(btn).Checked Then
                    If RB(btn) IsNot RB(9) Then
                        RB(btn + 1).Checked = True
                        turn = False
                    Else
                        Me.RB_1.Checked = True
                    End If
                End If
                btn += 1
            End If
        End While
    End Sub

    Private Sub BTN_PLAY_Click(sender As Object, e As EventArgs) Handles BTN_PLAY.Click
        Me.TIM_TIMER.Enabled = True
        Me.TIM_TIMER.Interval = 501 - Me.TKB_VIT.Value * 50
    End Sub

    Private Sub BTN_STOP_Click(sender As Object, e As EventArgs) Handles BTN_STOP.Click
        Me.TIM_TIMER.Enabled = False
    End Sub

    Private Sub TKB_VIT_Scroll(sender As Object, e As EventArgs) Handles TKB_VIT.Scroll
        Me.TIM_TIMER.Interval = 501 - Me.TKB_VIT.Value * 50
    End Sub

End Class
