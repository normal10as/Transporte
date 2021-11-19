Imports _2019.Final.TransporteEntidades

Public Class Encomienda
    Implements Facturable, Trasladable
    Public Property Monto As Decimal Implements Facturable.Monto
    Public Property PesoKilos As Byte
    Public Property Origen As Ciudad Implements Trasladable.Origen
    Public Property Destino As Ciudad Implements Trasladable.Destino
End Class
