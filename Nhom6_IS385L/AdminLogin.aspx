<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Nhom6_IS385L.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        html, body {
            width: 100%;
            height: 100%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Trang Quản Lý</h1>
            <asp:Login CssClass="login" ID="Login1" TitleText="Đăng nhập" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="QuanLy.aspx" runat="server"></asp:Login>
        </div>

    </form>
</body>
</html>
