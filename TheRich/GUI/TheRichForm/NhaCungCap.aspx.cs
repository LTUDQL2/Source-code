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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=kvhgiang-PC;Initial Catalog=TheRich;Integrated Security=True");
            sqlConn.Open();
            string commandText = "TimKiem3";
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@TenNCC", TextBoxTimKiem.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewNhaCungCap.DataSource = dt;
            GridViewNhaCungCap.DataBind();
        }
    }
}