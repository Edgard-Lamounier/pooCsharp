using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaBancaria
{
    internal class ContaBancaria
    {
        // atributos 
        private int numero_conta;
        private string nome;
        private double saldo;

        // métodos
        public ContaBancaria() // construtor default
        {
            numero_conta = 0;
            nome = string.Empty;
            saldo = 0;
        }

        public ContaBancaria(int  x, string y, double z)
        {
            numero_conta = x;
            nome = y;
            saldo = z;
        }

        public void imprime()
        {
            Console.WriteLine("Numero da conta =  " + numero_conta);
            Console.WriteLine("Nome = " +  nome);
            Console.WriteLine("Saldo = " +  saldo);
        }

        public void Deposito(double deposito)
        {
            saldo = saldo + deposito;
        }

        public void Saque(double saque)
        {
            saldo = saldo - saque;
        }
    }
}
