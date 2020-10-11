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

        public virtual DbSet<TipoPg> TipoPgs { get; set; } 
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Funcao>  Funcoes { get; set; }
        public virtual DbSet<Contrato>  Contratos { get; set; }
        public virtual DbSet<Pedido>  Pedidos { get; set; }
        public virtual DbSet<ItemPedido> ItemPedidos { get; set; }
        public virtual DbSet<TipoAcesso> TipoAcessos { get; set; }
        //public virtual DbSet<Pedido> FormaPg { get; set; }
        //public virtual DbSet<Pedido> Comissao { get; set; }
        //public virtual DbSet<Pedido> PedidoCancelamento { get; set; }
        //public virtual DbSet<Pedido> TipoCancelamento { get; set; }
        //public virtual DbSet<Pedido> RecuperarSenha { get; set; }
        //public virtual DbSet<Pedido> Despesa { get; set; }
        //public virtual DbSet<Pedido> TipoDespesa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TipoPgMapping()); 
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new FuncaoMapping());
            modelBuilder.Configurations.Add(new ContratoMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new TipoAcessoMapping());
            //modelBuilder.Configurations.Add(new FormaPgMapping());
            //modelBuilder.Configurations.Add(new ComissaoMapping());
            //modelBuilder.Configurations.Add(new PedidoCancelamentoMapping());
            //modelBuilder.Configurations.Add(new TipoCancelamentoMapping());
            //modelBuilder.Configurations.Add(new RecuperarSenhaMapping());
            //modelBuilder.Configurations.Add(new DespesaMapping());
            //modelBuilder.Configurations.Add(new TipoDespesaMapping());
        }
    }
}
