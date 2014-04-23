using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using System.Data;
using System.Web;
using System.Web.Services.Description;

namespace TheRich.TheRichForm
{
    public partial class NhaCungCap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            GridViewNhaCungCap.DataSource = NhaCungCap_BUS.SelectAllData();
            GridViewNhaCungCap.DataBind();
        }

        protected void GridViewNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridViewNhaCungCap.Columns.Count; i++)
            {
                int id = int.Parse(GridViewNhaCungCap.Rows[i].Cells[0].ToString());
                //int id = int.Parse(GridViewNhaCungCap.DataKeys[e].Value.ToString());

                NhaCungCap_BUS.Xoa(id);
            }
            ShowData();
        }
        private int CheckState()
        {
            int state = 0;
            //if (radioButtonMaLoaiNVL.Checked == true)
            //    state = 1;
            //else if (radioButtonMaNVL.Checked == true)
            //    state = 2;
            //else if (radioButtonTenNVL.Checked == true)
            //    state = 3;
            //else
            //    state = 0;
            return state;
        }

        DataTable dsnvl;
        private void TimKiem()
        {
            dsnvl = new DataTable();
            switch (CheckState())
            {
                case 0:
                    dsnvl = NhaCungCap_BUS.GetTable();
                    break;
                //case 1:
                //    dsnvl = SinhVienBUS.TimKiemTheoTenLoai(cbxLoaiNVL.Text); break;
                //case 2:
                //    dsnvl = SinhVienBUS.TimKiemTheoMaNVL(textBoxMaNVL.Text); break;
                //case 3:
                //    dsnvl = SinhVienBUS.TimKiemTheoTenNVL(textBoxTenNVL.Text); break;
            }
            //dataGridView1.AutoGenerateColumns = false;
            GridViewNhaCungCap.Columns.Clear();
            GridViewNhaCungCap.DataSource = dsnvl;
        }

        protected void ButtonThem_Click(object sender, EventArgs e)
        {

           
                DTO.NhaCungCap n = new DTO.NhaCungCap();

                ////n.Id_NDD = TextBoxTenNhaCungCap.Text;
                n.TenNCC = TextBoxTenNhaCungCap.Text;
                n.DiaChi = TextBoxDiaChi.Text;
                n.SDT = TextBoxSoDienThoai.Text;
                //n.Id_ND = DienThoai.Text;
               
                NhaCungCap_BUS.Them(n);
            TimKiem();
        }

        protected void ButtonSua_Click(object sender, EventArgs e)
        {
            DTO.NhaCungCap n = new DTO.NhaCungCap();
            TextBoxTenNhaCungCap.Text = GridViewNhaCungCap.Rows[0].Cells[1].ToString();
            TextBoxTenNhaCungCap.Text = GridViewNhaCungCap.Rows[0].Cells[2].ToString();
            TextBoxTenNhaCungCap.Text = GridViewNhaCungCap.Rows[0].Cells[3].ToString();
        }
           
            
        }
    }
