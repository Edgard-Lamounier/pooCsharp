using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaEspecial
{
    internal class ContaEspecial : Conta // herança
    {
        private double limite;

        public ContaEspecial() : base() 
        {
            limite = 0.0; 
        }

        public ContaEspecial(int _nroConta, double _saldo, double _limite) : base(_nroConta, _saldo)
        {
            this.limite = _limite;
        }

        public double Limite { get => limite; set => limite = value; }

        public override void Saque(double saque)
        {
            if(((saldo + limite) - saque) < 0)
                Console.WriteLine("Saldo insuficiente. Impossível fazer o saque");
            else
            {
                saldo = saldo - saque; // saldo -= saque
                Console.WriteLine("Saque efetuado com sucesso");
            }
        }

        public void verSaldo()
        {
            Console.WriteLine("Saldo da conta " + nroConta + " = " + saldo);
        }
    }
}
