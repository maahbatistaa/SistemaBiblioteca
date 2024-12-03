using System;
using SistemaBiblioteca.Services;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.UI
{
    public class Menu
    {
        private Biblioteca biblioteca;

        public Menu(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();  // Limpa a tela para maior clareza
                Console.WriteLine("\n=== Sistema de Biblioteca ===");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Adicionar Usuário");
                Console.WriteLine("4. Listar Usuários");
                Console.WriteLine("5. Emprestar Livro");
                Console.WriteLine("6. Devolver Livro");
                Console.WriteLine("7. Listar Empréstimos");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Título: ");
                        var titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        var autor = Console.ReadLine();

                        biblioteca.AdicionarLivro(titulo, autor);
                        break;

                    case "2":
                        biblioteca.ListarLivros();
                        break;

                    case "3":
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        biblioteca.AdicionarUsuario(nome);
                        break;

                    case "4":
                        biblioteca.ListarUsuarios();
                        break;

                    case "5":
                        Console.Write("ID do Livro: ");
                        var idLivro = int.Parse(Console.ReadLine());
                        Console.Write("ID do Usuário: ");
                        var idUsuario = int.Parse(Console.ReadLine());
                        biblioteca.EmprestarLivro(idLivro, idUsuario);
                        break;

                    case "6":
                        Console.Write("ID do Empréstimo: ");
                        var idEmprestimo = int.Parse(Console.ReadLine());
                        biblioteca.DevolverLivro(idEmprestimo);
                        break;

                    case "7":
                        biblioteca.ListarEmprestimos();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();  // Aguarda o usuário pressionar uma tecla para continuar
            }
        }
    }
}

