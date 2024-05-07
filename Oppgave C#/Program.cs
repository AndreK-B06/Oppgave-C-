using System;

namespace Oppgave_C_
{
     class Program
    {
        static void Main()
        {
            PrintUser();
            PrintKommuner();
            PrintPackingList();

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
        public static void PrintKommuner() {
            
            string[] kommuner = { 
                "Bergen",
                "Oslo",
                "Halden",
                "Troms" };
            for (int i = 0; i < kommuner.Length; i++)
            {
                Console.WriteLine("Kommune:" + kommuner[i]);
            }
                }
        public static void PrintPackingList()
        {
            List<string> items = new List<string>();
            //List Items
            items.Add("Socks");
            items.Add("Underwear");
            items.Add("T-shirts");
            items.Add("Pants");
            for (int i = 0; i < items.Length; i++) {
                Console.WriteLine("Remember:" + items);
                    }
        }
    }
}
