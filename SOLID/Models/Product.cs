using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class Product
    {
        private Product _instance;
        public Product Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Product();
                return _instance;
            }
        }

        private Product() { }
    }
}
