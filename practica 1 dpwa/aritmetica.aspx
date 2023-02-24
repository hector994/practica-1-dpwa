<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aritmetica.aspx.cs" Inherits="practica_1_dpwa.aritmetica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="selecciones la operacion a realizar:"></asp:Label>
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gruporadio" Text="suma" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gruporadio" Text="resta" />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gruporadio" Text="multiplicacion" />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="gruporadio" Text="divicion" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="dato 1:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="dato 2:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
