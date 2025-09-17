using Sistema_bancário;

Banco banco = new Banco();

int escolha;

do
{
    Console.WriteLine($@"
===== Sistema bancario =====
1 - criar conta
2 - depositar
3 - sacar
4 - listar contas
0 - sair
");
    escolha = int.Parse(Console.ReadLine());

    switch(escolha)
    {
        case 1:
            banco.CriarConta();
            break;
        case 2:
            banco.Depositar();
            break;
        case 3:
            banco.Sacar();
            break;
        case 4:
            banco.Listar();
            break;
        case 0:
            Console.WriteLine("saindo do sistema...");
            break;
        default:
            Console.WriteLine("opcao invalida");
            break;
    }
} while (escolha != 0);