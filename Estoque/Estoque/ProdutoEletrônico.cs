namespace Estoque
{
    public class ProdutoEletronico : Produto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public ProdutoEletronico( string nome, double preco, int quantidade,string sku,string marca, string modelo) : base(nome,preco,quantidade,sku)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo}");
        }
    }
}
