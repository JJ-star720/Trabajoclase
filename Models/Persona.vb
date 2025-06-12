﻿Public Class Persona
    Private _nombre As String
    Private _ápellido As String
    Private _edad As String
    Private _dirreccion As String
    Private _telefono As String
    Private _correo As String

    'constructor completo
    Public Sub New(nombre As String, ápellido As String, edad As String, dirreccion As String, telefono As String, correo As String)
        _nombre = nombre
        _ápellido = ápellido
        _edad = edad
        _dirreccion = dirreccion
        _telefono = telefono
        _correo = correo
    End Sub

    'constructor basico 
    Public Sub New(nombre As String, ápellido As String, edad As String)
        _nombre = nombre
        _ápellido = ápellido
        _edad = edad
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Ápellido As String
        Get
            Return _ápellido
        End Get
        Set(value As String)
            _ápellido = value
        End Set
    End Property

    Public Property Edad As String
        Get
            Return _edad
        End Get
        Set(value As String)
            _edad = value
        End Set
    End Property

    Public Property Dirreccion As String
        Get
            Return _dirreccion
        End Get
        Set(value As String)
            _dirreccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Function nombreCompleto() As String
        Return $"{_nombre}{_ápellido}"
    End Function
End Class
