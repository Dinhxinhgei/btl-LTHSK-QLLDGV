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
namespace git01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void FormLogin_Load(object sender, EventArgs e)
        {

            userName.Clear();
            password.Clear();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string pass = password.Text;
            if(name == "admin" && pass == "admin")
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("", cnn))
                    {
                        cmd.CommandText = "insert into tbl_user values ( @ma, @tg )";
                        cmd.Parameters.AddWithValue("@ma", "admin");
                        cmd.Parameters.AddWithValue("@tg", DateTime.Now);

                        cnn.Open();
                        int row_af = cmd.ExecuteNonQuery();
                        //if (row_af > 0)
                        //{
                        //    MessageBox.Show("Thêm thành công!");
                        //}
                    }
                }
                Welcome wlc = new Welcome();
                wlc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
