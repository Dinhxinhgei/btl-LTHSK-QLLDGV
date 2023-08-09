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
    public partial class FormLop : UserControl
    {
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public FormLop()
        {
            InitializeComponent();
        }
        private void hienDs()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from LOP", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        }

                    }

                }
            }
        }
        private void FormLop_Load(object sender, EventArgs e)
        {

            hienDs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "" || txtSoSV.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("Them_LOP", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@malop", txtMaLop.Text);
                        cmd.Parameters.AddWithValue("@sosv", txtSoSV.Text);

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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

            Form_Report_Lop frm = new Form_Report_Lop();
            frm.ShowReport_Lop();
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "" && txtSoSV.Text == "")
            {
                MessageBox.Show("nhập đầy đủ thông tin!");
            }
            else
            {
                string filter = "select*from LOP where sMalop IS NOT NULL";
                if (txtMaLop.Text != "")
                {
                    filter = filter + " and sMaLop = @lop ";
                }
                if (txtSoSV.Text != "")
                {
                    filter = filter + " and iSosv = @sl ";
                }

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(filter, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@lop", txtMaLop.Text);
                        cmd.Parameters.AddWithValue("@sl", txtSoSV.Text);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable("LOP"))
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    cnn.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaLop.Text;
            if (txtMaLop.Text == "" || txtSoSV.Text == "")
            {
                MessageBox.Show("nhập đầy đủ thông tin!");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_LOP", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MALOP", ma);
                        cmd.Parameters.AddWithValue("@SOSV", txtSoSV.Text);

                        int row_af = cmd.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            ResetValue();
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
                    cmd.CommandText = "DELETE_LOP";
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);

                    int row_af = 0;
                    try
                    {
                        row_af = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lớp đang trong quá trình dạy. Không thể xóa");
                    }
                    if (row_af > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        ResetValue();
                        hienDs();

                    }
                }
                cnn.Close();


            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        private void ResetValue()
        {
            txtMaLop.ResetText();
            txtSoSV.ResetText();

        }
    }
}
