<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiemTichLuy.aspx.cs" Inherits="GUI.TheRichForm.DiemTichLuy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 957px;
        }
        .auto-style2 {}
        .auto-style3 {
        }
        .auto-style4 {
            width: 119px;
        }
        .auto-style5 {
            width: 1139px;
        }
        .auto-style6 {
            width: 1118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Điểm Tích Lũy&nbsp;</h1></div>
    <div style="border-style:solid;border-width:1px;border-color:blue"><table>
        <tr>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style4">

                &nbsp;</td>
            <td class="auto-style1">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style4">

                Số điểm</td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBoxSoDiem" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style5">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style4">

                % Giảm</td>
            <td class="auto-style1">

                <asp:TextBox ID="TextBoxGiam" runat="server" Width="172px"></asp:TextBox>

            </td>
            <td class="auto-style5">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                 &nbsp;</td>
            <td class="auto-style3" colspan="2">

                 &nbsp;</td>
            <td class="auto-style5">

                 &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                 &nbsp;</td>
            <td class="auto-style3" colspan="2">

                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa " Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

            </td>
            <td class="auto-style5">

                 &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                 &nbsp;</td>
            <td class="auto-style3" colspan="2">

                 &nbsp;</td>
            <td class="auto-style5">

                 &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style2" colspan="2">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="94px" Width="768px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Số Điểm" />
                        <asp:BoundField HeaderText="Tỉ Lệ Giảm" />
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
            <td class="auto-style5">

                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">

                &nbsp;</td>
            <td class="auto-style2" colspan="2">

                &nbsp;</td>
            <td class="auto-style5">

                &nbsp;</td>
        </tr>
    </table>
        </div>
    </div>
    </form>
</body>
</html>
