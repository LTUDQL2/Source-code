using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace TheRich.TheRichForm
{
    public partial class QuanLySanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                ShowData();
                LoadNCC();
                LoadLoaiSP();
            }
        }

        private void ShowData()
        {
            GridViewQuanLySanPham.DataSource = SanPham_BUS.GetTable(); //chi moi do du lieu nhung chua co show
            GridViewQuanLySanPham.DataBind(); //Dong nay dung de load du~ lieu len tug dong trong GridView

        }
        private void LoadNCC()
        {
            DataTable ncc = NhaCungCap_BUS.SelectAllData();
            DropDownListNCC.DataSource = ncc;
            DropDownListNCC.DataValueField = "id_NCC";
            DropDownListNCC.DataTextField = "TenNCC";
            DropDownListNCC.DataBind();
        }
        private void LoadLoaiSP()
        {
            DataTable lsp = LoaiSP_BUS.SelectAllData();
            DropDownListLSP.DataSource = lsp;
            DropDownListLSP.DataValueField = "id_LSP";
            DropDownListLSP.DataTextField = "TenLoai";
            DropDownListLSP.DataBind();
        }
        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SanPham n = new SanPham();
            n.MaSP = TextBoxMaSanPham.Text;
            n.TenSP = TextBoxTenSanPham.Text;
            n.DonViTinh = TextBoxDonViTinh.Text;
            n.GiaNhap = Convert.ToInt32(TextBoxGiaMua.Text);
            n.GiaSi = Convert.ToInt32(TextBoxGiaSi.Text);
            n.GiaLe = Convert.ToInt32(TextBoxGiaLe.Text);
            n.TiLeGiam = Convert.ToSingle(TextBoxTiLeGiam.Text);


            n.Id_NCC = Convert.ToInt32(DropDownListNCC.SelectedItem.Value);
            n.Id_LSP = Convert.ToInt32(DropDownListLSP.SelectedItem.Value);
            SanPham_BUS.CapNhat(n);
        }

        protected void DropDownListNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridViewQuanLySanPham_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewQuanLySanPham.PageIndex = e.NewPageIndex;
            ShowData();
        }

        protected void GridViewQuanLySanPham_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
          
        }

        protected void GridViewQuanLySanPham_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridViewQuanLySanPham_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        protected void ButtonThem_Click(object sender, EventArgs e)
        {
                SanPham n = new SanPham();
                n.MaSP = TextBoxMaSanPham.Text;
                n.TenSP = TextBoxTenSanPham.Text;
                n.DonViTinh = TextBoxDonViTinh.Text;
                n.GiaNhap = Convert.ToInt32(TextBoxGiaMua.Text);
                n.GiaSi = Convert.ToInt32(TextBoxGiaSi.Text);
                n.GiaLe = Convert.ToInt32(TextBoxGiaLe.Text);
                n.TiLeGiam = Convert.ToSingle(TextBoxTiLeGiam.Text);
                n.Id_NCC = Convert.ToInt32(DropDownListNCC.SelectedItem.Value);
                n.Id_LSP = Convert.ToInt32(DropDownListLSP.SelectedItem.Value);
                SanPham_BUS.Them(n);
        }

        protected void ButtonXoa_Click(object sender, EventArgs e)
        {
            String MaSP = GridViewQuanLySanPham.SelectedRow.Cells.ToString();

            SanPham_BUS.Xoa(MaSP);
        }

      
    }
}