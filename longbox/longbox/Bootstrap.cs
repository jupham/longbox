using Autofac;
using Autofac.Extras.CommonServiceLocator;
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
            builder.RegisterType<ComicGridViewModel>().AsSelf();
            builder.RegisterInstance(new Comixed()).As<IComicProvider>().ExternallyOwned();
       
            IContainer container = builder.Build();

            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }
    }
}
