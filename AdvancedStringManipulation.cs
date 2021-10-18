using System;
using System.Linq;
/*
Let’s create another console application for more practice.This application asks the user to input a string in the first line like “Enter a string here: ”.
In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”
On the third line, it should write the index of the first occurrence of the searched character from the string. Now on concatenation...

THE TASK 

It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.
It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, before displaying it. 
*/




namespace AdvancedStringConcat
{
    class AdvancedStringManipulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here:");
            string input = Console.ReadLine();
            var arr = input.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });

            foreach (var c in arr)
            {
                Console.WriteLine(c.Count + "\n" + c.Char);
            }
            //   
           //mapping and grouping



            // char searchInput
            Console.WriteLine("Enter the string character you wish to count");
            var searchIndex = input.Length;
            // int searchIndex = searchInput.Length;//Searches for the funcation

            Console.WriteLine($"Index of character is [0] in a string of [1]{arr}");

            Console.WriteLine("Please wait for the next input.....\n.");

            Console.WriteLine("please write your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("please write your last name");
            string lastName = Console.ReadLine();

            //THIS IS NOT CORRECT
            string fullname = firstName + lastName;

            //System.Linq.Enumerable + SelectEnumerableIterator`2[System.Linq.IGrouping`2[System.Char, System.Char],<> f__AnonymousType0`2[System.Char, System.Int32]]
            //




            Console.WriteLine("Your full name combained by concat method {0}", fullname);

            /*


            public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


                public static enumExample void 
            {


            }
            */
        }


    }
}