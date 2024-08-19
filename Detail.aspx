<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="taotrangweb.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dl_sanpham" runat="server" OnSelectedIndexChanged="dl_sanpham_SelectedIndexChanged">
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td rowspan="4">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "hinhanh/"+Eval("HinhAnh") %>' />
                    </td>
                    <td>Tên: 
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
                    </td>              
                
                </tr>
                <tr>
                    <td>Mô tả: 
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                    </td>
                   
                </tr>
                 <tr>
                    <td>Đơn giá: 
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                     </td>
                   
                </tr>
                     <tr>
                    <td>Số Lượng: 
                        <asp:TextBox ID="txtSoluong" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Mua" OnClick="Button1_Click" CommandArgument='<%# Eval("MaHang") %>' />
                         </td>
                   
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:Label ID="lbthongbao" runat="server" Text=""></asp:Label>
&nbsp; <a href="giohang.aspx">Giỏ Hàng</a>
    
</asp:Content>

