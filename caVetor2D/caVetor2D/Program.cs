using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetor2D v1 = new Vetor2D();
            Vetor2D v2 = new Vetor2D(2.0, 3.0);
            Vetor2D v3 = new Vetor2D("Criando pelo teclado");

            Console.WriteLine("Produto Escalar entre v2 e v3 = " +
                v2.ProdutoEscalar(v3));

            v1 = v2.Soma(v3);
            v1.Imprime();

            Vetor2D v4 = new Vetor2D();

            v4 = Vetor2D.Soma2(v2, v3);

            Console.ReadLine();
        }
    }
}
