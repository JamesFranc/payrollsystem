Public Class Employee
    Dim strFName As String
    Dim strLName As String
    Dim strAddress1 As String
    Dim strAddress2 As String
    Dim strCity As String
    Dim strState As String
    Dim strZip As String
    Dim strPhone As String
    Dim strSSN As String
    Dim strUserId As String
    Dim strPassword As String
    Dim blnAdmin As Boolean

    Public Property fName() As String
        Get
            Return strFName
        End Get
        Set(value As String)
            strFName = value
        End Set
    End Property

    Public Property lName() As String
        Get
            Return strLName
        End Get
        Set(value As String)
            strLName = value
        End Set
    End Property

    Public Property address1() As String
        Get
            Return strAddress1
        End Get
        Set(value As String)
            strAddress1 = value
        End Set
    End Property

    Public Property address2() As String
        Get
            Return strAddress2
        End Get
        Set(value As String)
            strAddress2 = value
        End Set
    End Property

    Public Property city() As String
        Get
            Return strCity
        End Get
        Set(value As String)
            strCity = value
        End Set
    End Property

    Public Property state() As String
        Get
            Return strState
        End Get
        Set(value As String)
            strState = value
        End Set
    End Property

    Public Property zip() As String
        Get
            Return strZip
        End Get
        Set(value As String)
            strZip = value
        End Set
    End Property

    Public Property phone() As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            strPhone = value
        End Set
    End Property

    Public Property SSN() As String
        Get
            Return strSSN
        End Get
        Set(value As String)
            strSSN = value
        End Set
    End Property

    Public Property userId() As String
        Get
            Return strUserId
        End Get
        Set(value As String)
            strUserId = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return strPassword
        End Get
        Set(value As String)
            strPassword = value
        End Set
    End Property

    Public Property admin() As Boolean
        Get
            Return blnAdmin
        End Get
        Set(value As Boolean)
            blnAdmin = value
        End Set
    End Property


End Class