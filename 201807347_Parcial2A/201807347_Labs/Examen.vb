Public Class Examen

    Private m_examen(3) As String
    Private m_laboratorio As String
    Private m_pago As String
    Private m_subtotal As Double
    Private m_descuento As Double
    Private m_total As Double

    Public Sub New()

    End Sub

    Public Sub New(examen() As String, laboratorio As String, pago As String, subtotal As Double, descuento As Double, total As Double)
        m_examen = examen
        m_laboratorio = laboratorio
        m_pago = pago
        m_subtotal = subtotal
        m_descuento = descuento
        m_total = total
    End Sub

    Public Property Examen As String()
        Get
            Return m_examen
        End Get
        Set(value As String())
            m_examen = value
        End Set
    End Property

    Public Property Laboratorio As String
        Get
            Return m_laboratorio
        End Get
        Set(value As String)
            m_laboratorio = value
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
