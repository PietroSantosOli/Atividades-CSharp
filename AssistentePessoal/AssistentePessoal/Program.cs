using System;

List<string> tarefas = new List<string>();
List < bool> statusTarefas = new List<bool>();


//funcao -> verificar, atualizar
void ExibirMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("===== ASSISTENTE PESSOAL =====");
    Console.WriteLine("1 - Adicionar tarefas");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Marcar tarefas como concluídas");
    Console.WriteLine("4 - Excluir tarefas");
    Console.WriteLine("5 - Exibir resumo das tarefas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opcao: ");
}

void CadastrarTarefa()
{
    Console.WriteLine("Digite a nova tarefa: ");
    string novaTarefa = Console.ReadLine();
    //adicionando a nova tarefa na listas
    tarefas.Add(novaTarefa);
    statusTarefas.Add(false);
    Console.WriteLine("tarefa adicionada!");
}

void ListarTarefas()
{
    //verificar se existe alguma tarefa cadastrada
    if(tarefas.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada");
        return;
    }
    // tarefas. coun ==10.0
    Console.WriteLine("=== LISTA DE TAREFAS ===");
    for (int i = 0; i < tarefas.Count; i++)
    {
        bool status = statusTarefas[i];
        string check;
        if (status == true)
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }
        Console.WriteLine($"{check} - {tarefas[i]}");
    }
}

void MarcarComoConcluida()
{
    ListarTarefas();
    Console.WriteLine("informe o número da tarefa a ser concluída");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;

    if (numTarefa >= 0 && numTarefa <tarefas.Count)
    {
        statusTarefas[numTarefa] = true;
        Console.WriteLine("Tarefa marca como concluída");
    }
    else
    {
        Console.WriteLine("Número inválido. Essa tarefa nao existe!");
    }
}

void ExcluirTarefas()
{
    ListarTarefas();
    Console.WriteLine("informe o número da tarefa a ser excluída");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;

    if (numTarefa >= 0 && numTarefa < tarefas.Count)
    {
        tarefas.RemoveAt(numTarefa);
        statusTarefas.RemoveAt(numTarefa);
        Console.WriteLine("Tarefa removida com sucesso");
    }
    else
    {
        Console.WriteLine("Número inválido. Essa tarefa nao existe!");
    }
}

void ExibirResumo()
{
    int totalTarefas = tarefas.Count;
    //Esse pega todos os status com true e false
    //int tarefasConcluidas = statusTarefas.Count;
    // estamos pegando somente os status que estao true
    int tarefasConcluidas = statusTarefas.FindAll( x => x).Count();
    int tarefasPendentes = totalTarefas - tarefasConcluidas;

    Console.WriteLine("==== RESUMO ====");
    Console.WriteLine($"Total de tarefas: {totalTarefas}");
    Console.WriteLine($"Total de tarefas concluídas: {tarefasConcluidas}");
    Console.WriteLine($"Total de tarefas pendentes: {tarefasPendentes}");

}


do {
    ExibirMenu();
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            CadastrarTarefa();
            break;
        case "2":
            ListarTarefas();
            break ;
        case "3":
            MarcarComoConcluida();
            break;
        case "4":
            ExcluirTarefas();
            break;
        case "5":
            ExibirResumo();
            break;
        case "0":
            Console.WriteLine("Encerrando o programa...");
            return;
        default:
            Console.WriteLine("Opcao inválida! Tente novamente");
            break;

    }
}while (true);