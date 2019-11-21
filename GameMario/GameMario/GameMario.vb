Public Class GameMario

    Dim marioPerso As Mario

    Private Sub GameMario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ecoute des touches
        Me.KeyPreview = True
        'Instanciation objet marioPerso
        marioPerso = New Mario(Me.PIC_MARIO.Location, Me.PIC_MARIO.Size)
    End Sub

    Sub GameMario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Z
                marioPerso.Up()
            Case Keys.S
                marioPerso.Down()
            Case Keys.Q
                marioPerso.Left()
            Case Keys.D
                marioPerso.Right()
        End Select
        'Récupération nouvelle position
        Me.PIC_MARIO.Location = marioPerso.Position
    End Sub

    Private Sub BT_RIGHT_Click(sender As Object, e As EventArgs) Handles BT_RIGHT.Click
        marioPerso.Right()
        'Récupération nouvelle position
        Me.PIC_MARIO.Location = marioPerso.Position
    End Sub

    Private Sub BT_LEFT_Click(sender As Object, e As EventArgs) Handles BT_LEFT.Click
        marioPerso.Left()
        'Récupération nouvelle position
        Me.PIC_MARIO.Location = marioPerso.Position
    End Sub

    Private Sub BT_UP_Click(sender As Object, e As EventArgs) Handles BT_UP.Click
        marioPerso.Up()
        'Récupération nouvelle position
        Me.PIC_MARIO.Location = marioPerso.Position
    End Sub

    Private Sub BT_DOWN_Click(sender As Object, e As EventArgs) Handles BT_DOWN.Click
        marioPerso.Down()
        'Récupération nouvelle position
        Me.PIC_MARIO.Location = marioPerso.Position
    End Sub

End Class
