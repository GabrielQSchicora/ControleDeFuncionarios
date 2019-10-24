using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gerenciamento_de_funcionarios.Models;

namespace Gerenciamento_de_funcionarios.Models
{
    public class FuncionariosContext : DbContext
    {
        public FuncionariosContext (DbContextOptions<FuncionariosContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            //model.Entity<Funcionario>().HasOne(f => f.Lotacao).WithMany(l => l.Funcionarios);
        }

        public DbSet<Gerenciamento_de_funcionarios.Models.Departamento> Departamento { get; set; }

        public DbSet<Gerenciamento_de_funcionarios.Models.Funcionario> Funcionario { get; set; }

        public DbSet<Gerenciamento_de_funcionarios.Models.Tarefa> Tarefa { get; set; }
    }
}
