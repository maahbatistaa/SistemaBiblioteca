namespace SistemaBiblioteca
{
  class Program
  {
    static List<Livro> livros = new List<Livro>();
    static int proximoId = 1;

    static void Main(string[] args)
    {
      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== Sistema de Biblioteca ===");
        Console.WriteLine("1. Adicionar Livro");
        Console.WriteLine("2. Listar Livros");
        Console.WriteLine("3. Emprestar Livro");
        Console.WriteLine("4. Devolver Livro");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
          case "1":
            AdicionarLivro();
            break;
          case "2":
            ListarLivros();
            break;
          case "3":
            EmprestarLivro();
            break;
          case "4":
            DevolverLivro();
            break;
          case "5":
            return;
          default:
            Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
            Console.ReadLine();
            break;
        }

      }
    }

    static void AdicionarLivro()
    {
      Console.Clear();
      Console.WriteLine("=== Adicionar Livro ===");
      Console.Write("Título: ");
      string titulo = Console.ReadLine();
      Console.Write("Autor: ");
      string autor = Console.ReadLine();

      Livro novoLivro = new Livro
      {
        Id = proximoId,
        Titulo = titulo,
        Autor = autor,
      };

      livros.Add(novoLivro);
      Console.WriteLine("Livro adicionado com sucesso! Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ListarLivros()
    {
      Console.Clear();
      Console.WriteLine("=== Lista de Livros ===");
      foreach (var livro in livros)
      {
        livro.ExibirInformacoes();
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void EmprestarLivro()
    {
      Console.Clear();
      Console.WriteLine("=== Emprestar Livro ===");
      Console.Write("Informe o ID do livro: ");
      if (int.TryParse(Console.ReadLine(), out int id))
      {
        var livro = livros.Find(l => l.Id == id);
        if (livro != null && !livro.Emprestado)
        {
          livro.Emprestado = true;
          Console.WriteLine("Livro emprestado com sucesso!");
        }
        else
        {
          Console.WriteLine("Livro não encontrado ou já emprestado.");
        }
      }
      else
      {
        Console.WriteLine("ID inválido.");
      }

      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void DevolverLivro()
    {
      Console.Clear();
      Console.WriteLine("=== Devolver Livro ===");
      Console.Write("Informe o ID do livro: ");
      if (int.TryParse(Console.ReadLine(), out int id))
      {
        var livro = livros.Find(l => l.Id == id);
        if (livro != null && livro.Emprestado)
        {
          livro.Emprestado = false;
          Console.WriteLine("Livro devolvido com sucesso!");
        }
        else
        {
          Console.WriteLine("Livro não encontrado ou já devolvido.");
        }
      }
      else
      {
        Console.WriteLine("ID inválido.");
      }

      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }
  }
}