'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Pedido
    Public Property PedidoId As Integer
    Public Property FechaPedido As Date
    Public Property FechaModificacionPedido As Nullable(Of Date)
    Public Property IdCliente As Integer
    Public Property EstadoPedido As Byte
    Public Property IdTipoPedido As Integer

    Public Overridable Property Cliente As Cliente
    Public Overridable Property DetallePedido As ICollection(Of DetallePedido) = New HashSet(Of DetallePedido)

End Class
