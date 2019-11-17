using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.QLLichTH
{
	public partial class FrmGiaoVien : Form
	{
		SqlConnection sqlConnection;
		SqlCommand sqlCommand;
		public FrmGiaoVien(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmGiaoVien_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã GV],[Tên GV],[Điện thoại]FROM [PHONGMAY].[dbo].[Giáo viên]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTin.DataSource = data;
		}
	}
}
