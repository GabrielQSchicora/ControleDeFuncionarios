using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento_de_funcionarios.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Título")]
        public String Titulo { get; set; }
        [Required]
        [Display(Name="Descrição")]
        public String Descricao { get; set; }
        public Departamento Departamento { get; set; }
        [Display(Name = "Funcionário")]
        public Funcionario Funcionario { get; set; }
        [ForeignKey("Funcionario")]
        [Display(Name = "Funcionário")]
        public int? FuncionarioId { get; set; }

    }
}
