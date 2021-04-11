Public Class Paciente

    Private m_nombre As String
    Private m_nit As String
    Private m_dias As Integer
    Private m_habitacion As String
    Private m_pago As String
    Private m_subtotal As Double
    Private m_descuento As Double
    Private m_total As Double
    Public Sub New()

    End Sub

    Public Sub New(nombre As String, nit As String, dias As Integer, habitacion As String, pago As String, subtotal As Double, descuento As Double, total As Double)
        m_nombre = nombre
        m_nit = nit
        m_dias = dias
        m_habitacion = habitacion
        m_pago = pago
        m_subtotal = subtotal
        m_descuento = descuento
        m_total = total
    End Sub

    Public Property Nombre As String
        Get
            Return m_nombre
        End Get
        Set(value As String)
            m_nombre = value
        End Set
    End Property

    Public Property Nit As String
        Get
            Return m_nit
        End Get
        Set(value As String)
            m_nit = value
        End Set
    End Property

    Public Property Dias As Integer
        Get
            Return m_dias
        End Get
        Set(value As Integer)
            m_dias = value
        End Set
    End Property

    Public Property Habitacion As String
        Get
            Return m_habitacion
        End Get
        Set(value As String)
            m_habitacion = value
        End Set
    End Property

    Public Property Pago As String
        Get
            Return m_pago
        End Get
        Set(value As String)
            m_pago = value
        End Set
    End Property

    Public Property Subtotal As Double
        Get
            Return m_subtotal
        End Get
        Set(value As Double)
            m_subtotal = value
        End Set
    End Property

    Public Property Descuento As Double
        Get
            Return m_descuento
        End Get
        Set(value As Double)
            m_descuento = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return m_total
        End Get
        Set(value As Double)
            m_total = value
        End Set
    End Property
End Class
