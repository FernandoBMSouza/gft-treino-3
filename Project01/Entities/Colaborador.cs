using System;
using System.Text;

namespace Project01.Entities
{
    class Colaborador
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Colaborador(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"Nome: {Nome}");
            sb = sb.AppendLine($"Matricula: {Matricula}");
            return sb.ToString();
        }
    }
}