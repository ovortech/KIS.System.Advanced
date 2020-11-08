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
        public virtual DbSet<Comissao> Comissaos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Funcao>  Funcoes { get; set; }
        public virtual DbSet<Contrato>  Contratos { get; set; }
        public virtual DbSet<Pedido>  Pedidos { get; set; }
        public virtual DbSet<ItemPedido> ItemPedidos { get; set; }
        public virtual DbSet<TipoAcesso> TipoAcessos { get; set; }
        public virtual DbSet<FormaPg> FormaPgs { get; set; }
        public virtual DbSet<PedidoCancelamento> PedidoCancelamentos { get; set; }
        public virtual DbSet<TipoCancelamento> TipoCancelamentos { get; set; }
        public virtual DbSet<RecuperarSenha> RecuperarSenhas { get; set; }
        public virtual DbSet<Despesa> Despesas { get; set; }
        public virtual DbSet<TipoDespesa> TipoDespesas { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TipoPgMapping()); 
            modelBuilder.Configurations.Add(new ComissaoMapping());
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new FuncaoMapping());
            modelBuilder.Configurations.Add(new ContratoMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new TipoAcessoMapping());
            modelBuilder.Configurations.Add(new FormaPgMapping());
            modelBuilder.Configurations.Add(new PedidoCancelamentoMapping());
            modelBuilder.Configurations.Add(new TipoCancelamentoMapping());
            modelBuilder.Configurations.Add(new RecuperarSenhaMapping());
            modelBuilder.Configurations.Add(new DespesaMapping());
            modelBuilder.Configurations.Add(new TipoDespesaMapping());
            modelBuilder.Configurations.Add(new VendedorMapping());
        }
    }
}
