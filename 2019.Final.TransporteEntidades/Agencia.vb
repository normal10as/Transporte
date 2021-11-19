Public Class Agencia
    Private Shared _facturas As List(Of Factura)
    Public Shared Sub AddFacturas(factura As Factura)
        _facturas.Add(factura)
    End Sub
End Class