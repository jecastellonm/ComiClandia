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

Partial Public Class Cliente
    Public Property ClienteId As Integer
    Public Property Nombre As String
    Public Property Identificacion As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Ciudad As String
    Public Property Exclusivo As Boolean
    Public Property Activo As Boolean
    Public Property DescuentoAutorizado As Nullable(Of Byte)
    Public Property DescuentoActivo As Nullable(Of Boolean)

    Public Overridable Property Pedido As ICollection(Of Pedido) = New HashSet(Of Pedido)

End Class
