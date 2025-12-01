using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double valor1, valor2, resultado;
        string operacao;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            if (operacao == "Adicao")
            {
                valor2 = double.Parse(textBox1.Text);
                resultado = valor2 + valor1;

                textBox1.Text = valor1.ToString() + " + " + valor2.ToString();
                textBox3.Text = resultado.ToString();
            }

            if (operacao == "Subtracao")
            {
                valor2 = double.Parse(textBox1.Text);
                resultado = valor1 - valor2;

                textBox1.Text = valor1.ToString() + " - " + valor2.ToString();
                textBox3.Text = resultado.ToString();
            }

            if (operacao == "Multiplicacao")
            {
                valor2 = double.Parse(textBox1.Text);
                resultado = valor1 * valor2;

                textBox1.Text = valor1.ToString() + " x " + valor2.ToString();
                textBox3.Text = resultado.ToString();
            }

            if (operacao == "Divisao")
            {
                valor2 = double.Parse(textBox1.Text);
                resultado = valor1 / valor2;

                textBox1.Text = valor1.ToString() + " / " + valor2.ToString();
                textBox3.Text = resultado.ToString();
            }

            if (operacao == "Porcentagem")
            {
                valor2 = double.Parse(textBox1.Text);
                resultado = (valor1 * valor2) / 100;

                textBox1.Text = valor1.ToString() + " % " + valor2.ToString();
                textBox3.Text = resultado.ToString();
            }
        }

        private void AD_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "Adicao";
            {
                textBox3.Text = valor1.ToString() + " + ";
            }
            textBox1.Clear();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "Subtracao";
            {
                textBox3.Text = valor1.ToString() + " - ";
            }
            textBox1.Clear();
        }

        private void MUL_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "Multiplicacao";
            {
                textBox3.Text = valor1.ToString() + " x ";
            }
            textBox1.Clear();
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "Divisao";
            {
                textBox3.Text = valor1.ToString() + " / ";
            }
            textBox1.Clear();
        }

        private void PORCENTAGEM_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "Porcentagem";
            {
                textBox3.Text = valor1.ToString() + " % ";
            }
            textBox1.Clear();
        }

        private void MAISMENOS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double numero = double.Parse(textBox1.Text);

                numero = numero * -1;
                textBox1.Text = numero.ToString();
            }
        }

             private void DELETAR_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox3.Clear();
                valor1 = 0;
                valor2 = 0;
                resultado = 0;
                operacao = "";
            }
        

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";

        }

        private void DOIS_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void TRES_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void QUATRO_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void CINCO_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void SEIS_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void SETE_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void OITO_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void NOVE_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }


        private void ZERO_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void VIRGULA_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
