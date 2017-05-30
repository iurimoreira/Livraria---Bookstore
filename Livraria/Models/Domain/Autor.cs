using System;
using System.Collections.Generic;

namespace Livraria.Models.Domain
{
    public class Autor
    {
        public int AutorId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime AnoNascimento { get; set; }

        public virtual ICollection<Livro> livros { get; set; }
    }
}