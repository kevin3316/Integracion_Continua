<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="prueba.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>LOGIN</h1>
        USURIO:
    </div>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        CONTRASEÑA<br />
        <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalida" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Button" />
        <br />
    </form>
</body>
</html>
