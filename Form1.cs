using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormscalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnPlus.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnMinus.Text;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnMul.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnDiv.Text;
        }

        private void btnIst_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btnIst.Text;
            string[] plusStr = txtTotal.Text.Split('+');
            string[] plusStr2 = plusStr.Last<string>().Split('=');

            int result = 0;
            int result1 = 0;
            int totalResult = 0;
            List<string> minusStr = new List<string>();

            foreach (string item in plusStr)
            {
                if (!item.Contains("-"))
                {
                    if (!item.Contains("="))
                    {
                        result += Convert.ToInt32(item);
                    }
                }
                else
                {
                    minusStr = item.Split('-').ToList();

                    foreach (string minusItem in minusStr)
                    {
                        if (!item.Contains("="))
                        {
                            result1 -= Convert.ToInt32(minusItem);
                        }
                    }
                }
            }
            if (!plusStr2.First<string>().Contains("-"))
            {
                result += Convert.ToInt32(plusStr2.First<string>());
            }
            else
            {
                result1 -= Convert.ToInt32(minusStr.Last<string>().Split('=').First<string>());

            }
            totalResult = result + result1;

            txtTotal.Text += totalResult.ToString();




            //if (option.Equals("+"))
            //    result = num1 + num2;

            //if (option.Equals("-"))
            //    result = num1 - num2;

            //if (option.Equals("*"))
            //    result = num1 * num2;

            //if (option.Equals("/"))
            //    result = num1 / num2;

            //txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();

        }
    }
}