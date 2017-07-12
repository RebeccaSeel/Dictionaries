using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionaries are another data structure
            //a key value pair ex. eyes (key), value is the definition
            //each key must be unique, values can be the same
            //keys are like social security numbers, unique identifiers
            //syntax for a dictionary: Dictionary is a built-in class, first string is the key, second string is the value
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    {"A2", "Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4", "Sour Patch Kids" }
            //}; //semi-colon is needed, serves as a period - list of key value pairs is the "sentence"

            //foreach(KeyValuePair<string, string>item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Another way to write this - var stands for variable - but this is not good project because var is not clear
            //foreach (var item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //create a new dictionary called drink machine using add method
            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");
            ////prints out in order typed in
            ////dictionaries are hash tables
            ////Console.WriteLine(drinkMachine.Count); //prints out the number 5 - 5 entries in this dictionary
            ////come with built-in methods such as count, etc.
            ////type foreach and tab twice for structure
            ////foreach (var item in collection)
            //foreach (KeyValuePair<int,string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key); //returns all keys, can also do for values
            //    Console.WriteLine(drink.Value); //properties because of wrench
            //}

            //inclass problem #1
            //


        }
    }
}
