//1. Boletim de Viagem
//-Crie variáveis para armazenar o destino de uma viagem, a distância em km e o valor da passagem.
//-Exiba os dados de forma organizada no console.
//Console.WriteLine("=== Boletim de viagem ===");
//string viagem = "Acapucu";
//double km = 230.5;
//double valor = 199.9;
//Console.WriteLine($"\n Viagem para {viagem} \n Distância: {km} KM \n Valor: R$:{valor} ");

//2. Diário do Clima
//Console.WriteLine("=== Clima de Hoje ===");
//Console.Write("Qual temperatura máxima de hoje: ");
//double TempMaxima = double.Parse(Console.ReadLine());
//Console.Write("Qual temperatura mínima de hoje: ");
//double TempMinima = double.Parse(Console.ReadLine());

//Console.WriteLine($"A temepratura máxima de hoje é {TempMaxima} e a mínima é {TempMinima} ");

//3. Relatório Financeiro
//Console.WriteLine("=== Relatório Financeiro ===");
//Console.Write("Qual é o seu salário ?: ");
//double salario = double.Parse(Console.ReadLine());
//Console.Write("Qual sua despesa mensal?: ");
//double despesa = double.Parse(Console.ReadLine());
//double sobra = salario - despesa;
//Console.WriteLine($"Saldo disponivel: {sobra}");

//4. Conversor de moedas
//Console.WriteLine("=== Conversor de moedas ===");
//Console.Write("Qual o valor em reais?: ");
//double salario = double.Parse(Console.ReadLine());
//double dolar = 5.47;
//Console.WriteLine($"Você tem {salario/dolar:F2} dólares");

//5. Cálculo de desconto
//Console.WriteLine("=== Cálculo de desconto ===");
//Console.Write("Qual é o valor do produto ?: ");
//double valor = double.Parse(Console.ReadLine());
//Console.Write("Qual é o desconto do produto ?: ");
//double desconto = double.Parse(Console.ReadLine());
//double ValorDesconto = valor * (desconto / 100);
//Console.WriteLine($"Valor inicial: {valor} | desconto aplicado: {ValorDesconto} | Total a pagar: {valor-ValorDesconto}");

//6.Divisão de Conta
//Console.WriteLine("=== Divisão de Conta ===");
//Console.Write("Qual é o valor total da refeicao?: ");
//double conta = double.Parse(Console.ReadLine());
//Console.Write("Qual a quantidade de pessoas?: ");
//int pessoas = int.Parse(Console.ReadLine());
//Console.WriteLine($"Cada um deve pagar {conta/pessoas} reais");

//7.Velocidade da via
//Console.WriteLine("=== Velocidade da via ===");
//Console.Write("Qual a velocidade do carro?: ");
//double velocidade = double.Parse(Console.ReadLine());
//if (velocidade >= 80.0)
//{
//    Console.WriteLine("Multado");
//}
//else
//{
//    Console.WriteLine("dentro do limite (até 80 km/h)");
//}

//8. Categoria de Votação
//Console.WriteLine("=== Categoria de votacao ===");
//Console.Write("Qual a sua idade: ");
//int idade = int.Parse(Console.ReadLine());
//if (idade < 18)
//{
//    Console.WriteLine("Nao permitido");
//}
//else if (idade >= 18 && idade < 60)
//{
//    Console.WriteLine("Voto obrigatório");
//}
//else
//{
//    Console.WriteLine("Voto facultativo");
//}

//9. Classificação de Números
//Console.WriteLine("=== Classificao de números ===");
//Console.Write("Digite um número: ");
//int num  = int.Parse(Console.ReadLine());
//if (num < 0)
//{
//    Console.WriteLine("É negativo");
//}else if (num == 0)
//{
//    Console.WriteLine("É zero");
//}
//else
//{
//    Console.WriteLine("É positivo");
//}
//10.Validacao de senha
//Console.WriteLine("=== Validacao de senha ===");
//Console.Write("Digite uma senha: ");
//string tentativa = Console.ReadLine(); 
//string senha = "12345";
//if (senha == tentativa)
//{
//    Console.WriteLine("Acesso permitido");
//}
//else
//{
//    Console.WriteLine("Acesso negado");
//}

//11. Contagem de pares

//Console.WriteLine("=== Contagem de pares ===");
//Console.Write("Digite um número: ");
//int num = int.Parse(Console.ReadLine());
//for (int i = 0; i < num; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    else
//    {
//    }
//}

//12. Quadrado de números
//Console.WriteLine("=== Quadrado de números ===");
//Console.Write("Digite um número: ");
//int num = int.Parse(Console.ReadLine());

//for (int i = 1; i < num; i++)
//{
//        Console.WriteLine(i * i);
//}

//13. Sequencia de Fibonacci(limitada)

//Console.WriteLine("=== Sequencia de Fibonacci ===");
//Console.Write("Digite quantos termos voce quer: ");
//int QuantidadeTermos = int.Parse(Console.ReadLine());
//int numeroAtual = 0;
//int intermediaria;
//int numeroAnterior = 1;

//for (int i = 1;i <= QuantidadeTermos; i++)

//{
//    Console.WriteLine(numeroAtual);

//    intermediaria = numeroAtual;

//    numeroAtual = numeroAtual + numeroAnterior;

//    numeroAnterior = intermediaria;
//}

//14. caca ao numero


using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("=== Caca ao Numero ===");
//int maior = int.MinValue;
//while (true) {
//Console.Write("Digite um número(digite 0 para sair): ");
//int numero = int.Parse(Console.ReadLine());

//if (numero != 0 && numero > maior)
//{
//maior = numero;
//    }
//    else if (numero == 0)
//{
//break;
//   }
// }
//Console.WriteLine($"O número maior é: {maior}");

//15 media de varios numeros

int soma = 0;
int quantidade = 0;
int numero;
while (true)
{
    Console.Write("Digite um número (número negativo para sair): ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0) // condição de parada
        break;

    if (numero > 0) // só considera positivos
    {
        soma += numero;
        quantidade++;
    }
}

if (quantidade > 0)
{
    double media = (double)soma / quantidade;
    Console.WriteLine($"A média dos números positivos digitados é: {media:F2}");
}
else
{
    Console.WriteLine("Nenhum número positivo foi digitado.");
}