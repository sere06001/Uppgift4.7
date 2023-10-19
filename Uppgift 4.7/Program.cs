using System;
namespace Uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur mång steg till höger ska meddelandet flyttas?");
            int steg = int.Parse(Console.ReadLine());
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                    {
                        Console.Write(" ");
                    }
                Console.WriteLine(meddelande[i]);
            }
            Console.ReadKey();
        }
    }
}