<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="WebFormImagem.aspx.cs" Inherits="WebApplication1.WebFormImagem" %>

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
            <asp:GridView runat="server" ID="GridImagens" AutoGenerateColumns="False" OnRowCommand="GridImagens_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:ImageField DataImageUrlField="Id"
                        DataImageUrlFormatString="GenericHandlerLoadImagem.ashx?id={0}"
                        HeaderText="Imagem"
                        ControlStyle-Width="100px"
                        ItemStyle-Height="100px">
                        <ControlStyle Width="100px"></ControlStyle>

                        <ItemStyle Height="100px"></ItemStyle>
                    </asp:ImageField>
                    <asp:TemplateField HeaderText="Alterar" ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandArgument='<%#Bind("Id") %>' CommandName="Alterar" Text="Alterar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <asp:Label Text="" ID="LblEscolhido" runat="server" />
    </form>
</body>
</html>
