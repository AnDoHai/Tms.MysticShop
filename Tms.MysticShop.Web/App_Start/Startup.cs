using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System;
using System.EnterpriseServices;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Tms.MysticShop.Data;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Data.Respositories;
using Tms.MysticShop.Service.Service;

[assembly: OwinStartup(typeof(Tms.MysticShop.Web.App_Start.Startup))]

namespace Tms.MysticShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            ConfigAutofac(app);

        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<InitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();


            //injection dbcontext
            builder.RegisterType<TmsMysticShopDbContext>().AsSelf().InstancePerRequest();

            //injection respository
            builder.RegisterAssemblyTypes(typeof(UserRepository).Assembly)
                .Where(c=>c.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //injection service
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly)
                .Where(c => c.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes<IUserRoleService, UserRoleService>();

            Autofac.IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);


        }
    }
}
