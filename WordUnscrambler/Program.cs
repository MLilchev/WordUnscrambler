using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myFirstList = new List<int>();
            //int[] myFirstArray = { 7, 8, 4, 5, 15 };

            //Console.WriteLine(myFirstList.Count());

            //myFirstList.Add(10);
            //myFirstList.Add(5);
            //myFirstArray[4] = 5;
            //myFirstList.Add(6);
            //myFirstList[0] = 9;
            //Console.WriteLine(myFirstList[0]);

            //Array.Sort(myFirstArray);

            //for(int i=1; i<=5; i++)
            //{
            //    Console.WriteLine("This is line {0}", i);
            //}

            ////var input = Console.ReadLine();
            ////Console.WriteLine("User input is {0}", input);

            ////while ( !input.Equals(string.Empty))
            ////{
            ////    input = Console.ReadLine();
            ////    Console.WriteLine("User input is {0}", input);
            ////}

            //var input = string.Empty;

            //do
            //{
            //    input = Console.ReadLine();
            //    Console.WriteLine("User input is {0}", input);
            //} while (!input.Equals(string.Empty));

            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            ChangeName(person);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }

        static void ChangeName(Person personToChange)

        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }
    }
}
