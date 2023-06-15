<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="Nhom6_IS385L.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">\
    <div>
        <h1>Sản Phẩm Mới</h1>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%# Eval("MaHang")%>' OnClick="LinkButton1_Click">
                    <asp:Panel ID="Panel1" runat="server" >
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/Images/"+Eval("Hinh") %>' />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:C0}") %>'></asp:Label>
                    </asp:Panel>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>    
    </div>
<%--    <div>
        <h1>Sản Phẩm Giảm Giá</h1>
            <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MaHang")%>' OnClick="LinkButton1_Click">
                    <asp:Panel ID="Panel1" runat="server" >
                        <asp:Image ID="Image3" runat="server" ImageUrl='<%# "~/Images/"+Eval("Hinh") %>' />
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
                        <asp:Label ID="Label5" runat="server" Text="'<%# Eval("DonGia","{0:C0}") %>'"></asp:Label>
                    </asp:Panel>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>    

    </div>--%>

</asp:Content>
