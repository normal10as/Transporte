Public MustInherit Class Persona
    Private _dni As String
    Private _Nombre As String

    Public Sub New(dni As String, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
    End Sub
    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set
            If Value.Length = 8 Then
                _dni = Value
            End If
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set
            If Value.Length <= 30 Then
                _Nombre = Value
            End If
        End Set
    End Property
End Class
