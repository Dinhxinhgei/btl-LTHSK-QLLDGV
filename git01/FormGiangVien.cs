
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System;
using System.Text.RegularExpressions;

namespace git01
{
    public partial class FormGiangVien : UserControl
    {
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FormGiangVien()
        {
            InitializeComponent();
        }
        private void getDtb()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from GIANGVIEN", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }

                }
                using (SqlCommand cmd = new SqlCommand("select sChucvu from GIANGVIEN group by sChucvu", cnn))
                {
                    //cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cbbChucvu.ValueMember = "sChucvu";
                        cbbChucvu.DataSource = dt;
                    }

                }
            }
        }
        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            getDtb();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //ktra gioi tinh
            if (dataGridView1.CurrentRow.Cells["sGioitinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtMagv.Text = dataGridView1.CurrentRow.Cells["sMagv"].Value.ToString();
            txtTengv.Text = dataGridView1.CurrentRow.Cells["sTengv"].Value.ToString();
            dtNgaysinh.Text = dataGridView1.CurrentRow.Cells["dNgaysinh"].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells["sDiachi"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["sSdt"].Value.ToString();
            cbbChucvu.Text = dataGridView1.CurrentRow.Cells["sChucvu"].Value.ToString();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            txtDiachi.Enabled = true;
            cbbChucvu.Enabled = true;
            txtDiachi.Enabled = true;
            txtTengv.Enabled = true;
            txtMagv.Enabled = true;
            txtSDT.Enabled = true;
            dtNgaysinh.Enabled = true;
            btnSua.Enabled = true;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {

                    cmd.CommandText = "THEM_GIANGVIEN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (rdNam.Checked == true)
                        cmd.Parameters.AddWithValue("@Gioitinh", "Nam");
                    else
                        cmd.Parameters.AddWithValue("@Gioitinh", "Nữ");
                    cmd.Parameters.AddWithValue("@Magv", txtMagv.Text);
                    cmd.Parameters.AddWithValue("@Tengv", txtTengv.Text);
                    cmd.Parameters.AddWithValue("@Ngaysinh", Convert.ToDateTime(dtNgaysinh.Text));
                    cmd.Parameters.AddWithValue("@Diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@Sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Chucvu", cbbChucvu.Text);
                    cnn.Open();
                    int row_af = cmd.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
            }
            getDtb();
        }
        private bool checkValue(bool checkMa)
        {
            bool check = true;

            if (checkMa)
            {
                if (txtMagv.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtMagv, "Không được để trống!");
                    check = false;
                }
                else if (!Regex.IsMatch(txtMagv.Text.Trim(), @"^[A-z,0-9]+$"))
                {
                    errorProvider1.SetError(txtMagv, "Mã không hợp lệ!");
                    check = false;
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cm = new SqlCommand(
                            "SELECT COUNT(sMagv) FROM GIANGVIEN " +
                            "WHERE sMagv = @Magv"
                            , con))
                        {
                            cm.CommandType = CommandType.Text;
                            cm.Parameters.AddWithValue("@Magv", txtMagv.Text);
                            con.Open();
                            if ((int)cm.ExecuteScalar() != 0)
                            {
                                errorProvider1.SetError(txtMagv, "Mã nhà cung cấp đã có trong dữ liệu!");
                                check = false;
                            }
                            else
                                errorProvider1.SetError(txtMagv, "");
                        }
                    }
                }
            }

            if (txtTengv.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTengv, "Không được để trống!");
                check = false;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "SELECT COUNT(sTengv) FROM GIANGVIEN " +
                        "WHERE sTengv = @Tengv"
                        , con))
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@Tengv", txtTengv.Text);
                        con.Open();
                        if ((int)cm.ExecuteScalar() != 0)
                        {
                            errorProvider1.SetError(txtTengv, "Tên gv đã có trong dữ liệu!");
                            check = false;
                        }
                        else
                            errorProvider1.SetError(txtTengv, "");
                    }
                }
            }

            if (txtDiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiachi, "Không được để trống!");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtDiachi, "");
            }

            if (txtSDT.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSDT, "Không được để trống!");
                check = false;
            }
            else
            {
                Regex checkSDT = new Regex(@"^0[\d]{9}$");

                if (!checkSDT.IsMatch(txtSDT.Text.Trim()))
                {
                    errorProvider1.SetError(txtSDT, "Số điện thoại không hợp lệ!");
                    check = false;
                }
                else
                    errorProvider1.SetError(txtSDT, "");
            }

            //if (txtEmail.Text.Trim() == "")
            //{
            //    errorProvider1.SetError(txtEmail, "Không được để trống!");
            //    check = false;
            //}
            //else
            //{
            //    Regex checkMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$");

            //    if (!checkMail.IsMatch(txtEmail.Text.Trim()))
            //    {
            //        errorProvider1.SetError(txtEmail, "Mail không hợp lệ!");
            //        check = false;
            //    }
            //    else
            //        errorProvider1.SetError(txtEmail, "");
            //}

            return check;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "Delete from dbo.GIANGVIEN where sMagv=@Magv"
                        , con))
                    {

                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@Magv", txtMagv.Text);
                        con.Open();
                        int row_af = cm.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                    }

                }
                ResetValue();
                getDtb();
            }
        }
        private void ResetValue()
        {

            txtMagv.Text = "";
            txtTengv.Text = "";
            if (rdNam.Checked == true)
            {
                rdNam.Checked = false;
            }
            else
            {
                rdNu.Checked = false;
            }
            dtNgaysinh.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            cbbChucvu.Text = "";


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cm = new SqlCommand("", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    if (txtTengv.Text != "" && rdNam.Checked == true || rdNu.Checked == true)
                    {
                        cm.CommandText = "TimKiem_All";
                        cm.Parameters.AddWithValue("@Tengv", txtTengv.Text);
                        if (rdNam.Checked == true)
                            cm.Parameters.AddWithValue("@Gioitinh", "Nam");
                        else
                            cm.Parameters.AddWithValue("@Gioitinh", "Nữ");

                    }
                    else if (txtTengv.Text != "")
                    {
                        cm.CommandText = "TimKiem_Ten";
                        cm.Parameters.AddWithValue("@Tengv", txtTengv.Text);
                    }
                    else
                    {
                        cm.CommandText = "TimKiem_Gioitinh";
                        if (rdNam.Checked == true)
                            cm.Parameters.AddWithValue("@Gioitinh", "Nam");
                        else
                            cm.Parameters.AddWithValue("@Gioitinh", "Nữ");
                    }
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cm))
                    {
                        using (DataTable dt = new DataTable("GIANGVIEN"))
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }

            }

            txtTengv.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
             getDtb();

        }

        private void txtMagv_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtMagv.Text == "")
            {
                errorProvider1.SetError(txtMagv, "Ban phai nhap ma");
            }

            else
                errorProvider1.SetError(txtMagv, "");
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cm = new SqlCommand(
                    "update dbo.GIANGVIEN" +
                    " set sTengv=@Tengv," +
                    "sGioitinh =@Gioitinh," +
                    "dNgaysinh=@Ngaysinh," +
                    "sDiachi=@Diachi," +
                    "sSdt=@Sdt," +
                    "sChucvu=@Chucvu" +
                    " where sMagv=@Magv"
                    , con))
                {
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.AddWithValue("@Magv", txtMagv.Text.Trim());
                    cm.Parameters.AddWithValue("@Tengv", txtTengv.Text.Trim());

                    if (rdNam.Checked == true)
                        cm.Parameters.AddWithValue("@Gioitinh", "Nam");
                    else
                        cm.Parameters.AddWithValue("@Gioitinh", "Nữ");
                    cm.Parameters.AddWithValue("@Ngaysinh", Convert.ToDateTime(dtNgaysinh.Text));
                    cm.Parameters.AddWithValue("@Diachi", txtDiachi.Text.Trim());
                    cm.Parameters.AddWithValue("@Sdt", txtSDT.Text.Trim());
                    cm.Parameters.AddWithValue("@Chucvu", cbbChucvu.Text.Trim());
                    con.Open();
                    int row_af = cm.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                }
            }
            ResetValue();
            getDtb();
        }


        private void btnBaoCao_Click(object sender, EventArgs e)
        {

            Form_Report_GiangVien frm = new Form_Report_GiangVien();
            frm.ShowReport_GiangVien();
            frm.Show();
        }

        private void txtTengv_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (txtTengv.Text == "")
            //{
            //    errorProvider1.SetError(txtTengv, "Ban phai nhap ma");

            //}
            //else
            //    errorProvider1.SetError(txtTengv, "");
        }

        private void cbbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMagv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTengv_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
