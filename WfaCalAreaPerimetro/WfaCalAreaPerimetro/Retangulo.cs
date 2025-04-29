using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalAreaPerimetro
{
    class Retangulo:Formas
    {
        private double baseRetangulo;
        private double alturaRetangulo;

        public Retangulo(string nome, double baseRetangulo, double alturaRetangulo) :base(nome)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public double BaseRetangulo { get => baseRetangulo; set => baseRetangulo = value; }
        public double AlturaRetangulo { get => alturaRetangulo; set => alturaRetangulo = value; }
        
        public override double area()
        {
            return baseRetangulo * alturaRetangulo;
        }

        public override double perimetro()
        {
            return 2 * (baseRetangulo + alturaRetangulo);
        }


    }
}
