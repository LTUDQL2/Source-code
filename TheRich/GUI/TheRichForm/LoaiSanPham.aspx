<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoaiSanPham.aspx.cs" Inherits="TheRich.TheRichForm.LoaiSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 229px;
        }
        .auto-style4 {
            width: 17px;
        }
        .auto-style5 {
            width: 20px;
        }
        .auto-style6 {
            width: 24px;
        }
        .auto-style7 {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Loại Sản Phẩm</h1></div>
    
    </div>
       <div style="border-style:solid;border-width:1px;border-color:blue"><table>        
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            
            
              

            <td class="auto-style5">&nbsp;</td>
            
            
              

            <td class="auto-style7">&nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4"></td>
            <td class="auto-style1"><div align="Left" class="boiden">Tên Loại:</div></td>
            <td class="auto-style6"><div align="left"> 
                <asp:TextBox ID="TextBoxTenLoai" runat="server" Width="172px"></asp:TextBox>
                </div></td>
            
            
              

            <td class="auto-style5">&nbsp;</td>
            
            
              

            <td class="auto-style7">&nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            
            
              

            <td class="auto-style5">&nbsp;</td>
            
            
              

            <td class="auto-style7">&nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            <td class="auto-style1" colspan="2">
                 <asp:Button ID="ButtonThem" runat="server" Text="Thêm" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonThem0" runat="server" Text="Xóa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 <asp:Button ID="ButtonThem1" runat="server" Text="Sửa" Width="114px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 </td>
            
            
              

            <td class="auto-style5">
                 &nbsp;</td>
            
            
              

            <td class="auto-style7">
                 &nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            <td class="auto-style1" colspan="2">&nbsp;</td>
            
            
              

            <td class="auto-style5">&nbsp;</td>
            
            
              

            <td class="auto-style7">&nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            <td class="auto-style1" colspan="2">
                <asp:GridView ID="GridViewLoaiSanPham" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="67px" Width="342px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField HeaderText="Tên Loại" />
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
            
            
              

            <td class="auto-style7">
                &nbsp;</td>
            
            
              

   </tr>
            <tr class="boiden">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            
            
              

                <td class="auto-style5">&nbsp;</td>
            
            
              

                <td class="auto-style7">&nbsp;</td>
            
            
              

   </tr>
           </table></div>

    </form>
</body>
</html>
