using System;

namespace SistemaBiblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public override string ToString()
        {
            string devolvido = DataDevolucao.HasValue
                ? DataDevolucao.Value.ToString("dd/MM/yyyy")
                : "Pendente";
            return $"ID: {Id}, Livro: {Livro.Titulo}, Usuário: {Usuario.Nome}, Emprestado em: {DataEmprestimo:dd/MM/yyyy}, Devolvido: {devolvido}";
        }
    }
}
