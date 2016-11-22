using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QuanLiThuVienNew
{
    public partial class FrmThemDS : Form
    {
        public FrmThemDS()
        {
            InitializeComponent();
        }
        Sach_DAO bus_sach = new Sach_DAO();
        Sach_DTO enty_sach = new Sach_DTO();
        ChuDe_DAO bus_cd = new ChuDe_DAO();
       
        private void FrmThemDS_Load(object sender, EventArgs e)
        {
            cboMaCD.DataSource = ChuDe_DAO.LoadDuLieu();
            cboMaCD.DisplayMember = "TenCD";
            cboMaCD.ValueMember = "MaCD";
            cboNhaNXB.DataSource = NhaXuatBan_DAO.LoadDuLieu();
            dgvDausach.DataSource = Sach_DAO.LoadDuLieu();
            cboNhaNXB.DisplayMember = "TenNXB";
            cboNhaNXB.ValueMember = "MaNXB";
            txtMasach.ReadOnly = true;
        }
        void getnull()
        {
            txtMasach.Enabled = false;
            txtTensach.Text = "";
            txtGiaban.Text = "";
            txtSoluong.Text = "";
            txtNgaynhap.Text = "";
            txtMota.Text = "";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            getnull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                //enty_sach.MaSach = int.Parse(txtMasach.Text);
                enty_sach.TenSach = txtTensach.Text;
                enty_sach.GiaBan = int.Parse(txtGiaban.Text);
                enty_sach.MaCD = int.Parse(cboMaCD.SelectedValue.ToString());
                enty_sach.MaNXB = int.Parse(cboNhaNXB.SelectedValue.ToString());
                enty_sach.SoLuong = int.Parse(txtSoluong.Text);
                enty_sach.NgayNhap = Convert.ToDateTime(txtNgaynhap.Text);
                enty_sach.MoTa = txtMota.Text;
                Sach_DAO.Them(enty_sach);
                dgvDausach.DataSource = Sach_DAO.LoadDuLieu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
