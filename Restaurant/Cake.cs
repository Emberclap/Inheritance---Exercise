using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CakeCalories = 1000d;
        private const double CakeGrams = 250d;
        private const decimal CakePrice = 5m;
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {
                
        }
        
    }
}
