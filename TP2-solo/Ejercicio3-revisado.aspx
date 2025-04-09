<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3-revisado.aspx.cs" Inherits="TP2_solo.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="linkRojo" runat="server" OnClick="linkRojo_Click">Rojo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="linkAzul" runat="server" OnClick="linkAzul_Click">Azul</asp:LinkButton>
            <br />
            <asp:LinkButton ID="linkVerde" runat="server" OnClick="linkVerde_Click">Verde</asp:LinkButton>
            <br />
            <br />
            <br />
            <asp:Label ID="lblTexto" runat="server" Text="Texto coloreado"></asp:Label>
        </div>
    </form>
</body>
</html>
