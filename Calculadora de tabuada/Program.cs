bool calcularNovamente = false;

do
{
    Console.WriteLine("=== Calculadora de tabuada ===");
    Console.Write("Insira o número que deseja calcular: ");
    int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"=== Tabuada do {numeroEscolhido} ===");
    for (int contador = 1; contador <= 10; contador++)
    {
        Console.WriteLine($"=== {contador} x {numeroEscolhido} = {contador * numeroEscolhido}");
    }
    bool decisaoValida;
    Console.WriteLine("Deseja calcular o IMC novamente?: (1 = SIM, 2 = NAO");
    string decisao = Console.ReadLine();
    do
    {
        switch (decisao)
        {
            case "1":
                calcularNovamente = true;
                decisaoValida = true;
                break;
            case "2":
                calcularNovamente = false;
                decisaoValida = true;
                break;
            default:
                Console.WriteLine("\n Opçao inválida, digite uma opcao válida");
                decisaoValida = false;
                break;
        }

    } while (calcularNovamente == false);

} while (calcularNovamente == true);