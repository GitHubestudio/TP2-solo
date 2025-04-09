<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5-revisado.aspx.cs" Inherits="TP2_solo.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ELIJA SU CONFIGURACION<br />
            <br />
            Seleccione la cantidad de memoria:<br />
            <asp:DropDownList ID="ddlMemoria" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Seleccione los accesorios:<br />
            <asp:CheckBoxList ID="cblAccesorios" runat="server">
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular Precio" />
            <br />
            <br />
            <asp:Label ID="lblPrecio" runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
