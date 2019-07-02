
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="baja.aspx.cs" Inherits="PracticandoconBasedeDatos.baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:" AssociatedControlID="txtNombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
             <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" Text="Retornar" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
