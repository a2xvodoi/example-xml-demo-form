using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruongHoc_Form
{
    public partial class Form1 : Form
    {
        DataUlti data = new DataUlti();
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            List<SinhVien> liSV = new List<SinhVien>();
            for (int i = 0; i < dgvSt.Rows.Count-1; i++)
            {
                SinhVien sv = new SinhVien();
                sv.maSV =Convert.ToString(dgvSt.Rows[i].Cells[0].Value);
                sv.hoTen =Convert.ToString(dgvSt.Rows[i].Cells[1].Value);
                sv.gioiTinh =Convert.ToString(dgvSt.Rows[i].Cells[2].Value);
                sv.tuoi =Convert.ToString(dgvSt.Rows[i].Cells[3].Value);
                sv.diaChi =Convert.ToString(dgvSt.Rows[i].Cells[4].Value);
                sv.hocPhi =Convert.ToString(dgvSt.Rows[i].Cells[5].Value);
                liSV.Add(sv);
            }
            LopHoc cl = new LopHoc(textIdClass.Text, textNameClass.Text, textYear.Text, liSV);
            try
            {
                data.themClass(cl);
                clearTextClass();

                data.hienThi(dgvCl, dgvSt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            data.hienThi(dgvCl, dgvSt);

            long cost = 0;
            for (int i = 0; i < dgvCl.Rows.Count; i++)
            {
                cost += Convert.ToInt64(dgvCl.Rows[i].Cells[3].Value);
            }
            lbSumCostCl.Text = cost + "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearTextClass_Click(object sender, EventArgs e)
        {
            clearTextClass();
        }
        
        private void clearTextClass()
        {
            textIdClass.Clear();
            textNameClass.Clear();
            textYear.Clear();

            ActiveControl = textIdClass;
        }

        private void clearTextStudent()
        {
            textIdStudent.Clear();
            textNameStudent.Clear();
            textAge.Clear();
            //textAddress.Clear();
            cbAddress.SelectedIndex = -1;
            textCost.Clear();

            ActiveControl = textIdStudent;
        }

        private void btnClearTextSt_Click(object sender, EventArgs e)
        {
            clearTextStudent();
        }
        private SinhVien themStudent(SinhVien sv)
        {
            sv.maSV = textIdStudent.Text;
            sv.hoTen = textNameStudent.Text;
            sv.gioiTinh = radioM.Checked ? radioM.Text : radioFM.Text;
            sv.tuoi = textAge.Text;
            sv.diaChi = cbAddress.Text;
            sv.hocPhi = textCost.Text;
            return sv;
        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {
            int index = dgvSt.Rows.Count;
            dgvSt.ColumnCount = 6;
            for (int i = 0; i < index; i++)
            {
                if (Convert.ToString(dgvSt.Rows[i].Cells[0].Value).Equals(textIdStudent.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!!!");
                    return;
                }
            }
            dgvSt.Rows.Add();
            dgvSt.Rows[index-1].Cells[0].Value = textIdStudent.Text;
            dgvSt.Rows[index-1].Cells[1].Value = textNameStudent.Text;
            dgvSt.Rows[index-1].Cells[2].Value = radioM.Checked ? radioM.Text : radioFM.Text;
            dgvSt.Rows[index-1].Cells[3].Value = textAge.Text;
            dgvSt.Rows[index - 1].Cells[4].Value = cbAddress.Text;
            dgvSt.Rows[index-1].Cells[5].Value = textCost.Text;

        }

        private void cellClassClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCl.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvCl.Rows[i];

            textIdClass.Text = Convert.ToString(row.Cells[0].Value);
            textNameClass.Text = Convert.ToString(row.Cells[1].Value);
            textYear.Text = Convert.ToString(row.Cells[2].Value);

            data.hienThiStudent(dgvSt, Convert.ToString(row.Cells[0].Value));
        }

        private void cellStudentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSt.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvSt.Rows[i];

            textIdStudent.Text = Convert.ToString(row.Cells[0].Value);
            textNameStudent.Text = Convert.ToString(row.Cells[1].Value);
            textAge.Text = Convert.ToString(row.Cells[3].Value);
            cbAddress.Text = Convert.ToString(row.Cells[4].Value);
            textCost.Text = Convert.ToString(row.Cells[5].Value);
            if (Convert.ToString(row.Cells[2].Value).Equals("Nam"))
            {
                radioM.Checked = true;
            }
            else
            {
                radioFM.Checked = true;
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            List<SinhVien> liSV = new List<SinhVien>();
            for (int i = 0; i < dgvSt.Rows.Count - 1; i++)
            {
                SinhVien sv = new SinhVien();
                sv.maSV = Convert.ToString(dgvSt.Rows[i].Cells[0].Value);
                sv.hoTen = Convert.ToString(dgvSt.Rows[i].Cells[1].Value);
                sv.gioiTinh = Convert.ToString(dgvSt.Rows[i].Cells[2].Value);
                sv.tuoi = Convert.ToString(dgvSt.Rows[i].Cells[3].Value);
                sv.diaChi = Convert.ToString(dgvSt.Rows[i].Cells[4].Value);
                sv.hocPhi = Convert.ToString(dgvSt.Rows[i].Cells[5].Value);
                liSV.Add(sv);
            }
            LopHoc cl = new LopHoc(textIdClass.Text, textNameClass.Text, textYear.Text, liSV);
            try
            {
                data.suaClass(cl);
                clearTextClass();

                data.hienThi(dgvCl, dgvSt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            LopHoc cl = new LopHoc();
            cl.maLop = textIdClass.Text;
            try
            {
                data.timClass(cl, dgvCl, dgvSt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_Form(object sender, EventArgs e)
        {
            cbAddress.Items.Add("Hà Nội");
            cbAddress.Items.Add("Hải Phòng");
            cbAddress.Items.Add("Quảng Ninh");
            cbAddress2.Items.Add("Hà Nội");
            cbAddress2.Items.Add("Hải Phòng");
            cbAddress2.Items.Add("Quảng Ninh");
        }

        private void costByAddress(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.diaChi = cbAddress2.SelectedItem.ToString();
            lbCostByAd.Text = data.costByAd(sv) + "";
        }
    }
}
