using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering
{
    class Book
    {
        public int price;
        int rarity;
        string name;
        string category;
        int actualValue;
        bool cursed;
        static Random generator = new Random();

        public void NewBook(List<string> names, List<string> categories)
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

        }

        public int Evaluate()
        {

        }

        public string GetCategory()
        {

        }

        public string GetName()
        {

        }

        public bool GetCursed()
        {

        }
    }
}
