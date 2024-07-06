using System.ComponentModel.DataAnnotations;

namespace Area52Lanches.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage = "Atributo máximo 100 caracteres! ")]
        [Required(ErrorMessage = "Informe o nome da categoria! ")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Atributo máximo 200 caracteres! ")]
        [Required(ErrorMessage = "Informe a descrição! ")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanche { get; set; }
    }
}
