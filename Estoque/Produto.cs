namespace Estoque
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string SKU { get; set; }

        public Produto(string nome, double preco, int quantidade,string sku)
        {
            SKU = sku;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;  
        }

        
        public virtual void ExibirDados()
        {
            Console.WriteLine($"ID = {SKU} | Nome do produto: {Nome} | Preco do produto {Preco} | Quantidade: {Quantidade}");
        }
        
    }
}
