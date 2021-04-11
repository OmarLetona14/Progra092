Public Class Empleado

    Private m_nombre As String
    Private m_sueldobruto As Double
    Private m_descuento As String
    Private m_totaldescuento As Double
    Private m_bono As Double
    Private m_sueldototal As Double
    Public Sub New()

    End Sub

    Public Sub New(nombre As String, sueldobruto As Double, descuento As String, totaldescuento As Double, bono As Double, sueldototal As Double)
        m_nombre = nombre
        m_sueldobruto = sueldobruto
        m_descuento = descuento
        m_totaldescuento = totaldescuento
        m_bono = bono
        m_sueldototal = sueldototal
    End Sub

    Public Property Nombre As String
        Get
            Return m_nombre
        End Get
        Set(value As String)
            m_nombre = value
        End Set
    End Property

    Public Property Sueldobruto As Double
        Get
            Return m_sueldobruto
        End Get
        Set(value As Double)
            m_sueldobruto = value
        End Set
    End Property

    Public Property Descuento As String
        Get
            Return m_descuento
        End Get
        Set(value As String)
            m_descuento = value
        End Set
    End Property

    Public Property Totaldescuento As Double
        Get
            Return m_totaldescuento
        End Get
        Set(value As Double)
            m_totaldescuento = value
        End Set
    End Property

    Public Property Bono As Double
        Get
            Return m_bono
        End Get
        Set(value As Double)
            m_bono = value
        End Set
    End Property

    Public Property Sueldototal As Double
        Get
            Return m_sueldototal
        End Get
        Set(value As Double)
            m_sueldototal = value
        End Set
    End Property
End Class
