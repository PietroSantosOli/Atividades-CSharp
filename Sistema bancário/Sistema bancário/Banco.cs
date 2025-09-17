using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_bancário
{
    public class Banco
    {
        private List<ContaBancaria> contas = new List<ContaBancaria>();

        private ContaBancaria BuscarConta(int numeroContaDigitado)
        {
            return contas.Find(conta => conta.numeroConta == numeroContaDigitado);
        }
        public void CriarConta()
        {
            Console.Write("Digite um nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine($@"
Escolha o tipo de conta: 
1 - Corrente
2 - Poupanca");
            int tipo = int.Parse(Console.ReadLine());

            ContaBancaria novaConta = tipo == 1 ? new ContaCorrente(titular) : new ContaPoupanca(titular);

            contas.Add(novaConta);
            Console.WriteLine($"Conta {novaConta.numeroConta} criada com sucesso!");
        }

        public void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int numeroContaDigitado = int.Parse(Console.ReadLine());

            ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);
            if (contaBuscada != null)
            {
                Console.Write("Digite o valor do deposito: ");
                double valor = double.Parse(Console.ReadLine());
                contaBuscada.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Conta nao encontrada");
            }
        }

            public void Sacar()
            {
            Console.Write("Digite o número da conta: ");
            int numeroContaDigitado = int.Parse(Console.ReadLine());

            ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

            if (contaBuscada != null)
            {
                Console.WriteLine("Digite o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());
                contaBuscada.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Conta nao encontrada");
            }

            }
        public void Listar()
        {
            if (contas.Count > 0)
            {
                foreach (var conta in contas)
                {
                    conta.ConsultarSaldo();
                }
            }
            else
            {
                Console.WriteLine("nennuma conta cadastrada");
            }
        }
    } 
}
