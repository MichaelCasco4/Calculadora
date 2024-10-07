using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.clases
{
    internal class Operation
    {
        public double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return 0;
        }

        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double RaizCuadrada(double num)
        {
            return Math.Sqrt(num);
        }
        public string Exit_Program()
        {
            return "Bye bye American Bye"; 
        }
    }

}
