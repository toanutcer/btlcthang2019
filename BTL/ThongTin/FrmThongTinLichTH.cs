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

	public partial class FrmThongTinLichTH : Form
	{
		private string MaSTT = "";
		private SqlConnection connection;
		private SqlCommand command;
		public FrmThongTinLichTH(SqlConnection sql)
		{
			connection = sql;
			InitializeComponent();
		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmThongTinLichTH_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã STT],[Mã PM],[Mã NV],[Mã lớp],[Mã GV],[Mã môn],[Mã ca],[Thứ],[Ngày BĐ],[Ngày KT] FROM [PHONGMAY].[dbo].[Lịch thực hành]";
			command = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(command);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinLichTH.DataSource = data;

		}

		private void ptbThem_Click(object sender, EventArgs e)
		{
			string queryx = "insert [Lịch thực hành] ([Mã STT],[Mã PM],[Mã NV],[Mã lớp],[Mã GV],[Mã môn],[Mã ca],[Thứ],[Ngày BĐ],[Ngày KT])" +
				"values (N'" + txtMaSTT.Text +
				"',N'" + txtMaPM.Text +
				"',N'" + txtMaNV.Text +
				"',N'" + txtMaLop.Text +
				"',N'" + txtMaGV.Text +
				"',N'" + txtMaMon.Text +
				"',N'" + txtMaCa.Text+
				"',N'" + txtThu.Text+
				"', '" + dtpNgayBatDau.Text+
				"', '" + dtpNgayBatDau.Text +
				"')";
			
			command = new SqlCommand(queryx, connection);
			command.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã STT],[Mã PM],[Mã NV],[Mã lớp],[Mã GV],[Mã môn],[Mã ca],[Thứ],[Ngày BĐ]," +
							"[Ngày KT]FROM [PHONGMAY].[dbo].[Lịch thực hành]";
			command = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(command);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinLichTH.DataSource = data;
		}

		private void ptbXoa_Click(object sender, EventArgs e)
		{
			string queryx = "delete [Lịch thực hành] where [Mã STT] ='" + MaSTT + "'";
			command = new SqlCommand(queryx, connection);
			command.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã STT],[Mã PM],[Mã NV],[Mã lớp],[Mã GV],[Mã môn],[Mã ca],[Thứ],[Ngày BĐ]," +
							"[Ngày KT]FROM [PHONGMAY].[dbo].[Lịch thực hành]";
			command = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(command);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinLichTH.DataSource = data;
		}

		private void dgvThongTinLichTH_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			MaSTT = dgvThongTinLichTH[0, e.RowIndex].Value.ToString();
			txtMaSTT.Text = dgvThongTinLichTH[0, e.RowIndex].Value.ToString();
			txtMaPM.Text = dgvThongTinLichTH[1, e.RowIndex].Value.ToString();
			txtMaLop.Text = dgvThongTinLichTH[2, e.RowIndex].Value.ToString();
			txtMaGV.Text = dgvThongTinLichTH[3, e.RowIndex].Value.ToString();
			txtMaMon.Text = dgvThongTinLichTH[4, e.RowIndex].Value.ToString();
			txtMaCa.Text = dgvThongTinLichTH[5, e.RowIndex].Value.ToString();
			dtpNgayBatDau.Text = dgvThongTinLichTH[6, e.RowIndex].Value.ToString();
			dtpNgayKetThuc.Text = dgvThongTinLichTH[7, e.RowIndex].ToString();

		}

		private void ptbSua_Click(object sender, EventArgs e)
		{
			string queryx = "update [Phòng Máy] set N'" + txtMaSTT.Text +
				"',N'" + txtMaPM.Text +
				"',N'" + txtMaNV.Text +
				"',N'" + txtMaLop.Text +
				"',N'" + txtMaGV.Text +
				"',N'" + txtMaMon.Text +
				"',N'" + txtMaCa.Text +
				"',N'" + txtThu.Text +
				"', '" + dtpNgayBatDau.Text +
				"', '" + dtpNgayBatDau.Text +
				"where [Mã STT]='"+MaSTT+"'";

			command = new SqlCommand(queryx, connection);
			command.ExecuteNonQuery();
			string query = "SELECT TOP (1000) [Mã STT],[Mã PM],[Mã NV],[Mã lớp],[Mã GV],[Mã môn],[Mã ca],[Thứ],[Ngày BĐ]," +
							"[Ngày KT]FROM [PHONGMAY].[dbo].[Lịch thực hành]";
			command = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(command);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinLichTH.DataSource = data;
		}
	}
}
