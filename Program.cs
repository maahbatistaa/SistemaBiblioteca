using SistemaBiblioteca.Services;
using SistemaBiblioteca.UI;

namespace SistemaBiblioteca
{
  class Program
  {
    static void Main(string[] args)
    {
      Biblioteca biblioteca = new Biblioteca();
      Menu menu = new Menu(biblioteca);

      menu.ExibirMenu();
    }
  }

}
