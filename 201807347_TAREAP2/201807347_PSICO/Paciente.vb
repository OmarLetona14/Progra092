Public Class Paciente

    Private m_nombrepaciente As String
    Private m_genero As String
    Private m_dias As String
    Private m_tipoterapia As String
    Private m_subtotal As Double
    Private m_descuento As Double
    Private m_total As Double

    Public Sub New()

    End Sub

    Public Sub New(nombrepaciente As String, genero As String, dias As String, tipoterapia As String, subtotal As Double, descuento As Double, total As Double)
        m_nombrepaciente = nombrepaciente
        m_genero = genero
        m_dias = dias
        m_tipoterapia = tipoterapia
        m_subtotal = subtotal
        m_descuento = descuento
        m_total = total
    End Sub

    Public Property Nombrepaciente As String
        Get
            Return m_nombrepaciente
        End Get
        Set(value As String)
            m_nombrepaciente = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return m_genero
        End Get
        Set(value As String)
            m_genero = value
        End Set
    End Property

    Public Property Dias As String
        Get
            Return m_dias
        End Get
        Set(value As String)
            m_dias = value
        End Set
    End Property

    Public Property Tipoterapia As String
        Get
            Return m_tipoterapia
        End Get
        Set(value As String)
            m_tipoterapia = value
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
