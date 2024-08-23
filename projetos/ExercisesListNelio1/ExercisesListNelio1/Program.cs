using System;
using System.Globalization;

namespace ExercisesList1
{
    class Program
    {
        static void Main(string[] args)
        {

            //These are just some exercises to understand if i was able to follow up to Nelio´s introductory course to C# and OO

            //Exercise 1
            Console.WriteLine("Insira o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            int b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine($"SOMA : {x}");








            //Exercise 2

            //Console.WriteLine("Raio do círculo: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double pi = 3.14159;

            //double area = pi * Math.Pow(raio, 2);

            //Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));







            //Exercise 3
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //int dif = (A * B - C * D);

            //Console.WriteLine($"DIFERENÇA: {dif}");






            





        }
    }
}