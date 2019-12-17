using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessClass : IBusiness
    {
        IData _dataClass;
        public BusinessClass(IData dataClass)
        {
            _dataClass = dataClass;
        }
        public string GetBusinessData() => _dataClass.GetData();

    }
}
