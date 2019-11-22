Public Class Movie

    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Private _ReleaseDate As Date
    Public Property ReleaseDate As Date
        Get
            Return _ReleaseDate
        End Get
        Set(value As Date)
            _ReleaseDate = value
        End Set
    End Property

    Private _Director As String
    Public Property Director As String
        Get
            Return _Director
        End Get
        Set(value As String)
            _Director = value
        End Set
    End Property

    Private _Gender1 As String
    Public Property Gender1 As String
        Get
            Return _Gender1
        End Get
        Set(value As String)
            _Gender1 = value
        End Set
    End Property

    Private _Gender2 As String
    Public Property Gender2 As String
        Get
            Return _Gender2
        End Get
        Set(value As String)
            _Gender2 = value
        End Set
    End Property

    Private _Actors As String
    Public Property Actors As String
        Get
            Return _Actors
        End Get
        Set(value As String)
            _Actors = value
        End Set
    End Property

    Private _Synopsis As String
    Public Property Synopsis As String
        Get
            Return _Synopsis
        End Get
        Set(value As String)
            _Synopsis = value
        End Set
    End Property

    Private _PersonalView As String
    Public Property PersonalView As String
        Get
            Return _PersonalView
        End Get
        Set(value As String)
            _PersonalView = value
        End Set
    End Property

    Private _Note As Integer
    Public Property Note As Integer
        Get
            Return _Note
        End Get
        Set(value As Integer)
            _Note = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(Name As String, ReleaseDate As Date, Director As String, Gender1 As String, Gender2 As String, Actors As String, Synopsis As String, PersonalView As String, Note As Integer)
        _Name = Name
        _ReleaseDate = ReleaseDate
        _Director = Director
        _Gender1 = Gender1
        _Gender2 = Gender2
        _Actors = Actors
        _Synopsis = Synopsis
        _PersonalView = PersonalView
        _Note = Note
    End Sub

    Public Sub Update(Name As String, ReleaseDate As Date, Director As String, Gender1 As String, Gender2 As String, Actors As String, Synopsis As String, PersonalView As String, Note As Integer)
        _Name = Name
        _ReleaseDate = ReleaseDate
        _Director = Director
        _Gender1 = Gender1
        _Gender2 = Gender2
        _Actors = Actors
        _Synopsis = Synopsis
        _PersonalView = PersonalView
        _Note = Note
    End Sub

    Public Overrides Function ToString() As String
        Return _Name
    End Function

End Class
