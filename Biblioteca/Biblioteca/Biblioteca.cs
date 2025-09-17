namespace Biblioteca
{
    public class Biblioteca
    {
        public List<Livro> livros { get; set; } = new List<Livro>();

        public void ListarLivros()
        {
            if (livros == null || livros.Count == 0)
            {
                Console.WriteLine("\nNão há livros a serem listados!");
                return;
            }

            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livros[i]}");
            }
        }
        public bool AdicionarLivro()
        {
            Console.Write("Nome do livro: ");
            string livro = Console.ReadLine();
            Console.Write("Autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Ano de lancamento do livro: ");
            string ano = Console.ReadLine();
            bool estado = false;

            Livro novoLivro = new Livro(livro,autor,ano,estado);

            livros.Add(novoLivro);
            return true;
        }
        public bool RemoverLivro()
        {
            if (livros.Count == 0)
            {
                return false;
            }
            Console.Write("Informe o nome do livro a ser excluído: ");
            string nomeLivro = Console.ReadLine();
            int removidos = livros.RemoveAll(livro => livro.Titulo.Equals(nomeLivro));
            if (removidos > 0)
            {
                Console.WriteLine($"Livro \"{nomeLivro}\" removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
            return true;
        }
        public bool PesquisarLivro()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return false;
            }

            Console.Write("Digite o nome do livro para pesquisar: ");
            string pesquisa = Console.ReadLine();

            // Busca exata ignorando maiúsc/minúsc
            Livro resultado = livros.Find(l => l.Titulo.Equals(pesquisa));

            if (resultado != null)
            {
                Console.WriteLine("Livro encontrado:");
                Console.WriteLine(resultado);
                return true;
            }
            Console.WriteLine("Livro não encontrado.");
            return false;
        }

        public bool EmprestimoLivro()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return false;
            }

            Console.WriteLine("=== Lista de Livros ===");
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livros[i]}");
            }

            Console.Write("Informe o número do livro a ser emprestado: ");
            int numLivro;
            if (!int.TryParse(Console.ReadLine(), out numLivro) || numLivro < 1 || numLivro > livros.Count)
            {
                Console.WriteLine("Número inválido.");
                return false;
            }

            Livro livroSelecionado = livros[numLivro - 1];

            if (livroSelecionado.Estado)
            {
                Console.WriteLine("Esse livro já está emprestado.");
            }
            else
            {
                livroSelecionado.Estado = true;
                Console.WriteLine($"Você pegou \"{livroSelecionado.Titulo}\" emprestado.");
            }

            return true;
        }
        public bool DevolucaoLivro()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return false;
            }

            Console.WriteLine("=== Lista de Livros ===");
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livros[i]}");
            }

            Console.Write("Informe o número do livro a ser devolvido: ");
            int numLivro;
            if (!int.TryParse(Console.ReadLine(), out numLivro) || numLivro < 1 || numLivro > livros.Count)
            {
                Console.WriteLine("Número inválido.");
                return false;
            }

            Livro livroSelecionado = livros[numLivro - 1];

            if (!livroSelecionado.Estado)
            {
                Console.WriteLine("Esse livro não estava emprestado.");
            }
            else
            {
                livroSelecionado.Estado = false;
                Console.WriteLine($"Você devolveu \"{livroSelecionado.Titulo}\".");
            }

            return true;
        }

    }
}
