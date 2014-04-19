<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLyThuChi.aspx.cs" Inherits="TheRich.TheRichForm.QuanLyThuChi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            width: 169px;
        }
        .auto-style3 {
            width: 252px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center"><h1 style="color:#fff;background-color:#5b9bd5">Quản Lý Thu Chi</h1></div>
        </div>

        </div>
       <div style="border-style:solid;border-width:1px;border-color:blue"><table>  
           <tr>
               <td class="auto-style3">
                   &nbsp;</td>
               <td class="auto-style1">
                   &nbsp;</td>
               <td class="auto-style2">&nbsp;</td>
               <td class="auto-style2">&nbsp;</td>
           </tr>      
           <tr>
               <td class="auto-style3">
                   &nbsp;</td>
               <td class="auto-style1">
                 <asp:Button ID="ButtonInThuChi" runat="server" Text="In Thu Chi" Width="172px" BackColor="#5B9BD5" BorderColor="#0066FF" ForeColor="White" />
                 </td>
               <td class="auto-style2">&nbsp;</td>
               <td class="auto-style2">&nbsp;</td>
           </tr>      
           <tr>
               <td class="auto-style3">&nbsp;</td>
               <td class="auto-style1">&nbsp;</td>
               <td class="auto-style2">&nbsp;</td>
               <td class="auto-style2">&nbsp;</td>
           </tr>      
           <tr>
               <td class="auto-style3">
                   &nbsp;</td>
               <td class="auto-style1" colspan="2">
                   <asp:GridView ID="GridViewThuChi" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="123px" Width="788px" style="margin-left: 5px">
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                       <Columns>
                           <asp:BoundField HeaderText="Loại Thu/Chi" />
                           <asp:BoundField HeaderText="Ngày Và Giờ" />
                           <asp:BoundField HeaderText="Nguyên Nhân" />
                           <asp:BoundField HeaderText="Số Tiền" />
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
               <td class="auto-style1">
                   &nbsp;</td>
           </tr>      
           <tr>
               <td class="auto-style3">
                   &nbsp;</td>
               <td class="auto-style1" colspan="2">
                   &nbsp;</td>
               <td class="auto-style1">
                   &nbsp;</td>
           </tr>      
       </table>
      </div>
    </form>
</body>
</html>
