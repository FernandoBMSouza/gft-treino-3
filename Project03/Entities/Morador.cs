using System;

namespace Project03.Entities
{
    class Morador
    {
        public int Residencia { get; set; }
        public int Telefone { get; set; }

        public Morador(int residencia, int telefone)
        {
            Residencia = residencia;
            Telefone = telefone;
        }
    }
}