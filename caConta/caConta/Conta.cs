using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caConta
{
    internal class Conta
    {
        // atributos
        private string nome;
        private string cpf;
        private double saldo;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        // métodos 
        public Conta()
        {
        
        }

        public Conta(string _nome, string _cpf, double _saldo)
        {
            nome = _nome;
            cpf = _cpf;
            saldo = _saldo;
        }

        public void setSaldo(double novoSaldo) 
        { 
            saldo = novoSaldo;
            Console.WriteLine("Obrigado pela sua confiança");
        }

        public double getSaldo() 
        {
            return saldo;
        }

        public void setCPF(string novoCPF)
        {
            cpf = novoCPF;
        }

        public string getCPF()
        {
            return cpf;
        }

        public void imprimeDados()
        {
            Console.WriteLine("Nome = " + nome);
            Console.WriteLine("Cpf = " + this.cpf);
            Console.WriteLine("Saldo = " +  saldo);
        }


    } // fim da classe Conta
}
