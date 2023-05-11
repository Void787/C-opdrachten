using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_5._4
{
    internal class Product
    {
        public string name;
        public string location;
        public int weight;

        public Product(string name) 
        { 
            this.name = name;
            this.location = "shelf";
            this.weight = 1;
        }

        public Product(string name, string location)
        {
            this.name = name;
            this.location = location;
            this.weight = 1;
        }

        public Product(string name, int weight)
        {
            this.name = name;
            this.location = "warehouse";
            this.weight = weight;
        }

        public override string ToString()
        {
            string zin = name + " (" + weight + " kg) can be found from the " + location;
            return zin;
        }
    }
}
