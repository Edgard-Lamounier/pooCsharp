using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalAreaPerimetro
{
    class Quadrado : Formas
    {
        internal double ladoQuadrado;

        public Quadrado(string nome, double _ladoQuadrado): base(nome)
        {
            ladoQuadrado = _ladoQuadrado;
        }

        public double LadoQuadrado { get => ladoQuadrado; set => ladoQuadrado = value; }

        public override double area()
        {
            return  Math.Pow(ladoQuadrado, 2);
        }

        public override double perimetro()
        {
            return ladoQuadrado * 4;
        }

    }
}
