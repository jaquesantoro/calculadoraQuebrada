using Formularios.CalculadoraQuebradaWindowsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulários.CalculadoraQuebradaWindowsForm
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel_1_Form nivel1 = new Nivel_1_Form();
            nivel1.ShowDialog();

        }
    }
}
