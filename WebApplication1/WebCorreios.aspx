<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCorreios.aspx.cs" Inherits="WebApplication1.WebCorreios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="TxtCep" />
        <asp:Button Text="Enviar" runat="server" ID="BtnEnviar" OnClick="BtnEnviar_Click" />
        <div>
            <asp:Literal Text="" runat="server" ID="LitResponse" />
        </div>
    </div>
    </form>
</body>
</html>
