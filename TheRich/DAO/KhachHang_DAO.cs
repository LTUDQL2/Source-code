using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class KhachHang_DAO
    {
        public static DataTable SelectAllData(string kh)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CommandType = System.Data.CommandType.Text;
            DataTable dt = dataProvider.SelectAllData(kh);
            return dt;
        }
        public static List<KhachHang> GetList()
        {
            List<KhachHang> ds = new List<KhachHang>();
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Select * From KhachHang";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHang l = new KhachHang();
                l.Id_KH = (int)dr["Id_KH"];
                l.HoTen = (String)dr["HoTen"];
                l.NgaySinh = (DateTime)dr["NgaySinh"];
                l.GioiTinh = (string)dr["GioiTinh"];
                l.DiaChi = (String)dr["DiaChi"];
                l.SDT = (String)dr["SDT"];
                l.DiemTichLuy = (int)dr["DiemTichLuy"];
                l.Id_ND = (int)dr["Id_ND"];


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
            strSQL = "select * from KhachHang";


            SqlDataAdapter da;
            da = new SqlDataAdapter(strSQL, cn);
            da.Fill(dt);
            cn.Close();
            return dt;

        }
        public static void Them(KhachHang n)
        {
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL;
            strSQL = "Insert into KhachHang(HoTen,GioiTinh,DiaChi,Sdt) values (@HoTen,@GioiTinh,@DiaChi,@Sdt)";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            //cmd.Parameters.AddWithValue("@id_KH", n.Id_KH);
            cmd.Parameters.AddWithValue("@HoTen", n.HoTen);
            //cmd.Parameters.AddWithValue("@NgaySinh", n.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", n.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", n.DiaChi);
            cmd.Parameters.AddWithValue("@Sdt", n.SDT);
            //cmd.Parameters.AddWithValue("@DiemTichLuy", n.DiemTichLuy);
            //cmd.Parameters.AddWithValue("@id_ND", n.Id_ND);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
