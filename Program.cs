using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_4_numeros_de_1_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            for (numeros = 1; numeros <= 50; numeros++)
            {
                numeros = numeros ;
                Console.WriteLine(numeros);
            }
            Console.ReadKey();
        }
    }
}