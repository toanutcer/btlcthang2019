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
	public partial class FrmMonTH : Form
	{
		SqlConnection sqlConnection;
		SqlCommand sqlCommand;
		public FrmMonTH(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmMonTH_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã môn],[Tên môn]FROM [PHONGMAY].[dbo].[Môn thực hành]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlDataAdapter= new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			dgvThongTin.DataSource = dataTable;

		}
	}
}
