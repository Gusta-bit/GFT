using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)

        {

            int maior = 0, menor = 0, aux = 0, i = 0;
            do
            {
                Console.WriteLine("Digite um numero");
                aux = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = aux;
                    menor = aux;
                    i++;
                }
                 else if (aux > maior)
                {
                    maior = aux;
                }
                else if (aux < menor)
                {
                    menor = aux;
                }
            } while (1);

            Console.WriteLine("O Maior numero: " + maior + " o menor numero " + menor);
        }
    }
}
