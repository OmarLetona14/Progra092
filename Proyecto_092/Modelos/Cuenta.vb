Imports MySql.Data.MySqlClient

Public Class Cuenta

    Private m_idcuenta As Integer
    Private m_nocuenta As Integer
    Private m_total As Integer
    Private m_descripcion As String
    Private m_idcliente As Integer
    Private m_idtipo As Integer

    Public Sub New(idcuenta As Integer, nocuenta As Integer, total As Integer, descripcion As String, idcliente As Integer, idtipo As Integer)
        m_idcuenta = idcuenta
        m_nocuenta = nocuenta
        m_total = total
        m_descripcion = descripcion
        m_idcliente = idcliente
        m_idtipo = idtipo
    End Sub

    Public Sub New()

    End Sub

    Public Property Idcuenta As Integer
        Get
            Return m_idcuenta
        End Get
        Set(value As Integer)
            m_idcuenta = value
        End Set
    End Property

    Public Property Nocuenta As Integer
        Get
            Return m_nocuenta
        End Get
        Set(value As Integer)
            m_nocuenta = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return m_total
        End Get
        Set(value As Integer)
            m_total = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return m_descripcion
        End Get
        Set(value As String)
            m_descripcion = value
        End Set
    End Property

    Public Property Idcliente As Integer
        Get
            Return m_idcliente
        End Get
        Set(value As Integer)
            m_idcliente = value
        End Set
    End Property

    Public Property Idtipo As Integer
        Get
            Return m_idtipo
        End Get
        Set(value As Integer)
            m_idtipo = value
        End Set
    End Property

    Public Function getCuentas()
        Dim cuenta As Cuenta
        Dim cuentas = New List(Of Cuenta)
        Dim query = "select * from cuenta;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                cuenta = New Cuenta()
                cuenta.Idcuenta = reader.GetInt64(0)
                cuenta.Nocuenta = reader.GetString(1)
                cuenta.Total = reader.GetDouble(2)
                cuenta.Descripcion = reader.GetString(3)
                cuenta.Idcliente = reader.GetInt64(4)
                cuenta.Idtipo = reader.GetInt64(5)
                cuentas.Add(cuenta)
            End While
            reader.Close()
            Return cuentas
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function getOneCuenta(id As String)
        Dim cuenta As New Cuenta
        Dim query = "select * from cuenta where idcuenta = " & id & " ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                cuenta = New Cuenta()
                cuenta.Idcuenta = reader.GetInt64(0)
                cuenta.Nocuenta = reader.GetString(1)
                cuenta.Total = reader.GetDouble(2)
                cuenta.Descripcion = reader.GetString(3)
                cuenta.Idcliente = reader.GetInt64(4)
                cuenta.Idtipo = reader.GetInt64(5)
            End While
            reader.Close()
            Return cuenta
        Catch ex As Exception
            Console.Write(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function insertCuenta(c As Cuenta)
        Dim query = "Insert into cuenta values (null, '" & c.Nocuenta & "', " & c.Total & ", '" & c.Descripcion &
             "', " & c.Idcliente & ", " & c.Idtipo & " );"
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

    Public Function updateCuenta(c As Cuenta)
        Dim query = "update cuenta set nocuenta = '" & c.Nocuenta & "', total = " & c.Total &
            ", descripcion = '" & c.Descripcion & "', idcliente = " & c.Idcliente & ", idtipo = " & c.Idtipo &
            " where idcuenta = " & c.Idcuenta & " ;"
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

    Public Function deleteCuenta(id As String)
        Dim query = "delete from cuenta where idcuenta = " & id
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

    Public Function getCuentasPerCliente(nombre As String)
        Dim cuenta As New Cuenta
        Dim cuentas_1 As New List(Of Cuenta)
        Dim query = "select cu.nocuenta, cu.total, cu.descripcion from cuenta cu " &
            " inner join cliente c on c.idcliente = cu.idcliente " &
            "where c.nombre = '" & nombre & "' ;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                cuenta = New Cuenta()
                cuenta.Nocuenta = reader.GetString(0)
                cuenta.Total = reader.GetDouble(1)
                cuenta.Descripcion = reader.GetString(2)
                cuentas_1.Add(cuenta)
            End While
            reader.Close()
            Return cuentas_1
        Catch ex As Exception
            Console.Write(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
