using System;
using System.Collections.Generic;
using System.Linq;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Services
{
    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();
        private int proximoIdLivro = 1;
        private int proximoIdUsuario = 1;
        private int proximoIdEmprestimo = 1;
        private const int LimiteEmprestimos = 3;
        private const int DiasMaximosEmprestimo = 14;

        // Gerenciamento de Livros
        public void AdicionarLivro(string titulo, string autor)
        {
            var novoLivro = new Livro
            {
                Id = proximoIdLivro++,
                Titulo = titulo,
                Autor = autor
            };

            livros.Add(novoLivro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        public void ListarLivros()
        {
            Console.WriteLine("=== Lista de Livros ===");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }

        // Gerenciamento de Empréstimos
        public void EmprestarLivro(int idLivro, int idUsuario)
        {
            var livro = livros.FirstOrDefault(l => l.Id == idLivro);
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (livro == null || usuario == null || livro.Emprestado)
            {
                Console.WriteLine("Livro ou usuário inválido, ou o livro já está emprestado.");
                return;
            }

            var emprestimosAtuais = emprestimos.Count(e => e.Usuario.Id == idUsuario && e.DataDevolucao == null);
            if (emprestimosAtuais >= LimiteEmprestimos)
            {
                Console.WriteLine("O usuário já atingiu o limite de empréstimos.");
                return;
            }

            var novoEmprestimo = new Emprestimo
            {
                Id = proximoIdEmprestimo++,
                Livro = livro,
                Usuario = usuario,
                DataEmprestimo = DateTime.Now
            };

            livro.Emprestar();
            emprestimos.Add(novoEmprestimo);
            Console.WriteLine($"Livro '{livro.Titulo}' emprestado para {usuario.Nome}.");
        }

        public void DevolverLivro(int idEmprestimo)
        {
            var emprestimo = emprestimos.FirstOrDefault(e => e.Id == idEmprestimo && e.DataDevolucao == null);
            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo inválido ou livro já devolvido.");
                return;
            }

            emprestimo.DataDevolucao = DateTime.Now;
            emprestimo.Livro.Devolver();
            Console.WriteLine($"Livro '{emprestimo.Livro.Titulo}' devolvido com sucesso.");
        }

        public void ListarEmprestimos()
        {
            Console.WriteLine("=== Histórico de Empréstimos ===");
            foreach (var emprestimo in emprestimos)
            {
                Console.WriteLine(emprestimo);
            }
        }

        // Gerenciamento de Usuários
        public void AdicionarUsuario(string nome)
        {
            var novoUsuario = new Usuario
            {
                Id = proximoIdUsuario++,
                Nome = nome,
            };

            usuarios.Add(novoUsuario);
            Console.WriteLine("Usuário adicionado com sucesso!");
        }

        public void ListarUsuarios()
        {
            Console.WriteLine("=== Lista de Usuários ===");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
    }
}
