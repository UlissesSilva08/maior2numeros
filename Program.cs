using System;

namespace maior2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maior 2 Numeros");
            
            Console.Write("Digite o primeiro número: ");
            string numero1 = Console.ReadLine();
            double nr1 = double.Parse(numero1);

            Console.Write("Digite o segundo número: ");
            string numero2 = Console.ReadLine();
            double nr2 = double.Parse(numero2);

            if (nr1 > nr2)
            {
                Console.WriteLine("O maior número é " + nr1);
            }

            else
            {
                Console.WriteLine("O maior número é " + nr2);
            }
        }
    }
}
