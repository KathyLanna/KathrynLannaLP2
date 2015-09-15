using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int y = int.Parse(Console.ReadLine());
            int pot = x *= y;
            Console.WriteLine("O resultado é: " + pot);
            Console.ReadKey();
            

        }
    }
}
