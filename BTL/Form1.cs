using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.QLPhongMay;
using BTL.QLNhanVien;
using BTL.QLLichTH;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FORMGIAODIEN : Form
    {
		private SqlConnection sqlConnection;
        public FORMGIAODIEN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			FrmQuanLyLichTH quanLyLichTH = new FrmQuanLyLichTH();
            quanLyLichTH.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
			FrmQuanLyMayTinh quanLyMayTinh = new FrmQuanLyMayTinh(sqlConnection);
			quanLyMayTinh.Show();

        }

        private void FORMGIAODIEN_Load(object sender, EventArgs e)
        {
			string conn = @"Data Source=TOANUTC\SQLEXPRESS;Initial Catalog=PHONGMAY;Integrated Security=True";
			sqlConnection = new SqlConnection(conn);
			sqlConnection.Open();

		}

        private void button1_Click(object sender, EventArgs e)
        {
            int loopctr = 0;

            for (loopctr = 100; loopctr >= 5; loopctr -= 10)
            {
                this.Opacity = loopctr / 95.0;
                this.Refresh();
                Thread.Sleep(100);
            }
			sqlConnection.Close();
            this.Close();
        }

		private void button7_Click(object sender, EventArgs e)
		{
			FrmThongTin thongTin = new FrmThongTin(sqlConnection);
			thongTin.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			FrmTimKiem timKiem = new FrmTimKiem();
			timKiem.Show();
		}

		private void btnQuanLyPM_Click(object sender, EventArgs e)
		{
			FrmQuanLyPM quanLyPhongMay = new FrmQuanLyPM(sqlConnection);
			quanLyPhongMay.Show();
		}

		private void btnQuanLyNV_Click(object sender, EventArgs e)
		{
			FrmQuanLyNV quanLyNhanVien = new FrmQuanLyNV(sqlConnection);
			quanLyNhanVien.Show();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmThongTin frmThongTin = new FrmThongTin(sqlConnection);
			frmThongTin.Show();
		}

		private void qLMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmQuanLyMayTinh frmQuanLyMayTinh = new FrmQuanLyMayTinh(sqlConnection);
			frmQuanLyMayTinh.Show();
		}

		private void qLLịchThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmQuanLyLichTH frmQuanLyLichTH = new FrmQuanLyLichTH();
			frmQuanLyLichTH.Show();
		}

		private void qLNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmQuanLyNV frmQuanLyNV = new FrmQuanLyNV(sqlConnection);
			frmQuanLyNV.Show();
		}

		private void qLPhòngMáyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmQuanLyPM frmQuanLyPM = new FrmQuanLyPM(sqlConnection);
			frmQuanLyPM.Show();
		}
	}
}
