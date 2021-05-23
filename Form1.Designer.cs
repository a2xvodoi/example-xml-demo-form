namespace TruongHoc_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textIdClass = new System.Windows.Forms.TextBox();
            this.textNameClass = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textIdStudent = new System.Windows.Forms.TextBox();
            this.textNameStudent = new System.Windows.Forms.TextBox();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioFM = new System.Windows.Forms.RadioButton();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.dgvSt = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddSt = new System.Windows.Forms.Button();
            this.btnEditSt = new System.Windows.Forms.Button();
            this.btnDlSt = new System.Windows.Forms.Button();
            this.btnSearchSt = new System.Windows.Forms.Button();
            this.btnClearTextSt = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDlClass = new System.Windows.Forms.Button();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.btnClearTextClass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSumCostCl = new System.Windows.Forms.Label();
            this.dgvCl = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocphiCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbAddress2 = new System.Windows.Forms.ComboBox();
            this.lbCostByAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sinh viên trong lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tuổi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Học phí";
            // 
            // textIdClass
            // 
            this.textIdClass.Location = new System.Drawing.Point(108, 67);
            this.textIdClass.Name = "textIdClass";
            this.textIdClass.Size = new System.Drawing.Size(179, 20);
            this.textIdClass.TabIndex = 11;
            // 
            // textNameClass
            // 
            this.textNameClass.Location = new System.Drawing.Point(108, 138);
            this.textNameClass.Name = "textNameClass";
            this.textNameClass.Size = new System.Drawing.Size(179, 20);
            this.textNameClass.TabIndex = 12;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(108, 209);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(179, 20);
            this.textYear.TabIndex = 13;
            // 
            // textIdStudent
            // 
            this.textIdStudent.Location = new System.Drawing.Point(428, 66);
            this.textIdStudent.Name = "textIdStudent";
            this.textIdStudent.Size = new System.Drawing.Size(100, 20);
            this.textIdStudent.TabIndex = 14;
            // 
            // textNameStudent
            // 
            this.textNameStudent.Location = new System.Drawing.Point(428, 109);
            this.textNameStudent.Name = "textNameStudent";
            this.textNameStudent.Size = new System.Drawing.Size(100, 20);
            this.textNameStudent.TabIndex = 15;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(428, 145);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(47, 17);
            this.radioM.TabIndex = 16;
            this.radioM.TabStop = true;
            this.radioM.Text = "Nam";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioFM
            // 
            this.radioFM.AutoSize = true;
            this.radioFM.Location = new System.Drawing.Point(489, 145);
            this.radioFM.Name = "radioFM";
            this.radioFM.Size = new System.Drawing.Size(39, 17);
            this.radioFM.TabIndex = 17;
            this.radioFM.TabStop = true;
            this.radioFM.Text = "Nữ";
            this.radioFM.UseVisualStyleBackColor = true;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(645, 66);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(124, 20);
            this.textAge.TabIndex = 18;
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(645, 138);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(124, 20);
            this.textCost.TabIndex = 20;
            // 
            // dgvSt
            // 
            this.dgvSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.gioitinh,
            this.tuoi,
            this.diaChi,
            this.hocPhi});
            this.dgvSt.Location = new System.Drawing.Point(345, 227);
            this.dgvSt.Name = "dgvSt";
            this.dgvSt.Size = new System.Drawing.Size(424, 108);
            this.dgvSt.TabIndex = 21;
            this.dgvSt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellStudentClick);
            // 
            // masv
            // 
            this.masv.HeaderText = "ID";
            this.masv.Name = "masv";
            this.masv.Width = 40;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.Width = 120;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 40;
            // 
            // tuoi
            // 
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 32;
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 80;
            // 
            // hocPhi
            // 
            this.hocPhi.HeaderText = "Học phí";
            this.hocPhi.Name = "hocPhi";
            this.hocPhi.Width = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Danh sách lớp học";
            // 
            // btnAddSt
            // 
            this.btnAddSt.Location = new System.Drawing.Point(345, 190);
            this.btnAddSt.Name = "btnAddSt";
            this.btnAddSt.Size = new System.Drawing.Size(75, 23);
            this.btnAddSt.TabIndex = 23;
            this.btnAddSt.Text = "Thêm";
            this.btnAddSt.UseVisualStyleBackColor = true;
            this.btnAddSt.Click += new System.EventHandler(this.btnAddSt_Click);
            // 
            // btnEditSt
            // 
            this.btnEditSt.Location = new System.Drawing.Point(420, 190);
            this.btnEditSt.Name = "btnEditSt";
            this.btnEditSt.Size = new System.Drawing.Size(75, 23);
            this.btnEditSt.TabIndex = 24;
            this.btnEditSt.Text = "Sửa";
            this.btnEditSt.UseVisualStyleBackColor = true;
            // 
            // btnDlSt
            // 
            this.btnDlSt.Location = new System.Drawing.Point(495, 190);
            this.btnDlSt.Name = "btnDlSt";
            this.btnDlSt.Size = new System.Drawing.Size(75, 23);
            this.btnDlSt.TabIndex = 25;
            this.btnDlSt.Text = "Xóa";
            this.btnDlSt.UseVisualStyleBackColor = true;
            // 
            // btnSearchSt
            // 
            this.btnSearchSt.Location = new System.Drawing.Point(570, 190);
            this.btnSearchSt.Name = "btnSearchSt";
            this.btnSearchSt.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSt.TabIndex = 26;
            this.btnSearchSt.Text = "Tìm kiếm";
            this.btnSearchSt.UseVisualStyleBackColor = true;
            // 
            // btnClearTextSt
            // 
            this.btnClearTextSt.Location = new System.Drawing.Point(645, 190);
            this.btnClearTextSt.Name = "btnClearTextSt";
            this.btnClearTextSt.Size = new System.Drawing.Size(75, 23);
            this.btnClearTextSt.TabIndex = 27;
            this.btnClearTextSt.Text = "Hủy bỏ";
            this.btnClearTextSt.UseVisualStyleBackColor = true;
            this.btnClearTextSt.Click += new System.EventHandler(this.btnClearTextSt_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(33, 246);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 28;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(108, 246);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(75, 23);
            this.btnEditClass.TabIndex = 29;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnDlClass
            // 
            this.btnDlClass.Location = new System.Drawing.Point(183, 246);
            this.btnDlClass.Name = "btnDlClass";
            this.btnDlClass.Size = new System.Drawing.Size(75, 23);
            this.btnDlClass.TabIndex = 30;
            this.btnDlClass.Text = "Xóa";
            this.btnDlClass.UseVisualStyleBackColor = true;
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.Location = new System.Drawing.Point(258, 246);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClass.TabIndex = 31;
            this.btnSearchClass.Text = "Tìm kiếm";
            this.btnSearchClass.UseVisualStyleBackColor = true;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);
            // 
            // btnClearTextClass
            // 
            this.btnClearTextClass.Location = new System.Drawing.Point(108, 275);
            this.btnClearTextClass.Name = "btnClearTextClass";
            this.btnClearTextClass.Size = new System.Drawing.Size(75, 23);
            this.btnClearTextClass.TabIndex = 32;
            this.btnClearTextClass.Text = "Hủy bỏ";
            this.btnClearTextClass.UseVisualStyleBackColor = true;
            this.btnClearTextClass.Click += new System.EventHandler(this.btnClearTextClass_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(143, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Tổng học phí";
            // 
            // lbSumCostCl
            // 
            this.lbSumCostCl.AutoSize = true;
            this.lbSumCostCl.Location = new System.Drawing.Point(221, 325);
            this.lbSumCostCl.Name = "lbSumCostCl";
            this.lbSumCostCl.Size = new System.Drawing.Size(13, 13);
            this.lbSumCostCl.TabIndex = 35;
            this.lbSumCostCl.Text = "0";
            // 
            // dgvCl
            // 
            this.dgvCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.tenlop,
            this.namhoc,
            this.hocphiCl});
            this.dgvCl.Location = new System.Drawing.Point(33, 341);
            this.dgvCl.Name = "dgvCl";
            this.dgvCl.Size = new System.Drawing.Size(736, 130);
            this.dgvCl.TabIndex = 36;
            this.dgvCl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClassClick);
            // 
            // malop
            // 
            this.malop.HeaderText = "Mã lớp";
            this.malop.Name = "malop";
            // 
            // tenlop
            // 
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 300;
            // 
            // namhoc
            // 
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 150;
            // 
            // hocphiCl
            // 
            this.hocphiCl.HeaderText = "Học phí";
            this.hocphiCl.Name = "hocphiCl";
            this.hocphiCl.Width = 140;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(33, 274);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "Hiển thị";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(645, 109);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(124, 21);
            this.cbAddress.TabIndex = 19;
            this.cbAddress.Text = "--- Chọn địa chỉ ---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Học phí";
            // 
            // cbAddress2
            // 
            this.cbAddress2.FormattingEnabled = true;
            this.cbAddress2.Location = new System.Drawing.Point(198, 303);
            this.cbAddress2.Name = "cbAddress2";
            this.cbAddress2.Size = new System.Drawing.Size(89, 21);
            this.cbAddress2.TabIndex = 39;
            this.cbAddress2.Text = "Chọn địa chỉ ";
            this.cbAddress2.SelectedIndexChanged += new System.EventHandler(this.costByAddress);
            // 
            // lbCostByAd
            // 
            this.lbCostByAd.AutoSize = true;
            this.lbCostByAd.Location = new System.Drawing.Point(293, 306);
            this.lbCostByAd.Name = "lbCostByAd";
            this.lbCostByAd.Size = new System.Drawing.Size(13, 13);
            this.lbCostByAd.TabIndex = 40;
            this.lbCostByAd.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 473);
            this.Controls.Add(this.lbCostByAd);
            this.Controls.Add(this.cbAddress2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvCl);
            this.Controls.Add(this.lbSumCostCl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTextClass);
            this.Controls.Add(this.btnSearchClass);
            this.Controls.Add(this.btnDlClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnClearTextSt);
            this.Controls.Add(this.btnSearchSt);
            this.Controls.Add(this.btnDlSt);
            this.Controls.Add(this.btnEditSt);
            this.Controls.Add(this.btnAddSt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvSt);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.radioFM);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.textNameStudent);
            this.Controls.Add(this.textIdStudent);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textNameClass);
            this.Controls.Add(this.textIdClass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trường học";
            this.Load += new System.EventHandler(this.load_Form);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textIdClass;
        private System.Windows.Forms.TextBox textNameClass;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textIdStudent;
        private System.Windows.Forms.TextBox textNameStudent;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioFM;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.DataGridView dgvSt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddSt;
        private System.Windows.Forms.Button btnEditSt;
        private System.Windows.Forms.Button btnDlSt;
        private System.Windows.Forms.Button btnSearchSt;
        private System.Windows.Forms.Button btnClearTextSt;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDlClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnClearTextClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSumCostCl;
        private System.Windows.Forms.DataGridView dgvCl;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocphiCl;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbAddress2;
        private System.Windows.Forms.Label lbCostByAd;
    }
}

