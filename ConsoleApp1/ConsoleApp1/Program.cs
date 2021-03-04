using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "incomodam";
            int numero = 0;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {

                Console.WriteLine("Um elefante " + a + " Muita gente");
            }



        }
    }
}