using System;
using System.Text;

namespace Project01.Entities
{
    class Basico : Colaborador
    {
        public string Escola { get; set; }
        public Basico(string nome, int matricula, string escola) : base (nome, matricula)
        {
            Escola = escola;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"Escola: {Escola}");
            return $"{base.ToString()}{sb.ToString()}";
        }
    }
}