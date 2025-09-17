namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Ano { get; set; }
        public bool Estado { get; set; }

        public Livro(string titulo, string autor, string ano, bool estado)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Estado = estado;
        }
        public override string ToString()
        {
            string status = Estado ? "Emprestado" : "Disponível";
            return $"{Titulo} - {Autor} ({Ano}) [{status}]";
        }
    }
}
