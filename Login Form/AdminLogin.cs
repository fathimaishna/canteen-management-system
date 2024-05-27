using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class AdminLogin : Form
    {   
        public Boolean isLogName = false;
        public Boolean isLogPwd = false;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void txtAdminName_TextChanged(object sender, EventArgs e)
        {   
            if(txtAdminName.Text == "Admin")
                isLogName = true;
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "123")
                isLogPwd = true;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (isLogName == true)
            {
                MessageBox.Show("Welcome Admin!!");
                this.Hide();
          Admin fm = new Admin();
            fm.Show();
            }
            else {
                MessageBox.Show("Access Denied!!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
         Form1 fm = new Form1();
            fm.Show();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
