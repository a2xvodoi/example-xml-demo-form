using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TruongHoc_Form
{
    class DataUlti
    {
        XmlDocument doc;
        XmlElement root;
        string fileName;

        public DataUlti()
        {
            doc = new XmlDocument();
            fileName = "truonghoc.xml";
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void hienThi(DataGridView dgvCl, DataGridView dgvSt)
        {
            dgvCl.Rows.Clear();
            dgvCl.ColumnCount = 4;
            dgvSt.Rows.Clear();
            dgvSt.ColumnCount = 6;

            XmlNodeList list = root.SelectNodes("lophoc");
            int index = 0;
            foreach (XmlNode item in list)
            {
                dgvCl.Rows.Add();
                dgvCl.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                dgvCl.Rows[index].Cells[1].Value = item.SelectSingleNode("tenlop").InnerText;
                dgvCl.Rows[index].Cells[2].Value = item.SelectSingleNode("namhoc").InnerText;
                XmlNodeList listSt = item.SelectNodes("sinhvien");
                int indexS = 0;
                long cost = 0;
                foreach (XmlNode itemSt in listSt)
                {
                    cost += long.Parse(itemSt.SelectSingleNode("hocphi").InnerText);
                    indexS++;
                }
                dgvCl.Rows[index].Cells[3].Value = cost;
                index++;
            }
        }

        public void hienThiStudent(DataGridView dgvSt, string maLop)
        {
            dgvSt.Rows.Clear();
            dgvSt.ColumnCount = 6;
            XmlNode clTim = root.SelectSingleNode("lophoc[@malop='" + maLop + "']");
            XmlNodeList listSt = clTim.SelectNodes("sinhvien");

            int index = 0;
            foreach (XmlNode item in listSt)
            {
                dgvSt.Rows.Add();
                dgvSt.Rows[index].Cells[0].Value = item.SelectSingleNode("masv").InnerText;
                dgvSt.Rows[index].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                dgvSt.Rows[index].Cells[2].Value = item.SelectSingleNode("gioitinh").InnerText;
                dgvSt.Rows[index].Cells[3].Value = item.SelectSingleNode("tuoi").InnerText;
                dgvSt.Rows[index].Cells[4].Value = item.SelectSingleNode("diachi").InnerText;
                dgvSt.Rows[index].Cells[5].Value = item.SelectSingleNode("hocphi").InnerText;

                index++;
            }
            
        }
        public void themClass(LopHoc cl)
        {
            XmlNode clTim = root.SelectSingleNode("lophoc[@malop='" + cl.maLop + "']");
            if (clTim != null)
            {
                throw new Exception("Mã lớp đã tồn tại không thể thêm");
                
            }
            XmlElement c = doc.CreateElement("lophoc");

            c.SetAttribute("malop", cl.maLop);

            XmlElement tenLop = doc.CreateElement("tenlop");
            tenLop.InnerText = cl.tenLop;

            XmlElement namHoc = doc.CreateElement("namhoc");
            namHoc.InnerText = cl.namHoc;
            
            c.AppendChild(tenLop);
            c.AppendChild(namHoc);
            foreach (SinhVien item in cl.lisSv)
            {
                XmlElement sv = doc.CreateElement("sinhvien");

                XmlElement maSV = doc.CreateElement("masv");
                maSV.InnerText = item.maSV;

                XmlElement hoTen = doc.CreateElement("hoten");
                hoTen.InnerText = item.hoTen;

                XmlElement gioiTinh = doc.CreateElement("gioitinh");
                gioiTinh.InnerText = item.gioiTinh;

                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = item.tuoi;

                XmlElement diaChi = doc.CreateElement("diachi");
                diaChi.InnerText = item.diaChi;

                XmlElement hocPhi = doc.CreateElement("hocphi");
                hocPhi.InnerText = item.hocPhi;

                sv.AppendChild(maSV);
                sv.AppendChild(hoTen);
                sv.AppendChild(gioiTinh);
                sv.AppendChild(tuoi);
                sv.AppendChild(diaChi);
                sv.AppendChild(hocPhi);

                c.AppendChild(sv);

            }

            root.AppendChild(c);

            doc.Save(fileName);
        }
        public void suaClass(LopHoc cl)
        {
            XmlNode clTim = root.SelectSingleNode("lophoc[@malop='" + cl.maLop + "']");
            if (clTim == null)
            {
                throw new Exception("Không tìm thấy mã lớp");
                
            }
            XmlElement c = doc.CreateElement("lophoc");

            c.SetAttribute("malop", cl.maLop);

            XmlElement tenLop = doc.CreateElement("tenlop");
            tenLop.InnerText = cl.tenLop;

            XmlElement namHoc = doc.CreateElement("namhoc");
            namHoc.InnerText = cl.namHoc;
            
            c.AppendChild(tenLop);
            c.AppendChild(namHoc);
            foreach (SinhVien item in cl.lisSv)
            {
                XmlElement sv = doc.CreateElement("sinhvien");

                XmlElement maSV = doc.CreateElement("masv");
                maSV.InnerText = item.maSV;

                XmlElement hoTen = doc.CreateElement("hoten");
                hoTen.InnerText = item.hoTen;

                XmlElement gioiTinh = doc.CreateElement("gioitinh");
                gioiTinh.InnerText = item.gioiTinh;

                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = item.tuoi;

                XmlElement diaChi = doc.CreateElement("diachi");
                diaChi.InnerText = item.diaChi;

                XmlElement hocPhi = doc.CreateElement("hocphi");
                hocPhi.InnerText = item.hocPhi;

                sv.AppendChild(maSV);
                sv.AppendChild(hoTen);
                sv.AppendChild(gioiTinh);
                sv.AppendChild(tuoi);
                sv.AppendChild(diaChi);
                sv.AppendChild(hocPhi);

                c.AppendChild(sv);

            }

            root.ReplaceChild(c, clTim) ;

            doc.Save(fileName);
        }
        public void xoaClass(LopHoc cl)
        {
            XmlNode clTim = root.SelectSingleNode("lophoc[@malop='" + cl.maLop + "']");
            if (clTim == null)
            {
                throw new Exception("Không tìm thấy mã lớp");
                
            }
            root.RemoveChild(clTim);
            doc.Save(fileName);
        }
        public void timClass(LopHoc cl, DataGridView dgvCl, DataGridView dgvSt)
        {
            XmlNode clTim = root.SelectSingleNode("lophoc[@malop='" + cl.maLop + "']");
            if (clTim == null)
            {
                throw new Exception("Không tìm thấy mã lớp");
                
            }
            dgvCl.Rows.Clear();
            dgvCl.ColumnCount = 4;
            dgvSt.Rows.Clear();
            dgvSt.ColumnCount = 6;
            
            dgvCl.Rows[0].Cells[0].Value = clTim.Attributes[0].InnerText;
            dgvCl.Rows[0].Cells[1].Value = clTim.SelectSingleNode("tenlop").InnerText;
            dgvCl.Rows[0].Cells[2].Value = clTim.SelectSingleNode("namhoc").InnerText;
            XmlNodeList listSt = clTim.SelectNodes("sinhvien");
            int indexS = 0;
            long cost = 0;
            foreach (XmlNode itemSt in listSt)
            {
                cost += long.Parse(itemSt.SelectSingleNode("hocphi").InnerText);
                indexS++;
            }
            dgvCl.Rows[0].Cells[3].Value = cost;
            hienThiStudent(dgvSt, cl.maLop);
        }

        public long costByAd(SinhVien sv)
        {
            long cost = 0;
            XmlNodeList list = root.SelectNodes("lophoc");
            
            foreach (XmlNode item in list)
            {
                XmlNodeList listSt = item.SelectNodes("sinhvien");
                foreach (XmlNode itemSt in listSt)
                {
                    if (itemSt.SelectSingleNode("diachi").InnerText == sv.diaChi)
                    {
                        cost += long.Parse(itemSt.SelectSingleNode("hocphi").InnerText);
                    }
                }
            }
            return cost;
        }
    }
}
