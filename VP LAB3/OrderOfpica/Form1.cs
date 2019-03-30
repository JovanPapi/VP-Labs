using System;
using System.Windows.Forms;

namespace OrderOfpica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void calculateTotal()
        {
            int box1 = 0, box2 = 0, box31 = 0, box32 = 0, box33 = 0, box4 = 0;
            try
            {
                if (rbSmall.Checked)
                {
                    int.TryParse(txtSmall.Text, out box1);

                }
                if (rbMedium.Checked)
                {
                    int.TryParse(txtMedium.Text, out box1);
                }
                if (rbLarge.Checked)
                {
                    int.TryParse(txtLarge.Text, out box1);
                }
            }catch(Exception e) { MessageBox.Show("Cannot have an empty input!");  }
            
            try
            {
                if (cbSpices.Checked)
                {
                    box2 += int.Parse(txtSpices.Text);
                }
                if (cbCheese.Checked)
                {
                    box2 += int.Parse(txtCheese.Text);
                }
                if (cbKetchup.Checked)
                {
                    box2 += int.Parse(txtKetchup.Text);
                }
            }catch(Exception e) { MessageBox.Show("Cannot have empty input!"); }

            try
            {
                box31 = int.Parse(txtQuantityCocaCola.Text) * int.Parse(txtPriceCocaCola.Text);
                box32 = int.Parse(txtQuantityJuice.Text) * int.Parse(txtPriceJuice.Text);
                box33 = int.Parse(txtQuantityBeer.Text) * int.Parse(txtPriceBeer.Text);
            }
            catch(Exception e) {MessageBox.Show("Cannot have empty input!"); }
            
            txtTotalPriceCocaCola.Text = Convert.ToString(box31);

            txtTotalPriceJuice.Text = Convert.ToString(box32);

            txtTotalPriceBeer.Text = Convert.ToString(box33);

            if(txtPriceOfTheDesert.Text == "0" && lbDeserts.SelectedIndex != -1)
            {
                if(lbDeserts.SelectedItem.ToString().Equals("Fruit pie"))
                {
                    txtPriceOfTheDesert.Text = "140";
                }
                else if(lbDeserts.SelectedItem.ToString().Equals("Cake"))
                {
                    txtPriceOfTheDesert.Text = "210";
                }
                else if(lbDeserts.SelectedItem.ToString().Equals("Ice cream"))
                {
                    txtPriceOfTheDesert.Text = "90";
                }

            }

            box4 = int.Parse(txtPriceOfTheDesert.Text);
            
            txtTotalPrice.Text = Convert.ToString(box1 + box2 + box31 + box32 + box33 + box4);

            int payed = 0;
            int.TryParse(txtPayed.Text, out payed);
            int change = 0;

            change = int.Parse(txtTotalPrice.Text) - payed;

            if (payed == 0)
                txtChange.Text = "0";
            else
                txtChange.Text = Convert.ToString(change); 
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSmall_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtMedium_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtLarge_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbSpices_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtSpices_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtCheese_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtKetchup_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtQuantityCocaCola_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPriceCocaCola_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtQuantityJuice_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPriceJuice_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtQuantityBeer_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPriceBeer_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void lbDeserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPriceOfTheDesert.Text = "0";
            calculateTotal();
        }

        private void txtPriceOfTheDesert_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void txtPayed_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s = "";
            if (rbSmall.Checked)
                s += "Small pizza\n";
            if (rbMedium.Checked)
                s += "Medium pizza\n";
            if (rbLarge.Checked)
                s += "Large pizza\n";

            if(cbSpices.Checked || cbCheese.Checked || cbKetchup.Checked)
            {
                s += "Features:\n";
                if (cbSpices.Checked)
                    s += "Spices\n";
                if (cbCheese.Checked)
                    s += "Extra Cheese\n";
                if (cbKetchup.Checked)
                    s += "Ketchup\n";
            }

            if(txtQuantityCocaCola.Text != "0" 
                || txtQuantityJuice.Text != "0"
                || txtQuantityBeer.Text != "0")
            {
                s += "Drinks:\n";
                if (txtQuantityCocaCola.Text != "0")
                    s += txtQuantityCocaCola.Text + " " + label1.Text + "\n";
                if (txtQuantityBeer.Text != "0")
                    s += txtQuantityBeer.Text + " " + label2.Text + "\n";
                if (txtQuantityJuice.Text != "0")
                    s += txtQuantityJuice.Text + " " + label3.Text + "\n";
            }

            if (lbDeserts.SelectedIndex != -1)
                s += "Deserts:\n" +
                    lbDeserts.SelectedItem.ToString();

            MessageBox.Show(s);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure u want to cancel the order ?","Dialog2",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
