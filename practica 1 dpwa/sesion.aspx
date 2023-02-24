<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sesion.aspx.cs" Inherits="practica_1_dpwa.sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Inicio de secion:"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Usuario:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
