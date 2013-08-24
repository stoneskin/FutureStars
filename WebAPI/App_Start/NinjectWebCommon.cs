[assembly: WebActivator.PreApplicationStartMethod(typeof(WebAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(WebAPI.App_Start.NinjectWebCommon), "Stop")]

namespace WebAPI.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Http;
    using System.Web.Http.Dependencies;

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
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);

            var resolver = new NinjectDependencyResolver(kernel);
          //  GlobalConfiguration.Configuration.DependencyResolver = resolver;

            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DTOs.API.IFutureStarAPI>().To<MockBL.FutureStarService>();
            kernel.Bind<DTOs.API.IFutureStarDAL>().To<MockDAL.FutureStarMockUpService>();
        }        
    }

    internal class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _container;
        public IKernel Container
        {
            get { return _container; }
        }
        public NinjectDependencyResolver(IKernel container)
        {
            _container = container;
        }
        public object GetService(Type serviceType)
        {
            return _container.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAll(serviceType);
        }
        public IDependencyScope BeginScope()
        {
            return this;
        }
        public void Dispose()
        {
            // noop
        }
    }
}
