using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoCLT_HORISTA
{
    internal class EmpregadoCLT : Empregado
    {
        private double salario_mensal;

        public EmpregadoCLT() : base() 
        {
            salario_mensal = 0;
        }

        public EmpregadoCLT(string _primeiroNome, string _segundoNome, string _cpf,
                                double _salario_mensal) : base(_primeiroNome, _segundoNome, _cpf)
        {
            salario_mensal = _salario_mensal;
        }
        
        
        public double Salario_mensal { get => salario_mensal; set => salario_mensal = value; }

        public override double getSalLiquido()
        {
            if (salario_mensal >= 4000.00)
                return salario_mensal * 0.725;  // desconto de 27,5%
            else
                return salario_mensal * 0.85;   // desconto de 15,0%
        }



    }
}
