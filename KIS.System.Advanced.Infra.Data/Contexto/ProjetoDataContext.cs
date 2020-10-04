using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.Contexto
{   
    public class ProjetoDataContext : DbContext
    {
        public ProjetoDataContext() : base("name=DBKisContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        //  public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<TipoPg> TipoPgs { get; set; } // Alterar aqui

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Funcao> Funcaos { get; set; }

        public virtual DbSet<TipoCancelamento> TipoCancelamentos { get; set; }

        public virtual DbSet<FormaPg> FormaPgs { get; set; }
        
        public virtual DbSet<PedidoCancelamento> PedidoCancelamentos { get; set; }

        public virtual DbSet<Contrato> Contratos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            //    modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new TipoPgMapping()); // Alterar aqui

            modelBuilder.Configurations.Add(new ClienteMapping());

            modelBuilder.Configurations.Add(new FuncaoMapping());

            modelBuilder.Configurations.Add(new TipoCancelamentoMapping());

            modelBuilder.Configurations.Add(new FormaPgMapping());

            modelBuilder.Configurations.Add(new PedidoCancelamentoMapping());

            modelBuilder.Configurations.Add(new ContratoMapping());

        }
    }
}
