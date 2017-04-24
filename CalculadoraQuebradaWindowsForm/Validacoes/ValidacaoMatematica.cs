using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraQuebradaWindowsForm.Operacoes;

namespace CalculadoraQuebradaWindowsForm.Validacoes
{
    public static class ValidacaoMatematica
    {
        public static void ValidadoOhCampoStringQuandoEleForVazio(ref string campo, string caracter)
        {
            if (!ValidarCaracterDeEntrada(caracter))
                return;

            if(string.IsNullOrEmpty(campo))
            {
                if (caracter.Equals("="))
                    return;
            }
        }

        private static bool ValidarCaracterDeEntrada(string caracter)
        {
            throw new NotImplementedException();
        }

        private static bool ValidarCaracterAdicao(string caracter)
        {
            if(caracter.Equals(OperacaoSoma.SOMA))
                return true;
                
            return false;
        }

        private static bool ValidarCaracterSubtracao(string caracter)
        {
            if (caracter.Equals(OperacaoSubtracao.DIMUNUI))
                return true;

            return false;
        }

        private static bool ValidarCaracterMultiplicacao(string caracter)
        {
            if (caracter.Equals(OperacaoMultiplicacao.MULTIPLICA))
                return true;

            return false;
        }

        private static bool ValidarCaracterDivisao(string caracter)
        {
            if (caracter.Equals(OperacaoDivisao.DIVIDE))
                return true;

            return false;
        }
    }
}
