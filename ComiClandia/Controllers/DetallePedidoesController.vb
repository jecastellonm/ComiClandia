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
    Public Class DetallePedidoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ComiClandiaEntities

        ' GET: DetallePedidoes
        Function Index() As ActionResult
            Dim detallePedido = db.DetallePedido.Include(Function(d) d.Pedido).Include(Function(d) d.Producto)
            Return View(detallePedido.ToList())
        End Function

        ' GET: DetallePedidoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim detallePedido As DetallePedido = db.DetallePedido.Find(id)
            If IsNothing(detallePedido) Then
                Return HttpNotFound()
            End If
            Return View(detallePedido)
        End Function

        ' GET: DetallePedidoes/Create
        Function Create() As ActionResult
            ViewBag.IdPedido = New SelectList(db.Pedido, "PedidoId", "PedidoId")
            ViewBag.IdProducto = New SelectList(db.Producto, "ProductoID", "Nombre")
            Return View()
        End Function

        ' POST: DetallePedidoes/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="DetallePedidoId,IdProducto,IdPedido,Cantidad,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallePedido As DetallePedido) As ActionResult
            If ModelState.IsValid Then
                db.DetallePedido.Add(detallePedido)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdPedido = New SelectList(db.Pedido, "PedidoId", "PedidoId", detallePedido.IdPedido)
            ViewBag.IdProducto = New SelectList(db.Producto, "ProductoID", "Nombre", detallePedido.IdProducto)
            Return View(detallePedido)
        End Function

        ' GET: DetallePedidoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim detallePedido As DetallePedido = db.DetallePedido.Find(id)
            If IsNothing(detallePedido) Then
                Return HttpNotFound()
            End If
            ViewBag.IdPedido = New SelectList(db.Pedido, "PedidoId", "PedidoId", detallePedido.IdPedido)
            ViewBag.IdProducto = New SelectList(db.Producto, "ProductoID", "Nombre", detallePedido.IdProducto)
            Return View(detallePedido)
        End Function

        ' POST: DetallePedidoes/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="DetallePedidoId,IdProducto,IdPedido,Cantidad,FechaAdiciDetaPedido,FechaModifiDetaPedido")> ByVal detallePedido As DetallePedido) As ActionResult
            If ModelState.IsValid Then
                db.Entry(detallePedido).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.IdPedido = New SelectList(db.Pedido, "PedidoId", "PedidoId", detallePedido.IdPedido)
            ViewBag.IdProducto = New SelectList(db.Producto, "ProductoID", "Nombre", detallePedido.IdProducto)
            Return View(detallePedido)
        End Function

        ' GET: DetallePedidoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim detallePedido As DetallePedido = db.DetallePedido.Find(id)
            If IsNothing(detallePedido) Then
                Return HttpNotFound()
            End If
            Return View(detallePedido)
        End Function

        ' POST: DetallePedidoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim detallePedido As DetallePedido = db.DetallePedido.Find(id)
            db.DetallePedido.Remove(detallePedido)
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
