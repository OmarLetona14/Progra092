Imports MySql.Data.MySqlClient

Public Class TipoUsuario

    Private m_idtipousuario As Integer
    Private m_tipousuario As String

    Public Sub New(idtipousuario As Integer, tipousuario As String)
        m_idtipousuario = idtipousuario
        m_tipousuario = tipousuario
    End Sub

    Public Sub New()

    End Sub

    Public Property Idtipousuario As Integer
        Get
            Return m_idtipousuario
        End Get
        Set(value As Integer)
            m_idtipousuario = value
        End Set
    End Property

    Public Property Tipousuario As String
        Get
            Return m_tipousuario
        End Get
        Set(value As String)
            m_tipousuario = value
        End Set
    End Property

    Public Function getTipoUsuario()
        Dim tipousuario As TipoUsuario
        Dim tipousuarios = New List(Of TipoUsuario)
        Dim query = "select * from tipousuario;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                tipousuario = New TipoUsuario()
                tipousuario.Idtipousuario = reader.GetInt64(0)
                tipousuario.Tipousuario = reader.GetString(1)
                tipousuarios.Add(tipousuario)
            End While
            reader.Close()
            Return tipousuarios
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function insertTipoUsuario(c As TipoUsuario)
        Dim query = "Insert into tipousuario values (null, " & c.Tipousuario & " );"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function updateTipoUsuario(c As TipoUsuario)
        Dim query = "update tipousuario set tipo_user = '" & c.Tipousuario &
            "where idtipousuario = " & c.Idtipousuario & " ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function

    Public Function deleteTipoUsuario(id As String)
        Dim query = "delete from tipousuario where idtipousuario = " & id & " ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim rows = _comm.ExecuteNonQuery()
            If rows = 1 Then
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Return False
        End Try
        Return False
    End Function
End Class
