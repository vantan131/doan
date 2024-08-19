<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="taotrangweb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dl_mathang" runat="server" RepeatColumns="2">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "hinhanh/"+Eval("HinhAnh") %>' style="width: 200px; " CommandArgument='<%# Eval("MaHang") %>' OnClick="ImageButton1_Click" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("TENHANG") %>' CommandArgument='<%# Eval("MaHang") %>' OnClick="LinkButton2_Click"></asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("MaHang") %>' OnClick="LinkButton3_Click" >Chi tiết</asp:LinkButton>
    </ItemTemplate>
</asp:DataList>


</asp:Content>
