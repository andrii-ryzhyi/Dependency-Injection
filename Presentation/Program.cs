using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Initiator initiator = new Initiator();
            string data = initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}