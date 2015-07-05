using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF_CastleProxy.Interceptors
{
    public class LoginInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var x = invocation.Method.Name;
            
        }
    }
}
