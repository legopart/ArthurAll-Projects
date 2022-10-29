using Elias_DependencyInjection.drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias_DependencyInjection
{
    public class BoilerManger
    {
        public IDrink _Drink;

        List<Flat> _Flats = new List<Flat> { };

        public BoilerManger(IDrink drinkType)
        {
            _Drink = drinkType;
            var flat1 = new Flat(drinkType);
            _Flats.Add(flat1);
            var flat2 = new Flat(drinkType);
            var flat3 = new Flat(drinkType);
            var flat4 = new Flat(drinkType);
        }

    }
}
