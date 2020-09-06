using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.Contexto
{
    public class ProjetoDataContext : DbContext
    {
        public ProjetoDataContext() : base("KIS.System.Advanced")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
        }
    }
}
