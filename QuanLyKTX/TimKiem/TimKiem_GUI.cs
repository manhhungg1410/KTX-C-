using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX.TimKiem
{
    public partial class TimKiem_GUI : Form
    {
        TimKiem_BLL timkiem = new TimKiem_BLL();

        public TimKiem_GUI()
        {
            InitializeComponent();
        }
        void EditTable()
        {
            dgv_TimKiem.Columns[0].HeaderText = "Mã Số Thuê";
            dgv_TimKiem.Columns[1].HeaderText = "Mã Sinh Viên";
            dgv_TimKiem.Columns[2].HeaderText = "Mã Phòng";
            dgv_TimKiem.Columns[3].HeaderText = "Tên Sinh Viên";
            dgv_TimKiem.Columns[4].HeaderText = "Ngày Sinh";
            dgv_TimKiem.Columns[5].HeaderText = "Giới Tính";
            dgv_TimKiem.Columns[6].HeaderText = "Tên Phòng";
            dgv_TimKiem.Columns[7].HeaderText = "Loại Phòng";
            dgv_TimKiem.Columns[8].HeaderText = "Số Người Tối Đa";
            dgv_TimKiem.Columns[9].HeaderText = "Số Người Đang ở";
            dgv_TimKiem.Columns[10].HeaderText = "Giá Phòng";
            dgv_TimKiem.Columns[11].HeaderText = "Ngày Bắt Đầu";
            dgv_TimKiem.Columns[12].HeaderText = "Ngày Kết Thúc";
            dgv_TimKiem.Columns[13].HeaderText = "Trạng Thái Thuê Phòng";

            dgv_TimKiem.BackgroundColor = Color.Gray;
            dgv_TimKiem.Columns[0].Width = 85;
            dgv_TimKiem.Columns[1].Width = 85;
            dgv_TimKiem.Columns[2].Width = 85;
            dgv_TimKiem.Columns[3].Width = 130;
            dgv_TimKiem.Columns[4].Width = 70;
            dgv_TimKiem.Columns[5].Width = 70;
            dgv_TimKiem.Columns[6].Width = 70;
            dgv_TimKiem.Columns[7].Width = 70;
            dgv_TimKiem.Columns[8].Width = 70;
            dgv_TimKiem.Columns[9].Width = 70;
            dgv_TimKiem.Columns[10].Width = 90;
            dgv_TimKiem.Columns[11].Width = 90;
            dgv_TimKiem.Columns[12].Width = 90;
            dgv_TimKiem.Columns[13].Width = 90;
        }

        void ShowTable()
        {
            dgv_TimKiem.DataSource = timkiem.ShowTable();
        }

        private void KhuNha_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                txt_SinhVien.Focus();
                //ShowTable();
                //EditTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgv_TimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SinhVien.Enabled = true;
            txt_Phong.Enabled = true;
            txt_SinhVien.Text = "";
            txt_Phong.Text = "";

            txt_MST.Text = dgv_TimKiem.CurrentRow.Cells[0].Value.ToString();
            txt_MaSV.Text = dgv_TimKiem.CurrentRow.Cells[1].Value.ToString();
            txt_MaP.Text = dgv_TimKiem.CurrentRow.Cells[2].Value.ToString();
            txt_TenSV.Text = dgv_TimKiem.CurrentRow.Cells[3].Value.ToString();
            txt_NgaySinh.Text = dgv_TimKiem.CurrentRow.Cells[4].Value.ToString();
            txt_GioiTinh.Text = dgv_TimKiem.CurrentRow.Cells[5].Value.ToString();
            txt_TenPhong.Text = dgv_TimKiem.CurrentRow.Cells[6].Value.ToString();
            txt_LoaiPhong.Text = dgv_TimKiem.CurrentRow.Cells[7].Value.ToString();
            txt_SoLuongMax.Text = dgv_TimKiem.CurrentRow.Cells[8].Value.ToString();
            txt_SoLuongNow.Text = dgv_TimKiem.CurrentRow.Cells[9].Value.ToString();
            txt_GiaPhong.Text = dgv_TimKiem.CurrentRow.Cells[10].Value.ToString();
            txt_NgayBD.Text = dgv_TimKiem.CurrentRow.Cells[11].Value.ToString();
            txt_NgayKT.Text = dgv_TimKiem.CurrentRow.Cells[12].Value.ToString();
            txt_TT.Text = dgv_TimKiem.CurrentRow.Cells[13].Value.ToString();
            
        }
        


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {  
                if (txt_SinhVien.Text == "" && txt_Phong.Text == "" && cbb_TTTP.SelectedIndex < 1)
                {
                    MessageBox.Show("Hãy nhập gì đó để tìm kiếm");
                }
                else
                { 
                    dgv_TimKiem.Enabled = true;
                    resettext();
                }

                if (txt_SinhVien.Text != "" && txt_Phong.Text != "" && cbb_TTTP.SelectedIndex >= 1)
                {
                    dgv_TimKiem.DataSource = timkiem.Search_SV_P_TT(txt_SinhVien.Text, txt_Phong.Text, cbb_TTTP.SelectedIndex - 1);
                    EditTable();
                    return;
                }

                if (txt_SinhVien.Text != "" && txt_Phong.Text != "" && cbb_TTTP.SelectedIndex < 1)
                {
                    dgv_TimKiem.DataSource = timkiem.Search_SV_P(txt_SinhVien.Text, txt_Phong.Text);
                    EditTable();
                    return;
                }
                if (txt_SinhVien.Text != "" && txt_Phong.Text == "" && cbb_TTTP.SelectedIndex < 1)
                {
                    dgv_TimKiem.DataSource = timkiem.SearchSV(txt_SinhVien.Text);
                    EditTable();
                    return;
                }
                if (txt_SinhVien.Text == "" && txt_Phong.Text != "" && cbb_TTTP.SelectedIndex < 1)
                {
                    dgv_TimKiem.DataSource = timkiem.SearchPhong(txt_Phong.Text);
                    EditTable();
                    return;
                }

                if (txt_SinhVien.Text != "" && txt_Phong.Text == "" && cbb_TTTP.SelectedIndex >= 1)
                {
                    dgv_TimKiem.DataSource = timkiem.Search_SV_TT(txt_SinhVien.Text,cbb_TTTP.SelectedIndex - 1);
                    EditTable();
                    return;
                }

                if (txt_SinhVien.Text == "" && txt_Phong.Text != "" && cbb_TTTP.SelectedIndex >= 1)
                {
                    dgv_TimKiem.DataSource = timkiem.Search_P_TT(txt_Phong.Text, cbb_TTTP.SelectedIndex - 1);
                    EditTable();
                    return;
                }
                if (txt_SinhVien.Text == "" && txt_Phong.Text == "" && cbb_TTTP.SelectedIndex >= 1)
                {
                    dgv_TimKiem.DataSource = timkiem.Search_TT(cbb_TTTP.SelectedIndex - 1);
                    EditTable();
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            finally
            {
                txt_SinhVien.Focus();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dgv_TimKiem.Enabled = true;
            dgv_TimKiem.DataSource = null;
            txt_Phong.Text = "";
            txt_SinhVien.Text = "";
            resettext();
        }
        void resettext()
        {
            txt_MST.Text = "";
            txt_MaSV.Text = "";
            txt_MaP.Text = "";
            txt_TenSV.Text = "";
            txt_NgaySinh.Text = "";
            txt_GioiTinh.Text = "";
            txt_TenPhong.Text = "";
            txt_LoaiPhong.Text = "";
            txt_SoLuongMax.Text = "";
            txt_SoLuongNow.Text = "";
            txt_GiaPhong.Text = "";
            txt_NgayBD.Text = "";
            txt_NgayKT.Text = ""; 
            txt_TT.Text = "";
        }

        void EditTablePhongTrong()
        {
            resettext();
            dgv_TimKiem.Columns[0].HeaderText = "Mã Phòng";
            dgv_TimKiem.Columns[1].HeaderText = "Tên Phòng";
            dgv_TimKiem.Columns[2].HeaderText = "Mã Khu Nhà";
            dgv_TimKiem.Columns[3].HeaderText = "Loại Phòng";
            dgv_TimKiem.Columns[4].HeaderText = "Số Người Tối Đa";
            dgv_TimKiem.Columns[5].HeaderText = "Số Người Đang Ở";
            dgv_TimKiem.Columns[6].HeaderText = "Ghi Chú";
            dgv_TimKiem.Columns[7].HeaderText = "Giá Phòng";
            dgv_TimKiem.Columns[8].HeaderText = "Trạng Thái";
        }


        private void btn_TimKiem2_Click(object sender, EventArgs e)
        {
            dgv_TimKiem.Enabled = false;

            if (cb_phongtrong.Checked == true )
            {
                dgv_TimKiem.DataSource = timkiem.Search_PhongTrong();
                EditTablePhongTrong();
            }
            else
            {
                dgv_TimKiem.DataSource = null;
            }


            //if(cb_phongtrong.Checked == true && cbb_TTTP.SelectedIndex > 0)
            //{
            //    MessageBox.Show("Bạn chỉ được tìm kiếm theo 1 điều kiện");
            //    return;
            //}

            //if (cb_phongtrong.Checked == true && cbb_TTTP.SelectedIndex == -1 || cbb_TTTP.SelectedIndex == 0)
            //{
            //    if (cb_phongtrong.Checked == true)
            //    {
            //        dgv_TimKiem.DataSource = timkiem.Search_PhongTrong();
            //        EditTablePhongTrong();
            //    }
            //    return;
            //}


            //if (cb_phongtrong.Checked == false && cbb_TTTP.SelectedIndex < 1)
            //{
            //    MessageBox.Show("Chọn 1 điều kiện duy nhất nào đó để tìm kiếm");
            //    dgv_TimKiem.DataSource = null;
            //}

            //if (cb_phongtrong.Checked == false)
            //{
            //    if (cbb_TTTP.SelectedIndex == 3)
            //    {
            //        dgv_TimKiem.DataSource = timkiem.Search_TT2();
            //    }
            //    if (cbb_TTTP.SelectedIndex == 2)
            //    {
            //        dgv_TimKiem.DataSource = timkiem.Search_TT1();
            //    }
            //    if (cbb_TTTP.SelectedIndex == 1)
            //    {
            //        dgv_TimKiem.DataSource = timkiem.Search_TT0();
            //    }
            //    if (cbb_TTTP.SelectedIndex == 0 || cbb_TTTP.SelectedIndex == -1)
            //    {
            //        dgv_TimKiem.DataSource = null;
            //    }
            //}

        }


    }
}
