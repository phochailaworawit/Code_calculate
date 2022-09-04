using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text  +"0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNum.Text= txtNum.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }
        int a;
        int b;
        string s;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNum.Text);
            s = "+";
            txtNum.Text = "";
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNum.Text);
            s = "-";
            txtNum.Text = "";
        }

        private void btnAnw_Click(object sender, EventArgs e)
        {
            b = int.Parse(txtNum.Text);
            int c=0;
            if(s=="+")
            { c = a + b; }
            else if (s == "-")
            { c = a - b; }
            else if (s == "*")
            { c = a * b; }
            else if (s == "/")
            { c = a / b; }

            txtNum.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNum.Text);
            s = "*";
            txtNum.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNum.Text);
            s = "/";
            txtNum.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ");
        }
    }
}
