using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX
{
    class TrangChu_BLL
    {
        KhuNha.KhuNha_GUI khunha = new KhuNha.KhuNha_GUI();
        ThietBi.ThietBi_GUI thietbi = new ThietBi.ThietBi_GUI();
        Phong.Phong_GUI phong = new Phong.Phong_GUI();  
        ThietBi_Phong.ThietBi_Phong_GUI tbi_phong = new ThietBi_Phong.ThietBi_Phong_GUI();
        Khoa.Khoa_GUI khoa = new Khoa.Khoa_GUI();
        Lop.Lop_GUI lop = new Lop.Lop_GUI();
        Que.Que_GUI que = new Que.Que_GUI();
        SinhVien.SinhVien_GUI sinhvien = new SinhVien.SinhVien_GUI();
        SinhVien_DatPhong.SinhVien_ThuePhong_GUI SVThuePhong = new SinhVien_DatPhong.SinhVien_ThuePhong_GUI();
        SinhVien_TraPhong.SinhVien_TraPhong_GUI SVTraPhong = new SinhVien_TraPhong.SinhVien_TraPhong_GUI();
        TimKiem.TimKiem_GUI timkiem = new TimKiem.TimKiem_GUI();

        public void qlTimKiem()
        {
            timkiem.Show();
        }
        public void qlSVThuePhong()
        {
            SVThuePhong.Show();
        }

        public void qlSVTraPhong()
        {
            SVTraPhong.Show();
        }

        public void qlPhong()
        {
            phong.Show();
        }

        public void qlThietBi()
        {
            thietbi.Show();
        }

        public void qlKhuNha()
        {
            khunha.Show();
        }

        public void qlTbiPhong()
        {
            tbi_phong.Show();
        }

        public void qlLop()
        {
            lop.Show();
        }
        public void qlKhoa()
        {
            khoa.Show();
        }
        public void qlQue()
        {
            que.Show();
        }

        public void qlSinhVien()
        {
            sinhvien.Show();
        }
    }
}
