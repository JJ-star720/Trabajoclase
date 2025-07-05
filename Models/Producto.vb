Imports System.Net
Public Class Producto
    Private _ProductoID As Integer
    Private _Nombre As String
    Private _precio As Decimal
    Private _stock As Integer

    Public Sub New(productoID As Integer, nombre As String, Precio As Decimal, Stock As Integer)
        Me.ProductoID = productoID
        Me.Nombre = nombre
        Me.Precio = Precio
        Me.Stock = Stock
    End Sub

    Public Property ProductoID As Integer
        Get
            Return _ProductoID
        End Get
        Set(value As Integer)
            _ProductoID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
End Class
