using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MyFinalProject
{

    public partial class Form1 : Form
    {    // variables Dollers give by customers 
        int dollerhun = +100;
        int dollerfifty = +50;
        int dollertwenty = +20;
        int dollerten = +10;
        int dollerfive = +5;
        
        // amount value tranfer from one form to another
        public static string SetValueForText1 = "";
        public  Form1()
        {
           
            Thread t = new Thread(new ThreadStart(stratform));
            t.Start();
            Thread.Sleep(3000);
            

            InitializeComponent();
            t.Abort();
            
            enterpaymentmethod.Hide(); // Groupbox hide 
            balancebox.Hide();
            btnClear.Hide();
            POSTBOX.Hide();
            Phonetop.Hide();
            button12.Enabled = false; // button disable
            btnpending.Enabled = false;
          

        }
        public void stratform()
        {
            Application.Run(new Form3());
        }
        int a = 0;
        private void button11_Click(object sender, EventArgs e) // Miscellaneous Grocery 
        {
            POSTBOX.Show();
            post1.Text = "Miscellaneous";
        }

        private void oxfordpie_Click(object sender, EventArgs e)  // product item
        {
            a++;
            if (a > 1)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
            listBox1.Items.Add("oxford pie");
            listBox2.Items.Add(a * 3.99);

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)

            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void SingleIrvines_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Single Irevine pie");
            listBox2.Items.Add("1.99");

        }

        private void button33_Click(object sender, EventArgs e)
        {
            POSTBOX.Show();
        }

        private void pie3for5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Irevine pies 3 For $5");
            listBox2.Items.Add("5.00");
        }

        private void Lunchpaack_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Lunch Pack ");
            listBox2.Items.Add("2.50");
        }

        private void piecombo_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Pie Combo");
            listBox2.Items.Add("3.50");
        }

        private void Chips2for5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Chips 2 For $5");
            listBox2.Items.Add("5.00");
        }




        private void drinksspecial_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Drinks 3 For $5.00");
            listBox2.Items.Add("5.00");
        }

        private void SD2for5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Small Drinks 2 For $5.00");
            listBox2.Items.Add("5.00");
        }

        private void drinks2for6_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Drinks 2 For $6.50");
            listBox2.Items.Add("6.50");
        }

        private void v2for7_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("V Drinks Cans 2 For $7.00");
            listBox2.Items.Add("7.00");
        }

        private void Singledrink_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Single Drink");
            listBox2.Items.Add("1.39");
        }

        private void singlecan_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Single V Drink Can");
            listBox2.Items.Add("1.99");
        }

        private void milks2for6_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Milks 2 For  $6.49");
            listBox2.Items.Add("6.49");
        }

        private void standardmilk_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Standard Milk");
            listBox2.Items.Add("3.49");
        }

        private void butter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Butter");
            listBox2.Items.Add("10.00");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sale_Click(object sender, EventArgs e) // no sale button when someone click cash box opend with any sale enetry
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            totalsum.Text = "";
            MessageBox.Show("No sale  Cash Box Opened ");
            

        }


        public void mouse(object sender, MouseEventArgs e)  // clicl event total amlount added by selecting product items
        {
            decimal sum = 0;
           
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                
                sum += Convert.ToDecimal(listBox2.Items[i]);
            }
            totalsum.Text = sum.ToString();
           
        }

        private void oxfordpie_Click_1(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Oxford pie");
            listBox2.Items.Add("3.99");
        }

        private void milkpowder_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Powder Milk");
            listBox2.Items.Add("7.99");
        }

        private void eggs12_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Eggs 12 Pack");
            listBox2.Items.Add("6.99");
        }

        private void eggs6_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Eggs 6 Pack");
            listBox2.Items.Add("4.99");
        }

        private void trayegg_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("One Tray Egg");
            listBox2.Items.Add("11.99");
        }

        private void couplandbread_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Couplands Bread");
            listBox2.Items.Add("1.29");
        }

        private void bread4_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Bread 4 For $5");
            listBox2.Items.Add("5.00");
        }

        private void Eliquid30_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("E Liquid 30ml");
            listBox2.Items.Add("19.99");
        }

        private void eliquid10_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("E Liquid 10ml");
            listBox2.Items.Add("10.99");
        }

        private void Vape_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Vape");
            listBox2.Items.Add("30.00");
        }

        private void Sunrise2for5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Sunrise 2 for $5");
            listBox2.Items.Add("5.00");
        }

        private void Cosava2kg_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Fiji Cosava");
            listBox2.Items.Add("7.99");
        }

        private void TAro_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Fiji Taro");
            listBox2.Items.Add("13.99");
        }

        private void Loundrykey_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Loundry Key");
            listBox2.Items.Add("3.00");
        }

        private void dollerbaglooy_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("$1 bag Lollies");
            listBox2.Items.Add("1.00");
        }

        private void twodollerbaglooy_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("$2 bag Lollies");
            listBox2.Items.Add("2.00");

        }

        private void button5_Click(object sender, EventArgs e)// void entire sale 
        {
            enterpaymentmethod.Hide();
            DialogResult dialogResult = MessageBox.Show("Void Entire Sale", " Void", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                totalsum.Text = "";

            }

            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
           
            totalsum.Text = SetValueForText1;
            MessageBox.Show("Payment Accepted By Cash");
            enterpaymentmethod.Hide();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            totalsum.Text = "";

        }

        private void button45_Click(object sender, EventArgs e)  
        {
            MessageBox.Show("This Function is not performed on this transaction please login as admin ");
        }

        public void button9_Click(object sender, EventArgs e)
        {
            SetValueForText1 = totalsum.Text;
            Eftpos eftpos = new Eftpos();
            eftpos.Show();
            
            enterpaymentmethod.Show();
            balancebox.Hide();
            decimal sum = 0;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listBox2.Items[i]);
            }
            eftposamount.Text = sum.ToString();
            
            
            
        }

        private void textview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // print recipt
        {
            MessageBox.Show("Printer Required For Print the reciept");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterpaymentmethod_Enter(object sender, EventArgs e)
        {

        }

        private void BTNCASH_Click(object sender, EventArgs e)  // amount received by cash 
        {
            MessageBox.Show("Payment Accepted By Cash");
            enterpaymentmethod.Hide();
            balancebox.Hide();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            totalsum.Text = "";

        }

        private void eftposamount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void balancebox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)   // Hundered Doller note 
        {
            txtcash.Text = "$" + dollerhun.ToString();
            dollerhun += 100;
            Balance1.Text = "$" + (dollerhun - Convert.ToDouble(eftposamount.Text) - 100).ToString();
            Balance.Text = "Change = " + (dollerhun - Convert.ToDouble(eftposamount.Text) - 100).ToString();
            demopoint.Text = (dollerhun - Convert.ToDouble(eftposamount.Text) - 100).ToString();

            if (Convert.ToDouble(demopoint.Text) > 0)
            {
                balancebox.Show();
                btnClear.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //50 doller note 
        {
            txtcash.Text = "$" + dollerfifty.ToString();
            dollerfifty += 50;
            Balance1.Text = "$" + (dollerfifty - Convert.ToDouble(eftposamount.Text)-50).ToString();
            Balance.Text = "Change = " + (dollerfifty - Convert.ToDouble(eftposamount.Text)-50).ToString();
            demopoint.Text = (dollerfifty - Convert.ToDouble(eftposamount.Text) - 50).ToString();
            if (Convert.ToDouble(demopoint.Text) > 0)
            {
                balancebox.Show();
                btnClear.Show();


            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            totalsum.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e) // 20 doller note
        {
            txtcash.Text = "$" + dollertwenty.ToString();
            dollertwenty+=20;
            Balance1.Text = "$" + (dollertwenty - Convert.ToDouble(eftposamount.Text)-20).ToString();
            Balance.Text = "Change = " + (dollertwenty - Convert.ToDouble(eftposamount.Text)-20).ToString();
            demopoint.Text = (dollertwenty - Convert.ToDouble(eftposamount.Text) - 20).ToString();
            if (Convert.ToDouble(demopoint.Text) > 0)
            {
                balancebox.Show();
                btnClear.Show();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // 10 $ note 
        {
            txtcash.Text = "$" + dollerten.ToString();
            dollerten += 10;
            Balance1.Text = "$" + (dollerten - Convert.ToDouble(eftposamount.Text)-10).ToString();
            Balance.Text = "Change = " + (dollerten - Convert.ToDouble(eftposamount.Text)-10).ToString();
            demopoint.Text = (dollerten - Convert.ToDouble(eftposamount.Text) - 10).ToString();
            if (Convert.ToDouble(demopoint.Text) > 0)
            {
                balancebox.Show();
                btnClear.Show();


            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) // five doller note 
        {
            txtcash.Text = "$" + dollerfive.ToString();
            dollerfive += 5;
            Balance1.Text = "$" + (dollerfive - Convert.ToDouble(eftposamount.Text)-5).ToString();
            Balance.Text = "Change = " + (dollerfive - Convert.ToDouble(eftposamount.Text)-5).ToString();
            demopoint.Text = (dollerfive - Convert.ToDouble(eftposamount.Text) - 5).ToString();
            if (Convert.ToDouble(demopoint.Text) > 0)
            {
                balancebox.Show();
                btnClear.Show();


            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Restart();
        }
        
        public void BTNEFTPOS_Click(object sender, EventArgs e) // button eftspos click second form openf 
        {
            SetValueForText1 = eftposamount.Text;
        Eftpos eftpos = new Eftpos();

            eftpos.Show();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetValueForText1 = totalsum.Text;
           

            enterpaymentmethod.Show();
            balancebox.Hide();
            decimal sum = 0;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                sum += Convert.ToDecimal(listBox2.Items[i]);
            }
            eftposamount.Text = sum.ToString();



        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtpost.Text = txtpost.Text + button.Text;

        }

        private void btnok1_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add(post1.Text);
            listBox2.Items.Add(txtpost.Text);
            POSTBOX.Hide();
        }

        private void soup_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Soup");
            listBox2.Items.Add("7.99");
        }

        private void phonetopup_Click(object sender, EventArgs e) // phone top up 
        {
            Phonetop.Show();
        }

        private void button1_Click(object sender, EventArgs e)  // Refunt bitton
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            totalsum.Text = "";
            MessageBox.Show("Amount Refunded");
        }


        private void BTNCREDITCARD_Click(object sender, EventArgs e)   // credit card button
        {
            MessageBox.Show("2% Surcharge Will Apply on Credit Card Payment  Eftpos Machine Required For this Transection ");
                
        }

        private void btnSkinny10_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("SKinny");
            listBox2.Items.Add("10.00");
        }

        private void btnskinny20_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("SKinny");
            listBox2.Items.Add("20.00");
        }

        private void btnskinny50_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("SKinny");
            listBox2.Items.Add("50.00");
        }

        private void btndegree5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("2 Degree");
            listBox2.Items.Add("05.00");
        }

        private void btndegree10_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("2 Degree");
            listBox2.Items.Add("10.00");
        }

        private void btndegree20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("2 Degree");
            listBox2.Items.Add("20.00");
        }

        private void btnspark5_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Spark");
            listBox2.Items.Add("05.00");
        }

        private void btnspark20_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Spark");
            listBox2.Items.Add("20.00");
        }

        private void btnspark50_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Spark");
            listBox2.Items.Add("50.00");
        }

        private void btnvodaphone5_Click(object sender, EventArgs e)// product item
        { 
            listBox1.Items.Add("Vodaphone");
            listBox2.Items.Add("05.00");
        }

        private void btnvodaphone20_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Vodaphone");
            listBox2.Items.Add("20.00");
        }

        private void btnvodaphone50_Click(object sender, EventArgs e)// product item
        {
            listBox1.Items.Add("Vodaphone");
            listBox2.Items.Add("50.00");
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Phonetop.Hide();
        }

        private void clerk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clerk 1 is Opened");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

   
   
  

