namespace SistemaBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}";
        }
    }
}
