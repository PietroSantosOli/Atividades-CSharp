using System;
using Biblioteca;

class Program
{
    static void Main()
    {
        Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca();

        bool programa = true;
        while (programa)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Listar livros");
            Console.WriteLine("2 - Adicionar livro");
            Console.WriteLine("3 - Pesquisar livro");
            Console.WriteLine("4 - Remover livro");
            Console.WriteLine("5 - Emprestar livro");
            Console.WriteLine("6 - Devolver livro");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    biblioteca.ListarLivros();
                    break;
                case "2":
                    biblioteca.AdicionarLivro();
                    break;
                case "3":
                    biblioteca.PesquisarLivro();
                    break;
                case "4":
                    biblioteca.RemoverLivro();
                    break;
                case "5":
                    biblioteca.EmprestimoLivro();
                    break;
                case "6":
                    biblioteca.DevolucaoLivro();
                    break;
                case "0":
                    programa = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}
