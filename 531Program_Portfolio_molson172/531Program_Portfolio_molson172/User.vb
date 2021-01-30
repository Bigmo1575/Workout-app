Public Class User

    Private cId As Integer
    Public Property Id() As Integer
        Get
            Return cId
        End Get
        Set(ByVal value As Integer)
            cId = value
        End Set
    End Property

    Private cName As String
    Public Property Name() As String
        Get
            Return cName
        End Get
        Set(ByVal value As String)
            cName = value
        End Set
    End Property

    Private CDateSelected As String
    Public Property DateSelected() As String
        Get
            Return CDateSelected
        End Get
        Set(ByVal value As String)
            CDateSelected = value
        End Set
    End Property

    Private cSquat As Integer
    Public Property Squat() As Integer
        Get
            Return cSquat
        End Get
        Set(ByVal value As Integer)
            cSquat = value
        End Set
    End Property

    Private cDeadlift As Integer
    Public Property Deadlift() As Integer
        Get
            Return cDeadlift
        End Get
        Set(ByVal value As Integer)
            cDeadlift = value
        End Set
    End Property

    Private cBenchPress As Integer
    Public Property BenchPress() As Integer
        Get
            Return cBenchPress
        End Get
        Set(ByVal value As Integer)
            cBenchPress = value
        End Set
    End Property

    Private cOverHeadPress As Integer
    Public Property OverHeadPress() As Integer
        Get
            Return cOverHeadPress
        End Get
        Set(ByVal value As Integer)
            cOverHeadPress = value
        End Set
    End Property



End Class
