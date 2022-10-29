using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias_DependencyInjection.drinks
{
    internal class Pepsi : IDrink
    {
        public string GetDrink()
        {
            return "pepsi";
        }
    }
}
