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
    public partial class LuongNhanVien : Form
    {
        SqlConnection connec;
        SqlDataAdapter daLuong;
        DataTable tbLuong;
        public LuongNhanVien()
        {
            InitializeComponent();
        }

        private void btCapNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            string cn = "Data Source = DESKTOP-4H3ABTR; Initial Catalog = QLNhanSu; Integrated Security = True";
            connec = new SqlConnection(cn);
            connec.Open();
            daLuong = new SqlDataAdapter("select * from LUONG", connec);
            tbLuong = new DataTable();
            daLuong.Fill(tbLuong);
            dataGridView1.DataSource = tbLuong;
        }
    }
}
