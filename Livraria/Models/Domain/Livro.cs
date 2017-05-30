
using System.Collections.Generic;

namespace Livraria.Models.Domain
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Isbn { get; set; }

        public string Titulo { get; set; }

        public int Ano { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }
    }
}