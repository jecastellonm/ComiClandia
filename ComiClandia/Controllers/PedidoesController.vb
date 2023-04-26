Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ComiClandia

Namespace Controllers
  Public Class PedidoesController
    Inherits System.Web.Mvc.Controller

    Public Sub PedidoesController()

    End Sub

    Private db As New ComiClandiaEntities

    ' GET: Pedidoes
    Function Index() As ActionResult
      Dim pedido = db.Pedido.Include(Function(p) p.Cliente)
      Return View(pedido.ToList())
    End Function

    ' GET: Pedidoes/Details/5
    Function Details(ByVal id As Integer?) As ActionResult
      If IsNothing(id) Then
        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
      End If
      Dim pedido As Pedido = db.Pedido.Find(id)
      If IsNothing(pedido) Then
        Return HttpNotFound()
      End If
      Return View(pedido)
    End Function

    ' GET: Pedidoes/Create
    Function Create(
        <Bind(Include:="DetallePedidoId,IdProducto,IdCliente,Cantidad,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallepedido As DetallePedido
            ) As ActionResult
      '<Bind(Include:="ProductoID,Nombre,Descripcion,Stock,Valor,Departamento")> ByVal producto As Producto
      ViewBag.IdCliente = New SelectList(db.Cliente, "ClienteId", "Nombre")
      ViewBag.IdProducto = New SelectList(db.Producto, "ProductoId", "Nombre")
      Return View()
    End Function

    ' POST: Pedidoes/Create
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(<Bind(Include:="PedidoId,FechaPedido,FechaModificacionPedido,IdCliente,EstadoPedido,IdTipoPedido")> ByVal pedido As Pedido,
      <Bind(Include:="DetallePedidoId,IdProducto,IdCliente,Cantidad,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallepedido As DetallePedido,
      IdProducto As Integer, Cantidad As Integer
                ) As ActionResult
      '<Bind(Include:="IdProducto,Cantidad,IdCliente")> ByVal detallepedidop As PedidoDetalleP,
      Dim ValorProducto As Integer
      pedido.FechaPedido = DateTime.Now
      pedido.EstadoPedido = 0
      detallepedido.FechaAdiciDetaPedido = DateTime.Now
      detallepedido.Cantidad = Cantidad
      detallepedido.IdProducto = IdProducto
      ValorProducto = db.Producto.Find(IdProducto).Valor
      detallepedido.TotalDetalleP = Cantidad * ValorProducto
      detallepedido.Activo = 1
      If ModelState.IsValid Then
        'pedido.IdCliente = detallepedidop.IdCliente
        db.Pedido.Add(pedido)
        db.SaveChanges()
        detallepedido.IdPedido = pedido.PedidoId
        db.DetallePedido.Add(detallepedido)
        db.SaveChanges()
        Return RedirectToAction("Index")
      End If
      ViewBag.IdCliente = New SelectList(db.Cliente, "ClienteId", "Nombre", pedido.IdCliente)
      ViewBag.IdProducto = New SelectList(db.Producto, "ProductoId", "Nombre", detallepedido.IdProducto)
      Return View(pedido)
    End Function

    ' GET: Pedidoes/Edit/5
    Function Edit(ByVal id As Integer?,
                  <Bind(Include:="DetallePedidoId,IdProducto,IdCliente,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallepedido As DetallePedido
      ) As ActionResult
      If IsNothing(id) Then
        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
      End If
      Dim pedido As Pedido = db.Pedido.Find(id)
      Dim detallepedido1 As DetallePedido = db.DetallePedido.FirstOrDefault(Function(dp) dp.IdPedido = pedido.PedidoId)
      If IsNothing(pedido) Then
        Return HttpNotFound()
      End If
      ViewBag.IdCliente = New SelectList(db.Cliente, "ClienteId", "Nombre", pedido.IdCliente)
      ViewBag.IdProducto = New SelectList(db.Producto, "ProductoId", "Nombre", detallepedido1.IdProducto)
      ViewBag.Observaciones = detallepedido1.Observaciones
      ViewBag.Cantidad = detallepedido1.Cantidad
      ViewBag.Activo = detallepedido1.Activo

      Return View(pedido)
    End Function

    ' POST: Pedidoes/Edit/5
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(<Bind(Include:="PedidoId,FechaPedido,FechaModificacionPedido,IdCliente,EstadoPedido,IdTipoPedido")> ByVal pedido As Pedido,
                  <Bind(Include:="DetallePedidoId,IdProducto,IdCliente,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallepedido As DetallePedido
        ) As ActionResult

      If ModelState.IsValid Then
        pedido.FechaModificacionPedido = DateTime.Now
        db.Entry(pedido).State = EntityState.Modified
        db.SaveChanges()
        Return RedirectToAction("Index")
      End If
      ViewBag.IdCliente = New SelectList(db.Cliente, "ClienteId", "Nombre", pedido.IdCliente)
      ViewBag.IdProducto = New SelectList(db.Producto, "ProductoId", "Nombre", detallepedido.IdProducto)
      Return View(pedido)
    End Function

    ' GET: Pedidoes/Delete/5
    Function Delete(ByVal id As Integer?) As ActionResult
      If IsNothing(id) Then
        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
      End If
      Dim pedido As Pedido = db.Pedido.Find(id)
      If IsNothing(pedido) Then
        Return HttpNotFound()
      End If
      Return View(pedido)
    End Function

    ' POST: Pedidoes/Delete/5
    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(ByVal id As Integer) As ActionResult
      Dim pedido As Pedido = db.Pedido.Find(id)
      db.Pedido.Remove(pedido)
      db.SaveChanges()
      Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If (disposing) Then
        db.Dispose()
      End If
      MyBase.Dispose(disposing)
    End Sub
  End Class
End Namespace
