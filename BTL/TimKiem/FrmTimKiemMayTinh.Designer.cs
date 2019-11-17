namespace BTL
{
	partial class FrmTimKiemMayTinh
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnQuayLai = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbSearchBy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvTimKiem = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnQuayLai);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbbSearchBy);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(1, 1);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(1096, 262);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Tìm Kiếm";
			// 
			// btnQuayLai
			// 
			this.btnQuayLai.Location = new System.Drawing.Point(641, 194);
			this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnQuayLai.Name = "btnQuayLai";
			this.btnQuayLai.Size = new System.Drawing.Size(191, 60);
			this.btnQuayLai.TabIndex = 15;
			this.btnQuayLai.Text = "Quay Lại";
			this.btnQuayLai.UseVisualStyleBackColor = true;
			this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(251, 194);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(191, 60);
			this.btnTimKiem.TabIndex = 14;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(840, 112);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(207, 31);
			this.comboBox3.TabIndex = 13;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(532, 112);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(207, 31);
			this.comboBox2.TabIndex = 12;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(209, 112);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(207, 31);
			this.comboBox1.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(767, 112);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Ram :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(444, 112);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Chíp :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 112);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Phòng Máy :";
			// 
			// cbbSearchBy
			// 
			this.cbbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbSearchBy.FormattingEnabled = true;
			this.cbbSearchBy.Items.AddRange(new object[] {
            "Phòng Máy",
            "Chíp  ",
            "Ram"});
			this.cbbSearchBy.Location = new System.Drawing.Point(449, 23);
			this.cbbSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbbSearchBy.Name = "cbbSearchBy";
			this.cbbSearchBy.Size = new System.Drawing.Size(276, 31);
			this.cbbSearchBy.TabIndex = 7;
			this.cbbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbbSearchBy_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(291, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tìm Kiếm Theo";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvTimKiem);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(1, 271);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(1096, 287);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông Tin";
			// 
			// dgvTimKiem
			// 
			this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvTimKiem.BackgroundColor = System.Drawing.Color.White;
			this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTimKiem.Location = new System.Drawing.Point(4, 27);
			this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvTimKiem.Name = "dgvTimKiem";
			this.dgvTimKiem.RowHeadersWidth = 51;
			this.dgvTimKiem.Size = new System.Drawing.Size(1088, 256);
			this.dgvTimKiem.TabIndex = 0;
			// 
			// FrmTimKiemMayTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(1097, 561);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "FrmTimKiemMayTinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tìm Kiếm Lịch Máy Tính";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
			this.ResumeLayout(false);

		}



		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbbSearchBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvTimKiem;
		private System.Windows.Forms.Button btnQuayLai;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}