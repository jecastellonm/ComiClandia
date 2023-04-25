Public Class PedidoDetalleP
  Private p_IdProducto As Integer
  Private p_Cantidad As Integer
  Private p_IdCliente As Integer

  Private Sub New(idproducto As Integer, cantidad As Integer, idcliente As Integer)
    p_IdProducto = idproducto
    p_Cantidad = cantidad
    p_IdCliente = idcliente
  End Sub

  Private Sub New()

  End Sub

  Public Property IdProducto As Integer
    Get
      Return p_IdProducto
    End Get
    Set(value As Integer)
      p_IdProducto = value
    End Set
  End Property

  Public Property Cantidad As Integer
    Get
      Return p_Cantidad
    End Get
    Set(value As Integer)
      p_Cantidad = value
    End Set
  End Property

  Public Property IdCliente As Integer
    Get
      Return p_IdCliente
    End Get
    Set(value As Integer)
      p_IdCliente = value
    End Set
  End Property

End Class
