using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();

            List<string> nameList = new List<string>();
            nameList.Add("Bob");
            nameList.Add("Lisa");
            List<string> categoryList = new List<string>();
            categoryList.Add("Gamer");
            categoryList.Add("Lamer");

            b1.ConstructBook(nameList, categoryList);

            bool done = false;
            bool bookEvaluated = false;
            while (done == false)
            {
                Console.Clear();
                Console.WriteLine("You have 6 choices:\n1. Print info\n2. Evaluate book\n3. Find books category\n4. Find books name\n5. Find" +
                    " if the book is cursed\n6. Exit game");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    if (bookEvaluated == true)
                    {
                        b1.PrintInfo();
                    }
                    else
                    {
                        Console.WriteLine("\nEvaluate the book before you look at the info.");
                    }
                } else if (answer == "2")
                {
                    Console.WriteLine("\nThe books price will be " + b1.Evaluate() + ".");
                    bookEvaluated = true;
                }
                else if (answer == "3")
                {
                    Console.WriteLine("\nThe books category is " + b1.GetCategory() + ".");
                }
                else if (answer == "4")
                {
                    Console.WriteLine("\nThe books name is " + b1.GetName() + ".");
                }
                else if (answer == "5")
                {
                    bool cursed = b1.GetCursed();
                    if (cursed == true)
                    {
                        Console.WriteLine("\nThe book is cursed.");
                    }
                    else
                    {
                        Console.WriteLine("\nThe book is not cursed.");
                    }
                }
                else if (answer == "6")
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("\nPlease type a number, 1 - 6.");
                }

                Console.ReadLine();
            }

        }
    }
}
