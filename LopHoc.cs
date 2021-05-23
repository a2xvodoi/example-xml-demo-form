using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHoc_Form
{
    class LopHoc
    {
        public string maLop { get;  set; }
        public string tenLop { get;  set; }
        public string namHoc { get;  set; }

        public List<SinhVien> lisSv { get; set; }
        public LopHoc()
        {

        }

        public LopHoc(string maLop, string tenLop, string namHoc, List<SinhVien> liSv)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.namHoc = namHoc;
            this.lisSv = new List<SinhVien>(liSv);
        }
    }
}
