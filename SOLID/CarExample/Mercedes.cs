using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CarExample
{
    public class Mercedes : ICar,IAirCondition,ICabriolet
    {
        public void AirCondition()
        {
            Console.WriteLine("air condition");
        }

        public void Cabriolet()
        {
            Console.WriteLine("Cabriolet");
        }

        public void Drive()
        {
            Console.WriteLine("Mercedes is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Mercedes is stopping");
        }
    }
}
