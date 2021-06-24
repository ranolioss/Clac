using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calcu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtResult.Text="0";
            txtNumber.Clear();
        }
        private void butn1_Click(object sender, EventArgs e)
        {
            txtNumber.Text += ((Button)sender).Text;
           
        }
        private void butn0_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text!="0")
            {
                txtNumber.Text = "0";
            }
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                txtNumber.Text = "0.";
            }
            else if (!txtNumber.Text.Contains('.'))
            {
                txtNumber.Text += ".";
            }
        }
       double numberOne;
        double ResultOne;
        string op;
        private void btnPlus_Click(object sender, EventArgs e)
        {
         
            ResultOne = numberOne + double.Parse(txtNumber.Text);
            txtNumber.Text = "";
            op = ((Button)sender).Text;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    txtResult.Text = (ResultOne + double.Parse(txtNumber.Text)).ToString();
                   
                    break;
                case "-":
                    txtResult.Text = (ResultOne - double.Parse(txtNumber.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (ResultOne * double.Parse(txtNumber.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (ResultOne / double.Parse(txtNumber.Text)).ToString();
                    break;
                case "%":
                    txtResult.Text = (ResultOne % double.Parse(txtNumber.Text)).ToString();
                    break;
                case "√":
                    txtResult.Text = Math.Sqrt(double.Parse(txtNumber.Text)).ToString();
                    break;
                case "^":
                    txtResult.Text = Math.Pow(ResultOne, double.Parse(txtNumber.Text)).ToString();
                    break;
            }
        }
 
    Color OldColor;
        private void butn1_MouseEnter(object sender, EventArgs e)
        {
            OldColor = ((Button)sender).BackColor;
            ((Button)sender).BackColor = Color.AliceBlue;
        }

        private void butn1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = OldColor;

        }
    }
}
