using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        String oper = "";
        bool isOp=false;
        bool opcomplete= false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if(Result.Text=="0")
            {
                Result.Clear();
            }
            Button btn = (Button)sender;
            if(isOp==true||opcomplete==true)
            {
                Result.Text = btn.Text;
                isOp= false;
                opcomplete= false;
            }
            else
            {
                Result.Text = Result.Text + btn.Text;
            }
        }

        private void btnclick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operatorclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            oper = btn.Text;
            isOp = true;
            resultvalue = Double.Parse(Result.Text);
        }

        private void btnequalclick(object sender, EventArgs e)
        {
            switch(oper)
            {
                case "+":
                    Result.Text = (resultvalue + Double.Parse(Result.Text)).ToString();
                break;
                case "-":
                    Result.Text = (resultvalue - Double.Parse(Result.Text)).ToString();
                break;
                case "*":
                    Result.Text = (resultvalue * Double.Parse(Result.Text)).ToString();
                break;
                case "/":
                    Result.Text = (resultvalue / Double.Parse(Result.Text)).ToString();
                break;
                default:
                    break;
            }
            resultvalue= Double.Parse(Result.Text);
            isOp= false;
            opcomplete= true;  
            String curr=resultvalue.ToString();
            currentresult.Text = curr; 
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void btnC_click(object sender, EventArgs e)
        {
            oper = "";
            resultvalue = 0;
            Result.Text = "0"; 
            currentresult.Text = "--";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
