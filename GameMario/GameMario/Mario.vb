Public Class Mario

    Private _CoordonnesActuelles As Point
    Private _Taille As Size

    Sub New(originalPosition As Point, sizeMario As Size)
        _CoordonnesActuelles = New Point(originalPosition)
        _Taille = New Size(sizeMario)
    End Sub

    Public Sub Right()
        _CoordonnesActuelles.X = _CoordonnesActuelles.X + _PasX()
    End Sub

    Public Sub Left()
        _CoordonnesActuelles.X = _CoordonnesActuelles.X - _PasX()
    End Sub

    Public Sub Up()
        _CoordonnesActuelles.Y = _CoordonnesActuelles.Y - _PasY()
    End Sub

    Public Sub Down()
        _CoordonnesActuelles.Y = _CoordonnesActuelles.Y + _PasY()
    End Sub

    Public Property Position() As Point
        Get
            Return _CoordonnesActuelles
        End Get
        Set(value As Point)
            _CoordonnesActuelles = value
        End Set
    End Property

#Region "Fonctions privées"

    Private Function _PasX()
        Return _Taille.Width
    End Function

    Private Function _PasY()
        Return _Taille.Height
    End Function


#End Region

End Class
