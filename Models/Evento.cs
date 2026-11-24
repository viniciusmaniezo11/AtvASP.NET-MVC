using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExASP.NETMVC.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [StringLength(90, MinimumLength = 5, ErrorMessage = "Nome deve ter entre 5 a 80 caracteres.")]
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string? Nome { get; set; }

        [MinLength(10, ErrorMessage = "A descrição deve ter no minimo 10 caracteres")]
        [Required(ErrorMessage = "A descrição é obrigatorio.")]
        public string? Descricao { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "O local deve ter entre 3 a 100 caracteres")]
        [Required(ErrorMessage = "O local é obrigatorio.")]
        public string? Local { get; set; }
        public DateTime DataEvento { get; set; }

        [Range(1, 1000, ErrorMessage = "A quantidade de vagas é de 1 a 1000 pessoas.")]
        public int QuantidadeVagas { get; set; }
        public decimal ValorIngresso { get; set; }
    }
}