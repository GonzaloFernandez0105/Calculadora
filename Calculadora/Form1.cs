using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int valorActual = 0;
        int valorAnterior = 0;
        string Operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "4";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCuenta.Text, out valorAnterior))
            {
                Operacion = "+";
                txtCuenta.Text = "";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCuenta.Text, out valorActual))
            {
                if (Operacion == "+")
                {
                    int resultado = valorAnterior + valorActual;
                    lblResultado.Text = resultado.ToString();
                    txtCuenta.Text = "";
                }
                else if (Operacion == "-")
                {
                    int resultado = valorAnterior - valorActual;
                    lblResultado.Text = resultado.ToString();
                    txtCuenta.Text = "";
                }
                else if (Operacion == "x")
                {
                    int resultado = valorAnterior * valorActual;
                    lblResultado.Text = resultado.ToString();
                    txtCuenta.Text = "";
                }
                else if (Operacion == "/") 
                {
                    int resultado = valorAnterior / valorActual;
                    lblResultado.Text = resultado.ToString();
                    txtCuenta.Text = "";
                }

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCuenta.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCuenta.Text, out valorAnterior))
            {
                Operacion = "-";
                txtCuenta.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCuenta.Text, out valorAnterior))
            {
                Operacion = "x";
                txtCuenta.Text = "";
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtCuenta.Text, out valorAnterior))
            {
                Operacion = "/";
                txtCuenta.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            valorActual = 0;
            valorAnterior = 0;
            txtCuenta.Text = "";
            lblResultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown (object sender, EventArgs e)
        {
          

        }

   
    }
}

