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
    public partial class FormPhongBan : Form
    {
        SqlConnection connec;
        //1
        SqlDataAdapter daPhongBan;
        DataTable tbPhongBan;
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daPhongBan = new SqlDataAdapter("Select MaPB as N'Mã Phòng Ban', " +
                "TenPB as N'Tên Phòng Ban', SđtPB as N'Số Điện Thoại Phòng Ban', " +
                "DiaChiPB as N'Địa Chỉ' from PHONGBAN", connec);
            tbPhongBan = new DataTable();
            daPhongBan.Fill(tbPhongBan);
            dataGridView1.DataSource = tbPhongBan;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Insert into PHONGBAN values(N'{0}',N'{1}',N'{2}',N'{3}')", tbMaPhongBan.Text,tbTenPhongBan.Text, tbSDT.Text, tbDiaChi.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbPhongBan.Clear();
            daPhongBan.Fill(tbPhongBan);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update PHONGBAN set TenPB = N'{0}', SđtPB =N'{1}', DiaChiPB=N'{2}' Where MaPB = N'{3}'", tbTenPhongBan.Text, tbSDT.Text, tbDiaChi.Text, tbMaPhongBan.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbPhongBan.Clear();
            daPhongBan.Fill(tbPhongBan);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbPhongBan.Rows.Count > 0)
            {
                string sql1 = string.Format("Delete From PHONGBAN Where MaPB = N'{0}'", tbMaPhongBan.Text);
                SqlCommand cmd = new SqlCommand(sql1, connec);
                cmd.ExecuteNonQuery();
                tbPhongBan.Clear();
                daPhongBan.Fill(tbPhongBan);
            }
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
