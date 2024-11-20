using System;
using Libros;

namespace Metode
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix un número:");

            int usernum = Convert.ToInt32(Console.ReadLine());

            if (Libritos.NaturalNum(usernum))
            {
                Console.WriteLine("El número es natural");
            }
            else
            {
                Console.WriteLine ("No és natural");
            }
        }
    }
}