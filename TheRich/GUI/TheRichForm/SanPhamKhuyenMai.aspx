<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SanPhamKhuyenMai.aspx.cs" Inherits="GUI.TheRichForm.SanPhamKhuyenMai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 129px;
        }
        .auto-style2 {
            width: 26px;
        }
        .auto-style3 {
        }
        .auto-style4 {
            width: 164px;
        }
        .auto-style5 {
            width: 178px;
        }
        .auto-style6 {
            width: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Sản Phẩm Khuyến Mãi</h1></div>
    <div style="border-style:solid;border-width:1px;border-color:blue"><table style="width: 825px">
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style5">

                Mã Sản Phẩm Khuyến Mãi: </td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBoxMaSanPhamKhuyenMai" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

            </td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style5">

                Số Lượng</td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBoxSoLuong" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style5">

                Giá Bán</td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBoxGiaBan" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style3" colspan="3">

                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

            </td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style3" colspan="2">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style3" colspan="5">

                <asp:GridView ID="GridViewSanPhamKhuyenMai" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="101px" Width="786px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Mã Sản Phẩm Khuyến Mãi" />
                        <asp:BoundField HeaderText="Tên Sản Phẩm Khuyến Mãi" />
                        <asp:BoundField HeaderText="Số Lượng" />
                        <asp:BoundField HeaderText="Giá Bán" />
                        <asp:CheckBoxField HeaderText="Chọn" />
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
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style3" colspan="5">

                &nbsp;</td>
        </tr>
    </table>
        </div>
    </div>
    </form>
</body>
</html>
