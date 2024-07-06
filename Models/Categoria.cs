using Area52Lanches.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Area52Lanches.Models
{
    [Table("Categorias")]
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

        public List<Lanche> Lanches { get; set; }
    }
}