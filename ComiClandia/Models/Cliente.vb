Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Cliente
    Inherits Conexion

    Private c_clienteId As Integer
    Private c_nombre As String
    Private c_identificacion As String
    Private c_direccion As String
    Private c_telefono As String
    Private c_ciudad As String

    Private command As SqlCommand

    Private Sub New(nom As String, id As String, di As String, te As String, ci As String)
        nombre = nom
        identificacion = id
        direccion = di
        telefono = te
        ciudad = ci
    End Sub

    Private Sub New()

    End Sub

    Public Property NombreCli As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property identificacionCli As String
        Get
            Return identificacion
        End Get
        Set(value As String)
            identificacion = value
        End Set
    End Property
    Public Property direccionCli As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public Property telefonoCli As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property
    Public Property ciudadCli As String
        Get
            Return ciudad
        End Get
        Set(value As String)
            ciudad = value
        End Set
    End Property

    Public Function insertCliente(cli As Cliente) As Boolean
        Try
            Conectar()
            Dim sql As String = "INSERT INTO CLIENTE(Nombre, Identificacion, Direccion, Telefono, Ciudad) VALUES('" & cli.Nombre & "','" &
             cli.Identificacion & "','" & cli.Direccion & "','" & cli.Telefono & "','" & cli.Ciudad & "')"
            command = New SqlCommand(sql, conn)
            If command.ExecuteNonQuery() Then
                MsgBox("Se grabo el cliente exitosamente")
                Return True
            Else
                MsgBox("No Se grabo el cliente exitosamente")
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False

        Finally
            Desconectar()
        End Try

    End Function


End Class
