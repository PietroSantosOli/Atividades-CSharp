Console.Write("Escreva o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Escreva o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Você deseja somar/+ - subtrair/- - multiplicar/* - dividir// ");
string opcao = Console.ReadLine();

// os dois || significam OR , && significa AND 
if (opcao == "somar" || opcao == "+")
    {
    Console.WriteLine($"A soma é: {num1 + num2}");
    }
else if (opcao == "subtrair" || opcao == "-")
    {
    Console.WriteLine($"A subtracao é: {num1 - num2}");
    }
else if (opcao == "multiplicar" || opcao == "*")
    {
    Console.WriteLine($"A multiplicacao é: {num1 * num2}");
    }
else if (opcao == "dividir" || opcao == "/")
    {
    Console.WriteLine($"A divisao é: {num1 / num2}");
    }
else
    {
    Console.WriteLine("ERRO");
    }