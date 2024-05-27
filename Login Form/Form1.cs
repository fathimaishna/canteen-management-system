using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace Login_Form
{

    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                  Items na = new Items();
                    na.Show();







                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();

            }


        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            

            this.Hide();
            registerPage frm2 = new registerPage();
            frm2.ShowDialog();
        }



        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
      
       
        private void btnClearU_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

       
        private void btnClearP_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnClearU_MouseHover(object sender, EventArgs e)
        {
            btnClearU.ForeColor = Color.Red;
        }

        

        private void btnClearU_MouseLeave(object sender, EventArgs e)
        {
            btnClearU.ForeColor = Color.Black;

        }

        private void btnClearP_MouseHover(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.Red;
        }

        private void btnClearP_MouseLeave(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.Black;

        }

        private void bnCreate_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.Aqua;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.Aqua;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.WhiteSmoke;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnClearP.ForeColor = Color.WhiteSmoke;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adm = new AdminLogin();
            adm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
