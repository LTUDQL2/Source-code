using BUS.Properties;
using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAO dao = new NhanVien_DAO();
        //Thông báo lỗi
        public string wrongPass = Resources.lbPas;
        public string wrongName = Resources.lbUname;
        public string wrongOldPass = Resources.lbOld;
        public string wrongnewPass = Resources.lbNew;
        public string wrongAgainPass = Resources.lbAgain;
        //Nhớ mật khẩu
        public static int check;
        //Đăng nhập
        public static bool isLogin = false;
        public static int grant;
        public void Login(NhanVien_DTO nv)
        {
            int i = NhanVien_DAO.Login(nv, check);
            /*
            if (i == 1)
            {
                Form1.nv = nv;
                LoginForm.Hide();
                nv.Id_BP = Login_Grant(nv);
                isLogin = True;
            }
            else if (i == 2 )
            {
                wrongName = My.Resources.lbUname.Insert(0, "Sai tên đăng nhập");
            }
            else if (i == 3)
            {
                wrongP=s = My.Resources.lbP=.Insert(0, "Sai mật khẩu");
                wrongName = My.Resources.lbUname.Replace("Sai tên đăng nhập", "");
            }
        */
        }
        //Gọi uname & p=s đã được lưu
        public string Login_CallPass(string uname)
        {
            return NhanVien_DAO.Login_CallPass(uname);
        }
        //Ủy quyền
        public int Login_Grant(NhanVien_DTO nv)
        {
            grant = NhanVien_DAO.Login_Grant(nv);
            return grant;
        }
        //Đổi mật khẩu
        public static string test = "";
        public void ChangePas(NhanVien_DTO nv, string newPas, string again)
        {
            int i = NhanVien_DAO.ChangePass(nv, newPas, again);
            if (i == 0)
            {
                DialogResult msg = MessageBox.Show("Mật khẩu đã đổi");
                if (msg == DialogResult.OK)
                {
                    // ChangePass.Close();
                }
            }
            else if (i == 1)
            {
                //ChangePas.ErrorProvider1.SetError(ChangePas.txtAgain, "Mật khẩu xác nhận sai");
            }
        }
        private DataTable ds = new DataTable();
        public DataTable Info(string maNV)
        {
            return dao.Info(maNV);
        }
        //Tạo node nhân viên
        public List<TreeNode> ListNodeNV_BP(int id)
        {
            return dao.ListNodeNV_BP(id);
        }
        //AutoUpdate
        public void AutoUpdate(DataGridView dgv)
        {
            dao.AutoUpdate(dgv);
        }
        //Lấy danh sách nhân viên theo bộ phận
        public DataTable InfoNV_BP(string id_bp)
        {
            return dao.InfoNV_BP(id_bp);
        }
        //Lấy danh sách nhân viên trong cửa hàng
        public DataTable GetAllStaff()
        {
            return dao.GetAllStaff();
        }
        public List<NhanVien_DTO> GetListNVQL()
        {
            return dao.GetListNVQL();
        }
        public void Update(NhanVien_DTO nv)
        {
            dao.Update(nv);
        }

        public void Insert(NhanVien_DTO nv)
        {
            dao.Insert(nv);
        }

        public void Delete(int p1)
        {
            dao.Delete(p1);
        }
        public static List<NhanVien_DTO> getlist()
        {
            List<NhanVien_DTO> dt = new List<NhanVien_DTO>();
            dt = NhanVien_DAO.getlist();
            return dt;
        }

        public NhanVien_DTO SetNV(int id)
        {
            return dao.SetNV(id);
        }
        public void SetPas(int id, string pas)
        {
            dao.SetPas(id, pas);
        }
    }
}
