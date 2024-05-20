using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CarExample
{
    public class Hyundai : ICar,IAirCondition
    {
        public void AirCondition()
        {
            Console.WriteLine("Air condition is working");
        }

        public void Drive()
        {
            Console.WriteLine("Hyundai is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Hyundai is stopping");
        }
    }
}
