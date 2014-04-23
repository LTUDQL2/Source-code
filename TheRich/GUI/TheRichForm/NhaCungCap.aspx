<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhaCungCap.aspx.cs" Inherits="GUI.TheRichForm.NhaCungCap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 110px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 32px;
        }
        .auto-style5 {
            width: 75px;
        }
        .auto-style6 {
            width: 19px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 110px;
            height: 26px;
        }
        .auto-style12 {
            width: 71px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Nhà Cung Cấp</h1></div>
    <div style="border-style:solid;border-width:1px;border-color:blue"><table>
        <tr>
            <td class="auto-style12" colspan="10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4" align="right">Tên Nhà Cung Cấp:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxTenNhaCungCap" runat="server" Width="172px"></asp:TextBox>
            </td>
            <td class="auto-style8" colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4" align="right">Địa Chỉ:</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxDiaChi" runat="server" Width="172px"></asp:TextBox>
            </td>
            <td class="auto-style3" colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4" align="right">Số Điện Thoại:</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxSoDienThoai" runat="server" Width="172px"></asp:TextBox>
            </td>
            <td class="auto-style1" colspan="5">&nbsp;</td>
        </tr>
        <tr><td class="auto-style12" colspan="10">&nbsp;</td></tr>
        <tr>
            <td class="auto-style2" colspan="4" align="right">Tìm kiếm theo tên:</td>
            <td><asp:TextBox ID="TextBoxTimKiem" runat="server" Width="171px"></asp:TextBox></td>
            <td class="auto-style12" colspan="5">&nbsp;</td>
        </tr>
        <tr><td class="auto-style12" colspan="10">&nbsp;</td></tr>
        <tr>
            <td>

                 &nbsp;</td>
            <td class="auto-style2" colspan="4">

                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                <asp:Button ID="Buttontimkiem" runat="server" OnClick="Button1_Click" Text="Tìm kiếm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

            </td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style3">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td>

                &nbsp;</td>
            <td class="auto-style2">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style3">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style3">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
        </tr>
        <tr>
            <td>

                &nbsp;</td>
            <td class="auto-style2" colspan="8">

                <asp:GridView ID="GridViewNhaCungCap" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="109px" Width="785px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Tên Nhà Cung Cấp" DataField="TenNCC" />
                        <asp:BoundField HeaderText="Địa Chỉ" DataField="DiaChi" />
                        <asp:BoundField HeaderText="Số Điện Thoại" DataField="Sdt" />
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
            <td class="auto-style2">

                &nbsp;</td>
        </tr>
        <tr>
            <td>

                &nbsp;</td>
            <td class="auto-style2" colspan="8">

                &nbsp;</td>
            <td class="auto-style2">

                &nbsp;</td>
        </tr>
    </table>
        </div>
    </div>
    </form>
</body>
</html>
