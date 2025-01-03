using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Calculator
{
    public partial class Form1 : Form
    {
        int n1, n2, result;
        string math;

        private bool hexad = false;
        private bool deci = true;
        private bool bina = false;
        private bool octa = false;

        private void EnableBin()
        {
            zero.Enabled = true;
            one.Enabled = true;
        }

        private void DisableBin()
        {
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
        }

        private void EnableDec()
        {
            zero.Enabled = true;
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableDec();

            
            if(radioButton1.Checked)

            if (bina == true)
            {

                long bin = Convert.ToInt64(textBox1.Text, 2);
                string BinToDec = Convert.ToString(bin, 10);
                textBox1.Text = BinToDec.ToString();

                bina = false;
                deci = true;
                

            }
            else if (hexad == true)
            {

                long hex = Convert.ToInt64(textBox1.Text, 16);
                string HexToDec = Convert.ToString(hex, 10);
                textBox1.Text = HexToDec.ToString();

                hexad = false;
                deci = true;


            }
            else if (octa == true)
            {

                long oct = Convert.ToInt64(textBox1.Text, 8);
                string OctToDec = Convert.ToString(oct, 10);
                textBox1.Text = OctToDec.ToString();

                octa = false;
                deci = true;


            }

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EnableBin();
            DisableBin();

           
            if(radioButton2.Checked)
            if (deci == true)
            {
                long dec = Convert.ToInt64(textBox1.Text, 10);
                string decToBin = Convert.ToString(dec, 2);
                textBox1.Text = decToBin.ToString();


                deci = false;
                bina = true;

            }

            else if (hexad == true)
            {
                long hex = Convert.ToInt64(textBox1.Text, 16);
                string HexToBin = Convert.ToString(hex, 2);
                textBox1.Text = HexToBin.ToString();


                hexad = false;
                bina = true;

            }

            else if (octa == true)
            {
                long oct = Convert.ToInt64(textBox1.Text, 8);
                string OctToBin = Convert.ToString(oct, 2);
                textBox1.Text = OctToBin.ToString();


                octa = false;
                bina = true;

            }

           

        }















        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            math = "+";
            n1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            math = "-";
            n1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            math = "x";
            n1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToInt32(textBox1.Text);
            switch (math)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "x":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            math = "/";
            n1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if(radioButton3.Checked)
            if (deci == true)
            {
                long dec = Convert.ToInt64(textBox1.Text, 10);
                string DecToHex = Convert.ToString(dec, 16);
                textBox1.Text = DecToHex.ToString();

                deci = false;
                hexad = true;
            }

            else if (bina == true)
            {
                long bin = Convert.ToInt64(textBox1.Text, 2);
                string BinToHex = Convert.ToString(bin, 16);
                textBox1.Text = BinToHex.ToString();

                bina = false;
                hexad = true;
            }

            else if (octa == true)
            {
                long oct = Convert.ToInt64(textBox1.Text, 8);
                string OctToHex = Convert.ToString(oct, 16);
                textBox1.Text = OctToHex.ToString();

                octa = false;
                hexad = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if(radioButton4.Checked)
            if (deci == true)
            {
                long dec = Convert.ToInt64(textBox1.Text, 10);
                string DecToOct = Convert.ToString(dec, 8);
                textBox1.Text = DecToOct.ToString();

                deci = false;
                octa = true;

            }

            else if (bina == true)
            {
                long bin = Convert.ToInt64(textBox1.Text, 2);
                string BinToOct = Convert.ToString(bin, 8);
                textBox1.Text = BinToOct.ToString();

                bina = false;
                octa = true;

            }

            else if (hexad == true)
            {
                long hex = Convert.ToInt64(textBox1.Text, 16);
                string HexToOct = Convert.ToString(hex, 8);
                textBox1.Text = HexToOct.ToString();

                hexad = false;
                octa = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string binaryInput = textBox1.Text;


            string onesComplement = new string(binaryInput.Select(c => c == '0' ? '1' : '0').ToArray());

            textBox1.Text = onesComplement;
        }
    }
}
