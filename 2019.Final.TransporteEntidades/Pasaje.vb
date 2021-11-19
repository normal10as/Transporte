Imports _2019.Final.TransporteEntidades

Public Class Pasaje
    Public Property Fecha As Date
    Public Property Monto As Decimal
    Public Function CalcularIva() As Decimal
        Return Monto * 0.21
    End Function
    Public Property Origen As Ciudad
    Public Property Destino As Ciudad
End Class
