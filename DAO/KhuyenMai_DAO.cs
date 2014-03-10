using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DAO;
namespace Project.DAO
{
    public class KhuyenMai_DAO
    {
        public static List<KhuyenMai_DTO> getlist()
        {
            List<KhuyenMai_DTO> ls = new List<KhuyenMai_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "KhuyenMai_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                KhuyenMai_DTO da = new KhuyenMai_DTO();
                da.Id_KM = Convert.ToInt32(cusor["Id_KM"]);
                da.SoDiem = Convert.ToString(cusor["SoDiem"]);
                da.TiLeGiam = Convert.ToInt32(cusor["TiLeGiam"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }

    }
}
