<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NguoiDung.aspx.cs" Inherits="TheRich.TheRichForm.NguoiDung" %>

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
        .auto-style9 {
            width: 5px;
        }
        .auto-style10 {
            width: 5px;
            height: 23px;
        }
        .auto-style13 {
            width: 179px;
        }
        .auto-style14 {
            width: 179px;
            height: 23px;
        }
        .auto-style15 {
            width: 206px;
        }
        .auto-style16 {
            width: 206px;
            height: 23px;
        }
        .auto-style17 {
            width: 183px;
            height: 25px;
        }
        .auto-style18 {
            width: 221px;
            height: 25px;
        }
        .auto-style19 {
            width: 5px;
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
        .auto-style24 {
            width: 263px;
        }
        .auto-style25 {
            width: 602px;
        }
        .auto-style28 {
        }
        .auto-style29 {
            width: 478px;
        }
        .auto-style30 {
            width: 246px;
        }
        .auto-style31 {
            height: 23px;
        }
        .auto-style32 {
            height: 30px;
        }
        .auto-style33 {
            width: 206px;
            height: 30px;
        }
        .auto-style34 {
            width: 27px;
            height: 25px;
        }
        .auto-style35 {
            width: 27px;
        }
        .auto-style36 {
            width: 27px;
            height: 23px;
        }
        .auto-style37 {
            height: 30px;
            width: 27px;
        }
        .auto-style38 {
            width: 26px;
            height: 25px;
        }
        .auto-style39 {
            width: 26px;
        }
        .auto-style40 {
            width: 26px;
            height: 23px;
        }
        .auto-style41 {
            height: 30px;
            width: 26px;
        }
        .auto-style42 {
            width: 70px;
        }
    </style>
</head>
<body> 
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Người Dùng Website</h1></div>
    <div style="border-style:solid;border-width:1px;border-color:blue"><table>
        <tr>
            <td class="auto-style34">

                &nbsp;</td>
            <td class="auto-style17">

                &nbsp;</td>
            <td class="auto-style18">

                &nbsp;</td>
            <td class="auto-style19">

                &nbsp;</td>
            <td class="auto-style20">

                &nbsp;</td>
            <td class="auto-style21">

                &nbsp;</td>
            <td class="auto-style38">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style34">

                &nbsp;</td>
            <td class="auto-style17">

                Họ Tên:

            </td>
            <td class="auto-style18">

                <asp:TextBox ID="TextBoxHoTen" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style19">

            </td>
            <td class="auto-style20">

                Tên Cửa Hàng:</td>
            <td class="auto-style21">

                <asp:TextBox ID="TextBoxTenCuaHang" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style38">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5">

                Email:</td>
            <td class="auto-style7">

                <asp:TextBox ID="TextBoxEmail" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style9">

                &nbsp;</td>
            <td class="auto-style13">

                Tên Đăng Nhập:</td>
            <td class="auto-style15">

                <asp:TextBox ID="TextBoxTenTenDangNhap" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style36">

                &nbsp;</td>
            <td class="auto-style6">

                Số Điện Thoại:</td>
            <td class="auto-style8">

                <asp:TextBox ID="TextBoxSoDienThoai" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style10">

            </td>
            <td class="auto-style14">

                Mật Khẩu Cấp 1:</td>
            <td class="auto-style16">

                <asp:TextBox ID="TextBoxTenMatKhauCap1" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style40">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5">

                Chứng Minh Nhân Dân:</td>
            <td class="auto-style7">

                <asp:TextBox ID="TextBoxChungMinhNhanDan" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style9">

                &nbsp;</td>
            <td class="auto-style13">

                Mật Khẩu Cấp 2:</td>
            <td class="auto-style15">

                <asp:TextBox ID="TextBoxMatKhauCap2" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5">

                Số Tài Khoản:</td>
            <td class="auto-style7">

                <asp:TextBox ID="TextBoxSoTaiKhoan" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style9">

                &nbsp;</td>
            <td class="auto-style13">

                &nbsp;</td>
            <td class="auto-style15">

                &nbsp;</td>
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
            <td class="auto-style7">

                &nbsp;</td>
            <td class="auto-style9">

                &nbsp;</td>
            <td class="auto-style13">

                &nbsp;</td>
            <td class="auto-style15">

                &nbsp;</td>
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style37">

                 &nbsp;</td>
            <td class="auto-style32" colspan="4">

                 <asp:Button ID="ButtonThemNguoiDung" runat="server" Text="Thêm Người Dùng" Width="133px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" OnClick="ButtonThemNguoiDung_Click" />
                 <asp:Button ID="ButtonXoaNguoiDung" runat="server" Text="Xóa Người Dùng" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonSuaNguoiDung" runat="server" Text="Sửa Người Dùng" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
             </td>
            <td class="auto-style33">

                </td>
            <td class="auto-style41">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style36">

                &nbsp;</td>
            <td class="auto-style31">

                </td>
            <td class="auto-style8">

                </td>
            <td class="auto-style10">

                </td>
            <td class="auto-style14">

                </td>
            <td class="auto-style16">

                </td>
            <td class="auto-style40">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style36">

                &nbsp;</td>
            <td class="auto-style31" colspan="2">

                *Quản Lý Tài Khoản Nhân Viên*</td>
            <td class="auto-style10">

                </td>
            <td class="auto-style14">

                </td>
            <td class="auto-style16">

                </td>
            <td class="auto-style40">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style5" colspan="5">
                <div style="border-style:solid;border-width:1px;border-color:blue"> <table><tr><td class="auto-style42">&nbsp;</td><td class="auto-style29">&nbsp;</td><td class="auto-style30">

                    &nbsp;</td><td class="auto-style25">&nbsp;</td><td class="auto-style24">

                    &nbsp;</td></tr><tr><td class="auto-style42">&nbsp;</td><td class="auto-style29">Họ Tên Nhân Viên:</td><td class="auto-style30">

                <asp:TextBox ID="TextBoxHoTenNhanVien" runat="server" Width="172px"></asp:TextBox>

                    </td><td class="auto-style25">Chứng minh nhân dân:</td><td class="auto-style24">

                <asp:TextBox ID="TextBoxChungMinhNhanDanNhanVien" runat="server" Width="172px"></asp:TextBox>

                    </td></tr><tr><td class="auto-style42">&nbsp;</td><td class="auto-style29">Email NhanVien:</td><td class="auto-style30">

                <asp:TextBox ID="TextBoxEmailNhanVien" runat="server" Width="172px"></asp:TextBox>

                        </td><td class="auto-style25">Tên Đăng Nhập Nhân Viên:</td><td class="auto-style24">

                <asp:TextBox ID="TextBoxTenDangNhapNhanVien" runat="server" Width="172px"></asp:TextBox>

                        </td></tr><tr><td class="auto-style42">&nbsp;</td><td class="auto-style29">Số Điện Thoại Nhân Viên:</td><td class="auto-style30">

                <asp:TextBox ID="TextBoxSoDienThoaiNhanVien" runat="server" Width="172px"></asp:TextBox>

                        </td><td class="auto-style25">Mật Khẩu Nhân Viên:</td><td class="auto-style24">

                <asp:TextBox ID="TextBoxMatKhauNhanVien" runat="server" Width="172px"></asp:TextBox>

                        </td></tr><tr><td class="auto-style42">&nbsp;</td><td class="auto-style29">&nbsp;</td><td class="auto-style30">&nbsp;</td><td class="auto-style25">&nbsp;</td><td class="auto-style24">&nbsp;</td></tr><tr><td class="auto-style42">

                    &nbsp;</td><td class="auto-style28" colspan="4">

                 <asp:Button ID="ButtonDangKyNhanVien" runat="server" Text="Đăng Ký Nhân Viên" Width="129px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoaNhanVien" runat="server" Text="Xóa Nhân Viên" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonSuaNhanVien" runat="server" Text="Sửa Nhân Viên" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                    </td></tr><tr><td class="auto-style42">

                        &nbsp;</td><td class="auto-style28" colspan="4">

                            &nbsp;</td></tr></table></div>
                &nbsp;</td>
            <td class="auto-style39">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5" colspan="5">

                <asp:GridView ID="GridViewNguoiDung" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Họ Tên" />
                        <asp:BoundField HeaderText="Email" />
                        <asp:BoundField HeaderText="Số Điện Thoại" />
                        <asp:BoundField HeaderText="Chứng Minh Nhân Dân" />
                        <asp:BoundField HeaderText="Số Tài Khoản" />
                        <asp:BoundField HeaderText="Tên Cửa Hàng" />
                        <asp:BoundField HeaderText="Tên Đăng Nhập" />
                        <asp:BoundField HeaderText="Mật Khẩu Cấp 1" />
                        <asp:BoundField HeaderText="Mật Khẩu Cấp 2" />
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
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
            <td class="auto-style7">

                &nbsp;</td>
            <td class="auto-style9">

                &nbsp;</td>
            <td class="auto-style13">

                &nbsp;</td>
            <td class="auto-style15">

                &nbsp;</td>
            <td class="auto-style39">

                &nbsp;</td>
        </tr>
    </table></div>
    </div>
    </form>
</body>
</html>
