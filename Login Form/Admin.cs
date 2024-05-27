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
    public partial class Admin : Form
    {
        public string price_FriedRice = "150";
        public string price_Noodles = "100";
        public string price_Pasta = "120";
        public string price_Sandwitch = "80";
        public string price_Bread = "80";
        public string price_Parata = "100";
        public string price_Thosai = "120";
        public string price_StringHoppers = "70";
        public string price_Rice = "50";
        public string price_Hopper= "100";


        public string FriedRice = "FriedRice";
        public string Noodles = "Noodles";
        public string Pasta = "Pasta";
        public string Sandwitch = "Sandwitch";
        public string Bread = "Bread";
        public string Parata = "Parata ";
        public string Thosai = "Thosai";
        public string OrangeJuice = "OrangeJuice";
        public string StringHoppers = "StringHoppers";
        public string Rice = "Rice";


        public string temp;
        public string selectedFoodItem = null;
        public string newFood;
        public string newPrice;

        public Admin()
        {
            InitializeComponent();
          //  this.temp = x;
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            /* Items food = new Items();
             food.Show
             this.Hide();*/

            MessageBox.Show("customer orders ...","orders",MessageBoxButtons.OK,MessageBoxIcon.Information);
              


        }



        private void Btn_AvailableFoodItems_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(FriedRice);
            listBox1.Items.Add(Noodles);
            listBox1.Items.Add(Pasta);
            listBox1.Items.Add(Sandwitch);
            listBox1.Items.Add(Bread);
            listBox1.Items.Add(Parata);
            listBox1.Items.Add(Thosai);
            listBox1.Items.Add(OrangeJuice);
            listBox1.Items.Add(Rice);




            listBox2.Items.Add(price_FriedRice);
            listBox2.Items.Add(price_Noodles);
            listBox2.Items.Add(price_Pasta);
            listBox2.Items.Add(price_Sandwitch);
            listBox2.Items.Add(price_Bread);
            listBox2.Items.Add(price_Parata);
            listBox2.Items.Add(price_Thosai);
            listBox2.Items.Add(price_StringHoppers);
            listBox2.Items.Add(price_Rice);
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            selectedFoodItem = listBox1.SelectedItem.ToString();
            textBoxNewName.Text = selectedFoodItem;
            if (selectedFoodItem == "FriedRice")
            {
                textBoxNewPrice.Text = price_FriedRice;
            }
            else if (selectedFoodItem == "Noodles")
            {
                textBoxNewPrice.Text = price_Noodles;
                Noodles = textBoxEnterNewName.Text;
                price_Noodles = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Pasta")
            {
                textBoxNewPrice.Text = price_Pasta;
                Pasta = textBoxEnterNewName.Text;
                price_Pasta = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Sandwitch")
            {
                textBoxNewPrice.Text = price_Sandwitch;
                Sandwitch = textBoxEnterNewName.Text;
                price_Sandwitch = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Bread")
            {
                textBoxNewPrice.Text = price_Bread;
                Bread = textBoxEnterNewName.Text;
                price_Bread = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Parata ")
            {
                textBoxNewPrice.Text = price_Parata;
                Parata = textBoxEnterNewName.Text;
                price_Parata = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Thosai")
            {
                textBoxNewPrice.Text = price_Thosai;
                Thosai = textBoxEnterNewName.Text;
                price_Thosai = textBoxEnterNewPrice.Text;
            }
           
            else if (selectedFoodItem == "Rice")
            {
                textBoxNewPrice.Text = price_Rice;
                Rice = textBoxEnterNewName.Text;
                price_Rice = textBoxEnterNewPrice.Text;
            }
           

            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (selectedFoodItem == "FriedRice")
            {
                FriedRice = textBoxEnterNewName.Text;
                price_FriedRice = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Noodles")
            {
                Noodles = textBoxEnterNewName.Text;
                price_Noodles = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Pasta")
            {
                Pasta = textBoxEnterNewName.Text;
                price_Pasta = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Sandwitch")
            {
                Sandwitch = textBoxEnterNewName.Text;
                price_Sandwitch = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Bread")
            {
                Bread = textBoxEnterNewName.Text;
                price_Bread = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Parata ")
            {
                Parata = textBoxEnterNewName.Text;
                price_Parata = textBoxEnterNewPrice.Text;
            }
            else if (selectedFoodItem == "Thosai")
            {
                Thosai = textBoxEnterNewName.Text;
                price_Thosai = textBoxEnterNewPrice.Text;
            }
           

            newFood = textBoxNewFoodName.Text;
            newPrice = textBoxNewFoodPrice.Text;
        }

        private void textBoxNewFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
               listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add(FriedRice);
            listBox1.Items.Add(Noodles);
            listBox1.Items.Add(Pasta);
            listBox1.Items.Add(Sandwitch);
            listBox1.Items.Add(Bread);
            listBox1.Items.Add(Parata);
            listBox1.Items.Add(Thosai);
            listBox1.Items.Add(OrangeJuice);
           
            listBox1.Items.Add(newFood+listBox1.Items);

            listBox2.Items.Add(price_FriedRice);
            listBox2.Items.Add(price_Noodles);
            listBox2.Items.Add(price_Pasta);
            listBox2.Items.Add(price_Sandwitch);
            listBox2.Items.Add(price_Bread);
            listBox2.Items.Add(price_Parata);
            listBox2.Items.Add(price_Thosai);
           
            listBox2.Items.Add(newPrice);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {    
                listBox1.Items.Remove(listBox1.SelectedItem);

                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("no item selected", "item selection", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confom you want to exit the system", "Admin page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
