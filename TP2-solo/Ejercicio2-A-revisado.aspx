<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2-A-revisado.aspx.cs" Inherits="TP2_solo.Ejercicio2_A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbNombre" runat="server" Height="26px" Width="155px"></asp:TextBox>
            <br />
            <br />
            Apellido:&nbsp;&nbsp;
            <asp:TextBox ID="tbApellido" runat="server" Height="27px" Width="160px"></asp:TextBox>
            <br />
            <br />
            Ciudad:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudad" runat="server" Height="16px" Width="179px">
            </asp:DropDownList>
            <br />
            <br />
            Temas:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="cblTemas" runat="server">
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Ver Resumen" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
