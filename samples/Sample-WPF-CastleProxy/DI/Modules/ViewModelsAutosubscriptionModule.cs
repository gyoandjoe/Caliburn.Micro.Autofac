using Autofac;
using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF_CastleProxy.DI.Modules
{
    public class ViewModelsAutosubscriptionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShellViewModel>().EnableClassInterceptors().InstancePerDependency();
        }
    }
}
