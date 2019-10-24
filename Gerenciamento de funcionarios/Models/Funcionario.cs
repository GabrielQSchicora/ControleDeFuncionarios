using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento_de_funcionarios.Models
{
    public class Funcionario: Pessoa
    {
        [InverseProperty("Funcionarios")]
        [Display(Name = "Lotação")]
        public Departamento Lotacao { get; set; }
        [Display(Name = "Lotação")]
        [ForeignKey("Lotacao")]
        public int? LotacaoId { get; set; }
    }
}
