//funcao soma
//void Somar(){ 
//    int Somar(int num1, int num2)
//    {
//        return num1 + num2;
//    }
//    int resultado = Somar(15, 5);
//    Console.WriteLine($"A soma é: {resultado}");
//}
//Somar();

//funcao media
//void Media()
//{
//    double[] notas = { 10, 10, 10 };
//    double media = notas.Sum() / notas.Length;
//    Console.WriteLine($"A média das notas é {media}");
//}
//Media();

//funcao par ou impar
//void ParImpar()
//{
//    int num = 12;
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("O número é par");
//    }
//    else
//    {
//        Console.WriteLine("O número é impar");
//    }
//}
//ParImpar();

//função fatorial
//Console.Write("Digite um número para calcular o fatorial: ");
//int n = int.Parse(Console.ReadLine());

//long resultado = Fatorial(n);

//Console.WriteLine($"{n}! = {resultado}");
//long Fatorial(int n)
//    {
//    long fat = 1;

//    for (int i = 2; i <= n; i++)
//    {
//        fat *= i;
//    }

//    return fat;
//}

//inverter string

//Console.Write("Digite uma palavra ou frase: ");
//string texto = Console.ReadLine();

//string invertida = InverterString(texto);

//Console.WriteLine($"String invertida: {invertida}");
//string InverterString(string s)
//{
//    string resultado = "";
//    for (int i = s.Length - 1; i >= 0; i--)
//    {
//        resultado += s[i];
//    }
//    return resultado;
//}

//contar vogais

Console.Write("Digite uma palavra ou frase: ");
string texto = Console.ReadLine();

int quantidadeVogais = ContarVogais(texto);

Console.WriteLine($"A quantidade de vogais na frase é: {quantidadeVogais}");

static int ContarVogais(string s)
{
    int contador = 0;
    string vogais = "aeiouAEIOU"; // considerar maiúsculas e minúsculas

    foreach (char c in s)
    {
        if (vogais.Contains(c))
        {
            contador++;
        }
    }

    return contador;
}