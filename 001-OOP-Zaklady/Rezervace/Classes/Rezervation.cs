using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervace
{
    public class Rezervation
    {
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }

        public Rezervation(Customer customer, Movie movie)
        {
            Customer = customer;
            Movie = movie;
        }

        public double CalculatePrice()
        {
            if (Customer.Age <= 15)
                return Movie.Price * 0.5;

            return Movie.Price;
        }


    }
}
