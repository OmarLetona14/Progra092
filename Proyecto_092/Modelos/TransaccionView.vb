Imports MySql.Data.MySqlClient

Public Class TransaccionView


    Private m_idtransaccion As String
    Private m_concepto As String
    Private m_monto As Double
    Private m_tipotransaccion As String

    Public Sub New()

    End Sub
    Public Sub New(idtransaccion As String, concepto As String, monto As Double, tipotransaccion As String)
        m_idtransaccion = idtransaccion
        m_concepto = concepto
        m_monto = monto
        m_tipotransaccion = tipotransaccion
    End Sub

    Public Property Idtransaccion As String
        Get
            Return m_idtransaccion
        End Get
        Set(value As String)
            m_idtransaccion = value
        End Set
    End Property

    Public Property Concepto As String
        Get
            Return m_concepto
        End Get
        Set(value As String)
            m_concepto = value
        End Set
    End Property

    Public Property Monto As Double
        Get
            Return m_monto
        End Get
        Set(value As Double)
            m_monto = value
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

    Public Function getClientRecord(nombreCliente As String)
        Dim transaccion As TransaccionView
        Dim transacciones = New List(Of TransaccionView)
        Dim query = "select t.idtransaccion, t.concepto, t.monto, tt.tipo_transaccion " &
            " from transaccion t" &
            " inner join cliente c on c.idcliente = t.idcliente" &
            " inner join tipotransaccion tt on tt.idtipotran = t.idtipotran" &
            " where c.nombre = '" & nombreCliente & "';"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                transaccion = New TransaccionView()
                transaccion.Idtransaccion = reader.GetInt64(0)
                transaccion.Concepto = reader.GetString(1)
                transaccion.Monto = reader.GetDouble(2)
                transaccion.Tipotransaccion = reader.GetString(3)
                transacciones.Add(transaccion)
            End While
            reader.Close()
            Return transacciones
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

End Class
