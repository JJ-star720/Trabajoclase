Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnContactar_click(sender As Object, e As EventArgs)
        Dim persona As New Persona(TxtNombre.Text, TxtApellido.Text, TxtEmail.Text)
        LblMensaje.Text = $"Gracias por contactarnos {persona.nombreCompleto}"
    End Sub
End Class