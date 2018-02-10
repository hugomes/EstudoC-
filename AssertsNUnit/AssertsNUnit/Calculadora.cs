using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertsNUnit.Tests
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SomarDecimais(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Dividir(int num1, int num2)
        {
            if (num1 > 100)
            {
                throw new ArgumentOutOfRangeException("num2");
            }
            return num1/num2;
        }
    }
}
