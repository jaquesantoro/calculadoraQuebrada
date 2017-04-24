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

            if(operacao.Equals(OperacaoSoma.SOMA))
            {
                resultado.Soma(valor);
                campo += caracter;
            }

            if (operacao.Equals(OperacaoSubtracao.DIMUNUI))
            {
                resultado.Soma(valor);
                campo += caracter;
            }

            if (operacao.Equals(OperacaoMultiplicacao.MULTIPLICA))
            {
                resultado.Soma(valor);
                campo += caracter;
            }

            if (operacao.Equals(OperacaoDivisao.DIVIDE))
            {
                resultado.Soma(valor);
                campo += caracter;
            }
        }
    }
}
