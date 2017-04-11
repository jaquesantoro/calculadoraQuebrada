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
            if(caracter.Equals(Operacao.SOMA))
                return true;
                
            return false;
        }
    }
}
