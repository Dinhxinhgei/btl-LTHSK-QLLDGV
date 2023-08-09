using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace git01
{
    public partial class FormMon : UserControl
    {

        public FormMon()
        {
            InitializeComponent();
        }
        public static string dieukienReport = "";
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void FormMon_Load(object sender, EventArgs e)
        {
            hienDs();
        }
        private void hienDs()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from MON", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }

                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtSoTin.Text == "" )
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("THEMMON", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MAMON", txtMaMon.Text);
                        cmd.Parameters.AddWithValue("@TENMON", txtTenMon.Text);
                        //cmd.Parameters.AddWithValue("@dNgaysinh", Convert.ToDateTime(txtNgaysinh.Text));
                        cmd.Parameters.AddWithValue("@SOTIN", txtSoTin.Text);

                        int row_af = cmd.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            hienDs();
                        }
                    }
                    cnn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "delete_mon";
                    cmd.Parameters.AddWithValue("@MAMON", txtMaMon.Text);

                    int row_af = 0;
                    try
                    {
                        row_af = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Môn đang trong quá trình dạy. Không thể xóa");
                    }
                    if (row_af > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        hienDs();

                    }
                }
                cnn.Close();


            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Tag = txtMaMon.Text = txtTenMon.Text = txtSoTin.Text = string.Empty;
            btnThem.Text = "Thêm";
            txtMaMon.ResetText();
            txtSoTin.ResetText();
            txtTenMon.Focus();
            hienDs();

            btnTimKiem.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dataGridView1.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaMon.Text;
            if (txtMaMon.Text == "" || txtTenMon.Text == "" || txtSoTin.Text == "")
            {
                MessageBox.Show("nhập đầy đủ thông tin!");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("update_MON", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MAMON", ma);
                        cmd.Parameters.AddWithValue("@TENMON", txtTenMon.Text);
                        cmd.Parameters.AddWithValue("@SOTIN", txtSoTin.Text);

                        int row_af = cmd.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            hienDs();

                        }
                    }
                    cnn.Close();
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTenMon.Text;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                
                
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (txtTenMon.Text != "" && txtSoTin.Text == "")
                    {
                        cmd.CommandText = "search_tenmon";
                        cmd.Parameters.AddWithValue("@TENMON", txtTenMon.Text);
                    }
                    else if (txtTenMon.Text == "" && txtSoTin.Text != "")
                    {
                        cmd.CommandText = "search_sotin";
                        cmd.Parameters.AddWithValue("@SOTIN", txtSoTin.Text);
                    }
                    else
                    {
                        cmd.CommandText = "search_ten_st";
                        cmd.Parameters.AddWithValue("@TENMON", txtTenMon.Text);
                        cmd.Parameters.AddWithValue("@SOTIN", txtSoTin.Text);
                    }



                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("MON"))
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                cnn.Close();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

            Form_Report_Mon frm = new Form_Report_Mon();

            string filter = "1=1";
            if (txtTenMon.Text != "")
            {
                filter = filter + " and {MON.sTenmon} like " + "'" + txtTenMon.Text + "'";
            }
            if (txtSoTin.Text != "")
            {
                filter = filter + " and {MON.iSotin} = " + txtSoTin.Text ;
            }

            dieukienReport = filter;

            frm.ShowReport_Mon();
            frm.Show();
        }
    }
}
