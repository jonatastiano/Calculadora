using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args)
        {
            
            double num1, num2, resultado;
            string operador;

            Console.WriteLine("---- Calculadora -----");
            Console.WriteLine();

            Console.Write("Dgite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o operador: + | - | * | / | % | = ");
            operador = Console.ReadLine();

            Console.Write("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(operador == "+")
            {
                resultado = num1 + num2;
                Console.WriteLine("Resultado = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(operador == "-")
            {
                resultado = num1 - num2;
                Console.WriteLine("Resultado = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(operador == "*")
            {
                resultado = num1 * num2;
                Console.WriteLine("Resultado = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(operador == "/")
            {
                resultado = num1 / num2;
                Console.WriteLine("Resultado = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(operador == "%")
            {
                resultado = num1 % num2;
                Console.WriteLine("Resultado = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Operaçao Invalida.");
            }

            Console.ReadLine();
        }
    }
}
