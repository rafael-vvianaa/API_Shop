
using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Models
{
    public class Categoria
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        [MaxLength(100, ErrorMessage = "Campo suporta apenas 100 caracteres")]
        [DataType("nvarchar(100)")]
        public string Name { get; set; }
    }
}