<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="TheRich.TheRichForm.KhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 222px;
        }
        .auto-style2 {}
        .auto-style3 {
            width: 232px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5; width: 948px;">Khách Hàng</h1></div>
            <div style="border-style:solid;border-width:1px;border-color:blue"><table style="width: 923px">
            <tr>
                <td id="Họ Tên" class="auto-style2">

                    &nbsp;</td>
                <td id="Họ Tên" class="auto-style2">

                    Họ Tên</td>
                <td id="Họ Tên" class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style1">

                    <asp:TextBox ID="TextBoxHoTen" runat="server" Width="215px"></asp:TextBox>

                </td>
                <td class="auto-style1">

                    Địa Chỉ</td>
                <td class="auto-style3">

                    <asp:TextBox ID="TextBoxDiaChi" runat="server" Width="214px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2">

                    Ngày Sinh</td>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style1">

                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" Width="219px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>

                </td>
                <td class="auto-style1">

                    Số Điện Thoại</td>
                <td class="auto-style3">

                    <asp:TextBox ID="TextBoxSoDienThoai" runat="server" Width="212px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2">

                    Giới Tính</td>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style1">

                    <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="218px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2" colspan="5">

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2" colspan="5">

                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                </td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2" colspan="5">

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">

                    &nbsp;</td>
                <td class="auto-style2" colspan="5">

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="892px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField HeaderText="Họ Tên" DataField="HoTen" />
                            <asp:BoundField HeaderText="Ngày Sinh" DataField="NgaySinh" />
                            <asp:BoundField HeaderText="Giới Tính" DataField="GioiTinh" />
                            <asp:BoundField HeaderText="Địa Chỉ" DataField="DiaChi" />
                            <asp:BoundField HeaderText="Số Điện Thoai" DataField="Sdt" />
                            <asp:BoundField HeaderText="Điểm Tích Lũy" DataField="DiemTichLuy" />
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
                <td class="auto-style2" colspan="5">

                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </div>
    </form>
</body>
</html>
