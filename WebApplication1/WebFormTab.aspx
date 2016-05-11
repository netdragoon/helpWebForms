<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTab.aspx.cs" Inherits="WebApplication1.WebFormTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/modernizr-2.6.2.js"></script>
    <script src="Scripts/respond.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <ul class="nav nav-tabs" role="tablist" runat="server" id="myTabs">
                    <li role="presentation"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">Home</a></li>
                    <li role="presentation"><a href="#profile" aria-controls="profile" role="tab" data-toggle="tab">Profile</a></li>
                    <li role="presentation"><a href="#messages" aria-controls="messages" role="tab" data-toggle="tab">Messages</a></li>
                    <li role="presentation"><a href="#settings" aria-controls="settings" role="tab" data-toggle="tab">Settings</a></li>
                </ul>
                <div class="tab-content" runat="server" id="PanelContent">
                    <div role="tabpanel" class="tab-pane" id="home" runat="server">
                        <h3>Home</h3>
                        <asp:Button Text="Home" runat="server" ID="BtnHome" OnClick="BtnHome_Click" />
                    </div>
                    <div role="tabpanel" class="tab-pane" id="profile" runat="server">
                        <h3>Profile</h3>
                        <asp:Button Text="Profile" runat="server" ID="BtnProfile" OnClick="BtnProfile_Click" />
                    </div>

                    <div role="tabpanel" class="tab-pane" id="messages" runat="server">
                        <h3>Messages</h3>
                        <asp:Button Text="Messages" runat="server" ID="BtnMessage" OnClick="BtnMessage_Click" />
                    </div>
                    <div role="tabpanel" class="tab-pane" id="settings" runat="server">
                        <h3>Settings</h3>
                        <asp:Button Text="Settings" runat="server" ID="BtnSettings" OnClick="BtnSettings_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script>
        item = '#<%=PanelSelect%>';
        $(document).ready(function (e) {            
            $('#myTabs a[href="' + item + '"]').tab('show');
            console.log($(item));
        });
    </script>
</body>
</html>
