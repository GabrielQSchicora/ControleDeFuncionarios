using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento_de_funcionarios.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public String Nome { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }

    }
}
