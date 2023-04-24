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
    Public Class ProductoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ComiClandiaEntities

        ' GET: Productoes
        Function Index() As ActionResult
            Return View(db.Producto.ToList())
        End Function

        ' GET: Productoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As Producto = db.Producto.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            Return View(producto)
        End Function

        ' GET: Productoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Productoes/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ProductoID,Nombre,Descripcion,Stock,Valor,Departamento")> ByVal producto As Producto) As ActionResult
            If ModelState.IsValid Then
                db.Producto.Add(producto)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(producto)
        End Function

        ' GET: Productoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As Producto = db.Producto.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            Return View(producto)
        End Function

        ' POST: Productoes/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ProductoID,Nombre,Descripcion,Stock,Valor,Departamento")> ByVal producto As Producto) As ActionResult
            If ModelState.IsValid Then
                db.Entry(producto).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(producto)
        End Function

        ' GET: Productoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim producto As Producto = db.Producto.Find(id)
            If IsNothing(producto) Then
                Return HttpNotFound()
            End If
            Return View(producto)
        End Function

        ' POST: Productoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim producto As Producto = db.Producto.Find(id)
            db.Producto.Remove(producto)
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
