using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio3();
            Exercicio4();
            Exercicio6();
            Exercicio7();
            Exercicio8();
        }

        static void Exercicio1()
        {
            int numero, fatorial;


            Console.WriteLine("Digite um número para ser fatorado:");
            numero = int.Parse(Console.ReadLine());

            fatorial = numero;

            for (int i = numero - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine("Valor total do fatorial: " + fatorial);    

        }

        static void Exercicio3()
        {
            Console.WriteLine("Digite a quantidade de funcionários: ");
            int qtdFuncionario = int.Parse(Console.ReadLine());
            if (qtdFuncionario > 0)
            {
                for (int i = 0; i < qtdFuncionario; i++)
                {
                    double novoSalario;
                    Console.WriteLine("Digite o nome do funcionário: ");
                    string nomeFuncionario = Console.ReadLine();
                    Console.WriteLine("Digite o salário do funcionário " + nomeFuncionario + ":");
                    double salarioFuncionario = Convert.ToDouble(Console.ReadLine());

                    if (salarioFuncionario <= 2999 && salarioFuncionario > 0)
                    {
                        novoSalario = salarioFuncionario * 1.25;
                        Console.WriteLine("O salário atual do funcionário " + nomeFuncionario + " é " + salarioFuncionario + ". O salário reajustado é " + novoSalario + ".");
                    }
                    if (salarioFuncionario >= 3000 && salarioFuncionario <= 3999)
                    {
                        novoSalario = salarioFuncionario + (salarioFuncionario * (20 / 100.0));
                        Console.WriteLine("O salário atual do funcionário " + nomeFuncionario + " é " + salarioFuncionario + ". O salário reajustado é " + novoSalario + ".");
                    }
                    if (salarioFuncionario >= 4000 && salarioFuncionario <= 4999)
                    {
                        novoSalario = salarioFuncionario + (salarioFuncionario * (15 / 100.0));
                        Console.WriteLine("O salário atual do funcionário " + nomeFuncionario + " é " + salarioFuncionario + ". O salário reajustado é " + novoSalario + ".");
                    }
                    if (salarioFuncionario >= 5000)
                    {
                        novoSalario = salarioFuncionario + (salarioFuncionario * (10 / 100.0));
                        Console.WriteLine("O salário atual do funcionário " + nomeFuncionario + " é " + salarioFuncionario + ". O salário reajustado é " + novoSalario + ".");
                    }

                }

            }

            else
            {
                Console.WriteLine("Digite uma quantidade maior que 0.");
            }
        }

        static void Exercicio4()
        {
            int jogador1 = 0;
            int jogador2 = 0;
            string jog1 = "1";
            string jog2 = "2";
            bool pnts = true;

            while (pnts)
            {
                Console.WriteLine("Quem fez o ponto nessa rodada?");
                Console.WriteLine("Digite 1 para o primeiro jogador e 2 para o segundo jogador.");
                string nomeJogador = Console.ReadLine();
                if (jog1 == nomeJogador)
                {
                    jogador1++;

                }
                else if (jog2 == nomeJogador)
                {
                    jogador2++;
                }

                if ((jogador1 == 21 && jogador1 >= jogador2 + 2) || (jogador1 > 21 && jogador1 == jogador2 + 2))
                {
                    Console.WriteLine("O jogador 1 venceu a partida.");
                    pnts = false;
                }

                else if ((jogador2 == 21 && jogador2 >= jogador1 + 2) || (jogador2 == 21 && jogador2 >= jogador1 + 2))
                {
                    Console.WriteLine("O jogador 2 venceu a partida.");
                    pnts = false;
                }

            }

            Console.WriteLine("Pontuação Jogador1 = " + jogador1);
            Console.WriteLine("Pontuação Jogador2 = " + jogador2);
        }

        static void Exercicio6()
        {
            double altura = 0, maiorAltura1 = 0, maiorAltura2 = 0;
            string nome;
            int qtdMulheres1 = 0, qtdMulheres2 = 0;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            while (nome != "Fim")
            {

                if (nome != "Fim")
                {

                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());

                    if (altura > maiorAltura1)
                    {
                        maiorAltura2 = maiorAltura1;
                        maiorAltura1 = altura;
                        qtdMulheres1 = 1;
                    }

                    if (maiorAltura1 == altura)
                    {
                        qtdMulheres1++;
                    }

                    if (altura > maiorAltura2)
                    {
                        maiorAltura2 = altura;
                        qtdMulheres2 = 1;
                    }

                    if (maiorAltura2 == altura)
                    {
                        qtdMulheres2++;
                    }

                }

            }

            Console.WriteLine("Existem " + qtdMulheres1 + " com " + maiorAltura1 + " cm de altura e " + qtdMulheres2 + " com " + maiorAltura2 + " cm de altura.");
        }

        static void Exercicio7()
        {
            Console.WriteLine("Digite o clube: ");
            char clube = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Digite o número da prova: ");
            int numProva = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de nadadores: ");
            int qtdNadador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo: ");
            int tmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a classificação: ");
            int classificacao = int.Parse(Console.ReadLine());

            int pnts;
            int somaA = 0, somaB = 0;

            if (clube == 'A')
            {

                for (int i = 0; i < qtdNadador; i++)
                {
                    Console.WriteLine("Digite o nome do nadador: ");
                    string nomeNadador = Console.ReadLine();


                    if (classificacao == 1)
                    {
                        pnts = 9;
                        somaA += pnts;
                    }
                    if (classificacao == 2)
                    {
                        pnts = 6;
                        somaA += pnts;
                    }
                    if (classificacao == 3)
                    {
                        pnts = 4;
                        somaA += pnts;
                    }
                    if (classificacao == 4)
                    {
                        pnts = 3;
                        somaA += pnts;
                    }
                    else
                    {
                        Console.WriteLine("Não existe pontos para essa classificação.");
                    }

                }

            }

            if (clube == 'B')
            {

                for (int l = 0; l < qtdNadador; l++)
                {
                    Console.WriteLine("Digite o nome do nadador: ");
                    string nomeNadador = Console.ReadLine();

                    if (classificacao == 1)
                    {
                        pnts = 9;
                        somaB += pnts;
                    }
                    if (classificacao == 2)
                    {
                        pnts = 6;
                        somaB += pnts;
                    }
                    if (classificacao == 3)
                    {
                        pnts = 4;
                        somaB += pnts;
                    }
                    if (classificacao == 4)
                    {
                        pnts = 3;
                        somaB += pnts;
                    }
                    else
                    {
                        Console.WriteLine("Não existe pontos para essa classificação.");
                    }
                }
            }
            Console.WriteLine("Prova número: " + numProva + "Clube A obteu " + somaA + " pontos e o Clube B, " + somaB + ".");

            if (somaA > somaB)
            {
                Console.WriteLine("O clube A venceu a competição.");
            }
            if (somaA == somaB)
            {
                Console.WriteLine("Houve empate.");
            }
            else
            {
                Console.WriteLine("O Clube B venceu a competição.");
            }
        }

        static void Exercicio8()
        {
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 2; i < N; i++)
            {
                soma += i;
            }

            Console.WriteLine("Resultado: " + soma);
        }
    }
}
