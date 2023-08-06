using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BaiTapLonCSDLLan2
{
    public partial class Form1 : Form
    {
        SqlConnection connec;
        //1
        SqlDataAdapter daTKPhongBan;
        DataTable tbTKPhongBan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            LuongNhanVien luongNhanVien = new LuongNhanVien();
            luongNhanVien.ShowDialog();
        }

        private void btPhongBan_Click(object sender, EventArgs e)
        {
            FormPhongBan formPhongBan = new FormPhongBan();
            formPhongBan.ShowDialog();
        }

        private void btPhuCap_Click(object sender, EventArgs e)
        {
            
        }

        private void btHoSo_Click(object sender, EventArgs e)
        {
            FormThongTinHoSo formThongTinHoSo = new FormThongTinHoSo();
            formThongTinHoSo.ShowDialog();
        }

        private void btChucDanh_Click(object sender, EventArgs e)
        {
            
        }

        private void btChucVu_Click(object sender, EventArgs e)
        {
            FormThongTinChucVu formThongTinChucVu = new FormThongTinChucVu();   
            formThongTinChucVu.ShowDialog();
        }

        private void btTrinhDo_Click(object sender, EventArgs e)
        {
            FormTrinhDoChuyenMon formTrinhDoChuyenMon = new FormTrinhDoChuyenMon();
            formTrinhDoChuyenMon.ShowDialog();
        }

        private void btBaoHiem_Click(object sender, EventArgs e)
        {
            FormCapNhapBaoHiem formCapNhapBaoHiem = new FormCapNhapBaoHiem();
            formCapNhapBaoHiem.ShowDialog();
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            FormThongTinHopDong formThongTinHopDong =  new FormThongTinHopDong();
            formThongTinHopDong.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Phòng Ban
               Trình Độ Học Vấn
               Hồ Sơ
            */

            if (comboBox1.Text == "Phòng Ban")
            {
                daTKPhongBan = new SqlDataAdapter("EXEC Prd_TK_PhongBan N'"+ textBox1.Text + "'", connec);
                tbTKPhongBan = new DataTable();
                daTKPhongBan.Fill(tbTKPhongBan);
                dataGridView2.DataSource = tbTKPhongBan;
            }
            if (comboBox1.Text == "Trình Độ Học Vấn")
            {
                daTKPhongBan = new SqlDataAdapter("EXEC Prd_TK_TrinhDoNhanVien N'" + textBox1.Text + "'", connec);
                tbTKPhongBan = new DataTable();
                daTKPhongBan.Fill(tbTKPhongBan);
                dataGridView2.DataSource = tbTKPhongBan;
            }
            if (comboBox1.Text == "Hồ Sơ")
            {
                daTKPhongBan = new SqlDataAdapter("exec dbo.SP_Chucvu N'" + textBox1.Text + "'", connec);
                tbTKPhongBan = new DataTable();
                daTKPhongBan.Fill(tbTKPhongBan);
                dataGridView2.DataSource = tbTKPhongBan;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
