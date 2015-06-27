using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace SampleWPFNoLibReference
{
    [Export(typeof(IShell))]
    public class ShellViewModel: IShell 
    {
    }
}
