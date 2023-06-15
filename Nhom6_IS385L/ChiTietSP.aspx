<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSP.aspx.cs" Inherits="Nhom6_IS385L.ChiTietSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Images/"+Eval("Hinh") %>' />
                <h1>Mô Tả</h1>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:C0}") %>'></asp:Label>
                <h1>Số lượng</h1>
                <asp:TextBox ID="TextBox1" runat="server" Text="0"></asp:TextBox>
            </ItemTemplate>
        </asp:DataList>

    </div>
</asp:Content>
