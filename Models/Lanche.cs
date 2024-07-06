using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Area52Lanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado!")]
        [Display(Name = "Nome")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres e no máximo {2}!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no máximo {1} caracteres!")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres!")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no máximo {1} caracteres!")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres!")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preco do lanche deve ser informado!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres!")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres!")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem em Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} caracteres!")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "É preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}