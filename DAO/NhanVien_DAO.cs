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
    public class NhanVien_DAO
    {
        public static int Login(NhanVien_DTO nv, int check)
        {
            //
            //check = NhanVien_BUS.check;
            //
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_Login", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("uname", SqlDbType.VarChar, 10);
            para1.Direction = ParameterDirection.Input;
            para1.Value = nv.MaNV;
            sqlCmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("pas", SqlDbType.VarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = nv.Password;
            sqlCmd.Parameters.Add(para2);

            SqlParameter para4 = new SqlParameter("check", SqlDbType.Int);
            para4.Direction = ParameterDirection.Input;
            para4.Value = check;
            sqlCmd.Parameters.Add(para4);

            SqlParameter para3 = new SqlParameter("outRes", SqlDbType.Int);
            para3.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(para3);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(para3.Value.ToString());
        }

        public static int Login_Grant(NhanVien_DTO nv)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_Login_Grant", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("uname", SqlDbType.VarChar, 10);
            para1.Direction = ParameterDirection.Input;
            para1.Value = nv.MaNV;
            sqlCmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("pas", SqlDbType.VarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = nv.Password;
            sqlCmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("outRes", SqlDbType.Int);
            para3.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(para3);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(para3.Value.ToString());
        }
        //Đăng nhập với tài khoản đã nhớ trước đó
        public static string Login_CallPass(string uname)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_CallPass", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("uname", SqlDbType.VarChar, 10);
            para.Direction = ParameterDirection.Input;
            para.Value = uname;
            sqlCmd.Parameters.Add(para);

            SqlParameter para1 = new SqlParameter("pas", SqlDbType.VarChar, 30);
            para1.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(para1);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return para1.Value.ToString();
        }
        //Đổi mật khẩu
        public static int ChangePass(NhanVien_DTO nv, string newPass, string again)
        {
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_ChangePas", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("maNV", SqlDbType.VarChar, 10);
            para1.Direction = ParameterDirection.Input;
            para1.Value = nv.MaNV;
            sqlCmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("old", SqlDbType.VarChar, 30);
            para2.Direction = ParameterDirection.Input;
            para2.Value = nv.Password;
            sqlCmd.Parameters.Add(para2);

            SqlParameter para3 = new SqlParameter("newPas", SqlDbType.VarChar, 30);
            para3.Direction = ParameterDirection.Input;
            para3.Value = newPass;
            sqlCmd.Parameters.Add(para3);

            SqlParameter para4 = new SqlParameter("again", SqlDbType.VarChar, 30);
            para4.Direction = ParameterDirection.Input;
            para4.Value = again;
            sqlCmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("test", SqlDbType.Int);
            para5.Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add(para5);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(para5.Value.ToString());
        }
        //Thông tin nhân viên
        public DataTable Info(string maNV)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_StaffInfo", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("maNV", SqlDbType.VarChar, 10);
            para1.Direction = ParameterDirection.Input;
            para1.Value = maNV;
            sqlCmd.Parameters.Add(para1);

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return dt;
        }
        public DataTable InfoNV_BP(string id_bp)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListNV_BP", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("id_bp", SqlDbType.Int);
            para1.Direction = ParameterDirection.Input;
            para1.Value = id_bp;
            sqlCmd.Parameters.Add(para1);

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);

            conn.Open();
            sqlCmd.ExecuteNonQuery();
            conn.Close();

            return dt;
        }
        //Tạo node nhân viên thuộc bộ phận
        public List<TreeNode> ListNodeNV_BP(int id)
        {
            List<TreeNode> list = new List<TreeNode>();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListNV_BP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("id_bp", SqlDbType.Int);
            para.Direction = ParameterDirection.Input;
            para.Value = id;
            cmd.Parameters.Add(para);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                if (rd.IsDBNull(0))
                {
                    nv.Id_NV = 0;
                }
                else
                    nv.Id_NV = rd.GetInt32(0);
                if (rd.IsDBNull(1))
                {
                    nv.MaNV = "";
                }
                else
                    nv.MaNV = rd.GetString(1);

                TreeNode trn = new TreeNode(nv.MaNV);
                trn.Tag = nv;
                list.Add(trn);
            }
            return list;
        }
        //  AutoUpdate
        public DataTable AutoUpdate(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_AutoUpdateStaffInfo", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            dt = (DataTable)dgv.DataSource;

            DataColumn[] keys = new DataColumn[2];
            keys[0] = dt.Columns[0];
            keys[1] = dt.Columns[1];
            dt.PrimaryKey = keys;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            return dt;
        }
        //Danh sách nhân viên
        public DataTable GetAllStaff()
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListNV", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();
            sqlCmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
        public List<NhanVien_DTO> GetListNVQL()
        {
            List<NhanVien_DTO> list = new List<NhanVien_DTO>();
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListNVQL", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id_NV = rd.GetInt32(0);
                nv.MaNV = rd.GetString(1);
                list.Add(nv);
            }
            cn.Close();
            return list;
        }
        public void Insert(NhanVien_DTO nv)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_InsertNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para2 = new SqlParameter("ma", SqlDbType.VarChar, 10);
            para2.Value = nv.MaNV;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para4 = new SqlParameter("id_bp", SqlDbType.Int);
            para4.Value = nv.Id_BP;
            para4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("id_ch", SqlDbType.Int);
            para5.Value = nv.Id_CH;
            para5.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para5);

            SqlParameter para6 = new SqlParameter("nvql", SqlDbType.Int);
            para6.Value = nv.NVQL;
            para6.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para6);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(NhanVien_DTO nv)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_UpdateNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para1 = new SqlParameter("id", SqlDbType.Int);
            para1.Value = nv.Id_NV;
            para1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para1);

            SqlParameter para2 = new SqlParameter("maNV", SqlDbType.VarChar, 10);
            para2.Value = nv.MaNV;
            para2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para2);

            SqlParameter para4 = new SqlParameter("id_bp", SqlDbType.Int);
            para4.Value = nv.Id_BP;
            para4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para4);

            SqlParameter para5 = new SqlParameter("id_ch", SqlDbType.Int);
            para5.Value = nv.Id_CH;
            para5.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para5);

            SqlParameter para6 = new SqlParameter("nvql", SqlDbType.Int);
            para6.Value = nv.NVQL;
            para6.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para6);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_DeleteNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter para = new SqlParameter("id", SqlDbType.Int);
            para.Value = id;
            para.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(para);

            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static List<NhanVien_DTO> getlist()
        {
            List<NhanVien_DTO> ls = new List<NhanVien_DTO>();
            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Nhanvien_select";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataReader cusor = cmd.ExecuteReader();
            while (cusor.Read())
            {
                NhanVien_DTO da = new NhanVien_DTO();
                da.Id_NV = Convert.ToInt32(cusor["Id_NV"]);
                da.MaNV = cusor["MaNV"].ToString();
                ls.Add(da);
            }
            cusor.Close();
            conn.Close();
            return ls;
        }

        public NhanVien_DTO SetNV(int id)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_SetNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", id);
            NhanVien_DTO nv = new NhanVien_DTO();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nv.Id_NV = Convert.ToInt32(rd[0].ToString());
                if (rd.IsDBNull(1))
                {
                    nv.MaNV = "";
                }
                else
                    nv.MaNV = rd[1].ToString();
                if (rd.IsDBNull(2))
                {
                    nv.Id_BP = 0;
                }
                else
                    nv.Id_BP = Convert.ToInt32(rd[2].ToString());
                if (rd.IsDBNull(3))
                {
                    nv.NVQL = 0;
                }
                else
                    nv.NVQL = Convert.ToInt32(rd[3].ToString());
                if (rd.IsDBNull(4))
                {
                    nv.Id_CH = 0;
                }
                else
                    nv.Id_CH = Convert.ToInt32(rd[4].ToString());
            }
            cn.Close();
            return nv;
        }

        public void SetPas(int id, string pas)
        {
            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("update NhanVien set Pword=@pas where Id_NV=@id", cn);
            cmd.Parameters.AddWithValue("@pas", pas);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
