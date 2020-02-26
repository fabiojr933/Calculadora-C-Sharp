using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculadoraCSharp
{
   
    public partial class Calculadora : Form
    {
        string operador;
        double a = 0;
        bool validar = false;

        public Calculadora()
        {
            InitializeComponent();
        }

    
        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            Label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                Label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                Label1.Text = txtValor.Text + btnMais.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToDouble(txtValor.Text);
                Label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                Label1.Text = txtValor.Text + btnMenos.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(txtValor.Text);
                Label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                Label1.Text = txtValor.Text + btnVezes.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(txtValor.Text);
                Label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                Label1.Text = txtValor.Text + btnDivisao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                Label1.Text = Label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToDouble(txtValor.Text));
            }
            else if (operador == "-")
            {
                Label1.Text = Label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToDouble(txtValor.Text));
            }
            else if(operador == "*")
            {
                Label1.Text = Label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToDouble(txtValor.Text));
            }
            else if(operador == "/")
            {
                Label1.Text = Label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToDouble(txtValor.Text));
            }
        }
    }
}
