using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Autofac.Extras.DynamicProxy2;
using Sample_WPF_CastleProxy.Interceptors;

namespace Sample_WPF_CastleProxy
{
    //[Export(typeof(IShell))]
    [Intercept(typeof(LoginInterceptor))]
    public class ShellViewModel: IShell 
    {

        public virtual void DoLogin()
        {
 
        }


    }
}
