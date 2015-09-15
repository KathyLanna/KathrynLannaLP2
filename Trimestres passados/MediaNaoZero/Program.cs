using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNaoZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int cont = 0;
            int numero;
            char resposta = 's';
   
                while (resposta == 's')
                {
                    Console.WriteLine("Escreva o número: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deseja continuar? (s ou n) ");
                    resposta = Convert.ToChar(Console.ReadLine());
      
                if (numero != 0)
                {
                   soma += numero;
                   cont++;
                }             
 
            else
            {
                Console.WriteLine("Digite números diferente de 0");
            }

            Console.ReadKey();
       
             }
            int media = soma / cont;
            Console.WriteLine("A media é " + media);
        }
    }
}
