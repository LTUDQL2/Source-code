<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManHinhBanHang.aspx.cs" Inherits="WSTheRich.TheRichForm.ManHinhBanHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 715px;
        }
        .auto-style4 {
            height: 8px;
        }
        .auto-style6 {
        }
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            height: 8px;
            width: 682px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5; width: 951px;">Bán Hàng</h1></div>
    </div>
       <div style="border-style:solid;border-width:1px;border-color:blue"> <table>
            <tr>
                <td class="auto-style8" colspan="7">

                    &nbsp;dd/MM/yyyy:mm:ss</td>
                <td>

                    Welcome MaNV</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">

                    Mã Khách Hàng</td>
                <td class="auto-style2" colspan="4">

                    <asp:TextBox ID="TextBoxMaKhachHang" runat="server" Width="184px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">

                    Mã Sản Phẩm</td>
                <td class="auto-style2" colspan="4">

                    <asp:TextBox ID="TextBoxMaSanPham" runat="server" Width="183px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">

                    Số Lượng</td>
                <td class="auto-style2" colspan="4">

                    <asp:TextBox ID="TextBoxSoLuong" runat="server" Width="183px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="3">

                    &nbsp;</td>
                <td class="auto-style2" colspan="4">

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="8">

                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" OnClick="ButtonThemInHD_Click" />

                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonThanhToan" runat="server" Text="Thanh Toán" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonInHD" runat="server" Text="InHD" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="8">

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="948px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="STT" />
                            <asp:BoundField HeaderText="Mã Sản Phẩm" />
                            <asp:BoundField HeaderText="Tên Sản Phẩm" />
                            <asp:BoundField HeaderText="Số Lượng" />
                            <asp:BoundField HeaderText="Đơn Giá" />
                            <asp:BoundField HeaderText="Tỉ Lệ Giảm" />
                            <asp:BoundField HeaderText="Thành Tiền" />
                            <asp:CheckBoxField HeaderText=" Chọn" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4" colspan="2">

                    &nbsp;</td>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style9">

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4" colspan="2">

                    &nbsp;</td>
                <td class="auto-style9">

                    &nbsp;</td>
                <td class="auto-style4">

                    TỔNG CỘNG</td>
                <td class="auto-style4" colspan="2">

                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4" colspan="2">

                    &nbsp;</td>
                <td class="auto-style9">

                    &nbsp;</td>
                <td class="auto-style4">

                    Sau khi chiết khấu</td>
                <td class="auto-style4" colspan="2">

                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4" colspan="2">

                    &nbsp;</td>
                <td class="auto-style9">

                    &nbsp;</td>
                <td class="auto-style4">

                    Tiền mặt</td>
                <td class="auto-style4" colspan="2">

                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4">

                    &nbsp;</td>
                <td class="auto-style4" colspan="2">

                    &nbsp;</td>
                <td class="auto-style9">

                    &nbsp;</td>
                <td class="auto-style4">

                    Thối lại</td>
                <td class="auto-style4" colspan="2">

                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                </td>
            </tr>
        </table>
           </div>
    </form>
</body>
</html>
