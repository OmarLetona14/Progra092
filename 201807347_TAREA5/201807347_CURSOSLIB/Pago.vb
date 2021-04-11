Public Class Pago

    Private m_numero As Integer
    Private m_nombreCurso As String
    Private m_fecha As String
    Private m_dias As String
    Private m_horas As String
    Private m_formapago As String
    Private m_parcial As Double
    Private m_descuentopago As Double
    Private m_descuentodias As Double
    Private m_total As Double
    Private m_dosdias As Boolean

    Public Sub New()

    End Sub

    Public Sub New(numero As Integer, nombreCurso As String, fecha As String, dias As String, horas As String, formapago As String, parcial As Double, descuentopago As Double, descuentodias As Double, total As Double, dosdias As Boolean)
        m_numero = numero
        m_nombreCurso = nombreCurso
        m_fecha = fecha
        m_dias = dias
        m_horas = horas
        m_formapago = formapago
        m_parcial = parcial
        m_descuentopago = descuentopago
        m_descuentodias = descuentodias
        m_total = total
        m_dosdias = dosdias
    End Sub

    Public Property Numero As Integer
        Get
            Return m_numero
        End Get
        Set(value As Integer)
            m_numero = value
        End Set
    End Property

    Public Property NombreCurso As String
        Get
            Return m_nombreCurso
        End Get
        Set(value As String)
            m_nombreCurso = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return m_fecha
        End Get
        Set(value As String)
            m_fecha = value
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

    Public Property Horas As String
        Get
            Return m_horas
        End Get
        Set(value As String)
            m_horas = value
        End Set
    End Property

    Public Property Formapago As String
        Get
            Return m_formapago
        End Get
        Set(value As String)
            m_formapago = value
        End Set
    End Property

    Public Property Parcial As Double
        Get
            Return m_parcial
        End Get
        Set(value As Double)
            m_parcial = value
        End Set
    End Property

    Public Property Descuentopago As Double
        Get
            Return m_descuentopago
        End Get
        Set(value As Double)
            m_descuentopago = value
        End Set
    End Property

    Public Property Descuentodias As Double
        Get
            Return m_descuentodias
        End Get
        Set(value As Double)
            m_descuentodias = value
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

    Public Property Dosdias As Boolean
        Get
            Return m_dosdias
        End Get
        Set(value As Boolean)
            m_dosdias = value
        End Set
    End Property
End Class
