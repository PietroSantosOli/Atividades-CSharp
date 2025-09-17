using System.Threading.Channels;
using Atividade_POO;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        
    }

    public virtual void ExibirInformacoes()
    {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
    }
    public virtual void ExibirInformacoes(string sobrenome)
    {
        Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
    }
    public virtual void Apresentar()
    {
        string sobrenome = "Santos";
        Console.WriteLine($"Olá! {Nome} {sobrenome}");
    }
    
}

public class Funcionario : Pessoa {
    public double Salario;

    public Funcionario(string nome, int idade, double salario) : base(nome, idade)
    {
        Salario = salario;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Salário: R${Salario:F2}");
    }
}

public class Veiculo()
{
    public virtual void mover()
    {
        Console.WriteLine("Movendo...");
    }
}
public class Carro : Veiculo
{
    public override void mover() {
        Console.WriteLine("Se movendo de carro...");
            }
}
public class Bicicleta : Veiculo
{
    public override void mover()
    {
        Console.WriteLine("Se movendo de bicicleta...");
    }
}
public class Calculadora()
{
    public static void Somar(int num1, int num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); 
    }
    public static void Multiplicar(int num1, int num2)
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
    }
}
class Programa
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa("Pietro", 19);
        
        Funcionario funcionario = new Funcionario("pietro",19,1000);

        pessoa.ExibirInformacoes();
        funcionario.ExibirInformacoes();
        pessoa.Apresentar();
        
        Veiculo carro = new Carro();
        carro.mover();
        Veiculo bicicleta = new Bicicleta();
        bicicleta.mover();
        
        Calculadora.Somar(3,4);
        Calculadora.Multiplicar(3,4);
        
    }
}






