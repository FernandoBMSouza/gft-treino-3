using System;
using System.Text;

namespace Project01.Entities
{
    class Superior : Basico
    {
        public string Universidade { get; set; }
        public Superior(string nome, int matricula, string escola, string universidade) : base (nome, matricula, escola)
        {
            Universidade = universidade;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"Universidade: {Universidade}");
            return $"{base.ToString()}{sb.ToString()}";
        }
    }
}