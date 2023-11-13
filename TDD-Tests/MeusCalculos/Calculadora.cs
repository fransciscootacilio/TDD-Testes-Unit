using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusCalculos
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }
        public int somar(int num1, int num2)
        {
            int result = num1 + num2;

            listahistorico.Insert(0, "Res: " + result);
            return result;
        }

        public int subtrair(int num1, int num2)
        {
            int result = num1 - num2;

            listahistorico.Insert(0, "Res: " + result);
            return result;
        }

        public int mutiplicar(int num1, int num2)
        {
            int result = num1 * num2;

            listahistorico.Insert(0, "Res: " + result);
            return result;
        }

        public int dividir(int num1, int num2)
        {
            int result = num1 / num2;

            listahistorico.Insert(0, "Res: " + result);
            return result;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return new List<string>();
        }
    }
}