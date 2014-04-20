using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace TheRich.TheRichForm
{
    public partial class NhaCungCap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            GridViewNhaCungCap.DataSource = NhaCungCap_BUS.SelectAllData();
            GridViewNhaCungCap.DataBind();
        }
    }
}