<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormLoadImagem.aspx.cs" Inherits="WebApplication1.WebFormLoadImagem" %>

<!DOCTYPE html>
<%--https://developer.mozilla.org/en-US/docs/Web/API/FileReader/readAsDataURL--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Image ID="ImageUploadPreview" runat="server" />
    <asp:FileUpload ID="FileUploadImagem" runat="server" />
    </div>
    </form>
    <script>
        $(document).ready(function () {
            $("#<%=FileUploadImagem.ClientID%>").on('change', function()
            {
                var pre = $("#<%=ImageUploadPreview.ClientID%>");
                var img = $("#<%=FileUploadImagem.ClientID%>").get(0).files[0];
                var reader = new FileReader();

                reader.addEventListener("load", function () {
                    pre.removeAttr("src");
                    pre.attr("src", reader.result);                    
                }, false);

                if (img) {
                    reader.readAsDataURL(img);
                }
            })
            
        });
    </script>
</body>
</html>
