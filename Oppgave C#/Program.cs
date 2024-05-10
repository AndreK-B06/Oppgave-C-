using System;
using System.Collections.Generic;

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
    }


}
