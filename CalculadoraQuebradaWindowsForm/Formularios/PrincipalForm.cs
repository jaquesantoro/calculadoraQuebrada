using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraQuebradaWindowsForm.Formularios
{
    public partial class PrincipalForm : Form
    {
        private static Form _fromularioAtual;
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Button_Click_Nive1Form(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            OpenFormulario(new Nivel1Form());
        }

        private void Button_Click_Nive2Form(object sender, EventArgs e)
        {
            OpenFormulario(new Nivel2Form());
        }

        private void Button_Click_Nive3Form(object sender, EventArgs e)
        {
            OpenFormulario(new Nivel3Form());
        }

        private static void OpenFormulario(Form formularioNovo)
        {
            //formularioAntigo.Close();

            if(_fromularioAtual != null)
                _fromularioAtual.Close();

            _fromularioAtual = formularioNovo;
            _fromularioAtual.Show();
        }
    }
}
