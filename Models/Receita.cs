using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DesafioMVC.Models
{
    public class Receita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string UrlImagem { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int TempoDePreparo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ModoDePreparo { get; set; }
        public bool Status { get; set; }

        public List<string> passoAPasso;

        public ICollection<ReceitaIngrediente> IngredientesReceitas { get; set; }

        public Receita()
        {
            IngredientesReceitas = new Collection<ReceitaIngrediente>();
        }
    }
}