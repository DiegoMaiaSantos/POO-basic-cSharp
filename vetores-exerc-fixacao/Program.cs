using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            RentRoom[] vect = new RentRoom[10];

            Console.WriteLine("==========================================");
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("==========================================");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new RentRoom(name, email);
                Console.WriteLine("==========================================");
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            
            Console.WriteLine("==========================================");
        }
    }
}