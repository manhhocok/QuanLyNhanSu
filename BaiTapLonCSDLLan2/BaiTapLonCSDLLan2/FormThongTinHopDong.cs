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
    public partial class FormThongTinHopDong : Form
    {
        SqlConnection connec;
        SqlDataAdapter daHopDong;
        DataTable tbHopDong;
        public FormThongTinHopDong()
        {
            InitializeComponent();
        }

        private void FormThongTinHopDong_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daHopDong = new SqlDataAdapter("Select MaHD as N'Mã Hợp Đồng'," +
                " LoaiHD as N'Loại Hợp Đồng', GhiChu as N'Ghi Chú'from HOPDONG", connec);
            tbHopDong = new DataTable();
            daHopDong.Fill(tbHopDong);
            dataGridView1.DataSource = tbHopDong;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Insert into HOPDONG " +
                "values(N'{0}',N'{1}',N'{2}')", tbMaHopDong.Text, tbLoaiHopDong.Text, tbGhiChu.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbHopDong.Clear();
            daHopDong.Fill(tbHopDong);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update HOPDONG " +
               "set LoaiHD = N'{0}',GhiChu = N'{1}' Where MaHD = N'{2}'", tbLoaiHopDong.Text, tbGhiChu.Text, tbMaHopDong.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbHopDong.Clear();
            daHopDong.Fill(tbHopDong);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(tbHopDong.Rows.Count > 0)
            {
                string sql1 = string.Format("Delete From HOPDONG " +
               " Where MaHD = N'{0}'", tbMaHopDong.Text);
                SqlCommand cmd = new SqlCommand(sql1, connec);
                cmd.ExecuteNonQuery();
                tbHopDong.Clear();
                daHopDong.Fill(tbHopDong);
            }
        }
    }
}
