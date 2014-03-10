﻿using System;
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
    public class TyGia_DAO
    {
        public DataTable GetListTG()
        {
            DataTable dt = new DataTable();

            SqlConnection cn = DataProvider.ConnectionData();
            SqlCommand cmd = new SqlCommand("usp_GetListTG", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            cn.Close();
            return dt;
        }

        public DataTable AutoUpdateTG(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataProvider.GetConnString());
            SqlCommand sqlCmd = new SqlCommand("usp_GetListTG", conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);

            dt = (DataTable)dgv.DataSource;
            DataColumn[] keys = new DataColumn[2];
            keys[1] = dt.Columns[0];
            keys[2] = dt.Columns[1];
            dt.PrimaryKey = keys;

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            return dt;
        }


    }
}
