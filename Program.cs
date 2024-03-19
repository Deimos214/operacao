using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação: (+, -, * ou /)");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("O resultado da operação é: "+(num1+num2));
                    break;
                case "-":
                    Console.WriteLine("O resultado da operação é: "+(num1-num2));
                    break;
                case "*":
                    Console.WriteLine("O resultado da operação é: "+(num1*num2));
                    break;
                case "/":
                    Console.WriteLine("O resultado da operação é: "+(num1/num2));
                    break;
                default: Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
