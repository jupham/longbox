using Autofac;
using Autofac.Extras.CommonServiceLocator;
using ComixedService;
using CommonServiceLocator;
using longbox.Services;
using longbox.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace longbox
{
    public sealed class Bootstrap
    {
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();

            // Register Types
            builder.RegisterType<ComicGridViewModel>().AsSelf();
            builder.RegisterType<ComicCellViewModel>().AsSelf();

            // Register Services
            var comixed = new Comixed();
            comixed.SetProviderCredentials("comixedadmin@localhost", "comixedadmin");
            builder.RegisterInstance(comixed).As<IComicProvider>();
       
            IContainer container = builder.Build();

            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }
    }
}
