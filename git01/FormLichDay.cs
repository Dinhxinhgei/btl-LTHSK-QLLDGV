using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace git01
{
    public partial class FormLichDay : UserControl
    {
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public static string dieukienReport = "";

        public FormLichDay()
        {
            InitializeComponent();
        }

        private void FormLichDay_Load(object sender, EventArgs e)
        {
            hienDs();

        }
        SqlConnection cnn = new SqlConnection(constr);
        private void ketnoi()
        {
            cnn.Open();
            string sql = "select dNgayday, sCaday, sTengv, sTenmon, LICHDAY.sMalop, LICHDAY.sMap, iSosv, sTrangthai, sGhichu " +
                            "from LICHDAY "+
                            "INNER JOIN GIANGVIEN ON LICHDAY.sMagv = GIANGVIEN.sMagv "+
                            "INNER JOIN MON ON MON.sMamon = LICHDAY.sMamon "+
                            "INNER JOIN LOP ON LOP.sMalop = LICHDAY.sMalop ";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
            //dNgayday.Value.Date.ToString("yyyy/MM/dd");
            //dataGridView1.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
        }
        private void hienDs()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {

                
                ketnoi();//lay datagritview
                using (SqlCommand cmd = new SqlCommand("select dNgayday from THOIGIAN  group by dNgayday", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbbNgay.ValueMember = "dNgayday";
                        cbbNgay.DataSource = dt;
                    }

                }
                using (SqlCommand cmd = new SqlCommand("select sMagv,sTengv from GIANGVIEN", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        /*cbbMaGV.DisplayMember = "sTengv";*/
                        cbbMaGV.ValueMember = "sMagv";
                        cbbMaGV.DataSource = dt;
                    }

                }
                using (SqlCommand cmd = new SqlCommand("select sMamon,sTenmon from MON", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        /*cbbMaMon.DisplayMember = "sTenmon";*/
                        cbbMaMon.ValueMember = "sMamon";
                        cbbMaMon.DataSource = dt;
                    }

                }
                using (SqlCommand cmd = new SqlCommand("select sMalop from LOP", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbbMaLop.ValueMember = "sMalop"; 
                        if (cbbMaLop.DataSource != null)
                        cbbMaLop.Enabled = true;
                        cbbMaLop.DataSource = dt;
                    }

                }

                using (SqlCommand cmd = new SqlCommand("select sMap from PHONG", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbbMaPhg.ValueMember = "sMap";
                        if (cbbMaPhg.DataSource != null)
                        cbbMaLop.Enabled = true;
                        
                        cbbMaPhg.DataSource = dt;
                    }

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    /*DataRowView oDataRowView_gv = cbbMaGV.SelectedItem as DataRowView;
                    DataRowView oDataRowView_mon = cbbMaMon.SelectedItem as DataRowView;
                    string magv = string.Empty;
                    string mamon = string.Empty;

                    if (oDataRowView_gv != null)
                    {
                        magv = oDataRowView_gv.Row["sMagv"] as string;
                    }
                    if (oDataRowView_mon != null)
                    {
                        mamon = oDataRowView_mon.Row["sMamon"] as string;
                    }*/
                    string magv = cbbMaGV.Text;
                    string mamon = cbbMaMon.Text;
                    cmd.CommandText = "themLichday";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngayday", Convert.ToDateTime(cbbNgay.Text));
                        
                    cmd.Parameters.AddWithValue("@caday", cbbCaDay.Text);
                    cmd.Parameters.AddWithValue("@magv", magv);
                    cmd.Parameters.AddWithValue("@mamon", mamon);
                    cmd.Parameters.AddWithValue("@malop", cbbMaLop.Text);
                    cmd.Parameters.AddWithValue("@map", cbbMaPhg.Text);
                    cmd.Parameters.AddWithValue("@trangthai", cbbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                    cnn.Open();
                    int row_af = cmd.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                }
            ResetValue();
            hienDs();
            }
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "Delete from LICHDAY where dNgayday=@ngay and sCaday=@ca and sMagv=@gv and sMamon=@mon and sMalop=@lop and sMap=@phong"
                        , con))
                    {

                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@ngay", Convert.ToDateTime(cbbNgay.Text));
                        cm.Parameters.AddWithValue("@ca", cbbCaDay.Text);
                        cm.Parameters.AddWithValue("@gv", cbbMaGV.Text);
                        cm.Parameters.AddWithValue("@mon", cbbMaMon.Text);
                        cm.Parameters.AddWithValue("@lop", cbbMaLop.Text);
                        cm.Parameters.AddWithValue("@phong", cbbMaPhg.Text);
                        con.Open();
                        int row_af = cm.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                    }

                }
                ResetValue();
                hienDs();
            }
        }
        private void ResetValue()
        {
            cbbNgay.Text = "";
            cbbCaDay.Text = "";
            cbbMaGV.Text = "";
            cbbMaMon.Text = "";
            cbbMaLop.Text = "";
            cbbMaPhg.Text = "";
            cbbTrangThai.Text = "";
            txtGhiChu.Text = "";
            TimeToSearch.Text = "";

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Form_Report_LichDay frm = new Form_Report_LichDay();
            //báo cáo theo ngày dạy, ca dạy, trạng thái, mã phòng

            string filter = "1=1";
            if (cbbNgay.Text != "")
            {
                DateTime time = Convert.ToDateTime(cbbNgay.Text);
                filter += " and {LICHDAY.dNgayday} = '" + String.Format("{0:yyy-MM-dd}", time)+"'";
            }
            if (cbbCaDay.Text != "")
            {
                filter = filter + " and {LICHDAY.sCaday} = " + "N'" + cbbCaDay.Text +"'";
            }
            if (cbbTrangThai.Text != "")
            {
                filter = filter + " and {LICHDAY.sTrangthai} = " + "N'" + cbbTrangThai.Text + "'";
            }
            if (cbbMaPhg.Text != "")
            {
                filter = filter + " and {LICHDAY.sMap} = " + "'" + cbbMaPhg.Text + "'";

            }

            dieukienReport = filter;

            frm.ShowReport_LichDay();
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            
            if(cbbNgay.Text == "" &&cbbMaGV.Text =="" &&cbbMaMon.Text=="" && cbbMaLop.Text =="" && cbbCaDay.Text == "" && cbbTrangThai.Text == "" && cbbMaPhg.Text == ""&& TimeToSearch.CustomFormat == " ")
            {
                MessageBox.Show("Thiếu dữ liệu!");
            }
            else
            {
                DataRowView oDataRowView_gv = cbbMaGV.SelectedItem as DataRowView;
                DataRowView oDataRowView_mon = cbbMaMon.SelectedItem as DataRowView;
                string magv = string.Empty;
                string mamon = string.Empty;

                if (oDataRowView_gv != null)
                {
                    magv = oDataRowView_gv.Row["sMagv"] as string;
                }
                if (oDataRowView_mon != null)
                {
                    mamon = oDataRowView_mon.Row["sMamon"] as string;
                }
                string filter = "select*from vv_select_lichday where dNgayday IS NOT NULL";
                if (cbbNgay.Text != "")
                {
                    filter = "select*from vv_select_lichday where dNgayday = @cbngayday ";
                }
                if (TimeToSearch.CustomFormat != " ")
                {
                    filter = "select*from vv_select_lichday where dNgayday = @time_loc ";
                }
                if (cbbMaGV.Text != "")
                {
                    filter = filter + " and sMagv = @gv ";
                    MessageBox.Show(filter);
                }
                if (cbbMaMon.Text != "")
                {
                    filter = filter + " and sMamon = @mon ";
                }
                if (cbbCaDay.Text != "")
                {
                    filter = filter + " and sCaday = @ca ";
                }
                if (cbbMaLop.Text != "")
                {
                    filter = filter + " and sMalop = @lop ";
                }
                if (cbbTrangThai.Text != "")
                {
                    filter = filter + " and sTrangthai = @tt ";
                }
                if (cbbMaPhg.Text != "")
                {
                    filter = filter + " and sMap = @phong ";

                }
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(filter, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        if (TimeToSearch.CustomFormat != " ")
                            cmd.Parameters.AddWithValue("@time_loc", Convert.ToDateTime(TimeToSearch.Text));
                        if (cbbNgay.Text != "")
                            cmd.Parameters.AddWithValue("@cbngayday", Convert.ToDateTime(cbbNgay.Text));

                        cmd.Parameters.AddWithValue("@gv", magv);
                        cmd.Parameters.AddWithValue("@mon", mamon);
                        cmd.Parameters.AddWithValue("@lop", cbbMaLop.Text);
                        cmd.Parameters.AddWithValue("@ca", cbbCaDay.Text);
                        cmd.Parameters.AddWithValue("@tt", cbbTrangThai.Text);
                        cmd.Parameters.AddWithValue("@phong", cbbMaPhg.Text);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable("vv_select_lichday"))
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

        private void TimeToSearch_ValueChanged(object sender, EventArgs e)
        {

            if (!TimeToSearch.Checked)// không muốn chọn ngày
            {
                TimeToSearch.CustomFormat = " ";
            }
            else TimeToSearch.CustomFormat = "dd/MM/yyyy";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            hienDs();
        }
    }
}
