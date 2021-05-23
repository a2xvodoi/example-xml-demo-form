using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHoc_Form
{
    class SinhVien
    {
        public string maSV { get;  set; }
        public string hoTen { get;  set; }
        public string gioiTinh { get;  set; }
        public string tuoi { get;  set; }
        public string diaChi { get;  set; }
        public string hocPhi { get;  set; }

        public SinhVien()
        {

        }
        public SinhVien(string maSV, string hoTen, string gioiTinh, string tuoi, string diaChi, string hocPhi)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
            this.hocPhi = hocPhi;
        }
    }
}
