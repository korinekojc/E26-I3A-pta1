using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public double Age { get; set; }

        public Customer(string name, double age)
        {  
            Name = name; 
            Age = age; 
        }

    }
}
