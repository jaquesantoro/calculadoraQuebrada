using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraQuebradaWindowsForm.Operacoes;

namespace CalculadoraQuebradaWindowsForm.Processos
{
    public class Processo
    {
        public void ProcessoCalculadora(ref string campo, ref double resultado, string caracter, string operacao)
        {
            var valor = Convert.ToDouble(caracter);

            if(operacao.Equals(Operacao.SOMA))
            {
                resultado.Soma(valor);
                campo += caracter;
            }
            
        }
    }
}
