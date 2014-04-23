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
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            GridView1.DataSource = KhachHang_BUS.SelectAllData();
            GridView1.DataBind();
        }

        protected void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=kvhgiang-PC;Initial Catalog=TheRich;Integrated Security=True");
            sqlConn.Open();
            string commandText = "TimKiem";
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@HoTen", TextBoxTimkiem.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}