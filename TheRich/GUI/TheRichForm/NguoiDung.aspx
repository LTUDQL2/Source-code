<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NguoiDung.aspx.cs" Inherits="GUI.TheRichForm.NguoiDung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
        }
        .auto-style6 {
            width: 183px;
            height: 23px;
        }
        .auto-style7 {
            width: 221px;
        }
        .auto-style8 {
            width: 221px;
            height: 23px;
        }
        .auto-style13 {
            width: 179px;
        }
        .auto-style15 {
            width: 206px;
        }
        .auto-style17 {
            width: 183px;
            height: 25px;
        }
        .auto-style18 {
            width: 221px;
            height: 25px;
        }
        .auto-style20 {
            width: 179px;
            height: 25px;
        }
        .auto-style21 {
            width: 206px;
            height: 25px;
        }
        .auto-style32 {
            height: 30px;
        }
        .auto-style34 {
            width: 27px;
            height: 25px;
        }
        .auto-style37 {
            height: 30px;
            width: 27px;
        }
        .auto-style39 {
            width: 26px;
        }
        .auto-style40 {
            width: 26px;
            height: 23px;
        }
        </style>
</head>
<body> 
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Người Dùng Website</h1></div>
    <div style="border-style:solid;border-width:1px;border-color:blue"><table>
        <tr>
            <td class="auto-style34" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">Họ Tên:</td>
            <td class="auto-style18">
                <asp:TextBox ID="TextBoxHoTen" runat="server" Width="172px"></asp:TextBox>
            </td>
            <td class="auto-style20">Tên Cửa Hàng:</td>
            <td class="auto-style21">
                <asp:TextBox ID="TextBoxTenCuaHang" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style5">Email:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxEmail" runat="server" Width="172px"></asp:TextBox>
            </td>
            
            <td class="auto-style5">Địa chỉ:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Số Điện Thoại:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxSoDienThoai" runat="server" Width="172px"></asp:TextBox>
            </td>

            <td class="auto-style13">Tên Đăng Nhập:</td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBoxTenTenDangNhap" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Chứng Minh Nhân Dân:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxChungMinhNhanDan" runat="server" Width="172px"></asp:TextBox>
            </td>
            
            <td class="auto-style5">Vai trò:</td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Chủ cửa hàng</asp:ListItem>
                    <asp:ListItem>Nhân viên</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Số tài khoản:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox2" runat="server" Width="172px"></asp:TextBox>
            </td>
            
            <td class="auto-style5">Quản lý:</td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>            
            <td class="auto-style39" colspan="4">&nbsp;</td>
        </tr>
        <tr>            
            <td align="right" colspan="2">Tên người dùng: </td>
            <td class="auto-style39" colspan="2"><asp:TextBox ID="TextBoxTimkiem" runat="server" Width="160px"></asp:TextBox></td>
        </tr>
        <tr>            
            <td class="auto-style40" colspan="4"></td>
        </tr>
        <tr>
            <td class="auto-style37">

                 &nbsp;</td>
            <td class="auto-style32" colspan="3">

                 <asp:Button ID="ButtonThemNguoiDung" runat="server" Text="Thêm Người Dùng" Width="133px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" OnClick="ButtonThemNguoiDung_Click" />
                 <asp:Button ID="ButtonXoaNguoiDung" runat="server" Text="Xóa Người Dùng" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonSuaNguoiDung" runat="server" Text="Sửa Người Dùng" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                <asp:Button ID="ButtonTimKiem" runat="server" OnClick="ButtonTimKiem_Click" Text="Tìm Kiếm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
             </td>
            </tr>
        <tr>
            <td class="auto-style5" colspan="4">

                <asp:GridView ID="GridViewNguoiDung" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="794px" PageSize="2">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Họ Tên" DataField="HoTen" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Số Điện Thoại" DataField="Sdt" />
                        <asp:BoundField HeaderText="CMND" DataField="CMND" />
                        <asp:BoundField HeaderText="Số Tài Khoản" DataField="SoTaiKhoan" />
                        <asp:BoundField HeaderText="Tên Cửa Hàng" DataField="TenCuaHang" />
                        <asp:BoundField HeaderText="Tên Đăng Nhập" DataField="Uname" />
                        <asp:BoundField DataField="VaiTro" HeaderText="Vai trò" SortExpression="VaiTro" />
                        <asp:BoundField DataField="id_QL" HeaderText="Quản lý" SortExpression="id_QL" />
                        <asp:CheckBoxField HeaderText="Chọn" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" PreviousPageText="Prev" />
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
    </table></div>
    </div>
    </form>
</body>
</html>
