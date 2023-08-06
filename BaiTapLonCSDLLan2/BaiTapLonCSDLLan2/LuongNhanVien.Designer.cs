namespace BaiTapLonCSDLLan2
{
    partial class LuongNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btTinh = new System.Windows.Forms.Button();
            this.btCapNhap = new System.Windows.Forms.Button();
            this.cbTongThuong = new System.Windows.Forms.TextBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btExport);
            this.panel1.Controls.Add(this.btTinh);
            this.panel1.Controls.Add(this.btCapNhap);
            this.panel1.Controls.Add(this.cbTongThuong);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 248);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Export";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cập Nhập";
            // 
            // btExport
            // 
            this.btExport.Image = global::BaiTapLonCSDLLan2.Properties.Resources.Screenshot_2021_12_26_080437;
            this.btExport.Location = new System.Drawing.Point(903, 136);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 65);
            this.btExport.TabIndex = 8;
            this.btExport.UseVisualStyleBackColor = true;
            // 
            // btTinh
            // 
            this.btTinh.Image = global::BaiTapLonCSDLLan2.Properties.Resources.Screenshot_2021_12_26_080420;
            this.btTinh.Location = new System.Drawing.Point(716, 136);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(112, 65);
            this.btTinh.TabIndex = 7;
            this.btTinh.UseVisualStyleBackColor = true;
            // 
            // btCapNhap
            // 
            this.btCapNhap.Image = global::BaiTapLonCSDLLan2.Properties.Resources.Screenshot_2021_12_26_080354;
            this.btCapNhap.Location = new System.Drawing.Point(529, 136);
            this.btCapNhap.Name = "btCapNhap";
            this.btCapNhap.Size = new System.Drawing.Size(112, 65);
            this.btCapNhap.TabIndex = 6;
            this.btCapNhap.UseVisualStyleBackColor = true;
            this.btCapNhap.Click += new System.EventHandler(this.btCapNhap_Click);
            // 
            // cbTongThuong
            // 
            this.cbTongThuong.Location = new System.Drawing.Point(529, 45);
            this.cbTongThuong.Name = "cbTongThuong";
            this.cbTongThuong.Size = new System.Drawing.Size(222, 26);
            this.cbTongThuong.TabIndex = 5;
            this.cbTongThuong.Text = "0";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbNam.Location = new System.Drawing.Point(208, 109);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(137, 28);
            this.cbNam.TabIndex = 4;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(208, 43);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(137, 28);
            this.cbThang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Thưởng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // LuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "LuongNhanVien";
            this.Text = "Lương Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LuongNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCapNhap;
        private System.Windows.Forms.TextBox cbTongThuong;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}