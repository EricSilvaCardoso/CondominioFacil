using CondominioFacilDDD.Application;
using CondominioFacilDDD.Application.Interface;
using CondominioFacilDDD.Domain.Interfaces.Repositories;
using CondominioFacilDDD.Domain.Interfaces.Services;
using CondominioFacilDDD.Domain.Services;
using CondominioFacilDDD.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CondominioFacilDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CondominioFacilDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace CondominioFacilDDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
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
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IPropietarioAppService>().To<PropietarioAppService>();
            kernel.Bind<IRuaAppService>().To<RuaAppService>();
            kernel.Bind<IResidenciaAppService>().To<ResidenciaAppService>();
            kernel.Bind<ICondominioAppService>().To<CondominioAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IPropietarioService>().To<PropietarioService>();
            kernel.Bind<IRuaService>().To<RuaService>();
            kernel.Bind<IResidenciaService>().To<ResidenciaService>();
            kernel.Bind<ICondominioService>().To<CondominioService>();
            
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IPropietarioRepository>().To<PropietarioRepository>();
            kernel.Bind<IRuaRepository>().To<RuaRepository>();
            kernel.Bind<IResidenciaRepository>().To<ResidenciaRepository>();
            kernel.Bind<ICondominioRepository>().To<CondominioRepository>();
        }        
    }
}
