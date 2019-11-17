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
	
	public partial class FrmThongTinPM : Form
	{
		
		private SqlConnection connection;
		private SqlCommand sqlCommand;
		private string MaPM = "";
		public FrmThongTinPM(SqlConnection sql)
		{
			connection = sql;
			InitializeComponent();
		}
		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmThongTinPM_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại]FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinPM.DataSource = data;

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void ptbThem_Click(object sender, EventArgs e)
		{
			string queryx = "insert [Phòng Máy] ([Mã PM] ,[Tên PM],[Số máy],[Đại điểm],[Điện Thoại])" +
				"values ('" + txtMaPM.Text+
				"',N'" + txtTenPM.Text+
				"'," +txtSoMay.Text+
				",N'" + txtDiaDiem.Text+
				"',N'" +txtDienThoai.Text+
				"')";   
			sqlCommand = new SqlCommand(queryx, connection);
			sqlCommand.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại]FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinPM.DataSource = data;
		}

		private void ptbXoa_Click(object sender, EventArgs e)
		{
			string queryx = "delete [Phòng Máy] where [Mã PM] ='" + MaPM + "'";
			sqlCommand = new SqlCommand(queryx, connection);
			sqlCommand.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại]FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinPM.DataSource = data;
		}

		private void ptbSua_Click(object sender, EventArgs e)
		{
			string queryx = "update [Phòng Máy] set [Tên PM]=N'" + txtTenPM.Text +
				"',[Số máy]=" + txtSoMay.Text + ", [Đại điểm]=N'" + txtDiaDiem.Text + "',[Điện Thoại]='" + txtDienThoai.Text + "' " +
				"where [Mã PM]='"+MaPM+"'";
			sqlCommand = new SqlCommand(queryx, connection);
			sqlCommand.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại] FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinPM.DataSource = data;
		}

		private void ptbLuu_Click(object sender, EventArgs e)
		{

		}

		private void dgvThongTinPM_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			MaPM = dgvThongTinPM[0, e.RowIndex].Value.ToString();
			txtMaPM.Text= dgvThongTinPM[0,e.RowIndex].Value.ToString();
			txtTenPM.Text = dgvThongTinPM[1, e.RowIndex].Value.ToString();
			txtSoMay.Text= dgvThongTinPM[2, e.RowIndex].Value.ToString();
			txtDiaDiem.Text= dgvThongTinPM[3, e.RowIndex].Value.ToString();
			txtDienThoai.Text= dgvThongTinPM[4, e.RowIndex].Value.ToString();

		}
	}
}
