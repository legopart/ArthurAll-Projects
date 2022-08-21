using Elias_DependencyInjection.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias_DependencyInjection
{
    public class Flat
    {
        public IDrink _Drink;
        public Flat(IDrink drinkType)
        {
            _Drink = drinkType; 
        }
    }
}
