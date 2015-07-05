using Autofac;
using Castle.DynamicProxy;
using Sample_WPF_CastleProxy.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF_CastleProxy.DI.Modules
{
    public class InterceptorsAutosubscriptionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoginInterceptor>().InstancePerLifetimeScope().InstancePerDependency();
        }
    }
}
