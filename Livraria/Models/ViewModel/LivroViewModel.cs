
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models.ViewModel
{
    public class LivroViewModel
    {
        [Required]
        [Display(Name = "Isbn")]
        public string Isbn { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Ano")]
        public int Ano { get; set; }
    }
}