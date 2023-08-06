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
    public partial class FormThongTinHoSo : Form
    {
        SqlConnection connec;
        SqlDataAdapter daHoSo;
        DataTable tbHoSo;
        public FormThongTinHoSo()
        {
            InitializeComponent();
        }

        private void FormThongTinHoSo_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daHoSo = new SqlDataAdapter("select * from NHANVIEN", connec);
            tbHoSo = new DataTable();
            daHoSo.Fill(tbHoSo);
            dataGridView1.DataSource = tbHoSo;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("insert into NHANVIEN " +
                "values ('{0}',N'{1}','{2} ', N'{3}', N'{4}','{5}', N'{6}', N'{7}','{8}' ,'{9}','{10}', '{11}', '{12}', '{13}')"
                ,tbMaNhanVien.Text, tbHoTenNhanVien.Text, dateNgaySinh.Value, cbGioiTinh.Text, tbQueQuan.Text, tbSDT.Text, tbDanToc.Text, tbQuocTich.Text, tbLuongCoBan.Text, cbTenPhongBan.Text,cbHopDong.Text,cbTrinhDo.Text, cbChucVu.Text, cbBaoHiem.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbHoSo.Clear();
            daHoSo.Fill(tbHoSo);
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Delete From NHANVIEN Where MaNV = '{0}'",tbMaNhanVien.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbHoSo.Clear();
            daHoSo.Fill(tbHoSo);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update NHANVIEN " +
                "Set HoTenNV = N'{0}', NgaySinh = '{1}', GioiTinh = N'{2}', Quequan = N'{3}', SdtNV = '{4}', DanToc = N'{5}', QuocTich = N'{6}', Luongcoban = '{7}', MaPB = '{8}', MaHD = '{9}', MaTDHV = '{10}', MaCV = '{11}', MaBH = '{12}' " +
                "Where MaNV = '{13}'", tbHoTenNhanVien.Text, dateNgaySinh.Value, cbGioiTinh.Text, tbQueQuan.Text, tbSDT.Text, tbDanToc.Text, tbQuocTich.Text, tbLuongCoBan.Text, cbTenPhongBan.Text, cbHopDong.Text, cbTrinhDo.Text, cbChucVu.Text, cbBaoHiem.Text, tbMaNhanVien.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbHoSo.Clear();
            daHoSo.Fill(tbHoSo);
        }
    }
}
