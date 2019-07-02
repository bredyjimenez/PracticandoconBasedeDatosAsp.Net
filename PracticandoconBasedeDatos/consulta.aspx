<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="PracticandoconBasedeDatos.consulta2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de usuario:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Height="66px" OnClick="btnBuscar_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" Text="Retornar" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
