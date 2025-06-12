Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim persona As New Persona("Juan", "Velez", 0) With {
           .Dirreccion = "cuatro reinas",
            .Telefono = "62106857"}

        Titulo.Text = "Bienvenido a la clase de ASP.NET"
        Lblpersona.Text = persona.nombreCompleto
    End Sub
End Class