//Soma dos elementos

//int[] soma = [10,20,30,40,50];
//Console.WriteLine(soma.Sum());

//maior e menor
//int[] maiorMenor = new int[10];
//int maior = maiorMenor[0];
//int menor = maiorMenor[1];


//for (int i = 0; i < maiorMenor.Length; i++)
//{
//    Console.Write($"Digite o {i + 1} número: ");
//    maiorMenor[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < maiorMenor.Length; i++)
//{
//    if (maiorMenor[i] > maior)
//    {
//        maior = maiorMenor[i];
//    }
//    if (maiorMenor[i] < menor)//ta dando 0
//    {
//        menor = maiorMenor[i];
//    }
//}

//Console.WriteLine($"O maior número é: {maior}");
//Console.WriteLine($"O menor número é: {menor}");



//contagem de numeros pares
//int[] numeros = new int[10];
//int[] numerosPares = new int[10];
//int contador = 0;

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write($"Digite o {i + 1} número: ");
//    numeros[i] = int.Parse(Console.ReadLine());
//    if (numeros[i] % 2 == 0)
//    {
//        numerosPares[contador] = numeros[i];
//        ++contador;
//    }
//    else
//    {
//    }
//}
//Console.WriteLine($"Números pares digitados:");
//for (int i = 0; i < contador; i++)
//{
//    Console.WriteLine(numerosPares[i]);
//}//CONSERTAR DEPOIS

//Inversão de elemento
//int[] inversao = {1,2,3,4,5,6,7,8};
//Array.Reverse(inversao);
//for (int i = 0; i < inversao.Length; i++)
//{
//    Console.WriteLine(inversao[i]);
//}

//frequencia de numero
//int[] numero = new int[10];

//for (int i = 0; i < numero.Length; i++)
//{
//    Console.Write($"Digite o {i + 1} número: ");
//    numero[i] = int.Parse(Console.ReadLine());
//}
//Console.Write("Digite um numero para ver a frequencia: ");
//int numeroEspecial = int.Parse(Console.ReadLine());

//int contador = 0;
//for (int i = 0; i < numero.Length; i++)
//{

//    if (numeroEspecial == numero[i])
//    {
//        contador++;
//    }
//}
//if (contador > 0)
//{
//    Console.WriteLine($"o número aparece {contador} vezes");
//}
//else
//{
//    Console.WriteLine("O número não se repete");
//}

//remover duplicatas

//int[] numeros = new int[10];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write("Digite um número");
//    numeros[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0;i < numeros.Length;i++)
//{
//    int numero = numeros[i];
//    int repetido = 0;

//    for (int j = 0; j < numeros.Length; j++)
//    {
//        if (numero == numeros[j])
//        {
//            repetido++;
//            if (repetido == 2)
//            {
//                numeros[j] = 0;
//            }
//        }
//    }
//}
//for (int i = 0; i < numeros.Length ; i++)
//{
//    Console.WriteLine($"Número {1+i}: {numeros[i]}");
//}

//numeros = numeros.Distinct().ToArray();

////ordem crescente

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write("Digite um número");
//    numeros[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(numeros);

//intersecao de arrays

int[] array1 = new int[5];
int[] array2 = new int[5];

Console.WriteLine("Digite 5 números para o primeiro array:");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"Posição {i + 1}: ");
    array1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nDigite 5 números para o segundo array:");
for (int i = 0; i < array2.Length; i++)
{
    Console.Write($"Posição {i + 1}: ");
    array2[i] = int.Parse(Console.ReadLine());
}

// usando LINQ para achar a interseção
var intersecao = array1.Intersect(array2).ToArray();

Console.WriteLine("\n=== Interseção dos Arrays ===");
if (intersecao.Length > 0)
{
    Console.WriteLine("Números em comum: " + string.Join(", ", intersecao));
}
else
{
    Console.WriteLine("Não há números em comum.");
}