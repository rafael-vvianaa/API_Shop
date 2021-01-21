using System;
using System.ComponentModel.DataAnnotations;



namespace API_SHOP.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage="Campo é obrigatorio.")]
        [MaxLength(100, ErrorMessage="Campo não pode ultrapassar os 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage="Campo é obrigatorio.")]
        //verificar a possibilidade de trocar o numero 1 do range por 0.01 para produtos abaixo de 1 real
        [Range(1, int.MaxValue, ErrorMessage="Valor deve ser maior que 0.")]
        public decimal Preco { get; set; }
        
        [MaxLength(1000, ErrorMessage="Campo não pode ultrapassar os 1000 caracteres.")]
        public String Descrição { get; set; }

    }


}