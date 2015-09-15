using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma palavra ou frase:");
            string palavra = Console.ReadLine();
            int cont = 0;

            foreach (char vogal in palavra)
            {
                switch (vogal)
                {
                    case 'a':

                        cont++;
                        break;

                    case 'e':

                        cont++;
                        break;

                    case 'i':

                        cont++;
                        break;

                    case 'o':

                        cont++;
                        break;

                    case 'u':

                        cont++;
                        break;
                }

            }

           Console.WriteLine("Existem " + cont.ToString() + " vogais.");
       
        }
    }
}
