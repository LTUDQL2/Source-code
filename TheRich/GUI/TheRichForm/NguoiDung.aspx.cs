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
    public partial class NguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            GridViewNguoiDung.DataSource = NguoiDung_BUS.SelectAllData("NguoiDung");
            GridViewNguoiDung.DataBind();
        }

        protected void ButtonThemNguoiDung_Click(object sender, EventArgs e)
        {
         
        }

        protected void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=kvhgiang-PC;Initial Catalog=TheRich;Integrated Security=True");
            sqlConn.Open();
            string commandText = "TimKiem1";
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConn);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@HoTen", TextBoxTimkiem.Text);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewNguoiDung.DataSource = dt;
            GridViewNguoiDung.DataBind();
        }
    }
}