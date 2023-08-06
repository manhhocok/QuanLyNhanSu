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
    public partial class FormTrinhDoChuyenMon : Form
    {
        SqlConnection connec;
        SqlDataAdapter daTrinhDoHocVan;
        DataTable tbTrinhDoHocVan;
        public FormTrinhDoChuyenMon()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Insert into TRINHDOHOCVAN" +
                " values(N'{0}',N'{1}')", tbMaTrinhDo.Text, tbTenTrinhDo.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbTrinhDoHocVan.Clear();
            daTrinhDoHocVan.Fill(tbTrinhDoHocVan);
        }

        private void FormTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu;" +
                " Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daTrinhDoHocVan = new SqlDataAdapter("select MaTDHV as N'Mã Trình Độ Học Vấn'," +
                " TenTDHV as N'Tên Trình Độ Học Vấn' " +
                " from TRINHDOHOCVAN", connec);
            tbTrinhDoHocVan = new DataTable();
            daTrinhDoHocVan.Fill(tbTrinhDoHocVan);
            dataGridView1.DataSource = tbTrinhDoHocVan;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update TRINHDOHOCVAN" +
                " set TenTDHV = N'{0}' " +
                "Where MaTDHV = N'{1}'", tbTenTrinhDo.Text, tbMaTrinhDo.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbTrinhDoHocVan.Clear();
            daTrinhDoHocVan.Fill(tbTrinhDoHocVan);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Delete From TRINHDOHOCVAN " +
                "Where MaTDHV = N'{0}'",tbMaTrinhDo.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbTrinhDoHocVan.Clear();
            daTrinhDoHocVan.Fill(tbTrinhDoHocVan);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
