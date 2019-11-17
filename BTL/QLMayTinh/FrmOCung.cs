using System;
using System.Data;
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
	public partial class FrmOCung : Form
	{
		private SqlConnection sqlConnecting;
		private SqlCommand sqlCommand;
		public FrmOCung(SqlConnection sql)
		{

			sqlConnecting = sql;
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}
		/// <summary>
		///  
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void FrmOCung_Load(object sender, EventArgs e)
		{
			string query = "SELECT TOP (1000) [Mã nhân viên],[Tên nhân viên],[Mã PM],[Năm sinh],[Giới tính],[Mã tỉnh],[Điện thoại] FROM [PHONGMAY].[dbo].[Nhân viên]";
			sqlCommand = new SqlCommand(query, sqlConnecting);
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
			DataTable data = new DataTable();
			sqlData.Fill(data);
			dgvThongTin.DataSource = data;


		}
	}
}
