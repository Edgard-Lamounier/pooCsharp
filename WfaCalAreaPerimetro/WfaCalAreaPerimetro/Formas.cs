using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalAreaPerimetro
{
    public abstract class Formas
    {
        protected string nome;

        public Formas(string _nome)
        {
            nome = _nome;
        }

        public string Nome { get => nome; set => nome = value; }

        public virtual double area()
        {
            return 0.0;
        }

        public virtual double perimetro()
        {
            return 0.0;
        }
    }
}
