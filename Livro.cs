namespace SistemaBiblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Emprestado { get; set; }

        public void ExibirInformacoes()
        {
            string status = Emprestado ? "Emprestado" : "Disponível";
            Console.WriteLine($"ID: {Id}, Título: {Titulo}, Autor: {Autor}, Status: {status}");
        }
    }
}