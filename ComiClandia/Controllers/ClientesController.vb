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
    Public Class ClientesController
        Inherits System.Web.Mvc.Controller

        Public Sub ClientesController()

        End Sub

        Private db As New ComiClandiaEntities

        ' GET: Clientes
        Function Index() As ActionResult
            Return View(db.Cliente.ToList())
        End Function

        ' GET: Clientes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        ' GET: Clientes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Clientes/Create
        <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(<Bind(Include:="ClienteId,Nombre,Identificacion,Direccion,Telefono,Ciudad,Exclusivo,Activo,DescuentoAutorizado,DescuentoActivo")> ByVal cliente As Cliente) As ActionResult
      If ModelState.IsValid Then
        db.Cliente.Add(cliente)
        db.SaveChanges()
        Return RedirectToAction("Index")
      End If
      Return View(cliente)
    End Function

    ' GET: Clientes/Edit/5
    Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(<Bind(Include:="ClienteId,Nombre,Identificacion,Direccion,Telefono,Ciudad,Exclusivo,Activo,DescuentoAutorizado,DescuentoActivo")> ByVal cliente As Cliente) As ActionResult
      If ModelState.IsValid Then
        db.Entry(cliente).State = EntityState.Modified
        db.SaveChanges()
        Return RedirectToAction("Index")
      End If
      Return View(cliente)
    End Function

    ' GET: Clientes/Delete/5
    Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        ' POST: Clientes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim cliente As Cliente = db.Cliente.Find(id)
            db.Cliente.Remove(cliente)
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
