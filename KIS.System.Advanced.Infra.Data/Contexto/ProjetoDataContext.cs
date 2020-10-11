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
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Comissao> Comissaos { get; set; }
        public virtual DbSet<RecuperarSenha> RecuperarSenhas { get; set; }
        public virtual DbSet<TipoDespesa> TipoDespesas { get; set; }
        public virtual DbSet<TipoAcesso> TipoAcessos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //    modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new TipoPgMapping()); // Alterar aqui

            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new ComissaoMapping());
            modelBuilder.Configurations.Add(new RecuperarSenhaMapping());
            modelBuilder.Configurations.Add(new TipoDespesaMapping());
            modelBuilder.Configurations.Add(new TipoAcessoMapping());
        }
    }
}
