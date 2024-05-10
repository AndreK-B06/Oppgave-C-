using System;
using System.Collections.Concurrent;

namespace Oppgave_C_
{
     class Program
    {
        static void Main()
        {
            PrintUser();
            PrintKommuner();
            PackingList.PrintList();

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
        public class PackingList
        {
            private readonly List<string> items = new();
            //List Items
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
    }
}