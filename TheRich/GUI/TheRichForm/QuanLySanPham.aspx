<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="QuanLySanPham.aspx.cs" Inherits="GUI.TheRichForm.QuanLySanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
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
        .auto-style13 {
            width: 35px;
        }
        .auto-style14 {
            width: 176px;
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
            <td class="auto-style14">&nbsp;</td>

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
            <td class="auto-style14"><div align="left"> 
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
            <td class="auto-style14"><div align="left"> 
                <asp:TextBox ID="TextBoxGiaLe" runat="server" Width="172px"></asp:TextBox>
                </div></td>
              
            <td class="auto-style7"><div align="Left" class="boiden">Giá Mua:</td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxGiaMua" runat="server" Width="172px"></asp:TextBox>
            </td>
   </tr>
         <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style7"><div align="Left" class="boiden">Đơn Vị Tính: </div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxDonViTinh" runat="server" Width="172px"></asp:TextBox>
                </div></td>
             <td class="auto-style5"><div align="Left" class="boiden">Tỉ Lệ Giảm:</div></td>
            <td class="auto-style14"><div align="left"> 
                <asp:TextBox ID="TextBoxTiLeGiam" runat="server" Width="172px"></asp:TextBox>
                </div></td>
             <td class="auto-style5"><div align="Left" class="boiden">Loại Sản Phẩm:</div></td>
            <td class="auto-style3"><div align="left"> 
                <asp:DropDownList ID="DropDownListLSP" runat="server" Height="16px" Width="172px" AutoPostBack="True">
                </asp:DropDownList>
                </div></td>
   </tr>
         <tr class="boiden">
            <td class="auto-style8">&nbsp;</td>
            
   </tr>  
         <tr>
             <td class="auto-style8" >
                 &nbsp;</td>
             <td class="auto-style4" colspan="4" >
                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonXoa" runat="server" Text="Xóa" Width="121px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="Button3" runat="server" Text="Sửa" Width="113px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" OnClick="Button3_Click" />
                 <asp:Button ID="ButtonTimKiem" runat="server" OnClick="ButtonTimKiem_Click" Text="Tìm kiếm"  Width="113px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White"  />
             </td>
             <td class="auto-style14">&nbsp;</td>
             <td class="auto-style10"></td>
             <td class="auto-style9"></td>

             <td class="auto-style13">&nbsp;</td>

         </tr>
         <tr>
             <td class="auto-style8" >&nbsp;</td>
             <td class="auto-style7" ></td>
             <td class="auto-style6"></td>
             <td></td>
             <td class="auto-style14"></td>
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
								<asp:GridView ID="GridViewQuanLySanPham" runat="server" AutoGenerateColumns="False" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="156px" Width="985px" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" OnPageIndexChanging="GridViewQuanLySanPham_PageIndexChanging" PageSize="2" OnRowDeleted="GridViewQuanLySanPham_RowDeleted" OnRowDeleting="GridViewQuanLySanPham_RowDeleting" OnRowUpdating="GridViewQuanLySanPham_RowUpdating">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:BoundField HeaderText="Mã Sản Phẩm" DataField="MaSP" />
                                        <asp:BoundField HeaderText="Tên Sản Phẩm" DataField="TenSP" />
                                        <asp:BoundField HeaderText="Đơn Vị Tính" DataField="DonViTinh" />
                                        <asp:BoundField HeaderText="Số Lượng Tồn" DataField="SLTon" />
                                        <asp:BoundField HeaderText="Giá Mua" DataField="GiaNhap" />
                                        <asp:BoundField HeaderText="Giá Sỉ" DataField="GiaSi" />
                                        <asp:BoundField HeaderText="Giá Lẻ" DataField="GiaLe" />
                                        <asp:BoundField HeaderText="Tỉ Lệ Giảm" DataField="TiLeGiam" />
                                        <asp:BoundField HeaderText="Loại Sản Phẩm" DataField="id_LSP" />
                                        <asp:BoundField HeaderText="Nhà Cung Cấp" DataField="id_NCC" />
                                        <asp:CheckBoxField HeaderText="Chọn" />
                                    </Columns>
                                    <EmptyDataTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "MaSP") %>' CommandName="Update">Sua</asp:LinkButton>
                                        <asp:LinkButton ID="LinkButton2" runat="server"
                                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "MaSP") %>' CommandName="Delete">Xoa</asp:LinkButton>
                                    </EmptyDataTemplate>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" Position="TopAndBottom" PreviousPageText="Pre" />
                                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>

                                <br />
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>

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