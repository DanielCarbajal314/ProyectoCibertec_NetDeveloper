<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenimientoDeProductosConMasterPage.aspx.cs" Inherits="TiendaEnWebForms.Tienda.MantenimientoDeProductosConMasterPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <link href="../Content/DataTables.css" rel="stylesheet" />
        <script src="../Scripts/DataTables.js"></script>
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
                AutoGenerateColumns="false"
                SelectMethod ="ListarProductos" CssClass="table table-dark table-striped table-hover">
                 <Columns>
                            <asp:DynamicField DataField="Id" />
                            <asp:DynamicField DataField="Nombre" />
                            <asp:DynamicField DataField="Precio" />         
                </Columns>
            </asp:GridView>
        </div>
        <script>
            $(document).ready(function () {
                $("table").DataTable();
            });
        </script>
    </div>
</asp:Content>
