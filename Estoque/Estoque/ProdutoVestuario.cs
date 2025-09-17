namespace Estoque
{
    public class ProdutoVestuario : Produto
    {
        public string Tamanho { get; set; }
        public string Cor { get; set; }

        public ProdutoVestuario(string nome, double preco, int quantidade, string sku, string tamanho, string cor) : base(nome, preco, quantidade,sku)
        {
            Tamanho = tamanho;
            Cor = cor;
        }
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Tamanho: {Tamanho} | Cor: {Cor}");
        }
    }
}
