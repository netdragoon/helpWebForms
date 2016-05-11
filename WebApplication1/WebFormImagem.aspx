<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormImagem.aspx.cs" Inherits="WebApplication1.WebFormImagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="FileUploadFoto" runat="server" />
        </div>
        <div>
            <asp:Button Text="Enviar" runat="server" ID="BtnEnviar" OnClick="BtnEnviar_Click" />
        </div>
        <div>
            <asp:GridView runat="server" ID="GridImagens" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:ImageField DataImageUrlField="Id"
                         DataImageUrlFormatString="GenericHandlerLoadImagem.ashx?id={0}" 
                        HeaderText="Imagem" 
                        ControlStyle-Width="100px" 
                        ItemStyle-Height="100px">                        
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
