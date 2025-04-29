using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratThrow
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //NumberGenerator n = new NumberGenerator();
            //Console.WriteLine(n.GetNumber(-1));
            //Console.ReadLine();
            int[] array1 = { 0, 0 };
            int[] array2 = { 0, 0 };

            try
            {
                Array.Copy(array1, array2, -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: {0}", e);
                throw;
            }
            finally
            {
                Console.WriteLine("This statement is always executed");
            }
        }
    }
}
