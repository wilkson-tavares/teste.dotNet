using System;
using System.Collections.Generic;
using System.Text;

namespace TheosWebApplication.Domain.Entities
{
    public class Livros
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        public Livros() { }
    }
}
