using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaHeranca
{
    internal class ContaEspecial : Conta // herança
    {
        private double limite;

        public double Limite { get => limite; set => limite = value; }

        public ContaEspecial() : base() 
        {
            limite = 0.0;
        }

        public ContaEspecial(int _nroConta, double _saldo, double _limite) : base(_nroConta, _saldo)
        {
            limite = 1000.0;
        }

        public override void Saque(double saque)
        {
            if (((saldo + limite) - saque) < 0.0)
                Console.WriteLine("Saque impossível! Sem limite na Conta");
            else
            {
                saldo = saldo - saque;
                if (saldo < 0.0)
                {
                    Console.WriteLine("Atenção!! Você entrou no Cheque Especial!");
                    Console.WriteLine("O seu saldo para saque é " + (limite + saldo));
                }

            }
        }

        public override void verSaldo()
        { base.verSaldo();
            Console.WriteLine("Herdei da minha mãe!");

        }


    }
}
