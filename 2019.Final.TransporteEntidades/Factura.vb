Imports _2019.Final.TransporteEntidades
Public Class Factura
    Public Sub New(fecha As Date, cliente As Cliente)
        Me.Fecha = fecha
        Me.Cliente = cliente
    End Sub
    Public Property Fecha As Date
    Public Property Cliente As Cliente
End Class
