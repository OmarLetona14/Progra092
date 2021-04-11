Imports MySql.Data.MySqlClient

Public Class TipoCuenta

    Private m_idtipo As Integer
    Private m_nombretipo As String

    Public Sub New(idtipo As Integer, nombretipo As String)
        m_idtipo = idtipo
        m_nombretipo = nombretipo
    End Sub

    Public Sub New()

    End Sub
    Public Property Idtipo As Integer
        Get
            Return m_idtipo
        End Get
        Set(value As Integer)
            m_idtipo = value
        End Set
    End Property

    Public Property Nombretipo As String
        Get
            Return m_nombretipo
        End Get
        Set(value As String)
            m_nombretipo = value
        End Set
    End Property

    Public Function getTipoCuentas()
        Dim tipocuenta As TipoCuenta
        Dim tipocuentas = New List(Of TipoCuenta)
        Dim query = "select * from tipocuenta;"
        Dim _comm = New MySqlCommand(query, Connector.connection)
        Try
            Dim reader = _comm.ExecuteReader()
            While (reader.Read())
                tipocuenta = New TipoCuenta()
                tipocuenta.Idtipo = reader.GetInt64(0)
                tipocuenta.Nombretipo = reader.GetString(1)
                tipocuentas.Add(tipocuenta)
            End While
            reader.Close()
            Return tipocuentas
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function insertTipoCuenta(c As TipoCuenta)
        Dim query = "insert into tipocuenta values (null, '" & c.Nombretipo & "' );"
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


    Public Function updateTipoCuenta(c As TipoCuenta)
        Dim query = "update tipocuenta set nombre_tipo = '" & c.Nombretipo &
            "' where idtipo = " & c.Idtipo & " ;"
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

    Public Function deleteTipoCuenta(id As String)
        Dim query = "delete from tipocuenta where idtipo = " & id & " ;"
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
