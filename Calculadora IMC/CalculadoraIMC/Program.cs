using System.ComponentModel;

Console.WriteLine("=== Calculadora de IMC ===");
bool CalcularNovamente = false;

do
{
    Console.Write("Digite seu peso(kg): ");
    //convert.toDouble = double.Parse - converte os dois do mesmo jeito
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua altura ex: 1.90: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);
    if (imc <= 18.5)
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Baixo peso");
    }
    else if (imc >= 18.6 && imc <= 24.9)
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Peso normal");
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Sobrepeso");
    }
    else if (imc >= 30.0 && imc <= 34.9)
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 1");
    }
    else if (imc >= 35.0 && imc <= 39.9)
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 2");
    }
    else
    {
        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 3");
    }
    bool decisaoValida = false;

    Console.WriteLine("Deseja calcular o IMC novamente?: (1 = SIM, 2 = NAO");
    string decisao = Console.ReadLine();

    do
    {
        switch (decisao)
        {
            case "1":
                CalcularNovamente = true;
                decisaoValida = true;
                break;
            case "2":
                CalcularNovamente = false;
                decisaoValida = true;
                break;
            default:
                Console.WriteLine("\n Opçao inválida, digite uma opcao válida");
                decisaoValida = false;
                break;
        }

    } while (CalcularNovamente == false);

} while (CalcularNovamente == true);

//Utilizando o switch
//switch (imc)
//{
//    case <= 18.5:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Baixo peso");
//        break;
//    case >= 18.6 and  <= 24.9:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Peso normal");
//        break;
//    case >= 25 and <= 29.9:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Sobrepeso");
//        break;
//    case  >= 30.0 and  <= 34.9:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 1");
//        break;
//    case >= 35.0 and <= 39.9:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 2");
//        break;
//    default:
//        Console.WriteLine($"Seu imc é: {imc:F2} - Classificacao: Obesidade Grau 3");
//        break ;



