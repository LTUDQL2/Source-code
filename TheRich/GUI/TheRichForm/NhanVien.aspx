<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanVien.aspx.cs" Inherits="GUI.TheRichForm.NhanVien" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <style type="text/css">

        .auto-style29 {
            width: 478px;
        }
        .auto-style30 {
            width: 452px;
        }
        .auto-style32 {
            width: 248px;
        }
        .auto-style33 {
            width: 506px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Nhân Viên</h1></div>
    <div>
    
        <table>
            <tr>
                <td class="auto-style33">Họ tên nhân Viên:</td>
                <td class="auto-style32"><asp:TextBox ID="txtHoTen_NV" runat="server" Width="172px"></asp:TextBox></td>
                <td class="auto-style29">Chứng minh nhân dân:</td>
                <td><asp:TextBox ID="txtCMND_NV" runat="server" Width="172px"></asp:TextBox></td>
            </tr>

            <tr>
                <td class="auto-style33">Email:</td>
                <td class="auto-style32"><asp:TextBox ID="txtEmail_NV" runat="server" Width="172px"></asp:TextBox></td>
                <td class="auto-style29">Mã nhân viên:</td>
                <td><asp:TextBox ID="TextBox1" runat="server" Width="172px"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td class="auto-style33">Số Điện Thoại:</td>
                <td class="auto-style32"><asp:TextBox ID="TextBoxHoTenNhanVien1" runat="server" Width="172px"></asp:TextBox></td>
            </tr>
                        
            <tr>
                <td class="auto-style30" colspan="5">
                    <asp:Button ID="ThemNV" runat="server" Text="Thêm" Width="59px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                    <asp:Button ID="XoaNV" runat="server" Text="Xóa" Width="59px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                    <asp:Button ID="SuaNV" runat="server" Text="Sửa thông tin" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                    <br />

                <asp:GridView ID="GridViewNguoiDung" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="860px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="MaNV" DataField="Uname" />
                        <asp:BoundField HeaderText="Họ Tên" DataField="HoTen" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Số Điện Thoại" DataField="Sdt" />
                        <asp:BoundField HeaderText="CMND" DataField="CMND" />
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
        </table>
    
    </div>
    </form>
</body>
</html>
