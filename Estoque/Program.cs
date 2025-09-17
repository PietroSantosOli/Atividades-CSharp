using System;
using Estoque;

class Program
{
    static void Main()
    {
        var gerenciador = new GerenciadorEstoque();

        while (true)
        {
            Console.WriteLine(@"
1 - Cadastrar um produto
2 - Listar Produtos
3 - Remover produto por SKU
4 - Atualizar quantidade por SKU
5 - Pesquisar produtos
0 - Sair
> ");
            string opcao = Console.ReadLine();

            if (opcao == "0")
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else if (opcao == "1")
            {
                bool ok = gerenciador.AdicionarProduto();
                Console.WriteLine(ok ? "Produto cadastrado com sucesso." : "Cadastro cancelado/erro.");
            }
            else if (opcao == "2")
            {
                gerenciador.ListarProdutos();
            }
            if (opcao == "3")
            {
                Console.Write("Informe o SKU do produto a remover: ");
                string sku = Console.ReadLine();
                bool ok = gerenciador.RemoverProdutoPorSKU(sku);
                Console.WriteLine(ok ? "Produto removido com sucesso." : "Produto não encontrado.");
            }
            else if (opcao == "4")
            {
                Console.Write("Informe o SKU do produto a atualizar: ");
                string sku = Console.ReadLine();
                Console.Write("Informe a nova quantidade: ");
                if (int.TryParse(Console.ReadLine(), out int novaQuantidade))
                {
                    bool ok = gerenciador.AtualizarQuantidade(sku, novaQuantidade);
                    Console.WriteLine(ok ? "Quantidade atualizada." : "Falha ao atualizar (SKU não encontrado ou valor inválido).");
                }
                else
                {
                    Console.WriteLine("Quantidade inválida.");
                }
            }
            else if (opcao == "5")
            {
                Console.Write("Pesquisar por nome (parcial) ou SKU (exato): ");
                string query = Console.ReadLine();
                var resultados = gerenciador.Pesquisar(query);
                if (resultados == null || resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum produto encontrado.");
                }
                else
                {
                    Console.WriteLine($"\n{resultados.Count} produto(s) encontrado(s):");
                    int i = 1;
                    foreach (var p in resultados)
                    {
                        Console.WriteLine($"\nResultado #{i}:");
                        p.ExibirDados();
                        i++;
                    }
                }
            }
            
            
        }
    }
}
