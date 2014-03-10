using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Project.DTO;
using DAO;

namespace Project.DAO
{
    public class SanPham_DAO
    {
        public static DataTable gettable()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable2()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_select2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable3(int a)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_select3";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@Id_CH", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = a;
            cmd.Parameters.Add(para);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable gettable4(int a)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_select4";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@Id_SP", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = a;
            cmd.Parameters.Add(para);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<SanPham_DTO> getlist()
        {
            List<SanPham_DTO> ls = new List<SanPham_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                SanPham_DTO da = new SanPham_DTO();
                da.Id_SP = Convert.ToInt32(cusor["Id_SP"]);
                da.MaSP = cusor["MaSP"].ToString();
                da.TenSP = cusor["TenSP"].ToString();
                da.SLTon = Convert.ToInt32(cusor["SLTon"]);
                da.GiaSi = Convert.ToInt32(cusor["GiaSi"]);
                da.GiaLe = Convert.ToInt32(cusor["GiaLe"]);
                da.NgayNhap = Convert.ToDateTime(cusor["NgayNhap"]);
                if (cusor["Id_NSX"] is DBNull)
                {
                    da.Id_NSX = 0;
                }
                else
                    da.Id_NSX = Convert.ToInt32(cusor["Id_NSX"]);
                da.Id_NH = Convert.ToInt32(cusor["Id_NH"]);
                da.Id_DVT = Convert.ToInt32(cusor["Id_DVT"]);
                da.Id_CH = Convert.ToInt32(cusor["Id_CH"]);
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }

        public static void ThemSP(SanPham_DTO sp)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@MaSP", SqlDbType.VarChar, 50);
            para.Direction = ParameterDirection.Input;
            para.Value = sp.MaSP;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = sp.TenSP;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@SLTon", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = sp.SLTon;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@GiaSi", SqlDbType.Int);
            para4.Direction = ParameterDirection.Input;
            para4.Value = sp.GiaSi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@GiaLe", SqlDbType.Int);
            para5.Direction = ParameterDirection.Input;
            para5.Value = sp.GiaLe;
            cmd.Parameters.Add(para5);

            SqlParameter para6 = new SqlParameter("@NgayNhap", SqlDbType.DateTime);
            para6.Direction = ParameterDirection.Input;
            para6.Value = sp.NgayNhap;
            cmd.Parameters.Add(para6);

            SqlParameter para7 = new SqlParameter("@Id_NSX", SqlDbType.Int);
            para7.Direction = ParameterDirection.Input;
            para7.Value = sp.Id_NSX;
            cmd.Parameters.Add(para7);

            SqlParameter para8 = new SqlParameter("@Id_NH", SqlDbType.Int);
            para8.Direction = ParameterDirection.Input;
            para8.Value = sp.Id_NH;
            cmd.Parameters.Add(para8);

            SqlParameter para9 = new SqlParameter("@Id_DVT", SqlDbType.Int);
            para9.Direction = ParameterDirection.Input;
            para9.Value = sp.Id_DVT;
            cmd.Parameters.Add(para9);

            SqlParameter para10 = new SqlParameter("@Id_CH", SqlDbType.Int);
            para10.Direction = ParameterDirection.Input;
            para10.Value = sp.Id_CH;
            cmd.Parameters.Add(para10);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void capnhatSP(SanPham_DTO sp)
    {
        SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SanPham_update ";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;

        SqlParameter para = new SqlParameter("@MaSP", SqlDbType.VarChar, 50);
        para.Direction = ParameterDirection.Input;
        para.Value = sp.MaSP;
        cmd.Parameters.Add(para);

        SqlParameter para2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 30);
        para2.Direction = ParameterDirection.Input;
        para2.Value = sp.TenSP;
        cmd.Parameters.Add(para2);

        SqlParameter para3 = new SqlParameter("@SLTon", SqlDbType.Int);
        para3.Direction = ParameterDirection.Input;
        para3.Value = sp.SLTon;
        cmd.Parameters.Add(para3);

        SqlParameter para4 = new SqlParameter("@GiaSi", SqlDbType.Int);
        para4.Direction = ParameterDirection.Input;
        para4.Value = sp.GiaSi;
        cmd.Parameters.Add(para4);
            
