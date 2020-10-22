using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Panel : Form
    {

        List<System.Windows.Forms.Panel> listPanel = new List<System.Windows.Forms.Panel>();
        int index;

        public Panel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Navn_TextChanged(object sender, EventArgs e)
        {

        }

        private int checkCounter = 0;

        private void OnCheckedChanged(CheckBox box)
        {
            // Increase or decrease the check counter

            if (box.Checked == true)
                checkCounter++;

            else
                checkCounter = 0; 

            // prevent checking

            if (checkCounter > 4)
            {
                MessageBox.Show("You can only choose 4 toppings");
                checkCounter = 0;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            //Main 3 Pizza's

            double result;
            double Total1 = 0;
            double Total2 = 0;
            double Antal1;
            double Antal2;

            double pizzaCount = Convert.ToDouble(nrAntal.Value);
            double discountPercent;
            double discount;
            double realTotal = 0;
            double pris;

            if (radioButton1.Checked == true)
            {
                Total1 += 65;
            }

            if (radioButton2.Checked == true)
            {
                Total1 += 75;
            }

            if (radioButton3.Checked == true)
            {
                Total1 += 65;
            }

            if (Large.Checked == true)
            {
                Total1 += Total1 + 65;
            }

            //Drikkevare.

            if (radioButton16.Checked == true)
            {
                Total2 += 3.50;
            }

            if (radioButton17.Checked == true)
            {
                Total2 += 10;
            }

            if (radioButton18.Checked == true)
            {
                Total2 += 10;
            }

            //Make self Pizza.

            if (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked == true)
            {
                Total1 += 13.75;
            }

            if (radioButton7.Checked || radioButton8.Checked || radioButton9.Checked == true)
            {
                Total1 += 13.75;
            }

            if (radioButton10.Checked || radioButton11.Checked || radioButton12.Checked == true)
            {
                Total1 += 13.75;
            }

            if (radioButton13.Checked || radioButton14.Checked || radioButton15.Checked == true)
            {
                Total1 += 13.75;
            }

                OnCheckedChanged(checkBox1);
                OnCheckedChanged(checkBox2);
                OnCheckedChanged(checkBox3);
                OnCheckedChanged(checkBox4);
                OnCheckedChanged(checkBox5);
                OnCheckedChanged(checkBox6);
                OnCheckedChanged(checkBox7);
                OnCheckedChanged(checkBox8);
                OnCheckedChanged(checkBox9);
                OnCheckedChanged(checkBox10);

            if (checkBox1.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox2.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox3.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox4.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox5.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox6.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox7.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox8.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox9.Checked == true)
            {
                Total1 += 5;
            }

            if (checkBox10.Checked == true)
            {
                Total1 += 5;
            }

            //Operations.

            if (pizzaCount == 3)
            {
                discountPercent = 0;
                discount = Total1 * discountPercent;
                realTotal = Total1 - discount;
            }

            

            Antal1 = Convert.ToDouble(nrAntal.Value);
            Total1 = Convert.ToDouble(nrAntal.Value) * Total1;

            Antal2 = Convert.ToDouble(drikkeAntal.Value);
            Total2 = Convert.ToDouble(drikkeAntal.Value) * Total2;

            result = Total1 + Total2;

            pris = result - realTotal;

            //Imprestion.

            txtTotal.Text = pris.ToString("c2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            nrAntal.Value = 1;
            drikkeAntal.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            Large.Checked = false;
        }
    }
}
