namespace DesafioMVC.Models
{
    public class ReceitaIngrediente
    {
        public int ReceitaId { get; set; }
        public int IngredienteId { get; set; }
        public Receita Receitas { get; set; }
        public Ingrediente Ingredientes { get; set; }
    }
}