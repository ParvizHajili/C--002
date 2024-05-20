using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CarExample
{
    public class Lada : ICar
    {     
        public void Drive()
        {
            Console.WriteLine("lada is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Lada is stopping");
        }
    }
}
