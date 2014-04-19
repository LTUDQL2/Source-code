<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLySanPham.aspx.cs" Inherits="TheRich.TheRichForm.QuanLySanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 219px;
        }
        .auto-style4 {
        }
        .auto-style5 {
            width: 363px;
        }
        .auto-style6 {
            width: 209px;
        }
        .auto-style7 {
            width: 267px;
        }
        .auto-style8 {
            width: 301px;
        }
        .auto-style9 {
            width: 56px;
        }
        .auto-style10 {
            width: 235px;
        }
        .auto-style11 {
            width: 301px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style13 {
            width: 35px;
        }
        .auto-style14 {
            height: 23px;
            width: 35px;
        }
        </style>
</head>
<body>
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Sản Phẩm</h1></div>
    <form id="form1" runat="server">
     <div style="border-style:solid;border-width:1px;border-color:blue"><table border="0" style="width: 961px">
          <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            
              <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

              <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>

              

            <td class="auto-style13">
                &nbsp;</td>

              

   </tr>

          <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><div align="Left" class="boiden">Mã Sản Phẩm:</div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxMaSanPham" runat="server" Width="172px"></asp:TextBox>
                </div></td>
            
              <td class="auto-style5"><div align="Left" class="boiden">Giá Sỉ:</div></td>
            <td class="auto-style3"><div align="left"> 
                <asp:TextBox ID="TextBoxGiaSi" runat="server" Width="172px"></asp:TextBox>
                </div></td>

              <td class="auto-style10"><div align="Left" class="boiden">Nhà Cung Cấp:</div></td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownListNCC" runat="server" Height="16px" Width="172px" OnSelectedIndexChanged="DropDownListNCC_SelectedIndexChanged">
                </asp:DropDownList>
              </td>

              

            <td class="auto-style13">
                &nbsp;</td>

              

   </tr>

		  <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><div align="Left" class="boiden">Tên Sản Phẩm: </div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxTenSanPham" runat="server" Width="172px"></asp:TextBox>
                </div></td>
              <td class="auto-style5"><div align="Left" class="boiden">Giá Lẻ:</div></td>
            <td class="auto-style3"><div align="left"> 
                <asp:TextBox ID="TextBoxGiaLe" runat="server" Width="172px"></asp:TextBox>
                </div></td>

               <td class="auto-style10"><div align="Left" class="boiden">Người Dùng:</div></td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownListND" runat="server" Height="16px" Width="172px">
                </asp:DropDownList>
              </td>
            <td class="auto-style13">
                &nbsp;</td>
   </tr>
         <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><div align="Left" class="boiden">Đơn Vị Tính: </div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxDonViTinh" runat="server" Width="172px"></asp:TextBox>
                </div></td>
             <td class="auto-style5"><div align="Left" class="boiden">Tỉ Lệ Giảm:</div></td>
            <td class="auto-style3"><div align="left"> 
                <asp:TextBox ID="TextBoxTiLeGiam" runat="server" Width="172px"></asp:TextBox>
                </div></td>
   </tr>
         <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><div align="Left" class="boiden">Giá Mua: </div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxGiaMua" runat="server" Width="172px"></asp:TextBox>
                </div></td>
             <td class="auto-style5"><div align="Left" class="boiden">Loại Sản Phẩm:</div></td>
            <td class="auto-style3"><div align="left"> 
                <asp:DropDownList ID="DropDownListLSP" runat="server" Height="16px" Width="172px" AutoPostBack="True">
                </asp:DropDownList>
                </div></td>
   </tr>          
         <tr>
             <td class="auto-style8" >&nbsp;</td>
             <td class="auto-style7" ></td>
             <td class="auto-style6"></td>
         </tr>

         <tr>
             <td class="auto-style8" >
                 &nbsp;</td>
             <td class="auto-style4" colspan="3" >
                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="121px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="Button3" runat="server" Text="Sửa" Width="113px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" OnClick="Button3_Click" />
             </td>
             <td></td>
             <td class="auto-style10"></td>
             <td class="auto-style9"></td>

             <td class="auto-style13">&nbsp;</td>

         </tr>
         <tr>
             <td class="auto-style8" >&nbsp;</td>
             <td class="auto-style7" ></td>
             <td class="auto-style6"></td>
             <td></td>
             <td></td>
             <td class="auto-style10">Tìm Kiếm:</td>
             <td class="auto-style9"> 
                <asp:TextBox ID="TextBoxTimKiem" runat="server" Width="172px"></asp:TextBox>
                </td>

             <td class="auto-style13"> 
                 &nbsp;</td>

         </tr>
         <tr>
              <td class="auto-style8">
                  &nbsp;</td>

              <td colspan="6">
								<asp:GridView ID="GridViewQuanLySanPham" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="156px" Width="985px">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:BoundField HeaderText="Mã Sản Phẩm" />
                                        <asp:BoundField HeaderText="Tên Sản Phẩm" />
                                        <asp:BoundField HeaderText="Đơn Vị Tính" />
                                        <asp:BoundField HeaderText="Số Lượng Tồn" />
                                        <asp:BoundField HeaderText="Giá Mua" />
                                        <asp:BoundField HeaderText="Giá Sỉ" />
                                        <asp:BoundField HeaderText="Giá Lẻ" />
                                        <asp:BoundField HeaderText="Tỉ Lệ Giảm" />
                                        <asp:BoundField HeaderText="Loại Sản Phẩm" />
                                        <asp:BoundField HeaderText="Nhà Cung Cấp" />
                                        <asp:BoundField HeaderText="Người Dùng" />
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

              <td class="auto-style13">
                  &nbsp;</td>

         </tr></table></div> 
    </form>
               
         <tr>
              <td class="auto-style11">
                  </td>

              <td colspan="6" class="auto-style12">
                  </td>

              <td class="auto-style14">
                  </td>

         </tr>
                  
</body>

</html>
