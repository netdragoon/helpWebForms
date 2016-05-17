Public Class Items
    Private _key As String
    Public Property Key() As String
        Get
            Return _key
        End Get
        Set(ByVal value As String)
            _key = value
        End Set
    End Property
    Private _items As IList(Of String)
    Public Property Items() As IList(Of String)
        Get
            Return _items
        End Get
        Set(ByVal value As IList(Of String))
            _items = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal key As String, ByVal items As IList(Of String))
        _key = key
        _items = items
    End Sub

End Class
