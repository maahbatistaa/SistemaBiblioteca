namespace SistemaBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Emprestado { get; private set; }

        public void Emprestar()
        {
            Emprestado = true;
        }

        public void Devolver()
        {
            Emprestado = false;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Título: {Titulo}, Autor: {Autor}, Disponivel: {(Emprestado ? "Não" : "Sim")}";
        }
    }
}
