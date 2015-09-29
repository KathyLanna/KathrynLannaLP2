using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace aula290915
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual metodo acessar, 1_Consultar 2_Inserir Novo 3_remover 4_atualizar 5_sair");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    consultar();
                    break;
                case 2:
                    inserirNovo();
                    break;
                case 3:
                    Remover();
                    break;
                case 4:
                    atualizar();
                        break;

                default:
                    break;
            }

        }
        static void consultar()
        {
            string j = "Selc";
            Metodo(j);
        }
        static void inserirNovo()
        {
            Console.WriteLine("Digite modelo e marca");
            string modelo = Console.ReadLine();
            string marca = Console.ReadLine();
            string k = string.Format("Insert {0},{1} into Carro", modelo, marca);
            Metodo(k);
        }
        static void Remover()
        {
            Console.WriteLine("Qual campo você quer excluir");
            int p = int.Parse(Console.ReadLine());
            string l = string.Format("Delet {0} from carro", p); 
            Metodo(l);

        }
        static void atualizar()
        {
            string m = "";
                Metodo(m);
        }
        
        public static void Metodo(string query)
        {

            string strconn = "Server=localhost;Database=test;Uid=rootPwd=";
            MySqlConnection conn = new MySqlConnection(strconn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();


        }


    }
}
