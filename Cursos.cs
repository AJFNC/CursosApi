using System;

namespace CursosApi
{
    public class Cursos
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Ementa { get; set; }

        public int Duracao { get; set; }

        public decimal Valor { get; set; }

        public string Inicio { get; set; }
    }
}
