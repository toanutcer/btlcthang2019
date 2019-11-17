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

namespace BTL.QLPhongMay
{
	public partial class FrmQuanLyPM : Form
	{
		private SqlConnection connection;
		private SqlCommand sqlCommand;
		public FrmQuanLyPM(SqlConnection sql)
		{
			connection = sql;
			InitializeComponent();
		}

		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmQuanLyPM_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã PM],[Tên PM],[Số máy],[Đại điểm],[Điện Thoại] FROM [PHONGMAY].[dbo].[Phòng Máy]";
			sqlCommand = new SqlCommand(query, connection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTinPM.DataSource = data;
		}

		private void dgvThongTinPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
