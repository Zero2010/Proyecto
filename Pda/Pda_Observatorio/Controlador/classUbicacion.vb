Imports Modelo

Public Class classUbicacion

    Public strLocal As String
    Public strPasillo As String
    Public strPatente As String

    Public Property Local() As String
        Get
            Return strLocal
        End Get
        Set(ByVal value As String)
            strLocal = value
        End Set
    End Property

    Public Property Pasillo() As String
        Get
            Return strPasillo
        End Get
        Set(ByVal value As String)
            strPasillo = value
        End Set
    End Property

    Public Property Patente() As String
        Get
            Return strPatente
        End Get
        Set(ByVal value As String)
            strPatente = value
        End Set
    End Property

End Class
