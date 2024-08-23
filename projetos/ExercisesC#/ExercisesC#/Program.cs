using System.Globalization;
using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura:");
            string[] x = Console.ReadLine().Split(' ');
                string lastName = x[0];
                int age = int.Parse(x[1]);
                double height = double.Parse(x[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(quartos);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
