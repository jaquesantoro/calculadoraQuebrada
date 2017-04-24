using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraQuebradaWindowsForm.Operacoes
{
    public static class OperacaoMatematica
    {
        /*
        static int Soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        */

        public static double Soma(this double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public static int Soma(this int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public static int Subtracao(this int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public static int Multiplicacao(this int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public static int Divisao(this int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
