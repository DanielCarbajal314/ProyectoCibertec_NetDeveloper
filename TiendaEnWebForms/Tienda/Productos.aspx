<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TiendaEnWebForms.Tienda.Productos" %>
<link href="../Content/bootstrap.css" rel="stylesheet" />
<script src="../Scripts/bootstrap.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 187px">
    <form id="form1" runat="server">

        <asp:Label ID="EtiquetaNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="EtiquetaPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="Precio" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="Guardar" runat="server" Text="Button" OnClick="Guardar_Click" />
        <div>
            <asp:GridView 
                ID="ListaDeProductos" 
                runat="server"
                ItemType ="InterfacesInventario.Productos.Respuestas.ProductoRegistrado"
                DataKeyNames="Id"
                SelectMethod ="ListarProductos" CssClass="table table-dark table-striped table-hover">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