        SqlParameter para5 = new SqlParameter("@GiaLe", SqlDbType.Int);
        para5.Direction = ParameterDirection.Input;
        para5.Value = sp.GiaLe;
        cmd.Parameters.Add(para5);

        SqlParameter para6 = new SqlParameter("@NgayNhap", SqlDbType.DateTime);
        para6.Direction = ParameterDirection.Input;
        para6.Value = sp.NgayNhap;
        cmd.Parameters.Add(para6);

        SqlParameter para7 = new SqlParameter("@Id_NSX", SqlDbType.Int);
        para7.Direction = ParameterDirection.Input;
        para7.Value = sp.Id_NSX;
        cmd.Parameters.Add(para7);

        SqlParameter para8 = new SqlParameter("@Id_NH", SqlDbType.Int);
        para8.Direction = ParameterDirection.Input;
        para8.Value = sp.Id_NH;
        cmd.Parameters.Add(para8);

        SqlParameter para9 = new SqlParameter("@Id_DVT", SqlDbType.Int);
        para9.Direction = ParameterDirection.Input;
        para9.Value = sp.Id_DVT;
        cmd.Parameters.Add(para9);

        SqlParameter para10 = new SqlParameter("@Id_CH", SqlDbType.Int);
        para10.Direction = ParameterDirection.Input;
        para10.Value = sp.Id_CH;
        cmd.Parameters.Add(para10);

        SqlParameter para11 = new SqlParameter("@Id_SP", SqlDbType.Int);
        para11.Direction = ParameterDirection.Input;
        para11.Value = sp.Id_CH;
        cmd.Parameters.Add(para11);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

        public static void capnhatsoluongsanpham(int ID_SP, int Soluong)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_update2 ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@ID_SP", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = ID_SP;
            cmd.Parameters.Add(para);

