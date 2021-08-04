using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinalProject
{
    public partial class Eftpos : Form
    {
        Form1 form1 = new Form1(); // form 1 linked with eftpos form
        public Eftpos()
        {
          
            InitializeComponent();
            eftposamount.Text = Form1.SetValueForText1;
            Proccessing.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)// 100 doller note
        {
            int money = 100;
            if (eftposamount.Text == null)
            {
                MessageBox.Show("Please Select Items First Thank you");
            }
            else
            {
            label1.Text = "Change  = " + (money - Convert.ToDouble(eftposamount.Text)).ToString();

            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)   // 50 doller note
        {
            int money = 50;
            label1.Text = "Change Give to Customer = " + (money - Convert.ToDouble(eftposamount.Text)).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)// 200 doller note
        {
            int money = 20;
            label1.Text = "Change Give to Customer = " + (money - Convert.ToDouble(eftposamount.Text)).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)// 10 doller note
        {
            int money = 10;
            label1.Text = "Change Give to Customer = " + (money - Convert.ToDouble(eftposamount.Text)).ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)// 5 doller note
        {
            int money = 5;
            label1.Text = "Change = " + (money - Convert.ToDouble(eftposamount.Text)).ToString();
        }

         
               
         

        private void TotalAmount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(TotalAmount.Text)> 0)
            {
                btnok.Enabled = false;
            }



        }

        private void Cashoutamount_TextChanged(object sender, EventArgs e)
        {

            //decimal sum = Convert.ToDecimal(eftposamount.Text + Convert.ToDecimal(Cashoutamount.Text));

            //if (Convert.ToDouble(Cashoutamount.Text) > 0)
            //{
            //    sum += Convert.ToDecimal(Cashoutamount.Text + eftposamount.Text);
            //}
            //TotalAmount.Text += sum.ToString();

            
        }

        private void eftposamount_KeyDown(object sender, KeyEventArgs e)   // eftposamount 
        {
            if (e.KeyCode == Keys.Enter)
            {

                decimal a, b;
                a = Decimal.Parse(eftposamount.Text);
                b = Decimal.Parse(Cashoutamount.Text);
                TotalAmount.Text = (a + b).ToString();
            }
        }

        private void Cashoutamount_KeyDown_1(object sender, KeyEventArgs e) // cashout amount 
        {
            if (e.KeyCode == Keys.Enter)
            {

                decimal a, b;
                a = Decimal.Parse(eftposamount.Text);
                b = Decimal.Parse(Cashoutamount.Text);
                TotalAmount.Text = (a + b).ToString();
                btnok.Enabled = true;

            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Proccessing.Show();

        }

        private void OK_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       

        private void TotalAmount_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Fill Cash out Amount And  Press Enter");

        }

        
    }
}
