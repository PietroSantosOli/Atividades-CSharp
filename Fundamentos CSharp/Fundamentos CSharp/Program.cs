//Console.WriteLine("Digite seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite sua idade: ");
//int idade = int.Parse 
//    (Console.ReadLine());
//double altura = 1.90;
//bool fezAniversario = true;

//Console.WriteLine("Nome: " + nome);
//Console.WriteLine("Idade: " + idade);

//Console.WriteLine("Digite o primeiro número");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o segundo número");
//int num2 = int.Parse(Console.ReadLine());

//int soma = num1 + num2;

//Console.WriteLine("O resultado da soma é: " + soma);

//atividade 1.1

//string nome = "Pietro";

//int idade = 19;

//double altura = 1.89;
//// $ antes da "" para poder colocar a variavel junto do texto
//Console.WriteLine($"Nome: {nome} - Idade: {idade} - Altura: {altura}");

//atividade 1.2

//string produto = "Celular";

//int quantidade = 10;

//double valor = 299.99;
//// $ antes da "" para poder colocar a variavel junto do texto
//Console.WriteLine($"Produto: {produto} - Quantidade: {quantidade} - Valor: {valor}");


//2.1 e 3.1
//Console.WriteLine("Digite seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite sua idade: ");
//int idade = int.Parse
//    (Console.ReadLine());
//Console.WriteLine("Digite sua altura: ");
//double altura = double.Parse
//    (Console.ReadLine());
//// $ antes da "" para poder colocar a variavel junto do texto
//Console.WriteLine($"Nome: {nome} - Idade: {idade} - Altura: {altura}");

//2.2 e 3.2
//Console.WriteLine("Digite o nome do produto: ");
//string produto = Console.ReadLine();
//Console.WriteLine("Digite sua quantidade no estoque: ");
//int quantidade = int.Parse
//    (Console.ReadLine());
//Console.WriteLine("Digite o valor do produto: ");
//double valor = double.Parse
//    (Console.ReadLine());
//// $ antes da "" para poder colocar a variavel junto do texto
//Console.WriteLine($"Produto: {produto} - Quantidade: {quantidade} - Valor: {valor}");

//4.1
//Console.WriteLine("Digite o primeiro número");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o segundo número");
//int num2 = int.Parse(Console.ReadLine());

//int soma = num1 + num2;

//int subtracao = num1 - num2;

//int multiplicacao = num1 * num2;

//double divisao = num1 / num2;

//Console.WriteLine($"Soma {soma} - Subtração: {subtracao} - Multiplicação: {multiplicacao} - Divisão: {divisao}");

//4.2
Console.WriteLine("Digite o nome do produto: ");
string produto = Console.ReadLine();

Console.WriteLine("Digite o preço do produto: ");
Double preco = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade comprada");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de dinheiro que você possui: ");
Double dinheiro = Double.Parse(Console.ReadLine());
double valorAPagar = preco * quantidade;


if ((dinheiro - valorAPagar) >= 0) 
{
    Console.WriteLine($"Você está comprando {quantidade} {produto}(s), ");
};

//4.3

//Console.WriteLine("Digite a primeira nota: ");
//double nota1 =double.Parse(Console.ReadLine());
//Console.WriteLine("Digite a segunda nota: ");
//double nota2=double.Parse(Console.ReadLine());
//Console.WriteLine("Digite a terceira nota: ");
//double nota3=double.Parse(Console.ReadLine());

//double soma = nota1 + nota2 + nota3;
//double media = soma/3;
//Console.WriteLine($"A média é: {media}");
