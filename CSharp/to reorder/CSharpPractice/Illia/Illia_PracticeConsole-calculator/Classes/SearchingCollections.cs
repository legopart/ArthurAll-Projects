using ConsoleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Classes
{
    internal static class SearchingCollections
    {

        public static List<Fruit> InitializeFruits()
        {
            string[] fruitNames = { "Apple", "Banana", "Grapefruit", "Pomelo", "Grape" };
            List<Fruit> fruits = new List<Fruit>();
            for (int i = 0; i < fruitNames.Length; i++)
            {
                fruits.Add(new Fruit(i + 101, fruitNames[i]));
            }
            return fruits;
        }

        public static Fruit GetFruitByIdWithFor(List<Fruit> fruits, int id)
        {
            Fruit result = null;
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Id == id)
                {
                    result = fruits[i];
                    break;
                }
            }

            return result;
        }

        public static Fruit GetFruitByIdWithFind(List<Fruit> fruits, int id)
        {
            return fruits.Find(fruit => fruit.Id == id);
        }

        public static Fruit GetFruitByIdWithLinq(List<Fruit> fruits, int id)
        {
            return (from fruit in fruits
                    where fruit.Id == id
                    select fruit).FirstOrDefault();
        }
    }
}
