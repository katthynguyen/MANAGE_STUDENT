using STUDENT.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT.GUI
{
    public partial class TiepNhanHocSinh : Form
    {
        public TiepNhanHocSinh()
        {
            InitializeComponent();
            
        }       

        private void TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            LoadHocSinh();
        }
        void LoadHocSinh()
        {
            HOCSINHBUS bus = new HOCSINHBUS();
            dgvHocSinh.DataSource = bus.GetAllHocSinh();
        }
          
                
        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvHocSinh.CurrentRow.Index;
            txtMaHocSinh.Text = dgvHocSinh.Rows[idx].Cells["MaHocSinh"].Value.ToString();
            txtHoTen.Text = dgvHocSinh.Rows[idx].Cells["TenHocSinh"].Value.ToString();
            dtNgaySinh.Text = dgvHocSinh.Rows[idx].Cells["NgaySinh"].Value.ToString(); 
            txtEmail.Text = dgvHocSinh.Rows[idx].Cells["Email"].Value.ToString();
            txtDiaChi.Text = dgvHocSinh.Rows[idx].Cells["DiaChi"].Value.ToString();

            string gioitinh = dgvHocSinh.Rows[idx].Cells["GioiTinh"].Value.ToString();
            
            if (gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }  
            else if (gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
                
        }

        private void btnExitHocSinh_Click(object sender, EventArgs e)
        {

        }
    }
}
