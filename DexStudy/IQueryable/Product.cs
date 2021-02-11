using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryable
{
    class Product
    {
        static private int counter = 0;
        public Product()
        {
            Code = ++counter;
        }
        public int Code { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public bool IsInStock { get; set; }
    }
}
