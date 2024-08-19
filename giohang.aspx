<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="taotrangweb.giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Hình Ảnh">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "hinhanh/"+Eval("HinhAnh") %>' Width ="200px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="TenHang" HeaderText="Tên Hàng" />
            <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
            <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền" />
        </Columns>
    </asp:GridView>
</asp:Content>
