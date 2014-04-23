using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using System.Data.SqlClient;
using System.Data;

namespace GUI.TheRichForm
{
    public partial class QuanLySanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int check = 0;
            if (!IsPostBack)
            {
                switch (check) {
                    case 0: ShowData();
                        break;
                    case 1: ShowDataInCate();
                        break;
                    default: break;
                }
                
            }
        }

        private void ShowDataInCate()
        {
            GridViewQuanLySanPham.DataSource = SanPham_BUS.GetSPTheoLoai(1,1); 
            GridViewQuanLySanPham.DataBind();
        }

        private void ShowData()
        {
            GridViewQuanLySanPham.DataSource = SanPham_BUS.GetSanPham();
            GridViewQuanLySanPham.DataBind();
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

        protected void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=kvhgiang-PC;Initial Catalog=TheRich;Integrated Security=True");
            sqlConn.Open();
            string commandText = "TimKiem2";
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@TenSP", TextBoxTimKiem.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewQuanLySanPham.DataSource = dt;
            GridViewQuanLySanPham.DataBind();
        }
    }
}