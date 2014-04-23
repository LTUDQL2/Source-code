using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace TheRich.TheRichForm
{
    public partial class SanPhamKhuyenMai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();
            }
        }
        private void ShowData()
        {
            GridViewSanPhamKhuyenMai.DataSource = SPKhuyenMai_BUS.GetTable();
            GridViewSanPhamKhuyenMai.DataBind();

        }

        protected void ButtonThem_Click(object sender, EventArgs e)
        {
            SPKhuyenMai sp = new SPKhuyenMai();
            sp.TenSPKM = TextBoxTenSanPhamKhuyenMai.Text;
            sp.SoLuong = Convert.ToInt32(TextBoxSoLuong.Text);
            sp.GiaBan = Convert.ToInt32(TextBoxGiaBan.Text);
            SPKhuyenMai_BUS.Them(sp);
        }

        protected void ButtonXoa_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonSua_Click(object sender, EventArgs e)
        {
            SPKhuyenMai sp = new SPKhuyenMai();
            sp.TenSPKM = TextBoxTenSanPhamKhuyenMai.Text;
            sp.SoLuong = Convert.ToInt32(TextBoxSoLuong.Text);
            sp.GiaBan = Convert.ToInt32(TextBoxGiaBan.Text);
            SPKhuyenMai_BUS.CapNhat(sp);
        }
    }
}