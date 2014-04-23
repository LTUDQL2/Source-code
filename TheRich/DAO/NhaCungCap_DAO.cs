using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
//public static void Xoa(String MaKH)
        //{
        //    SqlConnection cn;
        //    cn = DataProvider.ConnectionData();
        //    string strSQL;
        //    strSQL = "Delete from KhachHang where MaNV=@MaNVL ";
        //    SqlCommand cmd = new SqlCommand(strSQL, cn);
        //    cmd.Parameters.AddWithValue("@MaNVL", MaKH);
        //    cmd.ExecuteNonQuery();
        //    cn.Close();
        //}


namespace DAO
{
    public class NhaCungCap_DAO
    {
        public static DataTable SelectAllData(string NhaCungCap)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            DataTable dt = dataProvider.SelectAllData(NhaCungCap);
            return dt;
        }

        public static void Them(NhaCungCap n)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Insert into NhaCungCap(TenNCC,DiaChi,Sdt) values (@TenNCC,@DiaChi,@Sdt)";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            //cmd.Parameters.AddWithValue("@id_NCC", n.Id_NDD);
            cmd.Parameters.AddWithValue("@TenNCC", n.TenNCC);
            cmd.Parameters.AddWithValue("@DiaChi", n.DiaChi);
            cmd.Parameters.AddWithValue("@Sdt", n.SDT);
            //cmd.Parameters.AddWithValue("@id_ND", n.Id_ND);
           
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static List<NhaCungCap> GetList()
        {
            List<NhaCungCap> ds = new List<NhaCungCap>();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From NhaCungCap";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhaCungCap l = new NhaCungCap();
                l.Id_NDD = (int)dr["id_NCC"];
                l.TenNCC = (string)dr["TenNCC"];
                l.DiaChi = (string)dr["DiaChi"];
                l.SDT = (string)dr["Sdt"];
                l.Id_ND = (int)dr["id_ND"];
               



                ds.Add(l);
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
            //strSQL = "Select MaSV,TenSV,NgaySinh,lq.TenLopQL From NhanVien n,LopQL lq where n.MaLopQL like lq.MaLopQL ";
            strSQL = "select * from NhaCungCap";

            SqlDataAdapter da;
            da = new SqlDataAdapter(strSQL, cn);
            da.Fill(dt);
            cn.Close();
            return dt;

        }
        public static void Xoa(int MaKH)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete from NhaCungCap where id_NCC=@id_NCC ";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@id_NCC", MaKH);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CapNhat(NhaCungCap n)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update NhaCungCap set TenNCC=@TenNCC,DiaChi=@DiaChi,Sdt=@Sdt where id_NCC=@id_NCC";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@TenNV", n.TenNCC);
            cmd.Parameters.AddWithValue("@MaLoai", n.DiaChi);
            cmd.Parameters.AddWithValue("@CMND", n.SDT);
           
           
           
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
