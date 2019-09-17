using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BOLORUNDURO VALIANT-JOSHUA
        //CPE/16/7824
        //The Functions are:
        /* 1 Addition
         * 2 Subtraction
         * 3 Division
         * 4 Multiplication
         * 5 Square Root
         * 6 Power
         * 7 Squaring
         * 8 Modulus
         * 9 Sine
         * 10 Cosine
         * 11 Tangent
         * 12 Factorial
         * 13 Clear Function
         * 14 Switch Off function
         * 15 Pi
         * 16 Log
         */
        string operation = "";
        double result = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closed Successfully", "Warning");
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 1;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 2;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 3;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 4;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 5;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 6;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 7;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 8;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + 9;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + ".";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void Arithmetic_Btn(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = double.Parse(txtOutput.Text);
            txtOutput.Text = "";
            label1.Text = Convert.ToString(result) + "" + operation;
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    txtOutput.Text = (result + double.Parse(txtOutput.Text)).ToString();
                    break;
                case "-":
                    txtOutput.Text = (result - double.Parse(txtOutput.Text)).ToString();
                    break;
                case "*":
                    txtOutput.Text = (result * double.Parse(txtOutput.Text)).ToString();
                    break;
                case "/":
                    txtOutput.Text = (result / double.Parse(txtOutput.Text)).ToString();
                    break;
                case "Pi":
                    txtOutput.Text = (result * 3.142).ToString();
                    break;
                case "Pow":
                    txtOutput.Text = System.Math.Pow(result, double.Parse(txtOutput.Text)).ToString();
                    break;
                case "Square":
                    txtOutput.Text = System.Math.Pow(result, 2).ToString();
                    break;
                case "Sqrt":
                    txtOutput.Text = System.Math.Sqrt(result).ToString();
                    break;
                case "Mod":
                    txtOutput.Text = (result % double.Parse(txtOutput.Text)).ToString();
                    break;
                case "cos":
                    txtOutput.Text = System.Math.Cos(result).ToString();
                    break;
                case "sin":
                    txtOutput.Text = System.Math.Sin(result).ToString();
                    break;
                case "tan":
                    txtOutput.Text = System.Math.Tan(result).ToString();
                    break;
                case "Log":
                    txtOutput.Text = System.Math.Log(result).ToString();
                    break;
                case "Factorial":
                    int tamp = Convert.ToInt32(result);
                    for (int i = 0; i < tamp; i++)
                    {
                        int init = 0;
                        init++;
                        result += init;
                    }
                    txtOutput.Text = Convert.ToString(result);
                    break;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            
        }
    }
}
