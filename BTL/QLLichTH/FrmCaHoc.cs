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
	public partial class FrmCaHoc : Form
	{
		SqlCommand sqlCommand;
		SqlConnection sqlConnection;
		public FrmCaHoc(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmCaHoc_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã ca],[Tên ca] FROM [PHONGMAY].[dbo].[Ca học]";
			sqlCommand = new SqlCommand(query, sqlConnection);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlData.Fill(dataTable);
			dgvThongTin.DataSource = dataTable;
		}
	}
}
