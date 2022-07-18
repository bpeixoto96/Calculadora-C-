using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor que voce quer saber");
            int xvalor = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                Console.WriteLine("a tabuada é " + xvalor + " X " + i + " = " + (xvalor * i));

        }
    }
}