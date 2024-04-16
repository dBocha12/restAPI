<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="PruebaRest.CVista.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de Usuario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Información del Usuario</h1>
            <div>
                <p>Nombre: <asp:Label ID="nombre" runat="server" /></p>
                <p>Edad: <asp:Label ID="edad" runat="server" /></p>
                <p>País: <asp:Label ID="pais" runat="server" /></p>
                <asp:Image ID="imagen" runat="server" Width="200" Height="200" />
                <p><asp:Label ID="respuesta" runat="server" /></p>
                <asp:Button ID="Button1" runat="server" Text="Consultar Usuario" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
