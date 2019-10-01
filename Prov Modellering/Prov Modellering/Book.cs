using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering
{
    class Book
    {
        public int price = 0;
        int rarity;
        string name;
        string category;
        int actualValue;
        bool cursed;
        static Random generator = new Random();

        public void ConstructBook(List<string> names, List<string> categories)
        {
            //Checks length of lists and randomizes a name and category to give the new book.
            int namesLength = names.Count;
            int categoriesLength = categories.Count;

            name = names[generator.Next(1, namesLength)];
            category = categories[generator.Next(1, categoriesLength)];

            actualValue = generator.Next(100, 1001);
            rarity = generator.Next(1, 5);
            int i = generator.Next(1, 5);
            if (i == 4)
            {
                cursed = true;
            }

        }

        public void PrintInfo()
        {
            string rarityName = "";
            if (rarity == 1)
            {
                rarityName = "common";
            } else if (rarity == 2)
            {
                rarityName = "rare";
            } else if (rarity == 3)
            {
                rarityName = "epic";
            } else if (rarity == 4)
            {
                rarityName = "legendary";
            }
            if (price == 0)
            {
                Console.WriteLine("The books name is " + name + ", rarity is " + rarityName + " and price is not assigned.");
            }
            else
            {
                Console.WriteLine("The books name is " + name + ", rarity is " + rarityName + " and price is " + price + ".");
            }
        }

        public int Evaluate()
        {
            //Multiplies the value with the rarity and randomizes it to cost 50% to 150% of that.
            int actualPrice = actualValue * rarity;
            int multiplier = generator.Next(5, 16);
            return price = actualPrice * multiplier / 10;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool GetCursed()
        {
            //80% that it returns the answer to if it cursed, 20% that it returns the opposite.
            int cursedChance = generator.Next(1, 101);
            if (cursedChance > 20)
            {
                return cursed;
            }
            else
            {
                if (cursed == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
