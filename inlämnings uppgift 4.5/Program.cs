using System;
namespace Uppgift_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in heltal");
            string heltal = Console.ReadLine();
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                Console.Write($"{siffra + 1}");
            }
            Console.ReadKey();
        }
    }
}