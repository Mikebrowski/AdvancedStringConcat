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


            Console.Write("Enter a string here:.. ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter a single character that will be check in the string you have inputed: ");

            char searchInput = Console.ReadLine()[0];

            int searchIndex = input.IndexOf(searchInput);

            Console.WriteLine($"Index of character is [0] in a string of [1]{searchIndex}");
            Console.WriteLine($"Index of character is [0] with the following lettter {searchInput} in a string of [1]{searchIndex}");

            Console.WriteLine("Please wait for the next input... \n.");

            Console.WriteLine("Please write your first name... ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please write your last name... ");
            string lastName = Console.ReadLine();

            //THIS IS NOT CORRECT
            string fullName = string.Concat(firstName," ",lastName);


          
            //System.Linq.Enumerable + SelectEnumerableIterator`2[System.Linq.IGrouping`2[System.Char, System.Char],<> f__AnonymousType0`2[System.Char, System.Int32]]
            //




            Console.WriteLine("Your full name combained by concat method {0}",fullName);
            /*HER HAR DU ET EKEMPSEL PÅ MAPPING MED GROUP BY MED lamban expression =>*/
            string groupByInput = Console.ReadLine();
            var arr = groupByInput.GroupBy(chars => chars).Select(chars => new { Char = chars.Key, Count = chars.Count() });

            //WHAT IS TSource c or x is the source it seems

            foreach (var chars in arr)
            {
                Console.WriteLine(chars.Count + "\n" + chars.Char);
            }

            Console.WriteLine("Enter the string character you wish to count");
            var searchIndex2 = input.Length;

            Console.WriteLine($"Index of character is [0] in a string of [1]{arr}");
            //mapping and grouping
        }


    }
}