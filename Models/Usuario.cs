using System;
using System.ComponentModel.DataAnnotations;

namespace API_SHOP.Models
{
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage="Campo é obrigatorio.")]
        public long Id { get; set; }

        [Required(ErrorMessage="Campo é obrigatorio.")]
        [MaxLength(50, ErrorMessage="Campo não pode ultrapassar os 50 caracteres.")]
        public String NomeUsuario { get; set; }

        [Required(ErrorMessage="Campo é obrigatorio.")]
        [MaxLength(20, ErrorMessage="Campo não pode ultrapassar os 50 caracteres.")]
        [MinLength(6, ErrorMessage="Campo deve ter no minimo 6 caracteres.")]
        public String Senha { get; set; }

        public String CategoriaUsuario { get; set; }
    }
}