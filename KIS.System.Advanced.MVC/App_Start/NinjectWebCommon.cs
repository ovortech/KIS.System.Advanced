[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(KIS.System.Advanced.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(KIS.System.Advanced.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace KIS.System.Advanced.MVC.App_Start
{
    using System;
    using global::System;
    using global::System.Web;
    using KIS.System.Advanced.Services;
    using KIS.System.Advanced.Services.Interfaces;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IRecuperarSenhaService>().To<RecuperarSenhaService>();
            kernel.Bind<IVendedorService>().To<VendedorService>();
            kernel.Bind<IPedidoService>().To<PedidoService>();
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<ITipoPagamentoService>().To<TipoPagamentoService>();
            kernel.Bind<IComissaoService>().To<ComissaoService>();            
            kernel.Bind<IItemPedidoService>().To<ItemPedidoService>();
            kernel.Bind<IFormaPagamentoService>().To<FormaPagamentoService>();
            kernel.Bind<IHistoricoVendaService>().To<HistoricoVendaService>();
        }
    }
}