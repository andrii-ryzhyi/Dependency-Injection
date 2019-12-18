using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IBusiness, BusinessClass>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
