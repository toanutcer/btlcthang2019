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
	public partial class FrmRam : Form
	{
		SqlConnection sqlConnection;
		SqlCommand sqlCommand;
		public FrmRam(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmRam_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã Ram],[Tên Ram] FROM [PHONGMAY].[dbo].[Ram]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			dgvThongTin.DataSource = dataTable;
		}
	}
}
