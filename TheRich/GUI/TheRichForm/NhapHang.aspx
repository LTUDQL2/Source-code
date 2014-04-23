<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhapHang.aspx.cs" Inherits="GUI.TheRichForm.NhapHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style3 {
            width: 153px;
        }
        .auto-style4 {
            width: 191px;
        }
        .auto-style7 {
            width: 191px;
            height: 26px;
        }
        .auto-style10 {
            width: 153px;
            height: 26px;
        }
        .auto-style13 {
            width: 20px;
        }
        .auto-style14 {
            width: 20px;
            height: 26px;
        }
        .auto-style15 {
            width: 101px;
        }
        .auto-style16 {
            width: 101px;
            height: 26px;
        }
        .auto-style17 {
            width: 176px;
        }
        .auto-style18 {
            width: 176px;
            height: 26px;
        }
        .auto-style20 {
            width: 223px;
            height: 26px;
        }
        .auto-style21 {
            width: 223px;
        }
        .auto-style22 {
            width: 162px;
            height: 26px;
        }
        .auto-style23 {
            width: 162px;
        }
    </style>
</head>
<body>
        
            <form id="form1" runat="server">
       <div align="center"> <h1 style="color:#fff;background-color:#5b9bd5; width: 948px;">Nhập Hàng</h1></div>
            <div align="left">
                <div style="border-style:solid;border-width:1px;border-color:blue"><table style="width: 874px; margin-right: 0px">
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style4">
                    
                        &nbsp;</td>
                    <td class="auto-style17">
                    
                        &nbsp;</td>
                    <td class="auto-style15">
                    
                        &nbsp;</td>
                    <td class="auto-style21" colspan="4">
                    
                        &nbsp;</td>
                    <td class="auto-style3" colspan="2">
                    
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">
                    
                        &nbsp;</td>
                    <td class="auto-style7">
                    
                        Mã Sản Phẩm:</td>
                    <td class="auto-style18">
                    
                        <asp:TextBox ID="TextBoxMaSanPham" runat="server" Width="172px"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                    
                        &nbsp;</td>
                    <td class="auto-style20">
                    
                        Nhà Cung Cấp:</td>
                    <td class="auto-style20" colspan="2">
                    
                        <asp:DropDownList ID="DropDownListNhaCungCap" runat="server" Width="172px">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style22">
                    
                        &nbsp;</td>
                    <td class="auto-style10" colspan="2">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style4">
                    
                        Số Lượng:</td>
                    <td class="auto-style17">
                    
                        <asp:TextBox ID="TextBoxSoLuong" runat="server" Width="172px"></asp:TextBox>
                    </td>
                    <td class="auto-style15">
                    
                        &nbsp;</td>
                    <td class="auto-style21">
                    
                        Giá Nhập:</td>
                    <td class="auto-style21" colspan="2">
                    
                        <asp:TextBox ID="TextBoxGiaNhap" runat="server" style="margin-left: 0px" Width="172px"></asp:TextBox>
                    </td>
                    <td class="auto-style23">
                    
                        &nbsp;</td>
                    <td class="auto-style3" colspan="2">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style1" colspan="9">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style1" colspan="9">
                    
                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonSua" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonThanhToan" runat="server" Text="Thanh Toán" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />

                 <asp:Button ID="ButtonInHD" runat="server" Text="In HD" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style1" colspan="9">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style1" colspan="9">
                    
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="856px" Height="87px">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField HeaderText="STT" />
                                <asp:BoundField HeaderText="Mã Sản Phẩm" />
                                <asp:BoundField HeaderText="Tên Sản Phẩm" />
                                <asp:BoundField HeaderText="Số Lượng" />
                                <asp:BoundField HeaderText="Đơn Giá" />
                                <asp:BoundField HeaderText="Tỉ Lệ Giảm" />
                                <asp:BoundField HeaderText="Thành Tiền" />
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
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style1" colspan="9">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style4">
                    
                        &nbsp;</td>
                    <td class="auto-style17">
                    
                        &nbsp;</td>
                    <td class="auto-style15">
                    
                        &nbsp;</td>
                    <td class="auto-style21">
                    
                        TỔNG CỘNG:</td>
                    <td class="auto-style21">
                    
                        <asp:TextBox ID="TextBoxTongCong" runat="server" Width="172px"></asp:TextBox></td>
                    <td class="auto-style21">
                    
                        VNĐ</td>
                    <td class="auto-style23">
                    
                        &nbsp;</td>
                    <td>
                    
                        &nbsp;</td>
                    <td rowspan="2">
                    
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    
                        &nbsp;</td>
                    <td class="auto-style4">
                    
                        &nbsp;</td>
                    <td class="auto-style17">
                    
                        &nbsp;</td>
                    <td class="auto-style15">
                    
                        &nbsp;</td>
                    <td class="auto-style21" colspan="4">
                    
                        &nbsp;</td>
                    <td>
                    
                        &nbsp;</td>
                </tr>
                </table>
            </div>
                </div>
            
    
            </form>
            
    
</body>
</html>
