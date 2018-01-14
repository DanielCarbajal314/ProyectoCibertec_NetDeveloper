<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJaxForm.aspx.cs" Inherits="TiendaEnWebForms.Tienda.AJaxForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:Label ID="HoraDeCarga" runat="server" Text="Label"></asp:Label>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>              
                <asp:Label ID="Hora" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="DimeLaHora" runat="server" Text="Button" OnClick="DimeLaHora_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>

    </div>
    </form>
</body>
</html>
