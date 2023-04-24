Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conexion
    Protected conn As New SqlConnection("Data Source=J-E-C-M\SQLEXPRESS;Initial Catalog=ComiClandia;User ID=sa;Password=12345")

    Public Function Conectar() As Boolean
        Try
            conn.Open()
            MsgBox("Conexion Exitosa")
            Return True
        Catch ex As Exception
            MsgBox("Conexion Fallida: " + ex.Message)
            Return False
        End Try
    End Function

    Public Sub Desconectar()
        Try
            If conn.State() = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Conexion Fallida: " + ex.Message)
        End Try
    End Sub
End Class
