using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace GUI.TheRichForm
{
    public partial class LoaiSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            GridViewLoaiSanPham.DataSource = LoaiSP_BUS.SelectAllData("LoaiSP");
            GridViewLoaiSanPham.DataBind();
        }
    }
}