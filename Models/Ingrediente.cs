using System.ComponentModel.DataAnnotations;

namespace DesafioMVC.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        public bool Status { get; set; }
        public Medida Medida { get; set; }
    }
}