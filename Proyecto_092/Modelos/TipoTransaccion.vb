Imports MySql.Data.MySqlClient

Public Class TipoTransaccion

    Private m_idtipotran As Integer
    Private m_tipotransaccion As String

    Public Sub New(idtipotran As Integer, tipotransaccion As String)
        m_idtipotran = idtipotran
        m_tipotransaccion = tipotransaccion
    End Sub

    Public Sub New()

    End Sub
    Public Property Idtipotran As Integer
        Get
            Return m_idtipotran
        End Get
        Set(value As Integer)
            m_idtipotran = value
        End Set
    End Property

    Public Property Tipotransaccion As String
        Get
            Return m_tipotransaccion
        End Get
        Set(value As String)
            m_tipotransaccion = value
        End Set
    End Property

    Public Function getTipoTransacciones()
        Dim tipotransaccion As TipoTransaccion
        Dim tipotransacciones = New List(Of TipoTransaccion)
        Dim query = "select * from tipotransaccion;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                tipotransaccion = New TipoTransaccion()
                tipotransaccion.Idtipotran = reader.GetInt64(0)
                tipotransaccion.Tipotransaccion = reader.GetString(1)
                tipotransacciones.Add(tipotransaccion)
            End While
            reader.Close()
            Return tipotransacciones
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function insertTipoTransaccion(c As TipoTransaccion)
        Dim query = "Insert into tipotransaccion values (null, '" & c.Tipotransaccion & "' );"
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

    Public Function updateTipoTransaccion(c As TipoTransaccion)
        Dim query = "update tipotransaccion set tipo_transaccion = '" & c.Tipotransaccion &
            "' where idtipotran = " & c.Idtipotran & " ;"
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

    Public Function deleteTipoTransaccion(id As String)
        Dim query = "delete from tipotransaccion where idtipotran = " & id & " ;"
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
