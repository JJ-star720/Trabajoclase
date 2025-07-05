<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="producto.aspx.vb" Inherits="Trabajoclase.producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Lista de Productos</h2>
        <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductoId"
            OnSelectedIndexChanged="gvProductos_SelectedIndexChanged"
            OnRowDeleting="gvProductos_RowDeleting">
            <Columns>
                <asp:BoundField DataField="ProductoId" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" />
                <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>

        </div>

        <div>
        <h3>Formulario</h3>
        <asp:Label Text="Nombre:" runat="server" />
        <asp:TextBox ID="txtNombre" runat="server" /><br />
        <asp:Label Text="Precio:" runat="server" />
        <asp:TextBox ID="txtPrecio" runat="server" /><br />
        <asp:Label Text="Stock:" runat="server" />
        <asp:TextBox ID="txtStock" runat="server" /><br /><br />
        </div>


        <div class="form-group mb-4">
            <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>

        <div class="form-group">
              <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-E9D67EJ\SQLEXPRESS;Initial Catalog=II46;Integrated Security=True;Encrypt=True;Trust Server Certificate=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Empleados]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:conexionDB %>"
                SelectCommand ="SELECT * FROM [Empleados]"></asp:SqlDataSource>
    </form>
</body>
</html>
