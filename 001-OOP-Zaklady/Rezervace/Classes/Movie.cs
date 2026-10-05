using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervace
{
    public class Movie
    {
        private string name;
       // private double price; //datový člen

        public string Name
        {  
            get 
            { 
                return name; 
            } 

            set 
            { 
                if(value != null)
                    name = value; 
            }
        }


        public double Price { get; set; } //automatická vlastnost


        public Movie(string name, double price)
        {
            this.name = name;
           // this.price = price;
           Price = price;
        }

        public string GetName()
        { 
            return name; 
        }

        /*
        public double GetPrice()
        {  
            return price; 
        }
        */
    }
}
