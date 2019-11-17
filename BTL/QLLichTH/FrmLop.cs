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
	public partial class FrmLop : Form
	{
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		public FrmLop(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmLop_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã lớp],[Tên lớp],[sí số]FROM [PHONGMAY].[dbo].[Lớp]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlDataAdapter.Fill(data);
			dgvThongTin.DataSource = data;


	}
	}
}
