using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaEspecial
{
    internal class Conta
    {
        protected int nroConta;
        protected double saldo;

        public int NroConta { get => nroConta; set => nroConta = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public Conta()
        {
            nroConta = 0;
            saldo = 0.0;
        }

        public Conta(int _nroConta, double _saldo)
        {
            this.nroConta = _nroConta;
            this.saldo = _saldo;
        }

        public void Deposito(double deposito)
        {
            saldo = saldo + deposito; // saldo += deposito
        }

        public virtual void Saque(double saque) 
        {
            if ((saldo - saque) < 0)
                Console.WriteLine("Saldo insuficiente. Impossível fazer o saque");
            else
            {
                saldo = saldo - saque; // saldo -= saque
                Console.WriteLine("Saque efetuado com sucesso");
            }
            
        }

        public  void verSaldo()
        {
            Console.WriteLine("Saldo da conta " + nroConta + " = " + saldo);
        }


    }
}
