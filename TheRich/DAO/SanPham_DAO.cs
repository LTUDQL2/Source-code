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
    public class SanPhamDAO
    {
        public static List<SanPham> GetList()
        {
            List<SanPham> ds = new List<SanPham>();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From SanPham";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPham h = new SanPham();
                h.MaSP = (String)dr["MaSP"];
                h.TenSP = (String)dr["TenSp"];
                h.SLTon = (int)dr["SLTon"];
                h.DonViTinh = (String)dr["DonViTinh"];
                h.GiaNhap = (int)dr["GiaNhap"];
                h.GiaSi = (int)dr["GiaSi"];
                h.GiaLe = (int)dr["GiaLe"];
                h.TiLeGiam = (float)dr["TiLeGiam"];
                h.Id_LSP = (int)dr["Id_LSP"];
                h.Id_NCC = (int)dr["Id_NCC"];
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
        public static void Them(SanPham sp)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Insert into SanPham(MaSP, TenSP, SLTon, DonViTinh, GiaNhap, GiaSi, GiaLe, TiLeGiam, id_LSP, id_NCC) values (@MaSP, @TenSP, @SLTon, @DonViTinh, @GiaNhap, @GiaSi, @GiaLe, @TiLeGiam, @id_LSP, @id_NCC)";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@SLTon", sp.SLTon);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
            cmd.Parameters.AddWithValue("@GiaSi", sp.GiaSi);
            cmd.Parameters.AddWithValue("@GiaLe", sp.GiaLe);
            cmd.Parameters.AddWithValue("@TiLeGiam", sp.TiLeGiam);
            cmd.Parameters.AddWithValue("@id_LSP", sp.Id_LSP);
            cmd.Parameters.AddWithValue("@id_NCC", sp.Id_NCC);
            //cmd.Parameters.AddWithValue("@id_ND", sp.Id_ND);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void Xoa(String MaSP)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Delete from SanPham where MaSp=@MaSp";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void CapNhat(SanPham sp)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Update SanPham set TenSP=@TenSP, SLTon = @SLTon, DonViTinh = @DonViTinh, GiaNhap = @GiaNhap, GiaSi = @GiaSi, GiaLe = @GiaLe, TiLeGiam = @TiLeGiam, id_LSP = @Id_LSP, id_NCC = id_NCC  where MaSP=@MaSP";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@SLTon", sp.SLTon);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
            cmd.Parameters.AddWithValue("@GiaLe", sp.GiaLe);
            cmd.Parameters.AddWithValue("@TiLeGiam", sp.DonViTinh);
            cmd.Parameters.AddWithValue("@id_LSP", sp.Id_LSP);
            cmd.Parameters.AddWithValue("@id_NCC", sp.Id_NCC);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
