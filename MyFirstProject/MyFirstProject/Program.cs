using MyFirstProject.User;
using System;
using System.Globalization;


namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--- CADASTRO DE CLIENTES ---");
            Console.Write("Quantos clientes você deseja cadastrar no sistema? ");
            int users = int.Parse(Console.ReadLine());

            AccountCreate[] accounts = new AccountCreate[users];

            for (int i = 0; i < users; i++)
            {
                Console.WriteLine($"Usuário #{i+1}: ");
                Console.Write("Nome Completo: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Data de nascimento(Dia/Mês/Ano): ");
                string date = Console.ReadLine();
                accounts[i] = new AccountCreate { Name = name, Email = email, Date = date };

            }
            for (int i = 0; i < users; i++)
            {
                Console.WriteLine($"Id:0{i + 1}" + " - " + accounts[i].ToString());
            }

        }
    }
}
