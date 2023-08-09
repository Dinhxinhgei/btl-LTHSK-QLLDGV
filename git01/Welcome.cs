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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        static string constr = @"Data Source=DESKTOP-5VLMAN1\SQLEXPRESS;Initial Catalog = BTL01; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        bool closeForm = true;
        private void danhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {


            body.Controls.Clear();
            body.Controls.Add(new FormMon());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {


            body.Controls.Clear();
            body.Controls.Add(new img_wlc());
        }

        private void danhSáchGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            body.Controls.Clear();
            body.Controls.Add(new FormGiangVien());
        }

        private void danhSáchLịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();
            body.Controls.Add(new FormLichDay());
        }

        private void danhSáchLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();
            body.Controls.Add(new FormLop());

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            FormLogin sh = new FormLogin();
            sh.Show();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeForm)
                Application.Exit();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();
            body.Controls.Add(new img_wlc());
        }
        private string name_u = "admin";
        private void thôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("tài khoản: " + name_u);
        
    }
    }
}
