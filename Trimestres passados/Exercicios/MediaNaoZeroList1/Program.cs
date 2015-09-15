using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNaoZeroList1
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            char resposta = 's';
            List<int> numeros = new List<int>();
            while (resposta == 's')
            {
                Console.WriteLine("Escreva o número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja continuar? (s ou n) ");
                resposta = Convert.ToChar(Console.ReadLine());
               
                numeros.Add(numero);
            }

                media = numeros.Sum() / numeros.Count(); 
               
                Console.WriteLine("A média é: " + media);
           
        }

    }
}
