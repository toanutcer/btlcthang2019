namespace BTL
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNTIMKIEM = new System.Windows.Forms.Button();
            this.BTNLUU = new System.Windows.Forms.Button();
            this.BTNTROVE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTNTIMKIEM
            // 
            this.BTNTIMKIEM.Location = new System.Drawing.Point(118, 19);
            this.BTNTIMKIEM.Name = "BTNTIMKIEM";
            this.BTNTIMKIEM.Size = new System.Drawing.Size(109, 23);
            this.BTNTIMKIEM.TabIndex = 1;
            this.BTNTIMKIEM.Text = "TÌM KIẾM";
            this.BTNTIMKIEM.UseVisualStyleBackColor = true;
            this.BTNTIMKIEM.Click += new System.EventHandler(this.BTNTIMKIEM_Click);
            // 
            // BTNLUU
            // 
            this.BTNLUU.Location = new System.Drawing.Point(364, 19);
            this.BTNLUU.Name = "BTNLUU";
            this.BTNLUU.Size = new System.Drawing.Size(109, 23);
            this.BTNLUU.TabIndex = 5;
            this.BTNLUU.Text = "LƯU";
            this.BTNLUU.UseVisualStyleBackColor = true;
            // 
            // BTNTROVE
            // 
            this.BTNTROVE.Location = new System.Drawing.Point(209, 59);
            this.BTNTROVE.Name = "BTNTROVE";
            this.BTNTROVE.Size = new System.Drawing.Size(187, 23);
            this.BTNTROVE.TabIndex = 6;
            this.BTNTROVE.Text = "TRỞ VỀ";
            this.BTNTROVE.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Khaki;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 44);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNTIMKIEM);
            this.groupBox1.Controls.Add(this.BTNTROVE);
            this.groupBox1.Controls.Add(this.BTNLUU);
            this.groupBox1.Location = new System.Drawing.Point(56, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NV";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNTIMKIEM;
        private System.Windows.Forms.Button BTNLUU;
        private System.Windows.Forms.Button BTNTROVE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}