using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Initiator
    {
        IBusiness _businessClass;
        public Initiator(IBusiness businessClass)
        {
            _businessClass = businessClass;
        }
        public string FetchData() => _businessClass.GetBusinessData();
    }
}
