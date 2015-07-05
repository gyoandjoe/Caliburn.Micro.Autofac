using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Sample_WPF_CastleProxy.DI;

namespace Sample_WPF_CastleProxy
{
    public class AppBootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        protected override void ConfigureBootstrapper()
        {
            
            //  you must call the base version first!
            
            base.ConfigureBootstrapper();

            //  override namespace naming convention
            EnforceNamespaceConvention = false;
            //  change our view model base type
            ViewModelBaseType = typeof(IShell);                       
        }
    }
}
