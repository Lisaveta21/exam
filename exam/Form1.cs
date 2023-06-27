using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        private int petrol72 = 25;
        private int petrol80 = 28;
        private int petrol92 = 38;
        private int petrol93 = 39;
        private int petrol95 = 40;
        private int petrol98 = 42;
        private int petrolDT = 38;

        public Form1()
        {
            InitializeComponent();
            textBoxCoffee.Text = "56";
            textBoxChips.Text = "66";
            textBoxHotdogs.Text = "76";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            if (comboBoxOil.Text == "А-95")
            {
                textBoxPrice.Text = petrol95.ToString();
                textBoxPriceRub.Focus();
            }

            else if (comboBoxOil.Text == "А-98")
            {
                textBoxPrice.Text = petrol98.ToString();
                textBoxPriceRub.Focus();
            }

            else if (comboBoxOil.Text == "ДТ")
            {
                textBoxPrice.Text = petrolDT.ToString();
                textBoxPriceRub.Focus();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panelPaymentone.Text = "К выдаче:";
                textBoxPriceLiter.Enabled = false;
                textBoxPriceRub.Enabled = true;
                textBoxPriceRub.Focus();
                labelOilLiter.Text = "л.";
            }
            else
            {
                textBoxPriceLiter.Text = null;
                textBoxPriceLiter.Enabled = false;
                   }
            }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panelPaymentone.Text = "К оплате:";
                textBoxPriceRub.Enabled = false;
                textBoxPriceLiter.Enabled = true;
                textBoxPriceLiter.Focus();
            }
            else
            {
                textBoxPriceLiter.Text = null;
                textBoxPriceLiter.Enabled = false;
            }
        }

        private void checkBoxCoffee_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBoxCoffee.Checked)
            {
                textBoxCoffee.Enabled = false;

                comboBoxAmountCoffee.SelectedIndex = 0;
                
               textBoxCoffee.Text = string.Format("{0}", int.Parse(textBoxCoffee.Text) * int.Parse(comboBoxAmountCoffee.Text));
               
            }
            else
            { 
                textBoxCoffee.Text = null;
                textBoxTotalCafe.Enabled = false;
                

            }
        }

        private void checkBoxHotdogs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotdogs.Checked)
            {
                textBoxHotdogs.Enabled = false;

                comboBoxHotdogsAmount.SelectedIndex = 0;


                textBoxCoffee.Text = string.Format("{0}", int.Parse(textBoxHotdogs.Text) * int.Parse(comboBoxHotdogsAmount.Text));
            }
            else
            {
                textBoxHotdogs.Text = null;
                textBoxTotalCafe.Enabled = false;


            }
        }

        private void checkBoxChips_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBoxChips.Checked)
            {
                textBoxChips.Enabled = false;
                comboBoxChipsAmount.SelectedIndex = 0;
                textBoxTotalCafe.Focus();
                
               

                    textBoxCoffee.Text = string.Format("{0}", int.Parse(textBoxChips.Text) * int.Parse(comboBoxChipsAmount.Text));
               
               

            }
            else
            {
                textBoxChips.Text = null;
                textBoxTotalCafe.Enabled = false;


            }
        }
    

        private void textBoxTotalCafe_TextChanged(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBoxChips.Text) + Convert.ToInt32(textBoxHotdogs.Text) + Convert.ToInt32(textBoxCoffee.Text);
            Console.WriteLine(a);


        }


        private void paneltotalpayment_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxChips.Text) + Convert.ToInt32(textBoxHotdogs.Text) + Convert.ToInt32(textBoxCoffee.Text);
            Console.WriteLine(a);
        }

        private void textBoxCoffee_TextChanged(object sender, EventArgs e)
        {
           
          
        }
        //Оплата всего и за кафе и за бензин

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBoxPriceLiter.Text) + Convert.ToInt32(textBoxTotalCafe);
            Console.WriteLine(s);
        }
    }


}

    