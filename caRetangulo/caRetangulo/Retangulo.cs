using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Retangulo
    {
        // atributos 
        private double comprimento; // private --> atributo só é acessado dentro da classe
        private double altura;

        public double Comprimento { get => comprimento; set => comprimento = value; }
        public double Altura { get => altura; set => altura = value; }


        // métodos (parecem funções em C)
        public Retangulo() // ARIDADE 0 --> construtor default
        {
            comprimento = 5.0;
            altura = 5.0;
        }

        public Retangulo(double comp, double alt) // ARIDADE 2
        {
            comprimento = comp; 
            altura = alt;
        }

        public void imprimeDados()
        {
            Console.WriteLine("Comprimento = " + comprimento);
            Console.WriteLine("Altura = " + altura);
        }

        public void setComprimento(double novoValor) // altera o valor do atributo
        {
            comprimento = novoValor;
        }

        public void setAltura(double novoValor)
        {
            altura = novoValor;
        }

        public double getComprimento() // retona o valor do atributo
        {
            return comprimento;
        }

        public double getAltura()
        {
            return altura;
        }


        public double Perimetro()
        {
            return (2 * (comprimento + altura));
        }

        public double Area()
        {
            return(comprimento * altura);
        }



    } // fim da classe Retangulo
}
