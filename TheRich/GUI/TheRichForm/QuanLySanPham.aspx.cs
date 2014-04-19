using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
namespace TheRich.TheRichForm
{
    public partial class QuanLySanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // thuong thi phai su dung dieu kien nay`, con tai s thi b quen r
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            GridViewQuanLySanPham.DataSource = SanPham_BUS.GetSanPham(); //chi moi do du lieu nhung chua co show
            GridViewQuanLySanPham.DataBind(); //Dong nay dung de load du~ lieu len tug dong trong GridView
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

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
    }
}