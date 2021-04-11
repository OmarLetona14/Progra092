Imports MySql.Data.MySqlClient

Public Class Cliente
    Private m_idcliente As Integer
    Private m_nombre As String
    Private m_direccion As String
    Private m_telefono As String
    Private m_idtipousuario As Integer

    Public Sub New(idcliente As Integer, nombre As String, direccion As String, telefono As String, idtipousuario As Integer)
        m_idcliente = idcliente
        m_nombre = nombre
        m_direccion = direccion
        m_telefono = telefono
        m_idtipousuario = idtipousuario
    End Sub

    Public Sub New()

    End Sub
    Public Property Idcliente As Integer
        Get
            Return m_idcliente
        End Get
        Set(value As Integer)
            m_idcliente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return m_nombre
        End Get
        Set(value As String)
            m_nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return m_direccion
        End Get
        Set(value As String)
            m_direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return m_telefono
        End Get
        Set(value As String)
            m_telefono = value
        End Set
    End Property

    Public Property Idtipousuario As Integer
        Get
            Return m_idtipousuario
        End Get
        Set(value As Integer)
            m_idtipousuario = value
        End Set
    End Property

    Public Function getClientes()
        Dim cliente As Cliente
        Dim clientes = New List(Of Cliente)
        Dim query = "select * from cliente;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                cliente = New Cliente()
                cliente.Idcliente = reader.GetInt64(0)
                cliente.Nombre = reader.GetString(1)
                cliente.Direccion = reader.GetString(2)
                cliente.Telefono = reader.GetString(3)
                cliente.Idtipousuario = reader.GetInt64(4)
                clientes.Add(cliente)
            End While
            reader.Close()
            Return clientes
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function insertCliente(c As Cliente)
        Dim query = "Insert into cliente values (null, '" & c.Nombre & "', '" & c.Direccion & "', '" & c.Telefono &
             "', " & c.Idtipousuario & " );"
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

    Public Function updateCliente(c As Cliente)
        Dim query = "update cliente set nombre = '" & c.Nombre & "', direccion = '" & c.Direccion &
            "', telefono = '" & c.Telefono & "', idtipousuario = " & c.Idtipousuario &
            " where idcliente = " & c.Idcliente & " ;"
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

    Public Function deleteCliente(id As String)
        Dim query = "delete from cliente where idcliente = " & id
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


