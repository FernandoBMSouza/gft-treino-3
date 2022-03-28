using System;
using System.Collections.Generic;
using Project03.Entities;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Morador> moradores = new List<Morador>();
            bool flag = true;
            while(flag)
            {
                System.Console.Write("Insira o numero da casa: ");
                int residencia = int.Parse(Console.ReadLine());
                System.Console.Write("Insira o numero do telefone: ");
                int telefone = int.Parse(Console.ReadLine());
                System.Console.Write("Tem Cachorro? (s/n): ");
                string cachorro = Console.ReadLine().ToLower();
                if(cachorro != "s" && cachorro != "n")
                {
                    System.Console.WriteLine("Valor Inválido");
                    break;
                }
                if(residencia % 2 != 0)
                {
                    moradores.Add(new Morador(residencia, telefone));
                }
                System.Console.Write("Deseja finalizar? (s/n): ");
                string finalizar = Console.ReadLine().ToLower();
                if(finalizar == "s")
                {
                    flag = false;
                }
            }
            System.Console.WriteLine($"Correspondências Entregues: {moradores.Count()}");
        }
    }
}