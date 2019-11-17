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

namespace BTL.QLNhanVien
{
	public partial class FrmQuanLyNV : Form
	{
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		private SqlConnection connection;

		public FrmQuanLyNV(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		
		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmQuanLyNV_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã nhân viên],[Tên nhân viên],[Mã PM],[Năm sinh],[Giới tính],[Mã tỉnh],[Điện thoại] FROM [PHONGMAY].[dbo].[Nhân viên]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinNV.DataSource = data;
		}
	}
}
