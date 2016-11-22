using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace QuanLiThuVienNew
{
    public partial class FrmTimKiemSach : Form
    {
        public FrmTimKiemSach()
        {
            InitializeComponent();
        }

        private void FrmTimKiemSach_Load(object sender, EventArgs e)
        {
            dgvDausach.DataSource = Sach_DAO.TimKiem("");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string dk;

            if (cboDanhmuc.SelectedItem.ToString()== "Tên sách")
            {
                dk = txtTim.Text.ToString();
                dgvDausach.DataSource = Sach_DAO.TimKiem("where TenSach like N'%" + dk.Trim()+"%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Chủ đề")
            {
                dk = txtTim.Text.ToString();
                dgvDausach.DataSource = Sach_DAO.TimKiem("where TenCD like N'%" + dk.Trim() + "%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Nhà xuất bản")
            {
                dk = txtTim.Text.ToString();
                dgvDausach.DataSource = Sach_DAO.TimKiem("where TenNXB like N'%" + dk.Trim() + "%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Ngày nhập")
            {
                dk = txtTim.Text.ToString();
                dgvDausach.DataSource = Sach_DAO.TimKiem("where NgayNhap like '%" + dk.Trim() + "'");
            }
        }
    }
}
