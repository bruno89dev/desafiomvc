using System.ComponentModel.DataAnnotations;

namespace DesafioMVC.Models
{
    public class Medida
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}