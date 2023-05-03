using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorOuIgual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float N1, N2;

            Console.WriteLine(" digite o primeiro valor");
            N1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" digite o segundo valor");
            N2 = float.Parse(Console.ReadLine());

            if (N1 == N2)
            {
                Console.WriteLine(" os valores são iguais");
            }
            else
            {
                if (N1 > N2)
                {
                    Console.WriteLine(" o primeiro valor é maior");
                }
                else
                {
                    Console.WriteLine(" o segundo valor maior");
                }
            }
        }
    }
}
