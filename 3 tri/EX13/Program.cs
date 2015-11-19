using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario();
            string resposta = "";

            while (resposta == "s")
            {
            Console.WriteLine("Login:");
            u.Login = Console.ReadLine();
            Console.WriteLine("Senha:");
            u.Senha = Console.ReadLine();


            string strConn = "Server=localhost;DataBase=test;Uid=root,Pwd=";
            string query = String.Format("SELECT Login, Senha FROM USUARIO WHERE Login = {0} AND Senha = {1}", u.Login, u.Senha);

            MySqlConnection cnn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = query;
            cnn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    Console.WriteLine("Login realizado com sucesso.");
                }
                else
                    Console.WriteLine("Erro ao realizar o login.");
            }
            reader.Close();
            cnn.Close();

            Console.WriteLine("Deseja sair(s)?");
            resposta = Console.ReadLine();
            }


        }
    }
}
