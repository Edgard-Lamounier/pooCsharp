using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaHeranca
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
            nroConta = _nroConta;
            saldo = _saldo;          
        }

        public void Deposito(double deposito)
        {
            saldo = saldo + deposito; // saldo += deposito
        }

        public virtual void Saque(double saque)
        {
            if ((saldo - saque) < 0)
                Console.WriteLine("Saque impossível! Sem limite na Conta");
            else
                saldo = saldo - saque;

        }

        public virtual  void verSaldo()
        {
            Console.WriteLine("Saldo atual da conta " + nroConta + 
                " = " + saldo);
        }
    }
}
