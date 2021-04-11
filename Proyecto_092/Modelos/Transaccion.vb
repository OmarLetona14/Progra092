Public Class Transaccion

    Private m_idtransaccion As Integer
    Private m_concepto As String
    Private m_monto As Integer
    Private m_idcliente As Integer
    Private m_idcuenta As Integer
    Private m_idtipotran As Integer

    Public Sub New(idtransaccion As Integer, concepto As String, monto As Integer, idcliente As Integer, idcuenta As Integer, idtipotran As Integer)
        m_idtransaccion = idtransaccion
        m_concepto = concepto
        m_monto = monto
        m_idcliente = idcliente
        m_idcuenta = idcuenta
        m_idtipotran = idtipotran
    End Sub

    Public Sub New()

    End Sub
    Public Property Idtransaccion As Integer
        Get
            Return m_idtransaccion
        End Get
        Set(value As Integer)
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

    Public Property Monto As Integer
        Get
            Return m_monto
        End Get
        Set(value As Integer)
            m_monto = value
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

    Public Property Idcuenta As Integer
        Get
            Return m_idcuenta
        End Get
        Set(value As Integer)
            m_idcuenta = value
        End Set
    End Property

    Public Property Idtipotran As Integer
        Get
            Return m_idtipotran
        End Get
        Set(value As Integer)
            m_idtipotran = value
        End Set
    End Property
End Class
