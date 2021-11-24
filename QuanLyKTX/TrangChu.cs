using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class TrangChu : Form
    {   

        public TrangChu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlLop();
        }


        private void quảnLýKhuNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlKhuNha();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlThietBi();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlPhong();
        }

        private void quảnLýPhòngThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlTbiPhong();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlKhoa();
        }

        private void quảnLýQuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlQue();
        }   

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlSinhVien();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlSVThuePhong();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlSVTraPhong();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TrangChu_BLL trangchu = new TrangChu_BLL();
            trangchu.qlTimKiem();
        }
    }
}
