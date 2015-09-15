using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            int n;
            double maior = 0;
            double menor = 0;
            double soma = 0;       

            Console.WriteLine("Escreva a quantidade de números: ");
            qtd = int.Parse(Console.ReadLine());
            
            for (int i = 0; i == qtd; i++)
            {
                Console.WriteLine("Digite o número: ");
                Console.ReadLine(n);

                if (n >= 0)
                {

                    soma += n;

                if (n > maior)
                {
                    maior = n;
                }

                if (n < menor)
                {
                    menor = n;
                }

                }

                else
                {
                    Console.WriteLine("Digite um número inteiro positivo.");
                }
            }

                Console.WriteLine("A soma é: " + soma);
                Console.WriteLine("O maior número é: " + maior);
                Console.WriteLine("O menor número é: " + menor);
        }
    }
}
