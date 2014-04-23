using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class SPKhuyenMai_DAO
    {
        public static List<SPKhuyenMai> GetList()
        {
            List<SPKhuyenMai> ds = new List<SPKhuyenMai>();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From SPKhuyenMai";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SPKhuyenMai h = new SPKhuyenMai();

                h.TenSPKM = (String)dr["Ten"];
                h.SoLuong = (int)dr["SoLuong"];
                h.GiaBan = (int)dr["GiaBan"];
                h.Id_ND = (int)dr["Id_ND"];
                ds.Add(h);
            }
            dr.Close();
            cn.Close();
            return ds;

        }

        public static DataTable GetTable()
        {
            DataTable dt = new DataTable();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select *from SanPham ";

            SqlDataAdapter da;
            da = new SqlDataAdapter(strSQL, cn);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public static void Them(SPKhuyenMai sp)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Insert into SPKhuyenMai(TenSPKM, SoLuong, GiaBan) values (@TenSPKM, @SoLuong, @GiaBan)";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@TenSPKM", sp.TenSPKM);
            cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);

            //cmd.Parameters.AddWithValue("@id_ND", sp.Id_ND);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Xoa(String TenSPKM)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete from SPKhuyenMai where TenSPKM=@TenSPKM";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@TenSPKM", TenSPKM);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CapNhat(SPKhuyenMai sp)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update SanPham set TenSPKM=@TenSPKM, SoLuong = @SoLuong, GiaBan = @GiaBan  where id_SPKM =id_SPKM";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@TenSPKM", sp.TenSPKM);
            cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
