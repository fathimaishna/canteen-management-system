using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderPage
{
    public partial class frm_Item : Form
    {
        const double price_FriedRice = 150;
        const double price_Noodles = 100;
        const double price_Pasta = 120;
        const double price_Sandwitch = 80;
        const double price_Bread = 80;
        const double price_Tea = 100;
        const double price_Nestea = 120;
        const double price_OrngJuice = 70;
        const double price_LmnJuice = 50;
        const double price_Faluda = 100;

        public frm_Item()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the system",
                "Ordering page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_Item_Load(object sender, EventArgs e)
        {
            Cmb_Payment.Items.Add(" ");
            Cmb_Payment.Items.Add("Cash");
            Cmb_Payment.Items.Add("Cash on Delivery");

            EnableTextBoxes();
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }


        private void Chk_Frdrice_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Frdrice.Checked == true)
            {
                Txt_Frdrice.Enabled = true;
                Txt_Frdrice.Text = "";
                Txt_Frdrice.Focus();
            }
            else
            {
                Txt_Frdrice.Enabled = false;
                Txt_Frdrice.Text = "0";
            }
        }

        private void Chk_Noodles_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Noodles.Checked == true)
            {
                Txt_Noodles.Enabled = true;
                Txt_Noodles.Text = "";
                Txt_Noodles.Focus();
            }
            else
            {
                Txt_Noodles.Enabled = false;
                Txt_Noodles.Text = "0";
            }
        }

        private void Chk_Pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Pasta.Checked == true)
            {
                Txt_Pasta.Enabled = true;
                Txt_Pasta.Text = "";
                Txt_Pasta.Focus();
            }
            else
            {
                Txt_Pasta.Enabled = false;
                Txt_Pasta.Text = "0";
            }
        }

        private void Chk_Sandwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Sandwitch.Checked == true)
            {
                Txt_Sandwitch.Enabled = true;
                Txt_Sandwitch.Text = "";
                Txt_Sandwitch.Focus();
            }
            else
            {
                Txt_Sandwitch.Enabled = false;
                Txt_Sandwitch.Text = "0";
            }
        }

        private void Chk_Bread_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Bread.Checked == true)
            {
                Txt_Bread.Enabled = true;
                Txt_Bread.Text = "";
                Txt_Bread.Focus();
            }
            else
            {
                Txt_Bread.Enabled = false;
                Txt_Bread.Text = "0";
            }
        }

        private void Chk_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Tea.Checked == true)
            {
                Txt_Tea.Enabled = true;
                Txt_Tea.Text = "";
                Txt_Tea.Focus();
            }
            else
            {
                Txt_Tea.Enabled = false;
                Txt_Tea.Text = "0";
            }
        }

        private void Chk_Nestea_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Nestea.Checked == true)
            {
                Txt_Nestea.Enabled = true;
                Txt_Nestea.Text = "";
                Txt_Nestea.Focus();
            }
            else
            {
                Txt_Nestea.Enabled = false;
                Txt_Nestea.Text = "0";
            }
        }

        private void Chk_Orng_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Orng.Checked == true)
            {
                Txt_Orng.Enabled = true;
                Txt_Orng.Text = "";
                Txt_Orng.Focus();
            }
            else
            {
                Txt_Orng.Enabled = false;
                Txt_Orng.Text = "0";
            }
        }

        private void Chk_Lemon_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Lemon.Checked == true)
            {
                Txt_Lemon.Enabled = true;
                Txt_Lemon.Text = "";
                Txt_Lemon.Focus();
            }
            else
            {
                Txt_Lemon.Enabled = false;
                Txt_Lemon.Text = "0";
            }
        }

        private void Chk_Faluda_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Faluda.Checked == true)
            {
                Txt_Faluda.Enabled = true;
                Txt_Faluda.Text = "";
                Txt_Faluda.Focus();
            }
            else
            {
                Txt_Faluda.Enabled = false;
                Txt_Faluda.Text = "0";
            }
        }

        private void Cmb_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Payment.Text == "Cash")
            {
                Txt_Payment.Enabled = true;
                Txt_Payment.Text = "";
                Txt_Payment.Focus();
            }
            else if (Cmb_Payment.Text == "Cash on Delivery")
            {
                Txt_Name.Enabled = true;
                Txt_Address.Enabled = true;
                Txt_Contact.Enabled = true;
                Txt_Name.Text = "";
                Txt_Contact.Text = "";
                Txt_Address.Text = "";
                Txt_Name.Focus();
                Txt_Address.Focus();
                Txt_Contact.Focus();
            }
            else
            {
                Txt_Payment.Enabled = false;
                Txt_Payment.Text = "0";
            }
        }

        private void Btn_total_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(Txt_Frdrice.Text) * price_FriedRice;
            itemcost[1] = Convert.ToDouble(Txt_Noodles.Text) * price_Noodles;
            itemcost[2] = Convert.ToDouble(Txt_Pasta.Text) * price_Pasta;
            itemcost[3] = Convert.ToDouble(Txt_Sandwitch.Text) * price_Sandwitch;
            itemcost[4] = Convert.ToDouble(Txt_Bread.Text) * price_Bread;
            itemcost[5] = Convert.ToDouble(Txt_Tea.Text) * price_Tea;
            itemcost[6] = Convert.ToDouble(Txt_Nestea.Text) * price_Nestea;
            itemcost[7] = Convert.ToDouble(Txt_Orng.Text) * price_OrngJuice;
            itemcost[8] = Convert.ToDouble(Txt_Lemon.Text) * price_LmnJuice;
            itemcost[9] = Convert.ToDouble(Txt_Faluda.Text) * price_Faluda;

            double total, payment, cost;
            if (Cmb_Payment.Text == "Cash")
            {
                total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                    itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9];

                Lbl_Result.Text = total.ToString();

                payment = Convert.ToInt32(Txt_Payment.Text);
                cost = payment - total;
                Lbl_Changeresult.Text = cost.ToString();
            }
            else
            {
                total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                   itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9];

                Lbl_Result.Text = total.ToString();

            }

        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            RestTextBox();
        }
        private void RestTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(Controls);
            };
            func(Controls);
        }
        private void RestCheckBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = "0";
                    else
                        func(Controls);
            };
            func(Controls);
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing our Canteen!!");
        }
    }

}


