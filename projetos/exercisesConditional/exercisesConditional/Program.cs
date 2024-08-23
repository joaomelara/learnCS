namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //if (x >= 0) {
            //Console.WriteLine("Positivo");
            //}
            //else {
            //    Console.WriteLine("Negativo");
            //        }

            //if (x % 2 == 0) {
            //    Console.WriteLine("Par");

            //}
            //else
            //{
            //    Console.WriteLine("Impar");
            //}


            //if (x % y == 0 || y % x == 0) {
            //    Console.WriteLine("Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao multiplos");
            //}

            if (y > x)
            {
                Console.WriteLine("O JOGO DUROU " + (y - x));
            }
 
            else
            {
                int a = 24 - x;
                int b = a + y;
                Console.WriteLine("O JOGO DUROU " + b);
            }
        }
    }
}