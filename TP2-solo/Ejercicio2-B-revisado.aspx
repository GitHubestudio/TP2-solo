<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2-B-revisado.aspx.cs" Inherits="TP2_solo.Ejercicio2_B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            RESUMEN<br />
            <br />
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <br />
            Apellido:&nbsp;&nbsp;
            <asp:Label ID="lblApellido" runat="server"></asp:Label>
            <br />
            Zona:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblZona" runat="server"></asp:Label>
            <br />
            <br />
            Los temas elegidos son:<br />
            <asp:Label ID="lblTemas" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
