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

namespace BTL
{
	
	public partial class FrmThongTinNV : Form
	{
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		public FrmThongTinNV(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void FrmThongTinNV_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã nhân viên],[Tên nhân viên],[Mã PM],[Năm sinh],[Giới tính],[Mã tỉnh],[Điện thoại] FROM [PHONGMAY].[dbo].[Nhân viên]";
			sqlCommand = new SqlCommand(query,sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinNV.DataSource = data;
		}

		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void ptbThem_Click(object sender, EventArgs e)
		{
			string queryx = "insert [Nhân viên] ([Mã nhân viên],[Tên nhân viên],[Mã PM],[Năm sinh],[Giới tính],[Mã tỉnh],[Điện thoại])" +
				"values (N'" + txtMaNV.Text +
				"',N'" + txtTenNV.Text +
				"',N" + txtMaPM.Text +
				"',N'" + txtNamSinh.Text +
				"',N'" + cmbGioiTinh.Text +
				"',N'" + txtMaTinh.Text +
				"',N'" + txtDienThoai.Text +
				"')";
			sqlCommand = new SqlCommand(queryx, sqlConnection);
			sqlCommand.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại]FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinNV.DataSource = data;
		}

		private void ptbXoa_Click(object sender, EventArgs e)
		{

		}
	}
}
