using System;
using System.Collections.Generic;

namespace Estoque
{
    public class GerenciadorEstoque
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void ListarProdutos()
        {
            if (Produtos == null || Produtos.Count == 0)
            {
                Console.WriteLine("\nNão há produtos a serem listados!");
                return;
            }

            int cont = 1;
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine($"\nProduto #{cont}:");
                produto.ExibirDados();   
                cont++;
            }
        }

        public bool AdicionarProduto()
        {
            Console.WriteLine($@"
===== Selecione o produto =====
1 - Produto de vestuário
2 - Produto eletrônico
0 - Voltar
> ");
            if (!int.TryParse(Console.ReadLine(), out int tipoProduto))
                return false;

            if (tipoProduto == 0) return false;

            Produto novo = ColetarDado(tipoProduto);
            if (novo == null) return false;

            Produtos.Add(novo);
            return true;
        }

        public Produto ColetarDado(int tipoProduto)
        {
            try
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                if (!double.TryParse(Console.ReadLine(), out double preco))
                {
                    Console.WriteLine("Preço inválido.");
                    return null;
                }

                Console.Write("Quantidade: ");
                if (!int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    Console.WriteLine("Quantidade inválida.");
                    return null;
                }

                Console.Write("SKU: ");
                string sku = Console.ReadLine();

                if (tipoProduto == 1)
                {
                    Console.Write("Tamanho: ");
                    string tamanho = Console.ReadLine();
                    Console.Write("Cor: ");
                    string cor = Console.ReadLine();

                    ProdutoVestuario novoVestuario = new ProdutoVestuario(nome, preco, quantidade, sku, tamanho, cor);
                    return novoVestuario;
                }
                else if (tipoProduto == 2)
                {
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();

                    ProdutoEletronico novoEletronico = new ProdutoEletronico(nome, preco, quantidade, sku, marca, modelo);
                    return novoEletronico;
                }
                else
                {
                    Console.WriteLine("Tipo de produto inválido.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao coletar dados: " + ex.Message);
                return null;
            }
        }
        public bool RemoverProdutoPorSKU(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku) || Produtos == null || Produtos.Count == 0)
                return false;

            
            Produto item = Produtos.FirstOrDefault(p => string.Equals(p.SKU, sku, StringComparison.OrdinalIgnoreCase));
            if (item == null) return false;

            return Produtos.Remove(item);
        }
        public bool AtualizarQuantidade(string sku, int newQuantidade)
        {
            if (string.IsNullOrWhiteSpace(sku) || Produtos == null || Produtos.Count == 0)
                return false;

            if (newQuantidade < 0) return false; 

            Produto item = Produtos.FirstOrDefault(p => string.Equals(p.SKU, sku, StringComparison.OrdinalIgnoreCase));
            if (item == null) return false;

            item.Quantidade = newQuantidade;
            return true;
        }
        public List<Produto> Pesquisar(string query)
        {
            var resultados = new List<Produto>();
            if (string.IsNullOrWhiteSpace(query) || Produtos == null || Produtos.Count == 0)
                return resultados;

            string q = query.Trim();

            
            resultados = Produtos
                .Where(p => string.Equals(p.SKU, q))
                .ToList();


            return resultados;
        }
    }
}
