using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Oppgave_C_
{
     class Program
    {
        static void Main()
        {
            PrintUser();

            PrintKommuner();

            PackingList.PrintList();

            // Get and Set
            Person myObj = new Person();
            myObj.Name ="Get name: " + "Adrian";
            Console.WriteLine(myObj.Name);

            //mathematics
            mathematics();

            split();

            Cow cow = new();
            cow.Speak();

            Wolf wolf = new();
            wolf.Speak();

            //People on Earth Growth Rate
            PeopleOnEarth();
        }
            // Variablels
        public static void PrintUser() { 
            
            int userAge = 50;
            double userHight = 150.1;
            string userName = "Leah";
            //Caling Variabels
            Console.WriteLine("Age:" + userAge);
            Console.WriteLine("Hight:" + userHight);
            Console.WriteLine("Name:" + userName);
        }
        //Array
        public static void PrintKommuner() 
        {

            string[] kommuner =
            {
                "Bergen",
                "Oslo",
                "Halden",
                "Troms"
            };
            for (int i = 0; i < kommuner.Length; i++)
            {
                Console.WriteLine("Kommune:" + kommuner[i]);
            }
        }
        //List Class
        public class PackingList
        {
            private readonly List<string> items = new();
            public void AddItems(string item) 
            {
              items.Add(item); 
            }
            public void PrintPackingList()
            {
              foreach (string item in items)
              {
                Console.WriteLine("Remember:" + item);
              }
            }
            //List Items
            public static void PrintList()
            {
                PackingList myPackingList = new PackingList();
                myPackingList.AddItems("Socks");
                myPackingList.AddItems("Underwear");
                myPackingList.AddItems("T-shirts");
                myPackingList.AddItems("Pants");
                myPackingList.PrintPackingList();

            }
        }
        public class Person
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        public static void mathematics()
        {
            int ingeAge = 27;
            int SteinAge = 40;
            Console.WriteLine("Comined age of Inge and Stein = " + (ingeAge + SteinAge));
        }

        public static void split()
        {
            string paragraf = "You win some times. you luse some times.";
            string[] subs = paragraf.Split(' ', '.');
            foreach (var sub in subs)
            {
                Console.WriteLine($"substring: {sub}");
            }

        }
            interface IAnimal
            {
                void Speak();
            }
        class Cow : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("The Cow says: Moo!");
            }
        }
        class Wolf : IAnimal
        {
            public void Speak()
            {
                 Console.WriteLine("The Wolf: Howl!");
            }
        }
        static void PeopleOnEarth()
        {
            // Start and end years
            int startYear = 1950;
            int endYear = 2024;

            // Start and end populations
            double startPopulation = 2.5e9;
            double GrowthRate = 0.016;

            //Calculate growth rate dynamically
            double growthRate = MatchCasing.Pow(endPeopulation / startPopulation, 1.0 / (endYear - startYear)); - 1

            Console.WriteLine("Year\tPopulation (in billions)");
            Console.WriteLine("==========================");

            // Calculate and print population for each year
            for (int year = startYear; year <= endYear; year++)
            {
                double population = startPopulation * Math.Pow(1 + GrowthRate, startYear);
                Console.WriteLine($"{year}\t{population / 1e9:0.##} billion");
            }
        }
    }
}