            SqlParameter para3 = new SqlParameter("@SoLuongthemvao", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = Soluong;
            cmd.Parameters.Add(para3);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void capnhatsoxoaluongsanpham(int ID_SP, int Soluong)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_update3 ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@ID_SP", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = ID_SP;
            cmd.Parameters.Add(para);

            SqlParameter para3 = new SqlParameter("@SoLuonglayra", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = Soluong;
            cmd.Parameters.Add(para3);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void xoaSP(int sp)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SanPham_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@ID_SP", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = sp;

            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void chuyencuahang(SanPham_DTO sp, int khochuyen, int soluongchuyen)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "chuyenhang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlParameter para = new SqlParameter("@MaSP", SqlDbType.VarChar, 50);
            para.Direction = ParameterDirection.Input;
            para.Value = sp.MaSP;
            cmd.Parameters.Add(para);

            SqlParameter para2 = new SqlParameter("@TenSP", SqlDbType.NVarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = sp.TenSP;
            cmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("@SLTon", SqlDbType.Int);
            para3.Direction = ParameterDirection.Input;
            para3.Value = sp.SLTon;
            cmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("@GiaSi", SqlDbType.Int);
            para4.Direction = ParameterDirection.Input;
            para4.Value = sp.GiaSi;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("@GiaLe", SqlDbType.Int);
            para5.Direction = ParameterDirection.Input;
            para5.Value = sp.GiaLe;
            cmd.Parameters.Add(para5);

            SqlParameter para6 = new SqlParameter("@NgayNhap", SqlDbType.DateTime);
            para6.Direction = ParameterDirection.Input;
            para6.Value = sp.NgayNhap;
            cmd.Parameters.Add(para6);

            SqlParameter para7 = new SqlParameter("@Id_NSX", SqlDbType.Int);
            para7.Direction = ParameterDirection.Input;
            para7.Value = sp.Id_NSX;
            cmd.Parameters.Add(para7);

            SqlParameter para8 = new SqlParameter("@Id_NH", SqlDbType.Int);
            para8.Direction = ParameterDirection.Input;
            para8.Value = sp.Id_NH;
            cmd.Parameters.Add(para8);

            SqlParameter para9 = new SqlParameter("@Id_DVT", SqlDbType.Int);
            para9.Direction = ParameterDirection.Input;
            para9.Value = sp.Id_DVT;
            cmd.Parameters.Add(para9);

            SqlParameter para10 = new SqlParameter("@Id_CH", SqlDbType.Int);
            para10.Direction = ParameterDirection.Input;
            para10.Value = sp.Id_CH;
            cmd.Parameters.Add(para10);

            SqlParameter para12 = new SqlParameter("@SLTon2", SqlDbType.Int);
            para12.Direction = ParameterDirection.Input;
            para12.Value = soluongchuyen;
            cmd.Parameters.Add(para12);
            SqlParameter para11 = new SqlParameter("@Id_CH2", SqlDbType.Int);
            para11.Direction = ParameterDirection.Input;
            para11.Value = khochuyen;
            cmd.Parameters.Add(para11);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable GetListSP()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }

        public SanPham_DTO SetSP(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_SetSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            SanPham_DTO sp = new SanPham_DTO();
            while (rd.Read())
            {
                sp.Id_SP = Convert.ToInt32(rd[0].ToString());
                if (rd.IsDBNull(1))
                    sp.MaSP = "";
                else
                    sp.MaSP = rd[1].ToString();
                if (rd.IsDBNull(2))
                    sp.TenSP = "";
                else
                    sp.TenSP = rd[2].ToString();
                if (rd.IsDBNull(3))
                    sp.GiaLe = 0;
                else
                    sp.GiaLe = Convert.ToInt32(rd[3].ToString());
                if (rd.IsDBNull(4))
                    sp.GiaSi = 0;
                else
                    sp.GiaSi = Convert.ToInt32(rd[4].ToString());
                if (rd.IsDBNull(5))
                    sp.SLTon = 0;
                else
                    sp.SLTon = Convert.ToInt32(rd[5].ToString());
                if (rd.IsDBNull(6))
                    sp.Id_CH = 0;
                else
                    sp.Id_CH = Convert.ToInt32(rd[6].ToString());
                if (rd.IsDBNull(7))
                    sp.Id_DVT = 0;
                else
                    sp.Id_DVT = Convert.ToInt32(rd[7].ToString());
                if (rd.IsDBNull(8))
                    sp.Id_NSX = 0;
                else
                    sp.Id_NSX = Convert.ToInt32(rd[8].ToString());
                if (rd.IsDBNull(9))
                    sp.Id_NH = 0;
                else
                    sp.Id_NH = Convert.ToInt32(rd[9].ToString());
                if (rd.IsDBNull(10))
                    sp.NgayNhap = DateTime.Now;
                else sp.NgayNhap = DateTime.Parse(rd[10].ToString());
            }
            cn.Close();
            return sp;
        }
        public void Insert(SanPham_DTO sp)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_InsertSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ma", sp.MaSP);
            cmd.Parameters.AddWithValue("ten", sp.TenSP);
            cmd.Parameters.AddWithValue("giaLe", sp.GiaLe);
            cmd.Parameters.AddWithValue("GiaSi", sp.GiaSi);
            cmd.Parameters.AddWithValue("slton", sp.SLTon);
            cmd.Parameters.AddWithValue("id_ch", sp.Id_CH);
            cmd.Parameters.AddWithValue("id_dvt", sp.Id_DVT);
            cmd.Parameters.AddWithValue("id_nsx", sp.Id_NSX);
            cmd.Parameters.AddWithValue("id_nh", sp.Id_NH);
            cmd.Parameters.AddWithValue("ngayNhap", sp.NgayNhap);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(SanPham_DTO sp)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_UpdateSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", sp.Id_SP);
            cmd.Parameters.AddWithValue("ma", sp.MaSP);
            cmd.Parameters.AddWithValue("ten", sp.TenSP);
            cmd.Parameters.AddWithValue("giaLe", sp.GiaLe);
            cmd.Parameters.AddWithValue("GiaSi", sp.GiaSi);
            cmd.Parameters.AddWithValue("slton", sp.SLTon);
            cmd.Parameters.AddWithValue("id_ch", sp.Id_CH);
            cmd.Parameters.AddWithValue("id_dvt", sp.Id_DVT);
            cmd.Parameters.AddWithValue("id_nsx", sp.Id_NSX);
            cmd.Parameters.AddWithValue("id_nh", sp.Id_NH);
            cmd.Parameters.AddWithValue("ngayNhap", sp.NgayNhap);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_DeleteSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable GetListSP_CH(int id)
        {
            DataTable dt = new DataTable();
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListSP_CH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }

    }
}
