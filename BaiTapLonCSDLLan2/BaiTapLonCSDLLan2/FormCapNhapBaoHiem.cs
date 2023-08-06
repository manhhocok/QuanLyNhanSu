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
    public partial class FormCapNhapBaoHiem : Form
    {
        SqlConnection connec;
        //1
        SqlDataAdapter daBaoHiem;
        DataTable tbBaoHiem;
        public FormCapNhapBaoHiem()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormCapNhapBaoHiem_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daBaoHiem = new SqlDataAdapter("select MaBH as N'Mã Bảo Hiểm', " +
               "LoaiBH as N'Loại Bảo Hiểm',NgayCapBH as N'Ngày Cấp Bảo Hiểm'," +
               "NoiCapBH as N'Nới Cấp Bảo Hiểm' from BAOHIEM", connec);
            tbBaoHiem = new DataTable();
            daBaoHiem.Fill(tbBaoHiem);
            dataGridView1.DataSource = tbBaoHiem;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
                string sql1 = string.Format("Insert into BAOHIEM values(N'{0}',N'{1}','{2}',N'{3}')", tbMaLoaiBaoHiem.Text, tbTenLoaiBaoHiem.Text, dateNgayCap.Value, tbNoiCap.Text);
                SqlCommand cmd = new SqlCommand(sql1, connec);
                cmd.ExecuteNonQuery();
                tbBaoHiem.Clear();
                daBaoHiem.Fill(tbBaoHiem);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update BaoHiem " +
                "set LoaiBH = N'{0}', NgayCapBH ='{1}', NoiCapBH=N'{2}', PhantramLuong = '{3}' " +
                "Where MaBH = N'{4}'",  tbTenLoaiBaoHiem.Text, dateNgayCap.Value, tbNoiCap.Text, tbPhanTramLuong.Text, tbMaLoaiBaoHiem.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbBaoHiem.Clear();
            daBaoHiem.Fill(tbBaoHiem);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(tbBaoHiem.Rows.Count > 0)
            {
                string sql1 = string.Format("Delete From BaoHiem" +
                    " Where MaBH = N'" + tbMaLoaiBaoHiem.Text + "'");
                SqlCommand cmd = new SqlCommand(sql1, connec);
                cmd.ExecuteNonQuery();
                tbBaoHiem.Clear();
                daBaoHiem.Fill(tbBaoHiem);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
