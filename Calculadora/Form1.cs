using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Form1 : Form
    {
        decimal num1 = 0;
        decimal num2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
            num1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "SOMA";
            lblOperacoes.Text = "+";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(num1 + num2);
                lblOperacoes.Text = "=";
            }else if(operacao == "SUB")
            {
                textResultado.Text = Convert.ToString(num1 - num2);
                lblOperacoes.Text = "=";
            }
            else if(operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(num1 * num2);
                lblOperacoes.Text = "=";
            }
            else if(operacao == "DIV")
            {
                textResultado.Text = Convert.ToString(num1 / num2);
                lblOperacoes.Text = "=";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textResultado.Text != "")
            {
                num1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SUB";
                lblOperacoes.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                num1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "MULT";
                lblOperacoes.Text = "x";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                num1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "DIV";
                lblOperacoes.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            num1 = 0;
            num2 = 0;
            lblOperacoes.Text = "";
        }
    }
}
