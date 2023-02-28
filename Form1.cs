using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed ="";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text=(resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        

        private void btn_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") ||(isOperationPerformed=true))
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
             
            
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

       
    }
}
