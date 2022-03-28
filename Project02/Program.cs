using System;
using System.Globalization;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool finaliza = false;
                while(!finaliza)
                {   
                    System.Console.WriteLine("Menu de Opções: ");
                    System.Console.WriteLine("1. Idade");
                    System.Console.WriteLine("2. IMC");
                    System.Console.WriteLine("3. Sair");
                    System.Console.Write("Digite a opção desejada: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            System.Console.Write("Ano de nascimento: ");
                            int nascimento = int.Parse(Console.ReadLine());
                            System.Console.Write("Ano Atual: ");
                            int atual = int.Parse(Console.ReadLine());
                            System.Console.WriteLine($"Idade: {atual - nascimento} anos");
                            break;
                        case 2:
                            System.Console.Write("Altura: ");
                            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            System.Console.Write("Peso: ");
                            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            System.Console.WriteLine($"IMC: {(peso / Math.Pow(altura, 2)).ToString("F2", CultureInfo.InvariantCulture)}");
                            break;
                        case 3:
                            System.Console.WriteLine("Obrigado, tenha um bom dia!");
                            finaliza = true;
                            break;
                        default:
                            System.Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
            } 
            catch(System.Exception e)
            {
                System.Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}