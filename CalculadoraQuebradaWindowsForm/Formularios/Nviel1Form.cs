using System;
using System.Windows.Forms;

namespace CalculadoraQuebradaWindowsForm.Formularios
{
    public partial class Nivel1Form : Form
    {
        string operador;
        double a = 0;
        bool validar = false;

        public Nivel1Form()
        {
            InitializeComponent();
        } 

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtValor.Text = txtValor.Text + btn.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btn_adicao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btn_multiplicacao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToDouble(txtValor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToDouble(txtValor.Text));
            }
        }
    }
}
