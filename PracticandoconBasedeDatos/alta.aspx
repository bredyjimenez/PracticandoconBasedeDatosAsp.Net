<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="PracticandoconBasedeDatos.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" AssociatedControlID="txtNombre" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" AssociatedControlID="txtClave" Text="Clave:"></asp:Label>
            <asp:TextBox ID="txtClave" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" AssociatedControlID="txtMail" Text="Mail"></asp:Label>
            <asp:TextBox ID="txtMail" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" Text="Retornar" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
