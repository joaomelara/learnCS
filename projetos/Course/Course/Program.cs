using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //Produtos:
            //Computador, cujo preço é $ 2100,00
            //Mesa de escritório, cujo preco é $ 650,50
            //Registro: 30 anos de idade, código 5290 e gênero: M
            //Medida com oito casas decimais: 53,23456700
            //Arredondado(três casas decimais): 53,235
            //Separador decimal invariant culture: 53.235


            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2} cujo preço é $ {preco1}");
            Console.WriteLine($"Registro: {idade} de idade, código {codigo} e gênero {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado(três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            //string[] s= Split

            //Console.ReadLine(); -> input

        }


    }


}


















//using System.Globalization; //mudar ponto pra vírgula

//// See https://aka.ms/new-console-template for more information
//byte x = 255;
//bool completo = false;
//char genero = 'F'; //Dá pra fazer por caracter unicode
//float n5 = 4.5f; //precisa do f para não confundir com double
//double saldo = 4.63434349;
//string nome = "Maria";
//object obj1 = "Alex"; //tipo generico, aceita qualquer coisa
//int idade = 40;
////int.MinValue;
////int
////long
////x++;
////Console.WriteLine(x);
////Write Line (inclui quebra de linha no final) x Write
////Console.WriteLine(n6.ToString("F2"));

//Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2"));
////Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
////Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
////Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
////+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

////CultureInfo.InvariantCulture