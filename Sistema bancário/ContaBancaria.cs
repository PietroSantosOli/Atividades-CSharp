using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_bancário
{
    public class ContaBancaria : IContaBancaria
    {
        private double saldo;
        public string Titular;
        public static int proximoNumero = 0;
        public int numeroConta;

        // método construtor que constrói o objeto  
        public ContaBancaria(string TitularRecebido)
        {
            //cria o objeto conta bancaria com o titular sendo o valor recebido
            Titular = TitularRecebido;
            //primeiro ele salva o número da conta e adiciona 1 depois
            numeroConta = ++proximoNumero;
            saldo = 0;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Conta: {numeroConta} | Titular {Titular} | Saldo = {saldo:F2}");
        }

        public virtual void Depositar(double valor)
        {
            //saldo = saldo + valor;
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado.\nSaldo atual: R${saldo:F2}");
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;

            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque no R${valor:2F} \n Saldo atual: R${saldo}");
                return true;
            }
        }
    }
}
