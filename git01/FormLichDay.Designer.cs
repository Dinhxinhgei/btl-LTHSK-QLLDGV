
namespace git01
{
    partial class FormLichDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dNgayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCaday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSosv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbCaDay = new System.Windows.Forms.ComboBox();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaMon = new System.Windows.Forms.ComboBox();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.cbbMaPhg = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.TimeToSearch = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "2. Danh sách lịch dạy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "1. Thông tin lịch dạy";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBaoCao.Location = new System.Drawing.Point(686, 218);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(100, 28);
            this.btnBaoCao.TabIndex = 75;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Học",
            "Nghỉ"});
            this.cbbTrangThai.Location = new System.Drawing.Point(835, 122);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(132, 24);
            this.cbbTrangThai.TabIndex = 74;
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBoqua.Location = new System.Drawing.Point(867, 218);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(100, 28);
            this.btnBoqua.TabIndex = 70;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Location = new System.Drawing.Point(500, 218);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(312, 218);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 68;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(135, 218);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(835, 168);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(132, 22);
            this.txtGhiChu.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Mã lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 58;
            this.label5.Text = "Quản lý lịch dạy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ca dạy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ngày dạy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNgayday,
            this.sCaday,
            this.sTengv,
            this.sTenmon,
            this.sMalop,
            this.sMap,
            this.iSosv,
            this.sTrangthai,
            this.sGhichu});
            this.dataGridView1.Location = new System.Drawing.Point(4, 315);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 194);
            this.dataGridView1.TabIndex = 53;
            // 
            // dNgayday
            // 
            this.dNgayday.DataPropertyName = "dNgayday";
            this.dNgayday.HeaderText = "Ngày dạy";
            this.dNgayday.MinimumWidth = 6;
            this.dNgayday.Name = "dNgayday";
            this.dNgayday.Width = 110;
            // 
            // sCaday
            // 
            this.sCaday.DataPropertyName = "sCaday";
            this.sCaday.HeaderText = "Ca dạy";
            this.sCaday.MinimumWidth = 6;
            this.sCaday.Name = "sCaday";
            this.sCaday.Width = 120;
            // 
            // sTengv
            // 
            this.sTengv.DataPropertyName = "sTengv";
            this.sTengv.HeaderText = "Tên gv";
            this.sTengv.MinimumWidth = 6;
            this.sTengv.Name = "sTengv";
            this.sTengv.Width = 180;
            // 
            // sTenmon
            // 
            this.sTenmon.DataPropertyName = "sTenmon";
            this.sTenmon.HeaderText = "Tên môn";
            this.sTenmon.MinimumWidth = 6;
            this.sTenmon.Name = "sTenmon";
            this.sTenmon.Width = 200;
            // 
            // sMalop
            // 
            this.sMalop.DataPropertyName = "sMalop";
            this.sMalop.HeaderText = "Mã lớp";
            this.sMalop.MinimumWidth = 6;
            this.sMalop.Name = "sMalop";
            this.sMalop.Width = 80;
            // 
            // sMap
            // 
            this.sMap.DataPropertyName = "sMap";
            this.sMap.HeaderText = "Mã phòng";
            this.sMap.MinimumWidth = 6;
            this.sMap.Name = "sMap";
            this.sMap.Width = 125;
            // 
            // iSosv
            // 
            this.iSosv.DataPropertyName = "iSosv";
            this.iSosv.HeaderText = "Số sv";
            this.iSosv.MinimumWidth = 6;
            this.iSosv.Name = "iSosv";
            this.iSosv.Width = 60;
            // 
            // sTrangthai
            // 
            this.sTrangthai.DataPropertyName = "sTrangthai";
            this.sTrangthai.HeaderText = "Trạng thái";
            this.sTrangthai.MinimumWidth = 6;
            this.sTrangthai.Name = "sTrangthai";
            this.sTrangthai.Width = 125;
            // 
            // sGhichu
            // 
            this.sGhichu.DataPropertyName = "sGhichu";
            this.sGhichu.HeaderText = "Ghi chú";
            this.sGhichu.MinimumWidth = 6;
            this.sGhichu.Name = "sGhichu";
            this.sGhichu.Width = 125;
            // 
            // cbbCaDay
            // 
            this.cbbCaDay.FormattingEnabled = true;
            this.cbbCaDay.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbCaDay.Location = new System.Drawing.Point(221, 115);
            this.cbbCaDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCaDay.Name = "cbbCaDay";
            this.cbbCaDay.Size = new System.Drawing.Size(132, 24);
            this.cbbCaDay.TabIndex = 78;
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(221, 164);
            this.cbbMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(132, 24);
            this.cbbMaGV.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Giảng viên";
            // 
            // cbbMaMon
            // 
            this.cbbMaMon.FormattingEnabled = true;
            this.cbbMaMon.Location = new System.Drawing.Point(519, 74);
            this.cbbMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaMon.Name = "cbbMaMon";
            this.cbbMaMon.Size = new System.Drawing.Size(132, 24);
            this.cbbMaMon.TabIndex = 81;
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(519, 115);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(132, 24);
            this.cbbMaLop.TabIndex = 82;
            // 
            // cbbMaPhg
            // 
            this.cbbMaPhg.FormattingEnabled = true;
            this.cbbMaPhg.Location = new System.Drawing.Point(519, 164);
            this.cbbMaPhg.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaPhg.Name = "cbbMaPhg";
            this.cbbMaPhg.Size = new System.Drawing.Size(132, 24);
            this.cbbMaPhg.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 84;
            this.label11.Text = "Mã phòng";
            // 
            // cbbNgay
            // 
            this.cbbNgay.FormattingEnabled = true;
            this.cbbNgay.Items.AddRange(new object[] {
            ""});
            this.cbbNgay.Location = new System.Drawing.Point(221, 73);
            this.cbbNgay.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.Size = new System.Drawing.Size(132, 24);
            this.cbbNgay.TabIndex = 85;
            // 
            // TimeToSearch
            // 
            this.TimeToSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeToSearch.Location = new System.Drawing.Point(24, 48);
            this.TimeToSearch.Name = "TimeToSearch";
            this.TimeToSearch.Size = new System.Drawing.Size(200, 22);
            this.TimeToSearch.TabIndex = 0;
            this.TimeToSearch.ValueChanged += new System.EventHandler(this.TimeToSearch_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lọc theo ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TimeToSearch);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(746, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 87);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // FormLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbNgay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbMaPhg);
            this.Controls.Add(this.cbbMaLop);
            this.Controls.Add(this.cbbMaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMaGV);
            this.Controls.Add(this.cbbCaDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLichDay";
            this.Size = new System.Drawing.Size(1143, 524);
            this.Load += new System.EventHandler(this.FormLichDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbCaDay;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaMon;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.ComboBox cbbMaPhg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbNgay;
        private System.Windows.Forms.DateTimePicker TimeToSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCaday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSosv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGhichu;
    }
}
