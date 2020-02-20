using System;

namespace oopcsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("");

            Console.WriteLine("Welcome to our business!");

            Console.WriteLine("");

            string[] vegetable = {"carrot", "asparagus", "lettuce", 
            "broccoli", "cabbage", "spinach", "artichoke", "celery", 
            "okra", "cauliflower", "rhubarb", "radish", "parsnip", 
            "zucchini", "watercress"};

            //Sorting list of vegetables in alphabetical order
            Array.Sort(vegetable);

            Console.WriteLine("Currently, these are the vegetables we have in stock, which I've made easier to read by sorting each type in alphabetical order:");
            foreach (string i in vegetable) //Listing out all vegetables
            {
                Console.WriteLine("-" + i);
            }

            Console.WriteLine("");

            //years in business
            int[] year = {1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 
            1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 
            2008, 2009, 2010};

            //calculating total number of years
            Console.WriteLine("We've currently been in business for aproximately " + year.Length + " years.");
            
            Console.WriteLine("");

            Console.WriteLine("These have been our most successfull years:");

            //calculating most successful years for business
            for (int i = 0; i < year.Length; i += 5)
            {
                Console.WriteLine("-" + year[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("Odd how we seem to have a good year only once every five years, isn't it?");
            Console.WriteLine("It's almost as if we've been cursed...");

            Console.WriteLine("");
        }
    }
}
