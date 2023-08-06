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

    public partial class FormThongTinChucVu : Form
    {
        SqlConnection connec;
        //1
        SqlDataAdapter daChucVu;
        DataTable tbChucVu;
        public FormThongTinChucVu()
        {
            InitializeComponent();
        }

        private void FormThongTinChucVu_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu;" +
                " Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daChucVu = new SqlDataAdapter("select MaCV as N'Mã Chức Vụ', " +
                "TenCV as N'Tên Chức Vụ' From CHUCVU", connec);
            tbChucVu = new DataTable();
            daChucVu.Fill(tbChucVu);
            dataGridView1.DataSource = tbChucVu;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Insert into CHUCVU " +
                "values(N'{0}',N'{1}')",tbMaChucVu.Text, tbTenChucVu.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbChucVu.Clear();
            daChucVu.Fill(tbChucVu);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("Update CHUCVU " +
                "set TenCV = N'{0}', HesoL ='{1}'  " +
               "Where MaCV = N'{2}'", tbTenChucVu.Text, tbHeSoLuong.Text, tbMaChucVu.Text);
            SqlCommand cmd = new SqlCommand(sql1, connec);
            cmd.ExecuteNonQuery();
            tbChucVu.Clear();
            daChucVu.Fill(tbChucVu);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbChucVu.Rows.Count > 0)
            {
                string sql1 = string.Format("Delete From CHUCVU " +
                    "Where MaCV = N'{0}'", tbMaChucVu.Text);
                SqlCommand cmd = new SqlCommand(sql1, connec);
                cmd.ExecuteNonQuery();
                tbChucVu.Clear();
                daChucVu.Fill(tbChucVu);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
