using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Lanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80,ErrorMessage = "Nome não pode exceder {1} caracteres.")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage ="A descrição curta do lanche deve ser informada.")]
        [Display(Name = "Descrição curta do lanche")]
        [MaxLength(200,ErrorMessage = "Descrição não pode exceder {1} caracteres.")] //using maxlength only for didactic purpose
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada.")]
        [Display(Name = "Descrição longa do lanche")]
        [StringLength(500, ErrorMessage = "Nome não pode exceder {1} caracteres.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do lanche deve ser informado.")]
        [Display(Name = "Preço do lanche")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, 999.99, ErrorMessage = "O preço deve estar entre R${1} e R${2}")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho imagem normal")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho imagem miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
