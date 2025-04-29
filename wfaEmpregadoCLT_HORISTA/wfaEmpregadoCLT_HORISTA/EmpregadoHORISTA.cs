using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoCLT_HORISTA
{
    internal class EmpregadoHORISTA : Empregado
    {
        private int nro_horas;
        private double preco_hora;

        public EmpregadoHORISTA() : base() 
        {
            nro_horas = 0;
            preco_hora = 0;
        }

        public EmpregadoHORISTA(string _primeiroNome, string _segundoNome, string _cpf,
            int _nro_horas, double _preco_hora) : base(_primeiroNome, _segundoNome, _cpf)
        {
            nro_horas = _nro_horas;
            preco_hora= _preco_hora;
        }

        public int Nro_horas { get => nro_horas; set => nro_horas = value; }
        public double Preco_hora { get => preco_hora; set => preco_hora = value; }

        public override double getSalLiquido()
        {
            return (nro_horas * preco_hora) * 0.85;
                
        }
    }
}
