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
	public partial class FrmThongTinMayTinh : Form
	{
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		public FrmThongTinMayTinh(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void FrmThongTinMayTinh_Load(object sender, EventArgs e)
		{
			string query = "SELECT  [Mã Máy],[Tên Máy],[Mã PM],[Mã ổ cứng],[Mã dưng lượng],[Mã chip]" +
				",[Mã ram],[Mã tốc độ],[Mã màn hình],[Mã cỡ MH],[Mã chuột],[Mã bàn phím],[Mã ổ đĩa]" +
				",[Ghi chú] FROM [PHONGMAY].[dbo].[Máy Tính]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlData.Fill(dataTable);
			dgvThongTinMT.DataSource = dataTable;
		}

		

		

		private void ptbQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void dgvThongTinMT_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvThongTinMT_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ptbThem_Click(object sender, EventArgs e)
		{

		}
	}
}
