using System;
using Project01.Entities;
using System.Collections.Generic;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Colaborador> colaboradores = new List<Colaborador>();
                bool flag = true;
                while(flag)
                {
                    System.Console.Write("Informe o Nível (1 - Não Estudou / 2 - Ensino Básico / 3 - Ensino Superior)/ 4 - Terminar Registro: ");
                    int nivel = int.Parse(Console.ReadLine());
                    switch (nivel)
                    {
                        case 1:
                            System.Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            System.Console.Write("Matricula: ");
                            int matricula = int.Parse(Console.ReadLine());
                            colaboradores.Add(new Colaborador(nome, matricula));
                            break;
                        case 2:
                            System.Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            System.Console.Write("Matricula: ");
                            matricula = int.Parse(Console.ReadLine());
                            System.Console.Write("Escola: ");
                            string escola = Console.ReadLine();
                            colaboradores.Add(new Basico(nome, matricula, escola));
                            break;
                        case 3:
                            System.Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            System.Console.Write("Matricula: ");
                            matricula = int.Parse(Console.ReadLine());
                            System.Console.Write("Escola: ");
                            escola = Console.ReadLine();
                            System.Console.Write("Universidade: ");
                            string universidade = Console.ReadLine();
                            colaboradores.Add(new Superior(nome, matricula, escola, universidade));
                            break;
                        case 4:
                            System.Console.Write("Obrigado, tenha um bom dia!");
                            System.Console.WriteLine();
                            flag = false;
                            break;
                        default:
                            System.Console.WriteLine("Valor inválido");
                            break;
                    }

                    foreach (Colaborador colaborador in colaboradores)
                    {
                        System.Console.WriteLine($"{colaborador}");
                        System.Console.WriteLine();
                    }
                }
            }
            catch(System.Exception se)
            {
                System.Console.WriteLine($"Error: {se.Message}");
            }
        }
    }
}