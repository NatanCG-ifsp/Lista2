using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float L1,L2,L3;

            Console.WriteLine("primeiro valor");
            L1 = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor");
            L2 = float.Parse(Console.ReadLine());
            Console.WriteLine("terceiro valor");
            L3 = float.Parse(Console.ReadLine());

            if(L1+L2 > L3 && L1+L3 > L2 && L2+L3 >L1)
            {
                if(L1 != L2 && L1 != L3 && L2 != L3)
                {
                    Console.WriteLine("é um triângulo escaleno");
                }
                else
                {
                    if(L1 == L2 && L1 != L3 || L1 == L3 && L1 != L2 || L2 == L3 && L2 != L1)
                    {
                        Console.WriteLine("é um triângulo isóceles");
                    }
                    else
                    {
                        if(L1 == L2 && L1 == L3  && L2 == L3)
                        {
                            Console.WriteLine("é um triângulo eqüilatero");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("não é um triângulo");
            }
        }
    }
}
