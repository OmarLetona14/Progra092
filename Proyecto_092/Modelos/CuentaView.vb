Imports MySql.Data.MySqlClient

Public Class CuentaView

    Private m_nocuenta As String
    Private m_descripcion As String
    Private m_tipo_cuenta As String
    Private m_saldo_disponible As String

    Public Sub New(nocuenta As String, descripcion As String, tipo_cuenta As String, saldo_disponible As String)
        m_nocuenta = nocuenta
        m_descripcion = descripcion
        m_tipo_cuenta = tipo_cuenta
        m_saldo_disponible = saldo_disponible
    End Sub

    Public Sub New()

    End Sub

    Public Property Nocuenta As String
        Get
            Return m_nocuenta
        End Get
        Set(value As String)
            m_nocuenta = value
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

    Public Property Tipo_cuenta As String
        Get
            Return m_tipo_cuenta
        End Get
        Set(value As String)
            m_tipo_cuenta = value
        End Set
    End Property

    Public Property Saldo_disponible As String
        Get
            Return m_saldo_disponible
        End Get
        Set(value As String)
            m_saldo_disponible = value
        End Set
    End Property

    Public Function getClientAccount(nombreCliente As String)
        Dim cuenta As CuentaView
        Dim cuentas = New List(Of CuentaView)
        Dim query = "select cu.nocuenta, cu.descripcion, tc.nombre_tipo, cu.total from cuenta cu " &
            " inner join cliente c on c.idcliente = cu.idcliente" &
            " inner join tipocuenta tc on tc.idtipo = cu.idtipo" &
            " where c.nombre = '" & nombreCliente & "';"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                cuenta = New CuentaView()
                cuenta.Nocuenta = reader.GetString(0)
                cuenta.Descripcion = reader.GetString(1)
                cuenta.Tipo_cuenta = reader.GetString(2)
                cuenta.Saldo_disponible = reader.GetDouble(3)
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


End Class
